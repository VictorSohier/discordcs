using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IAllowedMentions
    {
        public string[] Parse { get; set; }
		public ulong[] Roles { get; set; }
		public ulong[] Users { get; set; }
		public bool RepliedUser { get; set; }
    }
}