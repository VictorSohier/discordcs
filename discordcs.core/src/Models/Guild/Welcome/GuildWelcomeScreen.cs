using Discordcs.core.interfaces.guild.welcome;

namespace Discordcs.core.models.guild.welcome
{
	public class GuildWelcomeScreen : IGuildWelcomeScreen
	{
		public string Description { get; set; }
		public IGuildWelcomeChannel[] WelcomeChannels { get; set; }
	}
}