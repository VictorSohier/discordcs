namespace Discordcs.Core.Interfaces.Presence
{
	public interface IActivitySecrets
	{
		public string Join { get; set; }
		public string Spectate { get; set; }
		public string Match { get; set; }
	}
}