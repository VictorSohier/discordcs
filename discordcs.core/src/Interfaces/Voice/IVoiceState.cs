using Discordcs.Core.Interfaces.Guild;

namespace Discordcs.Core.Interfaces.Voice
{
	public interface IVoiceState
	{
		public ulong? GuildId { get; set; }
		public ulong? ChannelId { get; set; }
		public ulong UserId { get; set; }
		public string SessionId { get; set; }
		public bool Deaf { get; set; }
		public bool Mute { get; set; }
		public bool SelfDeaf { get; set; }
		public bool SelfMute { get; set; }
		public bool SelfStream { get; set; }
		public bool SelfVideo { get; set; }
		public bool Suppress { get; set; }
		public DateTimeOffset? RequestToSpeakTimestamp { get; set; }
		public IGuildMember Member { get; set; }
	}
}