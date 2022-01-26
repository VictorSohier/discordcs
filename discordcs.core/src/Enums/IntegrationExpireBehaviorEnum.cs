using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace Discordcs.Core.Enums
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