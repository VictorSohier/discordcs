using System;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
    public class GuildChannelParams : IGuildChannelParams
    {
		public string Name { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<ChannelTypeEnum, ushort>))]
        public ChannelTypeEnum Type { get; set; }
		public uint? Position { get; set; }
		public string Topic { get; set; }
		public bool? Nsfw { get; set; }
		public uint? RateLimitPerUser { get; set; }
		public uint? Bitrate { get; set; }
		public uint? UserLimit { get; set; }
		public ChannelOverwrite[] PermissionOverwrites { get; set; }
		public ulong? ParentId { get; set; }
		public string RTCRegion { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<VideoQualityEnum, ushort>))]
		public VideoQualityEnum VideoQualityMode { get; set; }
		public uint? DefaultAutoArchiveDuration { get; set; }

		public GuildChannelParams(string name, ChannelTypeEnum type)
		{
			Name = name;
			Type = type;
		}
    }
}