using Discordcs.core.enums;
using Discordcs.core.interfaces.auditLog;

namespace Discordcs.core.interfaces
{
	public interface IDiscordWrapper
	{
		public Task<IAuditLog> GetGuildAuditLog(ulong guildId, ulong? userId=null, AuditLogEventEnum? eventType=null, ulong? beforeId=null, int? limit=null);
	}
}