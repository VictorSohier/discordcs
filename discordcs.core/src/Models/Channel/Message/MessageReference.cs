using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class MessageReference : IMessageReference
    {
        public ulong? MessageId { get; set; }
		public ulong? ChannelId { get; set; }
		public ulong? GuildId { get; set; }
		public bool? FailIfNotExists { get; set; }
    }
}