using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class AuditLogChange : IAuditLogChange
	{
		public Dictionary<string, string>[] NewValue { get; set; }
		public Dictionary<string, string>[] OldValue { get; set; }
		public string Key { get; set; }
	}
}