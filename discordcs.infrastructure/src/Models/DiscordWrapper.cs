using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Discordcs.Core.Interfaces.AuditLog;
using Discordcs.Core.Models.AuditLog;
using Newtonsoft.Json;

namespace Discordcs.Infrastructure.Models
{
	public class DiscordWrapper : IDiscordWrapper
	{
		private string _baseUrl { get; } = "https://discord.com/api";
		private HttpClient _httpClient { get; } = new();
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
			AuditLog ret = JsonConvert.DeserializeObject<AuditLog>(await response.Content.ReadAsStringAsync());
			return ret;
		}
	}
}