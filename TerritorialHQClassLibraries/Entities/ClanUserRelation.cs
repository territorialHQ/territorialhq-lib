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

public class ClanUserRelation : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }

    public string? ClanId { get; set; }
    [JsonIgnore]
    public virtual Clan? Clan { get; set; }

    public string? AppUserId { get; set; }
    [JsonIgnore]
    public virtual AppUser? AppUser { get; set; }

    public IDto GetDto()
    {
        var dto = new DTOClanUserRelation();

        dto.Id = this.Id;
        dto.ClanId = this.ClanId;
        dto.AppUserId = this.AppUserId;
        dto.AppUserName = this.AppUser?.UserName;

        return dto;
    }

    public void MapDto(IDto dto) { }
}
