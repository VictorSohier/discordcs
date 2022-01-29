using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class MessageFlagsEnum : BitFlagSmartEnum<MessageFlagsEnum>
    {
		public static readonly MessageFlagsEnum CROSSPOSTED = new("Crossposted", 1 << 0); 
		public static readonly MessageFlagsEnum IS_CROSSPOST = new("Is crosspost", 1 << 1); 
		public static readonly MessageFlagsEnum SUPPRESS_EMBEDS = new("Suppress embeds", 1 << 2);
		public static readonly MessageFlagsEnum SOURCE_MESSAGE_DELETED = new("Source message deleted", 1 << 3);
		public static readonly MessageFlagsEnum URGENT = new("Urgent", 1 << 4);
		public static readonly MessageFlagsEnum HAS_THREAD = new("Has thread", 1 << 5);
		public static readonly MessageFlagsEnum EPHEMERAL = new("Ephemeral", 1 << 6);
		public static readonly MessageFlagsEnum LOADING = new("Loading", 1 << 7);

        private MessageFlagsEnum(string name, ulong value) : base(name, value)
		{

		}
    }
}