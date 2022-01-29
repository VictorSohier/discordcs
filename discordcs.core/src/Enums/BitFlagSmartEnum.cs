using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public abstract class BitFlagSmartEnum<TEnum> : SmartEnum<TEnum, ulong>
		where TEnum : SmartEnum<TEnum, ulong>
    {
        protected BitFlagSmartEnum(string name, ulong value) : base(name, value)
		{

		}

		public static TEnum[] FlagsToArray(ulong value)
		{
			List<TEnum> ret = new();
			ulong mask = 1;
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

		public static ulong ArrayToFlags(IEnumerable<TEnum> values)
		{
			ulong ret = 0;
			foreach (TEnum v in values)
			{
				ret |= v.Value;
			}
			return ret;
		}
    }
}