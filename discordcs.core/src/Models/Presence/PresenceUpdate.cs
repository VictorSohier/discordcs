using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class PresenceUpdate
	{
		public User User { get; set; }
		public ulong GuildId { get; set; }
		public string Status { get; set; }
		public ClientStatus ClientStatus { get; set; }
		public Activity[] Activities { get; set; }
	}
}