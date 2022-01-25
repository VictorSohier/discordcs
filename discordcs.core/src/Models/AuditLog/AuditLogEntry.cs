using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class AuditLogEntry : IAuditLogEntry
	{
		public ulong Id { get; set; }
		public ulong? UserId { get; set; }
		public string TargetId { get; set; }
		public string Reason { get; set; }
		public AuditLogEventEnum ActionType { get; set; }
		public AuditLogChange[] Changes { get; set; }
		public AuditLogOptionalInfo? Options { get; set; }
	}
}