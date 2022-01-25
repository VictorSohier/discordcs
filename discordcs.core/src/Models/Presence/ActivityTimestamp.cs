using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ActivityTimestamp : IActivityTimestamp
	{
		public int? Start { get; set; }
		public int? End { get; set; }
	}
}