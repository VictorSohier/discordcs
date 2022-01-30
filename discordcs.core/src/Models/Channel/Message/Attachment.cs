using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
    public class Attachment : IAttachment
    {
        public ulong Id { get; set; }
		public string Filename { get; set; }
		public string Description { get; set; }
		public string ContentType { get; set; }
		public long Size { get; set; }
		public string Url { get; set; }
		public string ProxyUrl { get; set; }
		public uint? Height { get; set; }
		public uint? Width { get; set; }
		public Attachment(ulong id, string filename, string contentType)
		{
			Id = id;
			Filename = filename;
			ContentType = contentType;
		}
    }
}