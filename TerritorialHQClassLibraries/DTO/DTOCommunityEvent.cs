using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.DTO
{
    public class DTOCommunityEvent : IDto
    {
        public string? Id { get; set; }
        public string? Creator { get; set; }

        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
        [Display(Name = "In Review")]
        public bool InReview { get; set; }

        [Display(Name = "Title")]
        public string? Title { get; set; }
        [Display(Name = "Event Description")]
        public string? Description { get; set; }

        [Display(Name = "Start (UTC)")]
        public DateTime? Start { get; set; }
        [Display(Name = "End (UTC)")]
        public DateTime? End { get; set; }
        [Display(Name = "Recurring Event")]
        public bool Recurring { get; set; }
        [Display(Name = "Interval (every X days)")]
        public int? Interval { get; set; }

        [Display(Name = "Event location (server / channel)")]
        public string? Location { get; set; }
        [Display(Name = "Discord server invite link")]
        public string? DiscordServerLink { get; set; }
        [Display(Name = "Host")]
        public string? Host { get; set; }
        [Display(Name = "Image file")]
        public string? ImageFile { get; set; }
    }
}
