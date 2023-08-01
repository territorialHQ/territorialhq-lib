using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerritorialHQ_Library.API.Reponses;

public class DiscordInfoResponse
{
    public ulong Id { get; set; }
    public string? Username { get; set; }
    public string? Avatar { get; set; }
    public string? AvatarUrl { get; set; }
    public bool? MfaEnabled { get; set; }
}
