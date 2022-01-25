using Discordcs.Core.Enums;
using Discordcs.Core.Interfaces;
using Discordcs.Core.Models;
using Discordcs.Infrastructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics;

namespace Discordcs.test.auditLog
{
	[TestClass]
	public class AuditLogTest
	{
		string PublicKey = "m9D5tA7pn1MbCFaAsTnDsTQ3wx7fgiIO7rDy/kWq72A=";
		private IDiscordWrapper _discord { get; set; }

		public AuditLogTest()
		{
			_discord = new DiscordWrapper("OTMzODg1NzI5MjIwNzM1MDQ2.YeoC3A.Qi2Wo_c7g2r1S3omDhE1yeaB74Q", Convert.FromBase64String(PublicKey));
		}

		[TestMethod]
		public void GetAuditLog()
		{
			IAuditLog auditLog = _discord.GetGuildAuditLog(549020785436655647).Result;
			Assert.IsInstanceOfType(auditLog, typeof(AuditLog));
		}
	}
}