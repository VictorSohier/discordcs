using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class MessageFlagsEnum : SmartEnum<MessageFlagsEnum, uint>
    {
		public static readonly MessageFlagsEnum CROSSPOSTED = new("Crossposted", 1 << 0); 
		public static readonly MessageFlagsEnum IS_CROSSPOST = new("Is crosspost", 1 << 1); 
		public static readonly MessageFlagsEnum SUPPRESS_EMBEDS = new("Suppress embeds", 1 << 2);
		public static readonly MessageFlagsEnum SOURCE_MESSAGE_DELETED = new("Source message deleted", 1 << 3);
		public static readonly MessageFlagsEnum URGENT = new("Urgent", 1 << 4);
		public static readonly MessageFlagsEnum HAS_THREAD = new("Has thread", 1 << 5);
		public static readonly MessageFlagsEnum EPHEMERAL = new("Ephemeral", 1 << 6);
		public static readonly MessageFlagsEnum LOADING = new("Loading", 1 << 7);

        private MessageFlagsEnum(string name, uint value) : base(name, value)
		{

		}

		public static MessageFlagsEnum[] FlagsToArray(uint value)
		{
			List<MessageFlagsEnum> ret = new();
			uint mask = 1;
			while (mask != 0)
			{
				if ((value & mask) > 0)
				{
					ret.Add(FromValue(mask));
				}
				mask <<= 1;
			}
			return ret.ToArray();
		}

		public static uint ArrayToFlags(IEnumerable<MessageFlagsEnum> values)
		{
			uint ret = 0;
			foreach (MessageFlagsEnum v in values)
			{
				ret |= v.Value;
			}
			return ret;
		}
    }
}