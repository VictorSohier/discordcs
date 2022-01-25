using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IThreadMember
	{
		public ulong? Id { get; set; }
		public ulong? UserId { get; set; }
		public DateTimeOffset JoinTimestamp { get; set; }
		//TODO: Add enum for flag values
		public int Flags { get; set; }
	}
}