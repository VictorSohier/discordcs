using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
    public interface IStickerItem
    {
        public ulong Id { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<StickerFormatTypeEnum, ushort>))]
		public StickerFormatTypeEnum FormatType { get; set; }
    }
}