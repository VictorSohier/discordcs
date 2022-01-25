using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IChannelOverwrite
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public string Allow { get; set; }
		public string Deny { get; set; }
	}
}