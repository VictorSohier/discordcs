using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IChannel
	{
		public ulong Id { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<ChannelTypeEnum, ushort>))]
		public ChannelTypeEnum Type { get; set; }
		public ulong? GuildId { get; set; }
		public uint? Position { get; set; }
		public string Name { get; set; }
		public string Topic { get; set; }
		public bool Nsfw { get; set; }
		public ulong? LastMessageId { get; set; }
		public uint? Bitrate { get; set; }
		public uint? UserLimit { get; set; }
		public uint? RateLimitPerUser { get; set; }
		public string Icon { get; set; }
		public ulong? OwnerId { get; set; }
		public ulong? ApplicationId { get; set; }
		public ulong? ParentId { get; set; }
		public DateTimeOffset? LastPinTimestamp { get; set; }
		public string RTCRegion { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<VideoQualityEnum, ushort>))]
		public VideoQualityEnum VideoQualityMode { get; set; }
		public uint? MessageCount { get; set; }
		public uint? DefaultAutoArchiveDuration { get; set; }
		public string Permissions { get; set; }
		public User[] Recipients { get; set; }
		public ChannelOverwrite[] PermissionOverwrites { get; set; }
		public ThreadMetadata? ThreadMetadata { get; set; }
		public ThreadMember? Member { get; set; }
	}
}