using Discordcs.core.interfaces.integration;

namespace Discordcs.core.models.integration
{
	public class IntegrationAccount : IIntegrationAccount
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
}