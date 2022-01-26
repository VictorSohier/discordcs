using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
	public class AuditLogEntry : IAuditLogEntry
	{
		public ulong Id { get; set; }
		public ulong? UserId { get; set; }
		public string TargetId { get; set; }
		public string Reason { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<AuditLogEventEnum, ushort>))]
		public AuditLogEventEnum ActionType { get; set; }
		public AuditLogChange[] Changes { get; set; }
		public AuditLogOptionalInfo? Options { get; set; }
	}
}