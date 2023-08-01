using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.DTO
{
    public class DTOClanListEntry : IDto
    {
        public string? Id { get; set; }
        public bool IsPublished { get; set; }
        public bool InReview { get; set; }
        public string? Name { get; set; }
        public string? Motto { get; set; }
        public string? Color1 { get; set; }
        public string? Color2 { get; set; }
        public string? Tag { get; set; }
        public string? DiscordLink { get; set; }
        public int? Position { get; set; }
        public float? Points { get; set; } 
        public string? LogoFile { get; set; }
        
    }
}
