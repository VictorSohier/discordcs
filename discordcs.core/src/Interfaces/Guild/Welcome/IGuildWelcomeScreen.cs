using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IGuildWelcomeScreen
	{
		public string Description { get; set; }
		public GuildWelcomeChannel[] WelcomeChannels { get; set; }
	}
}