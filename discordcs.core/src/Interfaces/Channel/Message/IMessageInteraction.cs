using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Enums;
using Discordcs.Core.Models;

namespace discordcs.core.src.Interfaces.Channel.Message
{
    public interface IMessageInteraction
    {
        public ulong Id { get; set; }
		public ushort Type { get; set; }
		public InteractionTypeEnum InteractionType { get; set; }
		public string Name { get; set; }
		public User User { get; set; }
		public GuildMember Member { get; set; }
    }
}