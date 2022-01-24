using Discordcs.Core.Interfaces.Guild.Welcome;

namespace Discordcs.Core.Models.Guild.Welcome
{
	public class GuildWelcomeScreen : IGuildWelcomeScreen
	{
		public string Description { get; set; }
		public IGuildWelcomeChannel[] WelcomeChannels { get; set; }
	}
}