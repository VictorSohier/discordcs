using Discordcs.Core.Interfaces.AuditLog;
using Discordcs.Core.Interfaces.Channel;
using Discordcs.Core.Interfaces.Guild.ScheduledEvent;
using Discordcs.Core.Interfaces.Integration;
using Discordcs.Core.Interfaces.User;
using Discordcs.Core.Interfaces.Webhook;

namespace Discordcs.Core.Models.AuditLog
{
	public class AuditLog : IAuditLog
	{
		public IAuditLogEntry[] AuditLogEntries { get; set; }
		public IGuildScheduledEvent[] GuildScheduledEvents { get; set; }
		public IUser[] Users { get; set; }
		public IIntegration[] Integrations { get; set; }
		public IChannel[] Threads { get; set; }
		public IWebhook[] Webhooks { get; set; }
	}
}