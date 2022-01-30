using System.Net;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Discordcs.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Discordcs.Infrastructure.Models
{
	public sealed class DiscordWrapper : IDiscordWrapper
	{
		private string _baseUrl { get; } = "https://discord.com/api";
		private HttpClient _httpClient { get; } = new();
		private JsonSerializerSettings _settings { get; } = new()
		{
			ContractResolver = new DefaultContractResolver()
			{
				NamingStrategy = new SnakeCaseNamingStrategy(),
			},
			DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
			//NullValueHandling = NullValueHandling.Ignore
		};
		private Dictionary<string, HttpResponseMessage> _commandResponses { get; } = new();
		private Queue<Func<Task<HttpResponseMessage>>> _commandQueue { get; } = new();
		private Queue<string> _commandQueueIds { get; } = new();
		private Thread _commandThread { get; }
		private bool _threadContinue = true;
		private bool _ThreadContinue {
			get {
				lock(_threadContinueLock)
				{
					return _threadContinue;
				}
			}
			set {
				lock(_threadContinueLock)
				{
					_threadContinue = value;
				}
			}
		}
		private object _threadContinueLock { get; } = new();
		private object _commandQueueLock { get; } = new();
		private object _commandResponsesLock { get; } = new();
		public byte ApiVersion { get; } = 9;
		public byte[] PublicKey { get; }

		public DiscordWrapper(string token, byte[] publicKey)
		{
			PublicKey = publicKey;
			_httpClient.BaseAddress = new($"{_baseUrl}/v{ApiVersion}");
			_httpClient.DefaultRequestHeaders.Add("Authorization", $"Bot {token}");
			_commandThread = new(_CommandQueueThread);
			_commandThread.Start();
		}

		/// <summary>
		/// Meant to avoid being rate limited by Cloudflare
		/// </summary>
		private void _CommandQueueThread()
		{
			while (_ThreadContinue)
			{
				Task<HttpResponseMessage> t;
				lock(_commandQueueLock)
				{
					if (_commandQueue.Count > 0)
					{
						t = _commandQueue.Peek().Invoke();
					}
					else
					{
						continue;
					}
				}
				HttpResponseMessage response = t.Result;
				if (response.StatusCode == HttpStatusCode.OK)
				{
					lock(_commandResponsesLock) _commandResponses.Add(_commandQueueIds.Dequeue(), response);
					lock(_commandQueueLock) _commandQueue.Dequeue();
					Thread.Sleep(100);
				}
			}
		}

		/// <summary>
		/// Adds a command to the command queue and returns an Id to retrieve the result later.
		/// Quasi-async function
		/// </summary>
		/// <param name="command">The command to be executed in a rate limited manor</param>
		/// <returns>A string to retrieve the result from GetCommandResponse</returns>
		private string AddCommand(Func<Task<HttpResponseMessage>> command)
		{
			string ret = Guid.NewGuid().ToString();
			lock (_commandQueueLock)
			{
				_commandQueue.Enqueue(command);
				_commandQueueIds.Enqueue(ret);
			}
			return ret;
		}

		/// <summary>
		/// Gets the result from a prior AddCommand call
		/// </summary>
		/// <param name="id">The id returned by AddCommand</param>
		/// <returns>The result of the command</returns>
		private HttpResponseMessage GetCommandResponse(string id)
		{
			bool containsKey;
			lock(_commandResponsesLock) containsKey = _commandResponses.ContainsKey(id);
			while (!containsKey)
			{
				lock(_commandResponsesLock) containsKey = _commandResponses.ContainsKey(id);
			}
			HttpResponseMessage ret;
			lock(_commandResponsesLock)
			{
				ret = _commandResponses[id];
				_commandResponses.Remove(id);
			}
			return ret;
		}

		/// <summary>
		/// Gets the audit log for a discord guild
		/// </summary>
		/// <param name="guildId">The discord ID of the guild</param>
		/// <param name="userId">User filter</param>
		/// <param name="eventType">Event type filter</param>
		/// <param name="beforeId">Before entry filter</param>
		/// <param name="limit">Count limiter</param>
		/// <returns>An audit log object from discord</returns>
		public async Task<IAuditLog> GetGuildAuditLog(ulong guildId, ulong? userId=null, AuditLogEventEnum? eventType=null, ulong? beforeId=null, int? limit=null)
		{
			string queryString = userId == null ? null : $"?user_id={userId}";
			queryString = eventType == null
			? queryString
			: queryString == null
				? $"?action_type={eventType.Value}"
				: $"{queryString}&action_type={eventType.Value}";
			queryString = beforeId == null
			? queryString
			: queryString == null
				? $"?before={beforeId}"
				: $"{queryString}&before={beforeId}";
			queryString = limit == null
			? queryString
			: queryString == null
				? $"?limit={limit}"
				: $"{queryString}&limit={limit}";
			string id = AddCommand(() => _httpClient.GetAsync($"guilds/{guildId}/audit-logs"));
			AuditLog ret = JsonConvert.DeserializeObject<AuditLog>(
				await GetCommandResponse(id).Content.ReadAsStringAsync(),
				_settings);
			return ret;
		}

		/// <summary>
		/// Gets a channel object from discord
		/// </summary>
		/// <param name="channelId">The id of the channel to be retrieved</param>
		/// <returns>The channel matching the ID from discord</returns>
		public async Task<IChannel> GetChannel(ulong channelId)
		{
			string id = AddCommand(() => _httpClient.GetAsync($"channels/{channelId}"));
			Channel ret = JsonConvert.DeserializeObject<Channel>(
				await GetCommandResponse(id).Content.ReadAsStringAsync(),
				_settings);
			return ret;
		}

		/// <summary>
		/// Modifies a given channel
		/// </summary>
		/// <param name="channelId">The channel to modify</param>
		/// <param name="parameters">A set of parameters to modify the channel with</param>
		/// <returns>The modified channel</returns>
		public async Task<Channel> ModifyChannel(ulong channelId, IChannelParams parameters)
		{
			StringContent content = new(JsonConvert.SerializeObject(parameters, _settings),
				Encoding.UTF8,
				"application/json");
			string id = AddCommand(() => _httpClient.PatchAsync($"channels/{channelId}", content));
			HttpResponseMessage response = GetCommandResponse(id);
			Channel ret = JsonConvert.DeserializeObject<Channel>(
				await response.Content.ReadAsStringAsync(), _settings);
			return ret;
		}

		/// <summary>
		/// Delete a channel from discord
		/// </summary>
		/// <param name="channelId">The id of the channel to be deleted</param>
		public void DeleteChannel(ulong channelId)
		{
			string id = AddCommand(() => _httpClient.DeleteAsync($"channels/{channelId}"));
			GetCommandResponse(id);
		}

		public async Task<Message[]> GetChannelMessages(ulong channelId, ulong? around=null, ulong? before=null, ulong? after=null, byte? limit=100)
		{
			string queryString = around == null ? null : $"?around={around}";
			queryString = before == null
			? queryString
			: queryString == null
				? $"?before={before}"
				: $"{queryString}&before={before}";
			queryString = after == null
			? queryString
			: queryString == null
				? $"?after={after}"
				: $"{queryString}&after={after}";
			queryString = limit == null
			? queryString
			: queryString == null
				? $"?limit={limit}"
				: $"{queryString}&limit={limit}";
			string id = AddCommand(() => _httpClient.GetAsync($"channels/{channelId}/messages{queryString}"));
			HttpResponseMessage response = GetCommandResponse(id);
			Message[] ret = JsonConvert.DeserializeObject<Message[]>(
				await response.Content.ReadAsStringAsync(),
				_settings
			);
			return ret;
		}

		public async Task<Message> CreateMessage(ulong channelId, NewMessage message)
		{
			MemoryStream ms = new();
			BinaryWriter bw = new(ms);
			bw.Write(JsonConvert.SerializeObject(message, _settings));
			bw.Close();
			HashAlgorithm sha512 = SHA512.Create();
			string boundary = BitConverter
				.ToString(await sha512.ComputeHashAsync(ms))
				.Replace("-", "");
			string s = $"--{boundary}\n"
				+ "Content-Disposition: form-data; name=\"payload_json\"\n"
				+ "Content-Type: application/json\n"
				+ $"{message.PayloadJson}\n";
			
			for (int i = 0; i < message.Attachments.Length; i++)
			{
				s += $"--{boundary}\n"
				+ $"Content-Disposition: form-data; name=\"files[{i}]\"\n"
				+ $"Content-Type: {message.Attachments[i].ContentType}\n"
				+ "\n"
				+ Convert.ToBase64String(message.Files[i]);
			}
			s += $"--{boundary}--";
			
			StringContent content = new(s, Encoding.UTF8, "multipart/form-data");
			string id = AddCommand(() => _httpClient.PostAsync($"channels/{channelId}/messages",
				content));
			HttpResponseMessage response = GetCommandResponse(id);
			return JsonConvert.DeserializeObject<Message>(await response.Content.ReadAsStringAsync());
		}

		~DiscordWrapper()
		{
			_ThreadContinue = false;
			_commandThread.Join();
		}
	}
}