using Discordcs.Core.Interfaces.Presence;
using Discordcs.Core.Interfaces.User;

namespace Discordcs.Core.Models.Presence
{
	public class PresenceUpdate
	{
		public IUser User { get; set; }
		public ulong GuildId { get; set; }
		public string Status { get; set; }
		public IClientStatus ClientStatus { get; set; }
		public IActivity[] Activities { get; set; }
	}
}