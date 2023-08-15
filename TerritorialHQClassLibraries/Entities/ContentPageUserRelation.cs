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

public class ContentPageUserRelation : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }

    public string? ContentPageId { get; set; }
    [JsonIgnore]
    public virtual ContentPage? ContentPage { get; set; }

    public string? AppUserId { get; set; }
    [JsonIgnore]
    public virtual AppUser? AppUser { get; set; }

    public IDto GetDto()
    {
        var dto = new DTOContentPageUserRelation();

        dto.Id = this.Id;
        dto.ContentPageId = this.ContentPageId;
        dto.AppUserId = this.AppUserId;
        dto.AppDiscordId = this.AppUser?.DiscordId;
        dto.AppUserName = this.AppUser?.UserName;

        return dto;
    }

    public void MapDto(IDto dto) { 
        var relation = (DTOContentPageUserRelation)dto;

        this.Id = relation.Id;
        this.ContentPageId = relation.ContentPageId;
        this.AppUserId = relation.AppUserId;
    }
}
