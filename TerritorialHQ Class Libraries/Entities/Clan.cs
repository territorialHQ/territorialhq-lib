using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace TerritorialHQ_Library.Entities;

public class Clan : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    [Display(Name = "Name")]
    public string? Name { get; set; }
    [Required]
    [Display(Name = "Discord Guild ID")]
    public ulong? GuildId { get; set; }
    [Display(Name = "Logo file")]
    public string? LogoFile { get; set; }
    [Display(Name = "Banner file")]
    public string? BannerFile { get; set; }
    [Display(Name = "Discord server link")]
    public string? DiscordLink { get; set; }
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Display(Name = "Published")]
    public bool IsPublished { get; set; }
    [Display(Name = "In Review")]
    public bool InReview { get; set; }

    [JsonIgnore]
    public virtual List<ClanUserRelation>? ClanUserRelations { get; set; }
}