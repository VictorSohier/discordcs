using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Discordcs.Core.Models;
using Newtonsoft.Json;

namespace Discordcs.Core.Interfaces
{
	public interface IUser
	{
		public ulong Id { get; set; }
		public string Username { get; set; }
		public string Discriminator { get; set; }
		public string Avatar { get; set; }
		public bool Bot { get; set; }
		public bool System { get; set; }
		public bool MFAEnabled { get; set; }
		public string Banner { get; set; }
		public int? AccentColor { get; set; }
		public string Locale { get; set; }
		public bool Verified { get; set; }
		public string Email { get; set; }
		[JsonConverter(typeof(SmartEnumArrayValueConverter<SystemChannelFlagsEnum>))]
		public UserFlagsEnum[] Flags { get; set; }
		[JsonConverter(typeof(SmartEnumValueConverter<PremiumTypesEnum, uint>))]
		public PremiumTypesEnum PremiumType { get; set; }
		[JsonConverter(typeof(SmartEnumArrayValueConverter<UserFlagsEnum>))]
		public UserFlagsEnum[] PublicFlags { get; set; }
	}
}