using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Discordcs.Core.Models
{
    public class NewMessage : INewMessage
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
		public string PayloadJson { get => JsonConvert.SerializeObject(this,
			new JsonSerializerSettings() {
				Formatting = Formatting.None,
				ContractResolver = new DefaultContractResolver()
				{
					NamingStrategy = new SnakeCaseNamingStrategy()
				}
			}); }
		public Attachment[] Attachments { get; set; }
		[JsonConverter(typeof(SmartEnumArrayValueConverter<MessageFlagsEnum>))]
		public MessageFlagsEnum[] Flags { get; set; }
		public NewMessage(string content)
		{
			Content = content;
		}

		public NewMessage(Embed[] embeds)
		{
			Embeds = embeds;
		}

		public NewMessage(ulong[] stickerIds)
		{
			StickerIds = stickerIds;
		}

		public NewMessage(Sticker[] stickers)
		{
			StickerIds = stickers.Select(e => e.Id).ToArray();
		}

		public NewMessage(Attachment[] attachments)
		{
			Attachments = attachments;
			Files = attachments
				.Select(e => {
					FileStream fs = new(e.Filename, FileMode.Open);
					byte[] file = new byte[fs.Length];
					long iter = 0;
					while (iter < file.Length)
						file[iter] = (byte) fs.ReadByte();
					return file;
				})
				.ToArray();
		}

		public NewMessage(
			string? content = null,
			Sticker[]? stickers = null,
			Attachment[]? attachments = null,
			Embed[]? embeds = null
		)
		{
			Content = content;
			StickerIds = stickers?.Select(e => e.Id).ToArray() ?? null;
			Attachments = attachments;
			Files = attachments?
				.Select(e => {
					FileStream fs = new(e.Filename, FileMode.Open);
					byte[] file = new byte[fs.Length];
					long iter = 0;
					while (iter < file.Length)
						file[iter] = (byte) fs.ReadByte();
					return file;
				})
				.ToArray() ?? null;
			Embeds = embeds;
		}
    }
}