
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities;

public class AppUserRoleRelation : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }

    [DisplayName("User")]
    public string? AppUserId { get; set; }
    [DisplayName("User")]
    public virtual AppUser AppUser { get; set; }
    

    [DisplayName("Role")]
    public AppUserRole? Role { get; set; }

    public void MapDto(IDto dto)
    {
        var relation = (DTOAppUserRoleRelation)dto;

        this.AppUserId = relation.AppUserId;
        this.Role = relation.Role;
    }

    public IDto GetDto()
    {
        var dto = new DTOAppUserRoleRelation();

        dto.Id = this.Id;
        dto.AppUserId = this.AppUserId;
        dto.Role = this.Role;
        return dto;
    }
}