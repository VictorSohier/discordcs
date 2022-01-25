using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class Emoji : IEmoji
	{
		public ulong? Id { get; set; }
		public string Name { get; set; }
		public ulong[] Roles { get; set; }
		public User user { get; set; }
		public bool RequireColons { get; set; }
		public bool Managed { get; set; }
		public bool Animated { get; set; }
		public bool Available { get; set; }
	}
}