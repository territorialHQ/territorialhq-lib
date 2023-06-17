using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities;

public class NavigationEntry : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }

    public string? Name { get; set; }
    public string? Slug { get; set; }
    public bool Public { get; set; }

    public string? ParentId { get; set; }
    [JsonIgnore]
    public virtual NavigationEntry? Parent { get; set; }
    public short Order { get; set; }

    public string? ContentPageId { get; set; }
    [JsonIgnore]
    public virtual ContentPage? ContentPage { get; set; }
    public string? ContentPageDisplayName => ContentPage?.DisplayName ?? string.Empty;

    public string? ExternalUrl { get; set; }

    [JsonIgnore]
    [InverseProperty("Parent")]
    public virtual List<NavigationEntry>? SubEntries { get; set; }

    public IDto GetDto()
    {
        var dto = new DTONavigationEntry();

        dto.Id = this.Id;
        dto.Name = this.Name;
        dto.Slug = this.Slug;
        dto.Public = this.Public;
        dto.ParentId = this.ParentId;
        dto.Order = this.Order;
        dto.ContentPageId = this.ContentPageId;
        dto.ContentPageDisplayName = this.ContentPageDisplayName;
        dto.ExternalUrl = this.ExternalUrl;

        dto.SubEntries = this.SubEntries?.Select(s => (DTONavigationEntry)s.GetDto()).ToList();

        return dto;
    }

    public void MapDto(IDto dto)
    {
        var entry = (DTONavigationEntry)dto;

        this.Name = entry.Name;
        this.Slug = entry.Slug;
        this.Public = entry.Public;
        this.ParentId = entry.ParentId;
        this.Order = entry.Order;
        this.ContentPageId = entry.ContentPageId;
        this.ExternalUrl = entry.ExternalUrl;
    }
}
