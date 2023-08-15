using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities;

public class ContentPage : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp{ get; set; }
    public string? Creator { get; set; }
    public string? DisplayName { get; set; }
    public string? Content { get; set; }
    public string? SidebarContent { get; set; }
    public string? BannerImage { get; set; }
    public bool IsPublished { get; set; }
    public bool InReview { get; set; }

    [JsonIgnore]
    public virtual List<ContentPageUserRelation> ContentPageUserRelations { get; set; }

    [JsonIgnore]
    public virtual List<NavigationEntry>? NavigationEntries { get; set; }

    public IDto GetDto()
    {
        var dto = new DTOContentPage
        {
            Id = this.Id,
            DisplayName = this.DisplayName,
            Content = this.Content,
            SidebarContent = this.SidebarContent,
            BannerImage = this.BannerImage,
            IsPublished = this.IsPublished,
            InReview = this.InReview,

            AssignedAppUsers = this.ContentPageUserRelations?.Select(r => new DTOContentPageUserRelation()
            {
                Id = r.AppUser!.Id,
                AppUserId = r.AppUser!.Id,
                AppDiscordId = r.AppUser!.DiscordId,
                AppUserName = r.AppUser!.UserName
            })?.ToList() ?? new(),
        };

        return dto;
    }

    public void MapDto(IDto dto)
    {
        var page = (DTOContentPage)dto;

        this.DisplayName = page.DisplayName;
        this.Content = page.Content;
        this.SidebarContent = page.SidebarContent;
        this.BannerImage = page.BannerImage;  
        this.IsPublished = page.IsPublished;
        this.InReview = page.InReview;
    }
}
