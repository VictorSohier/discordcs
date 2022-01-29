using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class VideoQualityEnum : SmartEnum<VideoQualityEnum, ushort>
    {
		public static readonly VideoQualityEnum AUTO = new("Auto", 0);
		public static readonly VideoQualityEnum FULL = new("Auto", 1);

        private VideoQualityEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}