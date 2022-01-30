using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
    public interface IGuildChannelParams : IChannelParams
    {
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
    }
}