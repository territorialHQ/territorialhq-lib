using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOClanRelation : IDto
    {
        public string? Id { get; set; }
        public string? ClanName { get; set; }
        public string? ClanLogo { get; set; }
        public string? ClanId { get; set; }
        public string? TargetClanId { get; set; }
        public string? TargetClanName { get; set; }
        public string? TargetClanLogo { get; set; }
        public bool? TargetClanPublished { get; set; }
        public DiplomaticRelationType DiplomaticRelation { get; set; }
        public HierachicalRelationType HierachicalRelation { get; set; }
        public MilitaryRelationType MilitaryRelation { get; set; }
    }
}
