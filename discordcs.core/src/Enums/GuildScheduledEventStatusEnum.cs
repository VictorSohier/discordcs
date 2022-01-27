using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
	public class GuildScheduledEventStatusEnum : SmartEnum<GuildScheduledEventStatusEnum, ushort>
	{
		public static readonly GuildScheduledEventStatusEnum SCHEDULED = new("Scheduled", 1);
		public static readonly GuildScheduledEventStatusEnum ACTIVE = new("Active", 2);
		public static readonly GuildScheduledEventStatusEnum COMPLETED = new("Completed", 3);
		public static readonly GuildScheduledEventStatusEnum CANCELED = new("Canceled", 4);

		private GuildScheduledEventStatusEnum(string name, ushort value) : base(name, value)
		{

		}
	}
}