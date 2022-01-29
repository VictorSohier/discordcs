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
		[JsonConverter(typeof(SmartEnumArrayValueConverter<MessageFlagsEnum>))]
		public MessageFlagsEnum[] Flags { get; set; }
	}
}