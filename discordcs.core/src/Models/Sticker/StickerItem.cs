using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
    public class StickerItem : IStickerItem
    {
        public ulong Id { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<StickerFormatTypeEnum, ushort>))]
		public StickerFormatTypeEnum FormatType { get; set; }
    }
}