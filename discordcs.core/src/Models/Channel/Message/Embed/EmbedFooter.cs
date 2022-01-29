using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class EmbedFooter : IEmbedFooter
    {
        public string Text { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
}