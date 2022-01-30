using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ChannelOverwrite : IChannelOverwrite
	{
		public ulong Id { get; set; }
		public string Type { get; set; }
		public string Allow { get; set; }
		public string Deny { get; set; }
	}
}