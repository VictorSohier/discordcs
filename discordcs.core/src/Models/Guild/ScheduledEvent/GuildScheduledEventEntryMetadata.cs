using Discordcs.Core.Interfaces.Guild.ScheduledEvent;

namespace Discordcs.Core.Models.Guild.ScheduledEvent
{
	public class GuildScheduledEventEntryMetadata : IGuildScheduledEventEntityMetadata
	{
		public string Location { get; set; }
	}
}