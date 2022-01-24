namespace Discordcs.Core.Interfaces.Presence
{
	public interface IActivityTimestamp
	{
		public int? Start { get; set; }
		public int? End { get; set; }
	}
}