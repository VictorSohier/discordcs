namespace Discordcs.Core.Interfaces
{
	public interface IActivityAsset
	{
		public string LargeImage { get; set; }
		public string LargeText { get; set; }
		public string SmallImage { get; set; }
		public string SmallText { get; set; }
	}
}