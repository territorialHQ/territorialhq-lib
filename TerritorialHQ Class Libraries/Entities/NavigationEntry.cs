using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TerritorialHQ_Library.Entities;

public  class NavigationEntry : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }

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
}
