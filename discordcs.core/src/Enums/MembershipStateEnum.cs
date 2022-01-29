using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class MembershipStateEnum : SmartEnum<MembershipStateEnum, ushort>
    {
		public static readonly MembershipStateEnum INVITED = new("Invited", 1);
		public static readonly MembershipStateEnum ACCEPTED = new("Accepted", 2);
        private MembershipStateEnum(string name, ushort value) : base(name, value)
		{

		}
    }
}