using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IThreadMetadata
	{
		public bool Archived { get; set; }
		public int AutoArchiveDuration { get; set; }
		public DateTimeOffset ArchiveTimestamp { get; set; }
		public bool Locked { get; set; }
		public bool Invitable { get; set; }
	}
}