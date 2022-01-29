using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class MessageTypeEnum : SmartEnum<MessageTypeEnum, ushort>
    {
		public static readonly MessageTypeEnum DEFAULT = new("Default", 0);
		public static readonly MessageTypeEnum RECIPIENT_ADD = new("Recipient add", 1);
		public static readonly MessageTypeEnum RECIPIENT_REMOVE = new("Recipient remove", 2);
		public static readonly MessageTypeEnum CALL = new("Call", 3);
		public static readonly MessageTypeEnum CHANNEL_NAME_CHANGE = new("Channel name change", 4);
		public static readonly MessageTypeEnum CHANNEL_ICON_CHANGE = new("Channel icon change", 5);
		public static readonly MessageTypeEnum CHANNEL_PINNED_CHANGE = new("Channel pinned change", 6);
		public static readonly MessageTypeEnum GUILD_MEMBER_JOIN = new("Guild member join", 7);
		public static readonly MessageTypeEnum USER_PREMIUM_GUILD_SUBSCRIPTION = new("Usser premium guild subscription", 8);
		public static readonly MessageTypeEnum USER_PREMIUM_GUILD_SUBSCRIPTION_TIER_1 = new("Usser premium guild subscription tier 1", 9);
		public static readonly MessageTypeEnum USER_PREMIUM_GUILD_SUBSCRIPTION_TIER_2 = new("Usser premium guild subscription tier 2", 10);
		public static readonly MessageTypeEnum USER_PREMIUM_GUILD_SUBSCRIPTION_TIER_3 = new("Usser premium guild subscription tier 3", 11);
		public static readonly MessageTypeEnum CHANNEL_FOLLOW_ADD = new("Channel follow add", 12);
		public static readonly MessageTypeEnum GUILD_DISCOVERY_DISQUALIFIED = new("Guild discovery disqualified", 14);
		public static readonly MessageTypeEnum GUILD_DISCOVERY_REQUALIFIED = new("Guild discovery Requalified", 15);
		public static readonly MessageTypeEnum GUILD_DISCOVERY_GRACE_PERIOD_INITIAL_WARNING = new("Guild discovery grace period initial warning", 16);
		public static readonly MessageTypeEnum GUILD_DISCOVERY_GRACE_PERIOD_FINAL_WARNING = new("Guild discovery grace period final warning", 17);
		public static readonly MessageTypeEnum THREAD_CREATED = new("Thread created", 18);
		public static readonly MessageTypeEnum REPLY = new("Reply", 19);
		public static readonly MessageTypeEnum CHAT_INPUT_COMMAND = new("Chat input command", 20);
		public static readonly MessageTypeEnum THREAD_STARTER_MESSAGE = new("Thread starter message", 21);
		public static readonly MessageTypeEnum GUILD_INVITE_REMINDER = new("Guild invite reminder", 22);
		public static readonly MessageTypeEnum CONTEXT_MENU_COMMAND = new("Context menu command", 23);

        private MessageTypeEnum (string name, ushort value) : base(name, value)
		{

		}
    }
}