using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IChannel
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public ulong GuildId { get; set; }
		public int Position { get; set; }
		public string Name { get; set; }
		public string Topic { get; set; }
		public bool Nsfw { get; set; }
		public ulong? LastMessageId { get; set; }
		public int? Bitrate { get; set; }
		public int? UserLimit { get; set; }
		public int? RateLimitPerUser { get; set; }
		public string Icon { get; set; }
		public ulong? OwnerId { get; set; }
		public ulong? ApplicationId { get; set; }
		public ulong? ParentId { get; set; }
		public DateTimeOffset? LastPinTimestamp { get; set; }
		public string RTCRegion { get; set; }
		public int? VideoQualityMode { get; set; }
		public int? MessageCount { get; set; }
		public int? DefaultAutoArchiveDuration { get; set; }
		public string Permissions { get; set; }
		public User[] Recipients { get; set; }
		public ChannelOverwrite[] PermissionOverwrites { get; set; }
		public ThreadMetadata? ThreadMetadata { get; set; }
		public ThreadMember? Member { get; set; }
	}
}