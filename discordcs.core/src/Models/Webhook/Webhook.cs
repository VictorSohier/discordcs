using Discordcs.core.interfaces.channel;
using Discordcs.core.interfaces.guild;
using Discordcs.core.interfaces.user;
using Discordcs.core.interfaces.webhook;

namespace Discordcs.core.models.webhook
{
	public class Webhook : IWebhook
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