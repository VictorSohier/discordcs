using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class Team : ITeam
    {
        public string Icon { get; set; }
        public ulong Id { get; set; }
        public TeamMember[] Members { get; set; }
        public string Name { get; set; }
        public ulong OwnerUserId { get; set; }
    }
}