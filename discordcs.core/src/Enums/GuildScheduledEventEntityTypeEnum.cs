using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
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