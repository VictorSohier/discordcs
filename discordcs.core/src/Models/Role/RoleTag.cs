using Discordcs.Core.Interfaces.Role;

namespace Discordcs.Core.Models.Role
{
	public class RoleTag : IRoleTag
	{
		public ulong? BotId { get; set; }
		public ulong? IntegrationId { get; set; }
		public bool PremiumSubscriber { get; set; }
	}
}