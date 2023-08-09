using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOJournalArticle : IDto
    {
        public string? Id { get; set; }
        public string? Author { get; set; }

        [Display(Name = "Title / Headline")]
        public string? Title { get; set; }

        [Display(Name = "Subtitle / Subheadline")]
        public string? Subtitle { get; set; }

        [Display(Name = "Publish from")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime PublishFrom { get; set; }

        [Display(Name = "Publish until")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? PublishTo { get; set; }

        public bool IsPublished => (DateTime.Now >= PublishFrom) && (PublishTo == null ? true : DateTime.Now <= PublishTo);

        [Display(Name = "Cleared for publish")]
        public bool IsCleared { get; set; }

        [Display(Name = "Teaser text")]
        public string? Teaser { get; set; }

        [Display(Name = "Content")]
        public string? Body { get; set; }

        [Display(Name = "Image")]
        public string? Image { get; set; }

        [Display(Name = "Tags (Comma separated)")]
        public string? Tags { get; set; }

        [Display(Name = "Sticky (keep on top)")]
        public bool IsSticky { get; set; }

    }
}
