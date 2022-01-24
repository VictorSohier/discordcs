using Discordcs.Core.Interfaces.Integration;

namespace Discordcs.Core.Models.Integration
{
	public class IntegrationAccount : IIntegrationAccount
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
}