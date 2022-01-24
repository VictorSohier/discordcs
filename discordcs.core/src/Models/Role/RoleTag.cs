using Discordcs.core.interfaces.role;

namespace Discordcs.core.models.role
{
	public class RoleTag : IRoleTag
	{
		public ulong? BotId { get; set; }
		public ulong? IntegrationId { get; set; }
		public bool PremiumSubscriber { get; set; }
	}
}