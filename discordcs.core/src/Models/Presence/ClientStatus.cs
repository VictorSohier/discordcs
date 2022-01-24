using Discordcs.core.interfaces.presence;

namespace Discordcs.core.models.presence
{
	public class ClientStatus : IClientStatus
	{
		public string Desktop { get; set; }
		public string Mobile { get; set; }
		public string Web { get; set; }
	}
}