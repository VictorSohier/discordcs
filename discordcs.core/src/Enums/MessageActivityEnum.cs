using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class MessageActivityEnum : SmartEnum<MessageActivityEnum, ushort>
    {
		public static readonly MessageActivityEnum JOIN = new("Join", 1);
		public static readonly MessageActivityEnum SPECTATE = new("Spectate", 2);
		public static readonly MessageActivityEnum LISTEN = new("Listen", 3);
		public static readonly MessageActivityEnum JOIN_REQUEST = new("Join request", 5);

        private MessageActivityEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}