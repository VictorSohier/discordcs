using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class ActivityFlagsEnum : BitFlagSmartEnum<ActivityFlagsEnum>
    {
		public static readonly ActivityFlagsEnum INSTANCE = new("Instance", 1 << 0);
		public static readonly ActivityFlagsEnum JOIN = new("Join", 1 << 1);
		public static readonly ActivityFlagsEnum SPECTATE = new("Spectate", 1 << 2);
		public static readonly ActivityFlagsEnum JOIN_REQUEST = new("Join request", 1 << 3);
		public static readonly ActivityFlagsEnum SYNC = new("Sync", 1 << 4);
		public static readonly ActivityFlagsEnum PLAY = new("Play", 1 << 5);
		public static readonly ActivityFlagsEnum PARTY_PRIVACY_FRIENDS = new("Party privacy friends", 1 << 6);
		public static readonly ActivityFlagsEnum PARTY_PRIVACY_VOICE_CHANNEL = new("Party privacy voice channel", 1 << 7);
		public static readonly ActivityFlagsEnum EMBEDDED = new("Embedded", 1 << 8);

        public ActivityFlagsEnum(string name, ulong value) : base(name, value)
		{

		}
    }
}