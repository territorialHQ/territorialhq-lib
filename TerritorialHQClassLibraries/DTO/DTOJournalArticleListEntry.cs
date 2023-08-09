using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.DTO
{
    public class DTOJournalArticleListEntry : IDto
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Subtitle { get; set; }
        public DateTime PublishFrom { get; set; }
        public bool IsPublished { get; set; }
        public bool IsCleared { get; set; }
        public string? Teaser { get; set; }
        public string? Image { get; set; }
        public bool IsSticky { get; set; }
    }
}
