using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace Discordcs.Core.Enums
{
	[JsonConverter(typeof(SmartEnumValueConverter<AuditLogEventEnum, ushort>))]
	public class AuditLogEventEnum : SmartEnum<AuditLogEventEnum, ushort>
	{
		public static readonly AuditLogEventEnum GUILD_UPDATE = new("Guild update", 1);
		public static readonly AuditLogEventEnum CHANNEL_CREATE = new("Channel create", 10);
		public static readonly AuditLogEventEnum CHANNEL_UPDATE = new("Channel update", 11);
		public static readonly AuditLogEventEnum CHANNEL_DELETE = new("Channel delete", 12);
		public static readonly AuditLogEventEnum CHANNEL_OVERWRITE_CREATE = new("Channel overwrite create", 13);
		public static readonly AuditLogEventEnum CHANNEL_OVERWRITE_UPDATE = new("Channel overwrite update", 14);
		public static readonly AuditLogEventEnum CHANNEL_OVERWRITE_DELETE = new("Channel overwrite delete", 15);
		public static readonly AuditLogEventEnum MEMBER_KICK = new("Member kick", 20);
		public static readonly AuditLogEventEnum MEMBER_PRUNE = new("Member prune", 21);
		public static readonly AuditLogEventEnum MEMBER_BAN_ADD = new("Member ban add", 22);
		public static readonly AuditLogEventEnum MEMBER_BAN_REMOVE = new("Member ban remove", 23);
		public static readonly AuditLogEventEnum MEMBER_UPDATE = new("Member ban update", 24);
		public static readonly AuditLogEventEnum MEMBER_ROLE_UPDATE = new("Member role update", 25);
		public static readonly AuditLogEventEnum MEMBER_MOVE = new("Member move", 26);
		public static readonly AuditLogEventEnum MEMBER_DISCONNECT = new("Member disconnect", 27);
		public static readonly AuditLogEventEnum BOT_ADD = new("Bot add", 28);
		public static readonly AuditLogEventEnum ROLE_CREATE = new("Role create", 30);
		public static readonly AuditLogEventEnum ROLE_UPDATE = new("Role update", 31);
		public static readonly AuditLogEventEnum ROLE_DELETE = new("Role delete", 32);
		public static readonly AuditLogEventEnum INVITE_CREATE = new("Invite create", 40);
		public static readonly AuditLogEventEnum INVITE_UPDATE = new("Invite update", 41);
		public static readonly AuditLogEventEnum INVITE_DELETE = new("Invite delete", 42);
		public static readonly AuditLogEventEnum WEBHOOK_CREATE = new("Webhook create", 50);
		public static readonly AuditLogEventEnum WEBHOOK_UPDATE = new("Webhook update", 51);
		public static readonly AuditLogEventEnum WEBHOOK_DELETE = new("Webhook delete", 52);
		public static readonly AuditLogEventEnum EMOJI_CREATE = new("Emoji create", 60);
		public static readonly AuditLogEventEnum EMOJI_UPDATE = new("Emoji update", 61);
		public static readonly AuditLogEventEnum EMOJI_DELETE = new("Emoji delete", 62);
		public static readonly AuditLogEventEnum MESSAGE_DELETE = new("Message delete", 72);
		public static readonly AuditLogEventEnum MESSAGE_BULK_DELETE = new("Message bulk delete", 73);
		public static readonly AuditLogEventEnum MESSAGE_PIN = new("Message pin", 74);
		public static readonly AuditLogEventEnum MESSAGE_UNPIN = new("Message unpin", 75);
		public static readonly AuditLogEventEnum INTEGRATION_CREATE = new("Integration create", 80);
		public static readonly AuditLogEventEnum INTEGRATION_UPDATE = new("Integration update", 81);
		public static readonly AuditLogEventEnum INTEGRATION_DELETE = new("Integration delete", 82);
		public static readonly AuditLogEventEnum STAGE_INSTANCE_CREATE = new("Stage instance create", 83);
		public static readonly AuditLogEventEnum STAGE_INSTANCE_UPDATE = new("Stage instance update", 84);
		public static readonly AuditLogEventEnum STAGE_INSTANCE_DELETE = new("Stage instance delete", 85);
		public static readonly AuditLogEventEnum STICKER_CREATE = new("Sticker create", 90);
		public static readonly AuditLogEventEnum STICKER_UPDATE = new("Sticker update", 91);
		public static readonly AuditLogEventEnum STICKER_DELETE = new("Sticker delete", 92);
		public static readonly AuditLogEventEnum GUILD_SCHEHDULE_EVENT_CREATE = new("Guild schedule event create", 100);
		public static readonly AuditLogEventEnum GUILD_SCHEHDULE_EVENT_UPDATE = new("Guild schedule event update", 101);
		public static readonly AuditLogEventEnum GUILD_SCHEHDULE_EVENT_DELETE = new("Guild schedule event delete", 102);
		public static readonly AuditLogEventEnum THREAD_CREATE = new("Thread create", 110);
		public static readonly AuditLogEventEnum THREAD_UPDATE = new("Thread update", 111);
		public static readonly AuditLogEventEnum THREAD_DELETE = new("Thread delete", 112);

		private AuditLogEventEnum(string name, ushort value) : base(name, value)
		{

		}
	}
}