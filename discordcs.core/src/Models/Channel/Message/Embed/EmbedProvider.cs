using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class EmbedProvider : IEmbedProvider
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}