using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Interfaces
{
    public interface IDirectMessageChannelParams : IChannelParams
    {
		public byte[] Icon { get; set; }
    }
}