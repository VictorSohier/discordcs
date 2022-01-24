using Discordcs.Core.Interfaces.Guild.Welcome;

namespace Discordcs.Core.Models.Guild.Welcome
{
	public class GuildWelcomeChannel : IGuildWelcomeChannel
	{
		public ulong ChannelId { get; set; }
		public string Description { get; set; }
		public ulong? EmojiId { get; set; }
		public string EmojiName { get; set; }
	}
}