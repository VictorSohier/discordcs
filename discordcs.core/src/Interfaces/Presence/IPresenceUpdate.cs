using Discordcs.core.interfaces.user;

namespace Discordcs.core.interfaces.presence
{
	public interface IPresenceUpdate
	{
		public IUser User { get; set; }
		public ulong GuildId { get; set; }
		public string Status { get; set; }
		public IClientStatus ClientStatus { get; set; }
		public IActivity[] Activities { get; set; }
	}
}