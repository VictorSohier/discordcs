using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		public uint Flags { get; set; }
		[JsonIgnore]
		public MessageFlagsEnum[] MessageFlagsEnums { get; set; }
	}
}