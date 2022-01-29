using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class ChannelTypeEnum : SmartEnum<ChannelTypeEnum, ushort>
    {
		public static readonly ChannelTypeEnum GUILD_TEXT = new("Guild text", 0);
		public static readonly ChannelTypeEnum DM = new("Direct message", 1);
		public static readonly ChannelTypeEnum GUILD_VOICE = new("Guild voice", 2);
		public static readonly ChannelTypeEnum GUILD_DM = new("Guild direct message", 3);
		public static readonly ChannelTypeEnum GUILD_CATEGORY = new("Guild category", 4);
		public static readonly ChannelTypeEnum GUILD_NEWS = new("Guild news", 5);
		public static readonly ChannelTypeEnum GUILD_STORE = new("Guild store", 6);
		public static readonly ChannelTypeEnum GUILD_NEWS_THREAD = new("Guild news thread", 10);
		public static readonly ChannelTypeEnum GUILD_PUBLIC_THREAD = new("Guild public thread", 11);
		public static readonly ChannelTypeEnum GUILD_PRIVATE_THREAD = new("Guild private thread", 12);
		public static readonly ChannelTypeEnum GUILD_STAGE_VOICE = new("Guild stage voice", 13);

        private ChannelTypeEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}