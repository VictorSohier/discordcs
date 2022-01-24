namespace Discordcs.Core.Interfaces.Guild.Welcome
{
	public interface IGuildWelcomeScreen
	{
		public string Description { get; set; }
		public IGuildWelcomeChannel[] WelcomeChannels { get; set; }
	}
}