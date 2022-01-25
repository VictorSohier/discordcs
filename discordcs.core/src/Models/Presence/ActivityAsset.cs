using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ActivityAsset : IActivityAsset
	{
		public string LargeImage { get; set; }
		public string LargeText { get; set; }
		public string SmallImage { get; set; }
		public string SmallText { get; set; }
	}
}