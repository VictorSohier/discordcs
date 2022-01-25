using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class ThreadMetadata : IThreadMetadata
	{
		public bool Archived { get; set; }
		public int AutoArchiveDuration { get; set; }
		public DateTimeOffset ArchiveTimestamp { get; set; }
		public bool Locked { get; set; }
		public bool Invitable { get; set; }
	}
}