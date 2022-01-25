using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ActivityParty : IActivityParty
	{
		public string Id { get; set; }
		public int[] Size { get; set; }
	}
}