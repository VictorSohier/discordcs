using Discordcs.Core.Interfaces.Channel.Thread;

namespace Discordcs.Core.Models.Channel.Thread
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