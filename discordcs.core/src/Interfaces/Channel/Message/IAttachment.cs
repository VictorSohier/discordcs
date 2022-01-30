namespace Discordcs.Core.Interfaces
{
    public interface IAttachment
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
    }
}