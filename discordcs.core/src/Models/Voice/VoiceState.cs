using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class VoiceState : IVoiceState
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
		public GuildMember Member { get; set; }
	}
}