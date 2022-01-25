using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
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
		public Emoji Emoji { get; set; }
		public bool Instance { get; set; }
		//TODO: Add enum for flag values
		public int? Flags { get; set; }
		public ActivityTimestamp Timestamps { get; set; }
		public ActivityParty Party { get; set; }
		public ActivityAsset Assets { get; set; }
		public ActivitySecrets Secrets { get; set; }
		public ActivityButton[] Buttons { get; set; }
	}
}