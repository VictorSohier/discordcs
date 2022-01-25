using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class GuildWelcomeChannel : IGuildWelcomeChannel
	{
		public ulong ChannelId { get; set; }
		public string Description { get; set; }
		public ulong? EmojiId { get; set; }
		public string EmojiName { get; set; }
	}
}