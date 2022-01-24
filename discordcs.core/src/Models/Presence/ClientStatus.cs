using Discordcs.Core.Interfaces.Presence;

namespace Discordcs.Core.Models.Presence
{
	public class ClientStatus : IClientStatus
	{
		public string Desktop { get; set; }
		public string Mobile { get; set; }
		public string Web { get; set; }
	}
}