using Discordcs.core.interfaces.user;

namespace Discordcs.core.models.user
{
	public class User : IUser
	{
		public ulong Id { get; set; }
		public string Username { get; set; }
		public string Discriminator { get; set; }
		public string Avatar { get; set; }
		public bool Bot { get; set; }
		public bool System { get; set; }
		public bool MFAEnabled { get; set; }
		public string Banner { get; set; }
		public int? AccentColor { get; set; }
		public string Locale { get; set; }
		public bool Verified { get; set; }
		public string Email { get; set; }
		public int? Flags { get; set; }
		public int? PremiumType { get; set; }
		public int? PublicFlags { get; set; }
	}
}