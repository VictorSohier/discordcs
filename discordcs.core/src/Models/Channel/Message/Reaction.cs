using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class Reaction : IReaction
    {
        public uint Count { get; set; }
        public bool Me { get; set; }
        public Emoji Emoji { get; set; }
    }
}