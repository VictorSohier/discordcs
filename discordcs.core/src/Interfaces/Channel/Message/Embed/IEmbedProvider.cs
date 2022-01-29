using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discordcs.Core.Interfaces
{
    public interface IEmbedProvider
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}