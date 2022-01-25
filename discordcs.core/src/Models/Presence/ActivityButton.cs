using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ActivityButton : IActivityButton
	{
		public string Label { get; set; }
		public string Url { get; set; }
	}
}