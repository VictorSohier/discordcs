using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
    public interface IMessageComponent
    {
		[JsonConverter(typeof(SmartEnumValueConverter<MessageComponentTypeEnum, ushort>))]
		public MessageComponentTypeEnum Type { get; set; }
		public string CustomId { get; set; }
		public bool? Disabled { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<ButtonStyleEnum, ushort>))]
		public ButtonStyleEnum Style { get; set; }
		public string Label { get; set; }
		public Emoji Emoji { get; set; }
		public string Url { get; set; }
		public SelectOption[] Options { get; set; }
		public string Placeholder { get; set; }
		public int? MinValues { get; set; }
		public int? MaxValues { get; set; }
		public MessageComponent[] Components { get; set; }
    }
}