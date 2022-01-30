using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
    public class ChannelMention : IChannelMention
    {
        public ulong Id { get; set; }
		public ulong GuildId { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<ChannelTypeEnum, ushort>))]
		public ChannelTypeEnum Type { get; set; }
		public string Name { get; set; }
    }
}