using Discordcs.core.enums;
using Discordcs.core.interfaces.user;

namespace Discordcs.core.interfaces.integration
{
	public interface IIntegration
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public bool Enabled { get; set; }
		public bool? Syncing { get; set; }
		public ulong? RoleId { get; set; }
		public bool? EnableEmoticons { get; set; }
		public int? ExpireGracePeriod { get; set; }
		public IUser? User { get; set; }
		public DateTimeOffset? SyncedAt { get; set; }
		public int? SubscriberCount { get; set; }
		public bool Revoked { get; set; }
		public IntegrationExpireBehaviorEnum? ExpireBehavior { get; set; }
		public IIntegrationAccount Account { get; set; }
		public IIntegrationApplication? Application { get; set; }
	}
}