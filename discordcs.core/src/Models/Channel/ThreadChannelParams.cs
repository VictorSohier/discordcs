using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class ThreadChannelParams : IThreadChannelParams
    {
		public string Name { get; set; }
        public bool Archived { get; set; }
        public uint AutoArchiveDuration { get; set; }
        public bool Locked { get; set; }
        public bool Invitable { get; set; }
        public uint? RateLimitPerUser { get; set; }

		public ThreadChannelParams(
			string name,
			bool archived,
			uint autoArchiveDuration,
			bool locked,
			bool invitable
		)
		{
			Name = name;
			Archived = archived;
			AutoArchiveDuration = autoArchiveDuration;
			Locked = locked;
			Invitable = invitable;
		}
    }
}