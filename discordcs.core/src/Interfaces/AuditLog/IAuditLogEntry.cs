using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IAuditLogEntry
	{
		public string TargetId { get; set; }
		public ulong? UserId { get; set; }
		public ulong Id { get; set; }
		public string Reason { get; set; }
		public AuditLogEventEnum ActionType { get; set; }
		public AuditLogChange[] Changes { get; set; }
		public AuditLogOptionalInfo? Options { get; set; }
	}
}