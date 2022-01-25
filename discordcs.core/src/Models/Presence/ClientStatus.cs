using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ClientStatus : IClientStatus
	{
		public string Desktop { get; set; }
		public string Mobile { get; set; }
		public string Web { get; set; }
	}
}