using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class Integration : IIntegration
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public bool Enabled { get; set; }
		public bool? Syncing { get; set; }
		public ulong? RoleId { get; set; }
		public bool? EnableEmoticons { get; set; }
		public int? ExpireGracePeriod { get; set; }
		public User? User { get; set; }
		public DateTimeOffset? SyncedAt { get; set; }
		public int? SubscriberCount { get; set; }
		public bool Revoked { get; set; }
		public IntegrationExpireBehaviorEnum? ExpireBehavior { get; set; }
		public IntegrationAccount Account { get; set; }
		public IntegrationApplication? Application { get; set; }
	}
}