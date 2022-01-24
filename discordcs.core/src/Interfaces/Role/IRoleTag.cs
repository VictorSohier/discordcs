namespace Discordcs.Core.Interfaces.Role
{
	public interface IRoleTag
	{
		public ulong? BotId { get; set; }
		public ulong? IntegrationId { get; set; }
		public bool PremiumSubscriber { get; set; }
	}
}