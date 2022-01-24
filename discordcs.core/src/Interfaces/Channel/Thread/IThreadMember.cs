using System;

namespace Discordcs.core.interfaces.channel.thread
{
	public interface IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		public int Flags { get; set; }
	}
}