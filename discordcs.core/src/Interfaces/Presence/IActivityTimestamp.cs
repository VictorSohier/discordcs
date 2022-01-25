using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IActivityTimestamp
	{
		public int? Start { get; set; }
		public int? End { get; set; }
	}
}