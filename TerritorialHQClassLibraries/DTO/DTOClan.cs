using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOClan : IDto
    {
        public string? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Creator { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Discord Guild ID")]
        public ulong? GuildId { get; set; }
        [Display(Name = "Date / Period of Foundation")]
        public string? Foundation { get; set; }
        [Display(Name = "Founder(s)")]
        public string? Founders { get; set; }
        [Display(Name = "Clan Motto")]
        public string? Motto { get; set; }
        [Display(Name = "Custom Bot HttpGet Endpoint")]
        public string? BotEndpoint { get; set; }
        [Display(Name = "Logo file")]
        public string? LogoFile { get; set; }
        [Display(Name = "Banner file")]
        public string? BannerFile { get; set; }
        [Display(Name = "Discord server link")]
        public string? DiscordLink { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
        [Display(Name = "In Review")]
        public bool InReview { get; set; }

        public virtual List<DTOAppUser> AssignedAppUsers { get; set; } = new();


    }
}
