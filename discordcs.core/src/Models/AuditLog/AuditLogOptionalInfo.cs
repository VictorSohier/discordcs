using Discordcs.core.interfaces.auditLog;

namespace Discordcs.core.models.auditLog
{
	public class AuditLogOptionalInfo : IAuditLogOptionalInfo
	{
		public ulong? ChannelId { get; set; }
		public ulong? Count { get; set; }
		public ulong? DeleteMemberDays { get; set; }
		public ulong? Id { get; set; }
		public ulong? MembersRemoved { get; set; }
		public ulong? MessageId { get; set; }
		public string RoleName { get; set; }
		public string Type { get; set; }
	}
}