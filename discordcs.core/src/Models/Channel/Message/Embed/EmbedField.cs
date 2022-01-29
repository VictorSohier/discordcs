using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class EmbedField : IEmbedField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Inline { get; set; }
    }
}