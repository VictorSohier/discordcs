using Discordcs.Core.Interfaces.Presence;

namespace Discordcs.Core.Models.Presence
{
	public class ActivitySecrets : IActivitySecrets
	{
		public string Join { get; set; }
		public string Spectate { get; set; }
		public string Match { get; set; }
	}
}