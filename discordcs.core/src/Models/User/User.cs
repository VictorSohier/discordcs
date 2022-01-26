using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
	public class User : IUser
	{
		private uint _userFlags { get; set; }
		private uint _premiumTypeFlag { get; set; }
		private uint _publicUserFlags { get; set; }
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
		public uint Flags { get => _userFlags; set => _userFlags = value; }
		[JsonIgnore]
		public UserFlagsEnum[] UserFlags {
			get => UserFlagsEnum.FlagsToArray(_userFlags);
			set => _userFlags = UserFlagsEnum.ArrayToFlags(value);
		}
		public uint PremiumType { get; set; }
		[JsonIgnore]
		public PremiumTypesEnum PremiumTypeEnum {
			get => PremiumTypesEnum.FromValue(_premiumTypeFlag);
			set => _userFlags = value.Value;
		}
		public uint PublicFlags { get; set; }
		[JsonIgnore]
		public UserFlagsEnum[] PublicUserFlags {
			get => UserFlagsEnum.FlagsToArray(_publicUserFlags);
			set => _publicUserFlags = UserFlagsEnum.ArrayToFlags(value);
		}
	}
}