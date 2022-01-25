using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class IntegrationApplication : IIntegrationApplication
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }
		public string Summary { get; set; }
		public User Bot { get; set; }
	}
}