using Discordcs.core.interfaces.presence;

namespace Discordcs.core.models.presence
{
	public class ActivitySecrets : IActivitySecrets
	{
		public string Join { get; set; }
		public string Spectate { get; set; }
		public string Match { get; set; }
	}
}