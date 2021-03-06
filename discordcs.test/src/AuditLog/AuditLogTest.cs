using Discordcs.Core.Interfaces;
using Discordcs.Core.Models;
using Discordcs.Infrastructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Discordcs.Test
{
	[TestClass]
	public class AuditLogTest
	{
		private IDiscordWrapper _discord { get; set; }
		private IConfiguration _config { get; }
		private ulong _guildId { get; }
		private JsonSerializerSettings settings = new JsonSerializerSettings();

		public AuditLogTest()
		{
			_config = new ConfigurationBuilder()
				.SetBasePath($"{Directory.GetCurrentDirectory()}/../../../")
				.AddJsonFile("appsettings.json")
				.AddUserSecrets("9462ec6c-6f3b-4e8b-bdd5-d9288223733b")
				.Build();
			_guildId = ulong.Parse(_config["GuildId"]);
			_discord = new DiscordWrapper(
				_config["Token"], Convert.FromBase64String(_config["PublicKey"]));
			settings.Formatting = Formatting.Indented;
		}

		[TestMethod]
		public async Task GetAuditLog()
		{
			IAuditLog auditLog = await _discord.GetGuildAuditLog(_guildId);
			Console.WriteLine(JsonConvert.SerializeObject(auditLog, settings));
			Assert.IsInstanceOfType(auditLog, typeof(AuditLog));
		}
	}
}