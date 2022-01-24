using Discordcs.Core.Enums;

namespace Discordcs.Core.Interfaces.Channel.Stage
{
	public interface IStage
	{
		public ulong Id { get; set; }
		public ulong GuildId { get; set; }
		public ulong ChannelId { get; set; }
		public string Topic { get; set; }
		public PrivacyLevelEnum PrivacyLevel { get; set; }
		public bool DiscoverableDisabled { get; set; }
	}
}