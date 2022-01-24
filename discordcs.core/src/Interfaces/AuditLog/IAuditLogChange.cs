namespace Discordcs.Core.Interfaces.AuditLog
{
	public interface IAuditLogChange
	{
		public string NewValue { get; set; }
		public string OldValue { get; set; }
		public string Key { get; set; }
	}
}