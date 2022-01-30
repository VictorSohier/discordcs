using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class AuditLogChange : IAuditLogChange
	{
		public dynamic NewValue { get; set; }
		public dynamic OldValue { get; set; }
		public string Key { get; set; }
	}
}