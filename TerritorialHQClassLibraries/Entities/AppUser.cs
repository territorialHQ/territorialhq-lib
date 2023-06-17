
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities;

public class AppUser : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }

    [DisplayName("Username")]
    public string? UserName { get; set; }

    [DisplayName("Discord ID")]
    public ulong DiscordId { get; set; }

    [DisplayName("Public Profile")]
    public bool Public { get; set; } = true;

    [DisplayName("Role")]
    public AppUserRole? Role { get; set; }

    public void MapDto(IDto dto)
    {
        var user = (DTOAppUser)dto;

        this.UserName = user.UserName;
        this.Role = user.Role;
        this.DiscordId = user.DiscordId;
    }
    public IDto GetDto()
    {

        var dto = new DTOAppUser();

        dto.Id = this.Id;
        dto.UserName = this.UserName;
        dto.DiscordId = this.DiscordId;
        dto.Role = this.Role;

        return dto;

    }
}