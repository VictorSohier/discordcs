using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Discordcs.Core.Interfaces;
using Discordcs.Core.Models;
using Discordcs.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Discordcs.Test
{
	[TestClass]
    public class ChannelTest
    {
		private IDiscordWrapper _discord { get; set; }
		private IConfiguration _config { get; }
		private ulong _guildId { get; }
		private ulong _channelId { get; }
		private JsonSerializerSettings settings = new JsonSerializerSettings();
		private string _testTopicText { get; }
		private IChannel _initialChannel { get; set; }
		private Stopwatch _watch { get; } = new();
		public ChannelTest()
		{
			_config = new ConfigurationBuilder()
				.SetBasePath($"{Directory.GetCurrentDirectory()}/../../..")
				.AddJsonFile("appsettings.json")
				.AddUserSecrets("9462ec6c-6f3b-4e8b-bdd5-d9288223733b")
				.Build();
			_guildId = ulong.Parse(_config["GuildId"]);
			_channelId = ulong.Parse(_config["ChannelId"]);
			_discord = new DiscordWrapper(
				_config["Token"], Convert.FromBase64String(_config["PublicKey"]));
			_testTopicText = _config["ChannelTestTopic"];
			settings.Formatting = Formatting.Indented;
		}

		[TestInitialize]
		public async Task ChannelInit()
		{
			_initialChannel = await _discord.GetChannel(_channelId);
		}

		[TestMethod]
		public async Task GetChannel()
		{
			_watch.Start();
			IChannel channel = await _discord.GetChannel(_channelId);
			_watch.Stop();
			Console.WriteLine($"{_watch.ElapsedMilliseconds}ms");
			//Console.WriteLine(JsonConvert.SerializeObject(channel, settings));
			Assert.IsInstanceOfType(channel, typeof(Channel));
			Assert.AreEqual("general", channel.Name);
		}

		[TestMethod]
		public async Task ModifyChannel()
		{
			IChannelParams parameters = new GuildChannelParams(
				_initialChannel.Name,
				_initialChannel.Type
			)
			{
				Topic = _testTopicText
			};
			_watch.Start();
			IChannel c1 = await _discord.ModifyChannel(_channelId, parameters);
			_watch.Stop();
			Console.WriteLine($"{_watch.ElapsedMilliseconds}ms");
			_watch.Start();
			IChannel c2 = await _discord.GetChannel(_channelId);
			_watch.Stop();
			Console.WriteLine($"{_watch.ElapsedMilliseconds}ms");

			Assert.AreNotEqual(_initialChannel.Topic, c2.Topic);
			Assert.AreEqual(_testTopicText, c2.Topic);
			
			parameters = new GuildChannelParams(
				_initialChannel.Name,
				_initialChannel.Type
			)
			{
				Topic = _initialChannel.Topic ?? ""
			};
			await _discord.ModifyChannel(_channelId, parameters);
		}

		[TestMethod]
		public async Task GetMessages()
		{
			Message[] messages = await _discord.GetChannelMessages(_channelId);

			Assert.AreEqual(true, messages.Length > 0);
		}

		[TestMethod]
		public async Task Get83Messages()
		{
			Message[] messages = await _discord.GetChannelMessages(_channelId, limit: 83);

			Assert.AreEqual(messages.Length, 83);
		}
    }
}