using Discordcs.core.enums;
using Discordcs.core.interfaces.auditLog;

namespace Discordcs.core.models.auditLog
{
	public class AuditLogEntry : IAuditLogEntry
	{
		public string TargetId { get; set; }
		public ulong? UserId { get; set; }
		public ulong Id { get; set; }
		public string Reason { get; set; }
		public AuditLogEventEnum ActionType { get; set; }
		public IAuditLogChange[] Changes { get; set; }
		public IAuditLogOptionalInfo? Options { get; set; }
	}
}