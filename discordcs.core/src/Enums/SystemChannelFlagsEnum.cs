using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class SystemChannelFlagsEnum : BitFlagSmartEnum<SystemChannelFlagsEnum>
    {
		public static readonly SystemChannelFlagsEnum SUPPRESS_JOIN_NOTIFICATIONS = new("Suppress join notifications", 1 << 0);
		public static readonly SystemChannelFlagsEnum SUPPRESS_PREMIUM_SUBSCRIPTIONS = new("Suppress premium subscriptions", 1 << 1);
		public static readonly SystemChannelFlagsEnum SUPPRESS_GUILD_REMINDER_NOTIFICATIONS = new("Suppress guild reminder notifications", 1 << 2);
		public static readonly SystemChannelFlagsEnum SUPPRESS_JOIN_NOTIFICATIONS_REPLIES = new("Suppress join notifications replies", 1 << 3);

        private SystemChannelFlagsEnum(string name, ulong value) : base(name, value)
		{

		}
    }
}