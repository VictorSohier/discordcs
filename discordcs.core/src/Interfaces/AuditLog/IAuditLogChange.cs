using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IAuditLogChange
	{
		public dynamic NewValue { get; set; }
		public dynamic OldValue { get; set; }
		public string Key { get; set; }
	}
}