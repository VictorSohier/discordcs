namespace Discordcs.core.interfaces.channel
{
	public interface IChannelOverwrite
	{
		public ulong Id { get; set; }
		public int Type { get; set; }
		public string Allow { get; set; }
		public string Deny { get; set; }
	}
}