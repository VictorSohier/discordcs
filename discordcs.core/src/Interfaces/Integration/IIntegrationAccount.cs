using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IIntegrationAccount
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
}