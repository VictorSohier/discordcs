using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace Discordcs.Core.Enums
{
	[JsonConverter(typeof(SmartEnumValueConverter<GuildScheduledEventEntityTypeEnum, ushort>))]
	public class GuildScheduledEventEntityTypeEnum : SmartEnum<GuildScheduledEventEntityTypeEnum, ushort>
	{
		public static readonly GuildScheduledEventEntityTypeEnum STAGE_INSTANCE = new("Stage instance", 1);
		public static readonly GuildScheduledEventEntityTypeEnum VOICE = new("Voice", 2);
		public static readonly GuildScheduledEventEntityTypeEnum EXTERNAL = new("External", 3);

		private GuildScheduledEventEntityTypeEnum(string name, ushort value) : base(name, value)
		{

		}
	}
}