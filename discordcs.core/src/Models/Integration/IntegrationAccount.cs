using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class IntegrationAccount : IIntegrationAccount
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
}