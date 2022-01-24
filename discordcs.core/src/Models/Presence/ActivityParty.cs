using Discordcs.Core.Interfaces.Presence;

namespace Discordcs.Core.Models.Presence
{
	public class ActivityParty : IActivityParty
	{
		public string Id { get; set; }
		public int[] Size { get; set; }
	}
}