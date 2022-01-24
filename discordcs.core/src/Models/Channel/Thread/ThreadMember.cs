using Discordcs.Core.Interfaces.Channel.Thread;

namespace Discordcs.Core.Models.Channel.Thread
{
	public class ThreadMember : IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		public int Flags { get; set; }
	}
}