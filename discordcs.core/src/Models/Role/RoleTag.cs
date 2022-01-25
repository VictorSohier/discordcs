using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class RoleTag : IRoleTag
	{
		public ulong? BotId { get; set; }
		public ulong? IntegrationId { get; set; }
		public bool PremiumSubscriber { get; set; }
	}
}