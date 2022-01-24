using Discordcs.Core.Interfaces.User;

namespace Discordcs.Core.Interfaces.Sticker
{
	public interface ISticker : IComparable<ISticker>
	{
		public ulong Id { get; set; }
		public ulong? PackId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Tags { get; set; }
		public string Asset { get; set; }
		public int Type { get; set; }
		public int FormatAType { get; set; }
		public bool Available { get; set; }
		public ulong GuildId { get; set; }
		public IUser User { get; set; }
		public int? SortValue { get; set; }
	}
}