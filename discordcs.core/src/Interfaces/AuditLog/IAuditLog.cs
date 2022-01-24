using Discordcs.core.interfaces.channel;
using Discordcs.core.interfaces.guild.scheduledEvent;
using Discordcs.core.interfaces.integration;
using Discordcs.core.interfaces.user;
using Discordcs.core.interfaces.webhook;

namespace Discordcs.core.interfaces.auditLog
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