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

    [JsonIgnore]
    public virtual List<NavigationEntry>? NavigationEntries { get; set; }

    public IDto GetDto()
    {
        var dto = new DTOContentPage();

        dto.Id = this.Id;
        dto.DisplayName = this.DisplayName;
        dto.Content = this.Content;
        dto.SidebarContent = this.SidebarContent;
        dto.BannerImage = this.BannerImage;

        return dto;
    }

    public void MapDto(IDto dto)
    {
        var page = (DTOContentPage)dto;

        this.DisplayName = page.DisplayName;
        this.Content = page.Content;
        this.SidebarContent = page.SidebarContent;
        this.BannerImage = page.BannerImage;    
    }
}
