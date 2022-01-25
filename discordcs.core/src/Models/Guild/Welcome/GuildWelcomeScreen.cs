using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class GuildWelcomeScreen : IGuildWelcomeScreen
	{
		public string Description { get; set; }
		public GuildWelcomeChannel[] WelcomeChannels { get; set; }
	}
}