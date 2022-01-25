using Discordcs.Core.Interfaces;

namespace Discordcs.Core.Models
{
	public class Webhook : IWebhook
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public ulong? GuildId { get; set; }
		public ulong ChannelId { get; set; }
		public User User { get; set; }
		public string Name { get; set; }
		public string Avatar { get; set; }
		public ulong? ApplicationId { get; set; }
		public Channel SourceChannel { get; set; }
		public string Url { get; set; }
		public Guild SourceGuild { get; set; }
	}
}