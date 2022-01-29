using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Enums;

namespace Discordcs.Core.Interfaces
{
    public interface IMessageActivity
    {
        public ushort Type { get; set; }
		public MessageActivityEnum MessageActivity { get; set; }
		public string PartyId { get; set; }
    }
}