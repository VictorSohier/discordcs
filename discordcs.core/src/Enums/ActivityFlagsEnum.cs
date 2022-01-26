using System;
using System.Collections.Generic;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class ActivityFlagsEnum : SmartEnum<ActivityFlagsEnum, uint>
    {
		public static readonly ActivityFlagsEnum INSTANCE = new("Instance", 1 << 0);
		public static readonly ActivityFlagsEnum JOIN = new("Join", 1 << 1);
		public static readonly ActivityFlagsEnum SPECTATE = new("Spectate", 1 << 2);
		public static readonly ActivityFlagsEnum JOIN_REQUEST = new("Join request", 1 << 3);
		public static readonly ActivityFlagsEnum SYNC = new("Sync", 1 << 4);
		public static readonly ActivityFlagsEnum PLAY = new("Play", 1 << 5);
		public static readonly ActivityFlagsEnum PARTY_PRIVACY_FRIENDS = new("Party privacy friends", 1 << 6);
		public static readonly ActivityFlagsEnum PARTY_PRIVACY_VOICE_CHANNEL = new("Party privacy voice channel", 1 << 7);
		public static readonly ActivityFlagsEnum EMBEDDED = new("Embedded", 1 << 8);

        public ActivityFlagsEnum(string name, uint value) : base(name, value)
		{

		}

		public static ActivityFlagsEnum[] FlagsToArray(uint value)
		{
			List<ActivityFlagsEnum> ret = new();
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

		public static uint ArrayToFlags(IEnumerable<ActivityFlagsEnum> values)
		{
			uint ret = 0;
			foreach (ActivityFlagsEnum v in values)
			{
				ret |= v.Value;
			}
			return ret;
		}
    }
}