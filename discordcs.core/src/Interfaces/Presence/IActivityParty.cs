using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IActivityParty
	{
		public string Id { get; set; }
		public int[] Size { get; set; }
	}
}