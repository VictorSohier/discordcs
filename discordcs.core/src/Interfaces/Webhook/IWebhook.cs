using Discordcs.Core.Interfaces.Channel;
using Discordcs.Core.Interfaces.Guild;
using Discordcs.Core.Interfaces.User;

namespace Discordcs.Core.Interfaces.Webhook
{
	public interface IWebhook
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public ulong? GuildId { get; set; }
		public ulong ChannelId { get; set; }
		public IUser User { get; set; }
		public string Name { get; set; }
		public string Avatar { get; set; }
		public ulong? ApplicationId { get; set; }
		public IChannel SourceChannel { get; set; }
		public string Url { get; set; }
		public IGuild SourceGuild { get; set; }
	}
}