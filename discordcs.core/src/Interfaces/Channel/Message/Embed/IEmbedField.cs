using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IEmbedField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Inline { get; set; }
    }
}