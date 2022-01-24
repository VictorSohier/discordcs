using Discordcs.Core.Interfaces.User;

namespace Discordcs.Core.Interfaces.Presence
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