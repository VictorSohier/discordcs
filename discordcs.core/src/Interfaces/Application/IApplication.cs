using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discordcs.Core.Enums;
using Discordcs.Core.Models;

namespace Discordcs.Core.Interfaces
{
    public interface IApplication
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string[] RPCOrigins { get; set; }
        public bool BotPublic { get; set; }
        public bool BotRequireCodeGrant { get; set; }
        public string TermsOfServiceUrl { get; set; }
        public string PrivacyPolicyUrl { get; set; }
        public User Owner { get; set; }
        public string Summary { get; set; }
        public string VerifyKey { get; set; }
        public Team Team { get; set; }
		public ulong? GuildId { get; set; }
		public ulong? PrimarySKUId { get; set; }
		public string Slug { get; set; }
		public string CoverImage { get; set; }
		public ApplicationFlagEnum[] Flags { get; set; }
    }
}