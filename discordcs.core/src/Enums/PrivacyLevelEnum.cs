using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
	public class PrivacyLevelEnum : SmartEnum<PrivacyLevelEnum, ushort>
	{
		public static readonly PrivacyLevelEnum PUBLIC = new("Public", 1);
		public static readonly PrivacyLevelEnum GUILD_ONLY = new("Guild only", 2);

		private PrivacyLevelEnum(string name, ushort value) : base(name, value)
		{

		}
	}
}