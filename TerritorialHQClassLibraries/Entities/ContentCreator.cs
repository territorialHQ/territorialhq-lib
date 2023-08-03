using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.DTO;

namespace TerritorialHQ_Library.Entities
{
    public class ContentCreator : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Creator { get; set; }
        public string? Name { get; set; }
        public string? LogoFile { get; set; }
        public string? BannerFile { get; set; }
        public string? ChannelLink { get; set; }

        public IDto GetDto()
        {
            var dto = new DTOContentCreator
            {
                Id = this.Id,
                Name = this.Name,
                Creator = this.Creator,
                Timestamp = this.Timestamp,
                LogoFile = this.LogoFile,
                BannerFile = this.BannerFile,
                ChannelLink = this.ChannelLink
            };

            return dto;
        }

        public void MapDto(IDto dto)
        {
            var creator = (DTOContentCreator)dto;

            this.Id = creator.Id;
            this.Creator = creator.Creator;
            this.Timestamp = creator.Timestamp;
            this.Name = creator.Name;
            this.LogoFile = creator.LogoFile;
            this.BannerFile = creator.BannerFile;
            this.ChannelLink = creator.ChannelLink;
        }
    }
}
