using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
    public interface IChannelMention
    {
        public ulong Id { get; set; }
		public ulong GuildId { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<ChannelTypeEnum, ushort>))]
		public ChannelTypeEnum Type { get; set; }
		public string Name { get; set; }
    }
}