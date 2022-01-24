using Discordcs.core.interfaces.user;
using System;

namespace Discordcs.core.interfaces.guild
{
	public interface IGuildMember
	{
		public IUser User { get; set; }
		public string Nick { get; set; }
		public string Avatar { get; set; }
		public ulong[] Roles { get; set; }
		public DateTimeOffset JoinedAt { get; set; }
		public DateTimeOffset? PremiumSince { get; set; }
		public bool Deaf { get; set; }
		public bool Mute { get; set; }
		public bool Pending { get; set; }
		public string Permissions { get; set; }
		public DateTimeOffset? CommunicationsDisabledUntil { get; set; }
	}
}