using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IEmbedFooter
    {
        public string Text { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
}