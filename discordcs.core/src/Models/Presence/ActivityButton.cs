using Discordcs.core.interfaces.presence;

namespace Discordcs.core.models.presence
{
	public class ActivityButton : IActivityButton
	{
		public string Label { get; set; }
		public string Url { get; set; }
	}
}