using Discordcs.Core.Models;

namespace Discordcs.Core.Interfaces
{
	public interface IPresenceUpdate
	{
		public User User { get; set; }
		public ulong GuildId { get; set; }
		public string Status { get; set; }
		public ClientStatus ClientStatus { get; set; }
		public Activity[] Activities { get; set; }
	}
}