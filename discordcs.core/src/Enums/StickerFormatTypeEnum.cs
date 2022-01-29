using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class StickerFormatTypeEnum : SmartEnum<StickerFormatTypeEnum, ushort>
    {
		public static readonly StickerFormatTypeEnum PNG = new("PNG", 1);
		public static readonly StickerFormatTypeEnum APNG = new("APNG", 2);
		public static readonly StickerFormatTypeEnum LOTTIE = new("Lottie", 3);

        private StickerFormatTypeEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}