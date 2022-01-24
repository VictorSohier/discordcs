using Discordcs.Core.Interfaces.Integration;
using Discordcs.Core.Interfaces.User;

namespace Discordcs.Core.Models.Integration
{
	public class IntegrationApplication : IIntegrationApplication
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }
		public string Summary { get; set; }
		public IUser Bot { get; set; }
	}
}