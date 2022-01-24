using Discordcs.core.interfaces.guild.scheduledEvent;

namespace Discordcs.core.models.guild.scheduledEvent
{
	public class GuildScheduledEventEntryMetadata : IGuildScheduledEventEntityMetadata
	{
		public string Location { get; set; }
	}
}