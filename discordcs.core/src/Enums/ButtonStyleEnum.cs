using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class ButtonStyleEnum : SmartEnum<ButtonStyleEnum, ushort>
    {
		public static readonly ButtonStyleEnum PRIMARY = new("Primary", 1);
		public static readonly ButtonStyleEnum SECONDARY = new("Secondary", 2);
		public static readonly ButtonStyleEnum SUCCESS = new("Success", 3);
		public static readonly ButtonStyleEnum DANGER = new("Danger", 4);
		public static readonly ButtonStyleEnum LINK = new("Link", 5);

        private ButtonStyleEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}