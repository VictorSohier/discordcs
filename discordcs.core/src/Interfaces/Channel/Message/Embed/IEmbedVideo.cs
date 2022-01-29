using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IEmbedVideo
    {
        public string Url { get; set; }
        public string ProxyUrl { get; set; }
        public uint? Height { get; set; }
        public uint? Width { get; set; }
    }
}