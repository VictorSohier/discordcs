using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class SystemChannelFlagsEnum : SmartEnum<SystemChannelFlagsEnum, uint>
    {
		public static readonly SystemChannelFlagsEnum SUPPRESS_JOIN_NOTIFICATIONS = new("Suppress join notifications", 1 << 0);
		public static readonly SystemChannelFlagsEnum SUPPRESS_PREMIUM_SUBSCRIPTIONS = new("Suppress premium subscriptions", 1 << 1);
		public static readonly SystemChannelFlagsEnum SUPPRESS_GUILD_REMINDER_NOTIFICATIONS = new("Suppress guild reminder notifications", 1 << 2);
		public static readonly SystemChannelFlagsEnum SUPPRESS_JOIN_NOTIFICATIONS_REPLIES = new("Suppress join notifications replies", 1 << 3);

        private SystemChannelFlagsEnum(string name, uint value) : base(name, value)
		{

		}

		public static SystemChannelFlagsEnum[] FlagsToArray(uint value)
		{
			List<SystemChannelFlagsEnum> ret = new();
			uint mask = 1;
			while (mask != 0)
			{
				if ((value & mask) > 0)
				{
					ret.Add(FromValue(mask));
				}
				mask <<= 1;
			}
			return ret.ToArray();
		}

		public static uint ArrayToFlags(IEnumerable<SystemChannelFlagsEnum> values)
		{
			uint ret = 0;
			foreach (SystemChannelFlagsEnum v in values)
			{
				ret |= v.Value;
			}
			return ret;
		}
    }
}