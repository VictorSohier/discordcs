using Discordcs.core.interfaces.presence;

namespace Discordcs.core.models.presence
{
	public class ActivityParty : IActivityParty
	{
		public string Id { get; set; }
		public int[] Size { get; set; }
	}
}