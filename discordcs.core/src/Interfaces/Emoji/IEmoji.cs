using Discordcs.core.interfaces.user;

namespace Discordcs.core.interfaces.emoji
{
	public interface IEmoji
	{
		public ulong? Id { get; set; }
		public string Name { get; set; }
		public ulong[] Roles { get; set; }
		public IUser user { get; set; }
		public bool RequireColons { get; set; }
		public bool Managed { get; set; }
		public bool Animated { get; set; }
		public bool Available { get; set; }
	}
}