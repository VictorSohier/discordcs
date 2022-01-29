using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
	public class Guild : IGuild
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public string IconHash { get; set; }
		public string Splash { get; set; }
		public string DiscoverySplash { get; set; }
		public bool Owner { get; set; }
		public ulong OwnerId { get; set; }
		public string Permissions { get; set; }
		public string Region { get; set; }
		public ulong? AFKChannelId { get; set; }
		public int AFKTimeout { get; set; }
		public bool WidgetEnabled { get; set; }
		public int VerificationLevel { get; set; }
		public int DefaultMessageNotifications { get; set; }
		public int ExplicitContentFilter { get; set; }
		public string[] Features { get; set; }
		public int MFALevel { get; set; }
		public ulong? ApplicationId { get; set; }
		public ulong? SystemChannelId { get; set; }
		[JsonConverter(typeof(SmartEnumArrayValueConverter<SystemChannelFlagsEnum>))]
		public SystemChannelFlagsEnum[] SystemChannelFlags { get; set; }
		public ulong? RulesChannelId { get; set; }
		public DateTimeOffset? JoinedAt { get; set; }
		public bool Large { get; set; }
		public bool Unavailable { get; set; }
		public int? MemberCount { get; set; }
		public Channel[] Channels { get; set; }
		public Channel[] Threads { get; set; }
		public int? MaxPrecences { get; set; }
		public int? MaxMembers { get; set; }
		public string VanityUrlCode { get; set; }
		public string Description { get; set; }
		public string Banner { get; set; }
		public int PremiumTier { get; set; }
		public int? PremiumSubscriptionCount { get; set; }
		public string PreferredLocale { get; set; }
		public ulong? PublicUpdatesChannel { get; set; }
		public int? MaxVideoChannelUsers { get; set; }
		public int? ApproximateMemberCount { get; set; }
		public int? ApproximatePresenceCount { get; set; }
		public int NSFWLevel { get; set; }
		public GuildScheduledEvent[] GuildScheduledEvents { get; set; }
		public bool PremiumProgressBarEnabled { get; set; }
		public Role[] Roles { get; set; }
		public Emoji[] Emojis { get; set; }
		public VoiceState[] VoiceStates { get; set; }
		public GuildMember[] Members { get; set; }
		public PresenceUpdate[] Presences { get; set; }
		public GuildWelcomeScreen WelcomeScreen { get; set; }
		public Stage[] StageInstances { get; set; }
		public Sticker[] Stickers { get; set; }
	}
}