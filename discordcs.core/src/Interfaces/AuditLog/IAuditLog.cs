using Discordcs.Core.Interfaces.Channel;
using Discordcs.Core.Interfaces.Guild.ScheduledEvent;
using Discordcs.Core.Interfaces.Integration;
using Discordcs.Core.Interfaces.User;
using Discordcs.Core.Interfaces.Webhook;

namespace Discordcs.Core.Interfaces.AuditLog
{
	public interface IAuditLog
	{
		public IAuditLogEntry[] AuditLogEntries { get; set; }
		public IGuildScheduledEvent[] GuildScheduledEvents { get; set; }
		public IUser[] Users { get; set; }
		public IIntegration[] Integrations { get; set; }
		public IChannel[] Threads { get; set; }
		public IWebhook[] Webhooks { get; set; }
	}
}