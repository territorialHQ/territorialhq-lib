using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.DTO;

namespace TerritorialHQ_Library.Entities;

public class JournalArticle : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }


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

    public IDto GetDto()
    {
        var dto = new DTOJournalArticle();

        dto.Id = this.Id;
        dto.Author = this.Creator;
        dto.Title = this.Title;
        dto.Subtitle = this.Subtitle;
        dto.PublishFrom = this.PublishFrom;
        dto.PublishTo = this.PublishTo;
        dto.Teaser = this.Teaser;
        dto.Body = this.Body;
        dto.Image = this.Image;
        dto.Tags = this.Tags;
        dto.IsSticky = this.IsSticky;

        return dto;
    }

    public void MapDto(IDto dto)
    {
        var article = (DTOJournalArticle)dto;

        this.Title = article.Title;
        this.Subtitle = article.Subtitle;
        this.PublishFrom = article.PublishFrom;
        this.PublishTo = article.PublishTo;
        this.Teaser = article.Teaser;
        this.Body = article.Body;
        this.Image = article.Image;
        this.Tags = article.Tags;
        this.IsSticky = article.IsSticky;
    }

    public DTOJournalArticleListEntry GetDtoListEntry()
    {
        var dto = new DTOJournalArticleListEntry
        {
            Id = this.Id,
            Author = this.Creator,
            Title = this.Title,
            Subtitle = this.Subtitle,
            PublishFrom = this.PublishFrom,
            IsPublished = (DateTime.Now >= this.PublishFrom) && (PublishTo == null ? true : DateTime.Now <= this.PublishTo),
            Teaser = this.Teaser,
            Image = this.Image,
            IsSticky = this.IsSticky
        };

        return dto;
    }
}
