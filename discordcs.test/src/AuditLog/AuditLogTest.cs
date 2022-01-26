using Discordcs.Core.Interfaces;
using Discordcs.Core.Models;
using Discordcs.Infrastructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Discordcs.test.auditLog
{
	[TestClass]
	public class AuditLogTest
	{
		private IDiscordWrapper _discord { get; set; }
		private IConfiguration _config { get; }

		public AuditLogTest()
		{
			_config = new ConfigurationBuilder()
				.SetBasePath($"{Directory.GetCurrentDirectory()}/../../../")
				.AddJsonFile("appsettings.json")
				.AddUserSecrets("9462ec6c-6f3b-4e8b-bdd5-d9288223733b")
				.Build();
			_discord = new DiscordWrapper(
				_config["Token"], Convert.FromBase64String(_config["PublicKey"]));
		}

		[TestMethod]
		public void GetAuditLog()
		{
			IAuditLog auditLog = _discord.GetGuildAuditLog(549020785436655647).Result;
			Assert.IsInstanceOfType(auditLog, typeof(AuditLog));
		}
	}
}