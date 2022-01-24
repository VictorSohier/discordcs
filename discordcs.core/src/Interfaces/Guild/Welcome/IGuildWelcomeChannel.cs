namespace Discordcs.Core.Interfaces.Guild.Welcome
{
	public interface IGuildWelcomeChannel
	{
		public ulong ChannelId { get; set; }
		public string Description { get; set; }
		public ulong? EmojiId { get; set; }
		public string EmojiName { get; set; }
	}
}