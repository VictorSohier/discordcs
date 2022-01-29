using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
    public class TeamMember : ITeamMember
    {
		private ushort _membershipState { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<MembershipStateEnum, ushort>))]
        public MembershipStateEnum MembershipState { get; set; }
		public string[] Permissions { get; set; }
        public ulong TeamId { get; set; }
        public User User { get; set; }
    }
}