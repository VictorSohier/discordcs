using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ThreadMember : IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		//TODO: Add enum for flag values
		public int Flags { get; set; }
	}
}