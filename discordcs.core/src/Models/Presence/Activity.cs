using Discordcs.core.interfaces.emoji;
using Discordcs.core.interfaces.presence;

namespace Discordcs.core.models.presence
{
	public class Activity : IActivity
	{
		public string Name { get; set; }
		public int Type { get; set; }
		public string Url { get; set; }
		public int CreatedAt { get; set; }
		public ulong? ApplicationId { get; set; }
		public string Details { get; set; }
		public string State { get; set; }
		public IEmoji Emoji { get; set; }
		public bool Instance { get; set; }
		public int? Flags { get; set; }
		public IActivityTimestamp Timestamps { get; set; }
		public IActivityParty Party { get; set; }
		public IActivityAsset Assets { get; set; }
		public IActivitySecrets Secrets { get; set; }
		public IActivityButton[] Buttons { get; set; }
	}
}