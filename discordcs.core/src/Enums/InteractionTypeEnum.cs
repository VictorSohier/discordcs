using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class InteractionTypeEnum : SmartEnum<InteractionTypeEnum, ushort>
    {
		public static readonly InteractionTypeEnum PING = new("Ping", 1);
		public static readonly InteractionTypeEnum APPLICATION_COMMAND = new("Application command", 2);
		public static readonly InteractionTypeEnum MESSAGE_COMPONENT = new("Message component", 3);
		public static readonly InteractionTypeEnum APPLICATION_COMMAND_AUTOCOMPLETE = new("Application command autocomplete", 4);

        private InteractionTypeEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}