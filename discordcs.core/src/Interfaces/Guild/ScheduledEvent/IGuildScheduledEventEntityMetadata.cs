using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IGuildScheduledEventEntityMetadata
	{
		public string Location { get; set; }
	}
}