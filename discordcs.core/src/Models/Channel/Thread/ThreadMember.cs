using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
	public class ThreadMember : IThreadMember
	{
		private uint _messageFlags { get; set; }
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		public uint Flags { get => _messageFlags; set => _messageFlags = value; }
		[JsonIgnore]
		public MessageFlagsEnum[] MessageFlags {
			get => MessageFlagsEnum.FlagsToArray(_messageFlags);
			set => _messageFlags = MessageFlagsEnum.ArrayToFlags(value);
		}
	}
}