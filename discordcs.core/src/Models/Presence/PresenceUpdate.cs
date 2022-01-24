using Discordcs.core.interfaces.presence;
using Discordcs.core.interfaces.user;

namespace Discordcs.core.models.presence
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