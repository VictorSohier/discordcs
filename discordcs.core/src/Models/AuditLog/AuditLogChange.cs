using Discordcs.Core.Interfaces.AuditLog;

namespace Discordcs.Core.Models.AuditLog
{
	public class AuditLogChange : IAuditLogChange
	{
		public string NewValue { get; set; }
		public string OldValue { get; set; }
		public string Key { get; set; }
	}
}