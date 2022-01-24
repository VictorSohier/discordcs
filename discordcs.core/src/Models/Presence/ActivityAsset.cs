using Discordcs.Core.Interfaces.Presence;

namespace Discordcs.Core.Models.Presence
{
	public class ActivityAsset : IActivityAsset
	{
		public string LargeImage { get; set; }
		public string LargeText { get; set; }
		public string SmallImage { get; set; }
		public string SmallText { get; set; }
	}
}