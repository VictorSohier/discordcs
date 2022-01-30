using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IThreadChannelParams : IChannelParams
    {
        public bool Archived { get; set; }
        public uint AutoArchiveDuration { get; set; }
        public bool Locked { get; set; }
        public bool Invitable { get; set; }
        public uint? RateLimitPerUser { get; set; }
    }
}