using Discordcs.Core.Interfaces.Emoji;

namespace Discordcs.Core.Interfaces.Presence
{
	public interface IActivity
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