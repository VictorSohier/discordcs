using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IActivityButton
	{
		public string Label { get; set; }
		public string Url { get; set; }
	}
}