using Discordcs.Core.Enums;
using Discordcs.Core.Models;

namespace Discordcs.Core.Interfaces
{
	public interface IDiscordWrapper
	{
		public Task<IAuditLog> GetGuildAuditLog(ulong guildId, ulong? userId=null, AuditLogEventEnum? eventType=null, ulong? beforeId=null, int? limit=null);
		public Task<IChannel> GetChannel(ulong channelId);
		public Task<Channel> ModifyChannel(ulong channelId, IChannelParams parameters);
		public void DeleteChannel(ulong channelId);
		public Task<Message[]> GetChannelMessages(ulong channelId, ulong? around=null, ulong? before=null, ulong? after=null, byte? limit=null);
	}
}