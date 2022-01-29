using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IEmbedAuthor
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
}