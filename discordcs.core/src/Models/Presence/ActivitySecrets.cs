using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ActivitySecrets : IActivitySecrets
	{
		public string Join { get; set; }
		public string Spectate { get; set; }
		public string Match { get; set; }
	}
}