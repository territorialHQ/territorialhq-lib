using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TerritorialHQ_Library.Entities;

public class ClanUserRelation : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }

    public string? ClanId { get; set; }
    [JsonIgnore]
    public virtual Clan? Clan { get; set; }

    public string? AppUserId { get; set; }
    public virtual AppUser? AppUser { get; set; }
}
