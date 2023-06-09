using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerritorialHQ_Library.Entities;

public class AppUser : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }

    [DisplayName("Created")]
    public DateTime Created { get; set; }

    [DisplayName("Username")]
    public string UserName { get; set; }

    [DisplayName("Discord ID")]
    public ulong DiscordId { get; set; }

    [DisplayName("Role")]
    public AppUserRole? Role { get; set; }
}
