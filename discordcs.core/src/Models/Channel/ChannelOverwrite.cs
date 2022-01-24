using Discordcs.Core.Interfaces.Channel;

namespace Discordcs.Core.Models.Channel
{
	public class ChannelOverwrite : IChannelOverwrite
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public string Allow { get; set; }
		public string Deny { get; set; }
	}
}