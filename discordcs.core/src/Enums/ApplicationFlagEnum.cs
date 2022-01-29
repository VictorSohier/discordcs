using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class ApplicationFlagEnum : BitFlagSmartEnum<ApplicationFlagEnum>
    {
		public static readonly ApplicationFlagEnum GATEWAY_PRESENCE = new("Gateway presence", 1 << 12);
		public static readonly ApplicationFlagEnum GATEWAY_PRESENCE_LIMITED = new("Gateway presence limited", 1 << 13);
		public static readonly ApplicationFlagEnum GATEWAY_GUILD_MEMBERS = new("Gateway guild members", 1 << 14);
		public static readonly ApplicationFlagEnum GATEWAY_GUILD_MEMBERS_LIMITED = new("Gateway guild members limited", 1 << 15);
		public static readonly ApplicationFlagEnum VERIFICATION_PENDING_GUILD_LIMIT = new("Verification pending guild limit", 1 << 16);
		public static readonly ApplicationFlagEnum EMBEDDED = new("Embedded", 1 << 17);
		public static readonly ApplicationFlagEnum GATEWAY_MESSAGE_CONTENT = new("Gateway message content", 1 << 18);
		public static readonly ApplicationFlagEnum GATEWAY_MESSAGE_CONTENT_LIMITED = new("Gateway message content limited", 1 << 19);

        private ApplicationFlagEnum(string name, ulong value) : base(name, value)
		{

		}
    }
}