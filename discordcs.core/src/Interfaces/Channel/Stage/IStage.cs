using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IStage
	{
		public ulong Id { get; set; }
		public ulong GuildId { get; set; }
		public ulong ChannelId { get; set; }
		public string Topic { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<PrivacyLevelEnum, ushort>))]
		public PrivacyLevelEnum PrivacyLevel { get; set; }
		public bool DiscoverableDisabled { get; set; }
	}
}