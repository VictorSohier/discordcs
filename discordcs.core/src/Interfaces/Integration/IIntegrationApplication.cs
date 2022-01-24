using Discordcs.core.interfaces.user;

namespace Discordcs.core.interfaces.integration
{
	public interface IIntegrationApplication
	{
		public ulong Id { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }
		public string Summary { get; set; }
		public IUser Bot { get; set; }
	}
}