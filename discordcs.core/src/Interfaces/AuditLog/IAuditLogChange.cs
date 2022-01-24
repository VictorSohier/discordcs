namespace Discordcs.core.interfaces.auditLog
{
	public interface IAuditLogChange
	{
		public string NewValue { get; set; }
		public string OldValue { get; set; }
		public string Key { get; set; }
	}
}