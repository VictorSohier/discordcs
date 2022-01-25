using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Interfaces
{
	public interface IDiscordWrapper
	{
		public Task<IAuditLog> GetGuildAuditLog(ulong guildId, ulong? userId=null, AuditLogEventEnum? eventType=null, ulong? beforeId=null, int? limit=null);
	}
}