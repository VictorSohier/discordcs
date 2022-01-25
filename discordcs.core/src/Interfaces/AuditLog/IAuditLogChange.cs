using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IAuditLogChange
	{
		public Dictionary<string, string>[] NewValue { get; set; }
		public Dictionary<string, string>[] OldValue { get; set; }
		public string Key { get; set; }
	}
}