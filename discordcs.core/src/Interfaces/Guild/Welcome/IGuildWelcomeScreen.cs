namespace Discordcs.core.interfaces.guild.welcome
{
	public interface IGuildWelcomeScreen
	{
		public string Description { get; set; }
		public IGuildWelcomeChannel[] WelcomeChannels { get; set; }
	}
}