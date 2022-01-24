using Discordcs.Core.Interfaces.Presence;

namespace Discordcs.Core.Models.Presence
{
	public class ActivityButton : IActivityButton
	{
		public string Label { get; set; }
		public string Url { get; set; }
	}
}