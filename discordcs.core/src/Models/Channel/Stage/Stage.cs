using Discordcs.core.enums;
using Discordcs.core.interfaces.channel.stage;

namespace Discordcs.core.models.channel.stage
{
	public class Stage : IStage
	{
		public ulong Id { get; set; }
		public ulong GuildId { get; set; }
		public ulong ChannelId { get; set; }
		public string Topic { get; set; }
		public PrivacyLevelEnum PrivacyLevel { get; set; }
		public bool DiscoverableDisabled { get; set; }
	}
}