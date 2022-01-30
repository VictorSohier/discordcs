using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
    public interface INewMessage
    {
		public string Content { get; set; }
		public bool TTS { get; set; }
		public Embed[] Embeds { get; set; }
		public AllowedMentions AllowedMentions { get; set; }
		public MessageReference MessageReference { get; set; }
		public MessageComponent[] Components { get; set; }
		public ulong[] StickerIds { get; set; }
		[JsonIgnore]
		public byte[][] Files { get; set; }
		[JsonIgnore]
		public string PayloadJson { get; }
		public Attachment[] Attachments { get; set; }
		[JsonConverter(typeof(SmartEnumArrayValueConverter<MessageFlagsEnum>))]
		public MessageFlagsEnum[] Flags { get; set; }
    }
}