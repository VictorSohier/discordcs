using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class MessageComponentTypeEnum : SmartEnum<MessageComponentTypeEnum, ushort>
    {
		public static readonly MessageComponentTypeEnum ACTION_ROW = new("Action row", 1);
		public static readonly MessageComponentTypeEnum BUTTON = new("Button", 2);
		public static readonly MessageComponentTypeEnum SELECT_MENU = new("Select menu", 3);

        private MessageComponentTypeEnum(string name, ushort value) : base(name, value)
		{
			
		}
    }
}