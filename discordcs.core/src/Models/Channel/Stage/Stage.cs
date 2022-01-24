using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces.Channel.Stage;

namespace Discordcs.Core.Models.Channel.Stage
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