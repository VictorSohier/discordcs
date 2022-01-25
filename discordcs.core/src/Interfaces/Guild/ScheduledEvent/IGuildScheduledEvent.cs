using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IGuildScheduledEvent
	{
		public ulong Id { get; set; }
		public ulong GuildId { get; set; }
		public ulong? ChannelId { get; set; }
		public ulong? CreatorId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTimeOffset ScheduledStartTime { get; set; }
		public DateTimeOffset? ScheduledEndTime { get; set; }
		public ulong EntityId { get; set; }
		public ulong UserCount { get; set; }
		public PrivacyLevelEnum PrivacyLevel { get; set; }
		public GuildScheduledEventStatusEnum Status { get; set; }
		public GuildScheduledEventEntityTypeEnum EntityType { get; set; }
		public GuildScheduledEventEntityMetadata? EntityMetadata { get; set; }
		public User Creator { get; set; }
	}
}