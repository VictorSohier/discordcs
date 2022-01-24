using Discordcs.Core.Interfaces.Channel;
using Discordcs.Core.Interfaces.Channel.Thread;
using Discordcs.Core.Interfaces.User;

namespace Discordcs.Core.Models.Channel
{
	public class Channel : IChannel
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
		public IUser[] Recipients { get; set; }
		public IChannelOverwrite[] PermissionOverwrites { get; set; }
		public IThreadMetadata? ThreadMetadata { get; set; }
		public IThreadMember? Member { get; set; }
	}
}