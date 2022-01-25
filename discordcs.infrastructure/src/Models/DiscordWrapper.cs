using System.Diagnostics;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Discordcs.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Discordcs.Infrastructure.Models
{
	public class DiscordWrapper : IDiscordWrapper
	{
		private string _baseUrl { get; } = "https://discord.com/api";
		private HttpClient _httpClient { get; } = new();
		private JsonSerializerSettings _settings { get; } = new()
		{
			ContractResolver = new DefaultContractResolver()
			{
				NamingStrategy = new SnakeCaseNamingStrategy()
			},
			NullValueHandling = NullValueHandling.Ignore
		};
		public byte ApiVersion { get; } = 9;
		public byte[] PublicKey { get; }

		public DiscordWrapper(string token, byte[] publicKey)
		{
			PublicKey = publicKey;
			_httpClient.BaseAddress = new($"{_baseUrl}/v{ApiVersion}");
			_httpClient.DefaultRequestHeaders.Add("Authorization", $"Bot {token}");
		}

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
			HttpResponseMessage response = await _httpClient.GetAsync($"guilds/{guildId}/audit-logs");
			AuditLog ret = JsonConvert.DeserializeObject<AuditLog>(
				await response.Content.ReadAsStringAsync(),
				_settings);
			return ret;
		}
	}
}