using Ardalis.SmartEnum;

namespace Discordcs.core.enums
{
	public class IntegrationExpireBehaviorEnum : SmartEnum<IntegrationExpireBehaviorEnum, ushort>
	{
		public static readonly IntegrationExpireBehaviorEnum REMOVE_ROLE = new("Remove role", 0);
		public static readonly IntegrationExpireBehaviorEnum KICK = new("Kick", 1);

		private IntegrationExpireBehaviorEnum(string name, ushort value) : base(name, value)
		{

		}
	}
}