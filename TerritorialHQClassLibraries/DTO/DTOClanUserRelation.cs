using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOClanUserRelation : IDto
    {
        public string? Id { get; set; }
        public string? ClanId { get; set; }
        public string? AppUserId { get; set; }
        public string? AppUserName { get; set; }

    }
}
