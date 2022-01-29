using Discordcs.Core.Models;

namespace Discordcs.Core.Interfaces
{
	public interface IAuditLog
	{
		public AuditLogEntry[] AuditLogEntries { get; set; }
		public GuildScheduledEvent[] GuildScheduledEvents { get; set; }
		public User[] Users { get; set; }
		public Integration[] Integrations { get; set; }
		public Channel[] Threads { get; set; }
		public Webhook[] Webhooks { get; set; }
	}
}