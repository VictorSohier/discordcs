using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Models;

namespace Discordcs.Core.Interfaces
{
    public interface ISelectOption
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public Emoji Emoji { get; set; }
        public bool? Default { get; set; }
    }
}