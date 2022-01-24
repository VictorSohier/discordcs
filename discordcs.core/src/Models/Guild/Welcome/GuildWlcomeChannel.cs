using Discordcs.core.interfaces.guild.welcome;

namespace Discordcs.core.models.guild.welcome
{
	public class GuildWelcomeChannel : IGuildWelcomeChannel
	{
		public ulong ChannelId { get; set; }
		public string Description { get; set; }
		public ulong? EmojiId { get; set; }
		public string EmojiName { get; set; }
	}
}