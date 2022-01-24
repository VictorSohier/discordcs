namespace Discordcs.Core.Interfaces.Presence
{
	public interface IActivityParty
	{
		public string Id { get; set; }
		public int[] Size { get; set; }
	}
}