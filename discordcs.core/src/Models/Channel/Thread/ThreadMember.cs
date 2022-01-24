using Discordcs.core.interfaces.channel.thread;

namespace Discordcs.core.models.channel.thread
{
	public class ThreadMember : IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		public int Flags { get; set; }
	}
}