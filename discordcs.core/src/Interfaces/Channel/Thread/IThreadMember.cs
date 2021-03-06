using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		public MessageFlagsEnum[] Flags { get; set; }
	}
}