using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities
{
    public class CommunityEvent : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Creator { get; set; }

        public bool IsPublished { get; set; }
        public bool InReview { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }

        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool Recurring { get; set; }
        public int? Interval { get; set; }

        public string? Location { get; set; }
        public string? DiscordServerLink { get; set; }
        public string? Host { get; set; }
        public string? ImageFile { get; set; }

        public IDto GetDto()
        {
            return new DTOCommunityEvent()
            {
                Id = Id,
                Creator = Creator,
                Title = Title,
                Description = Description,
                Start = Start,
                End = End,
                Recurring = Recurring,
                Interval = Interval,
                Location = Location,
                DiscordServerLink = DiscordServerLink,
                Host = Host,
                ImageFile = ImageFile,
                IsPublished = IsPublished,
                InReview = InReview
            };
        }

        public void MapDto(IDto dto)
        {
            var evt = (DTOCommunityEvent)dto;

            this.Title = evt.Title;
            this.Description = evt.Description;
            this.Start = evt.Start;
            this.End = evt.End;
            this.Recurring = evt.Recurring;
            this.Interval = evt.Interval;
            this.Location = evt.Location;
            this.DiscordServerLink = evt.DiscordServerLink;
            this.Host = evt.Host;
            this.ImageFile = evt.ImageFile; 
            this.IsPublished = evt.IsPublished;
            this. InReview = evt.InReview;
        }
    }
}
