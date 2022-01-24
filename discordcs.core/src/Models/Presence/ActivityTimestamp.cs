using Discordcs.Core.Interfaces.Presence;

namespace Discordcs.Core.Models.Presence
{
	public class ActivityTimestamp : IActivityTimestamp
	{
		public int? Start { get; set; }
		public int? End { get; set; }
	}
}