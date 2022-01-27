using Discordcs.Core.Models;

namespace Discordcs.Core.Interfaces
{
	public interface IRole
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public int Color { get; set; }
		public bool Hoist { get; set; }
		public string Icon { get; set; }
		public string UnicodeEmoji { get; set; }
		public int Position { get; set; }
		public string Permissions { get; set; }
		public bool Managed { get; set; }
		public bool Mentionable { get; set; }
		public RoleTag Tags { get; set; }
	}
}