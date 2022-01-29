using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
    public class Message
    {
        public ulong Id { get; set; }
		public ulong ChannelId { get; set; }
		public ulong? GuildId { get; set; }
		public User Author { get; set; }
		public GuildMember Member { get; set; }
		public string Content { get; set; }
		public DateTimeOffset Timestamp { get; set; }
		public DateTimeOffset EditedTimestamp { get; set; }
		public bool TTS { get; set; }
		public bool MentionEveryone { get; set; }
		public User[] Mentions { get; set; }
		public Role[] MentionRoles { get; set; }
		public Channel[] MentionChannels { get; set; }
		public Attachment[] Attachments { get; set; }
		public Embed[] Embeds { get; set; } 
		public Reaction[] Reactions { get; set; }
		public string Nonce { get; set; }
		public bool Pinned { get; set; }
		public ulong? WebhookId { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<MessageTypeEnum, ushort>))]
		public MessageTypeEnum Type { get; set; }
		public Application Application { get; set; }
		public ulong? ApplicationId { get; set; }
		public MessageReference MessageReference { get; set; }
		[JsonConverter(typeof(SmartEnumArrayValueConverter<MessageFlagsEnum>))]
		public MessageFlagsEnum[] Flags { get; set; }
		public MessageInteraction Interaction { get; set; }
		public Channel Thread { get; set; }
		public MessageComponent[] Components { get; set; }
		public StickerItem[] StickerItems { get; set; }
		public Sticker Stickers { get; set; }
    }
}