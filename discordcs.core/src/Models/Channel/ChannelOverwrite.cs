using Discordcs.core.interfaces.channel;

namespace Discordcs.core.models.channel
{
	public class ChannelOverwrite : IChannelOverwrite
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public string Allow { get; set; }
		public string Deny { get; set; }
	}
}