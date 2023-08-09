using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities
{
    public class ClanRelation : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Creator { get; set; }

        public string? ClanId { get; set; }
        [JsonIgnore]
        public virtual Clan? Clan { get; set; }

        public string? TargetClanId { get; set; }
        [JsonIgnore]
        public virtual Clan? TargetClan { get; set; }


        public DiplomaticRelationType DiplomaticRelation { get; set; }
        public HierachicalRelationType HierachicalRelation { get; set; }
        public MilitaryRelationType MilitaryRelation { get; set; }

        public IDto GetDto()
        {
            return new DTOClanRelation()
            {
                ClanId = ClanId,
                ClanName = Clan?.Tag,
                ClanLogo = Clan?.LogoFile,
                TargetClanId = TargetClanId,
                TargetClanName = TargetClan?.Tag,
                TargetClanLogo = TargetClan?.LogoFile,
                TargetClanPublished = TargetClan?.IsPublished,
                DiplomaticRelation = DiplomaticRelation,
                HierachicalRelation = HierachicalRelation,
                MilitaryRelation = MilitaryRelation
            };
        }

        public void MapDto(IDto dto)
        {
            var clanRelation = (DTOClanRelation)dto;

            this.Id = clanRelation.Id;
            this.ClanId = clanRelation.ClanId;
            this.TargetClanId = clanRelation.TargetClanId;
            this.DiplomaticRelation = clanRelation.DiplomaticRelation;
            this.HierachicalRelation = clanRelation.HierachicalRelation;
            this.MilitaryRelation = clanRelation.MilitaryRelation;
        }
    }
}
