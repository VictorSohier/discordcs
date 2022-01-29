using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class UserFlagsEnum : BitFlagSmartEnum<UserFlagsEnum>
    {
		public static readonly UserFlagsEnum STAFF = new("Staff", 1 << 0);
		public static readonly UserFlagsEnum PARTNER = new("Partner", 1 << 1);
		public static readonly UserFlagsEnum HYPESQUAD = new("Hypesquad", 1 << 2);
		public static readonly UserFlagsEnum BUG_HUNTER_LEVEL_1 = new("Bug hunter level 1", 1 << 3);
		public static readonly UserFlagsEnum HYPESQUAD_ONLINE_HOUSE_1 = new("Hypesquad online house 1", 1 << 6);
		public static readonly UserFlagsEnum HYPESQUAD_ONLINE_HOUSE_2 = new("Hypesquad online house 2", 1 << 7);
		public static readonly UserFlagsEnum HYPESQUAD_ONLINE_HOUSE_3 = new("Hypesquad online house 3", 1 << 8);
		public static readonly UserFlagsEnum PREMIUM_EARLY_SUPPORTER = new("Premium early supporter", 1 << 9);
		public static readonly UserFlagsEnum TEAM_PSEUDO_USER = new("Team pseudo user", 1 << 10);
		public static readonly UserFlagsEnum BUG_HUNTER_LEVEL_2 = new("Bug hunter level 2", 1 << 14);
		public static readonly UserFlagsEnum VERIFIED_BOT = new("Verified bot", 1 << 16);
		public static readonly UserFlagsEnum VERIFIED_DEVELOPER = new("Verified developer", 1 << 17);
		public static readonly UserFlagsEnum CERTIFIED_MODERATOR = new("Certified moderator", 1 << 18);
		public static readonly UserFlagsEnum BOT_HTTP_INTERACTIONS = new("Bot http interactions", 1 << 19);
        private UserFlagsEnum(string name, ulong value) : base(name, value)
		{

		}
    }
}