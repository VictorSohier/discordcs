namespace Discordcs.Core.Interfaces.Presence
{
	public interface IClientStatus
	{
		public string Desktop { get; set; }
		public string Mobile { get; set; }
		public string Web { get; set; }
	}
}