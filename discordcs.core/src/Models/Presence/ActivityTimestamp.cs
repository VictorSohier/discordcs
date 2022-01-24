using Discordcs.core.interfaces.presence;

namespace Discordcs.core.models.presence
{
	public class ActivityTimestamp : IActivityTimestamp
	{
		public int? Start { get; set; }
		public int? End { get; set; }
	}
}