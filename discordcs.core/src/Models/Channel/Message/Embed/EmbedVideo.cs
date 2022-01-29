using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class EmbedVideo : IEmbedVideo
    {
        public string Url { get; set; }
        public string ProxyUrl { get; set; }
        public uint? Height { get; set; }
        public uint? Width { get; set; }
    }
}