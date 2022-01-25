using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
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