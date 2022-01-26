using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
	public class Activity : IActivity
	{
		private uint _activityFlagsEnum { get; set; }
		public string Name { get; set; }
		public int Type { get; set; }
		public string Url { get; set; }
		public int CreatedAt { get; set; }
		public ulong? ApplicationId { get; set; }
		public string Details { get; set; }
		public string State { get; set; }
		public Emoji Emoji { get; set; }
		public bool Instance { get; set; }
		public uint Flags {
			get => _activityFlagsEnum;
			set => _activityFlagsEnum = value;
		}
		[JsonIgnore]
		public ActivityFlagsEnum[] ActivityFlags {
			get => ActivityFlagsEnum.FlagsToArray(_activityFlagsEnum);
			set => _activityFlagsEnum = ActivityFlagsEnum.ArrayToFlags(value);
		}
		public ActivityTimestamp Timestamps { get; set; }
		public ActivityParty Party { get; set; }
		public ActivityAsset Assets { get; set; }
		public ActivitySecrets Secrets { get; set; }
		public ActivityButton[] Buttons { get; set; }
	}
}