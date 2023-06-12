using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TerritorialHQ_Library.Entities;

public class ContentPage : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }

    public string? DisplayName { get; set; }
    public string? Content { get; set; }
    public string? SidebarContent { get; set; }

    public string? BannerImage { get; set; }

    [JsonIgnore]
    public virtual List<NavigationEntry>? NavigationEntries { get; set; }
}
