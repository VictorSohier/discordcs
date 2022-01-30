using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class AllowedMentions : IAllowedMentions
    {
        public string[] Parse { get; set; }
		public ulong[] Roles { get; set; }
		public ulong[] Users { get; set; }
		public bool RepliedUser { get; set; }
    }
}