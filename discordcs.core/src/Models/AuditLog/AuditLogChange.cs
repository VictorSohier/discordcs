using Discordcs.core.interfaces.auditLog;

namespace Discordcs.core.models.auditLog
{
	public class AuditLogChange : IAuditLogChange
	{
		public string NewValue { get; set; }
		public string OldValue { get; set; }
		public string Key { get; set; }
	}
}