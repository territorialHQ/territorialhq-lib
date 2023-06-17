using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities
{
    public class TokenClient : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Creator { get; set; }
        public string? Name { get; set; }
        public string? ReturnUrl { get; set; }

        public IDto GetDto()
        {
            var dto = new DTOTokenClient();

            dto.Id = this.Id;
            dto.Name = this.Name;   
            dto.ReturnUrl = this.ReturnUrl;

            return dto;
        }

        public void MapDto(IDto dto)
        {
            var tokenClient = (DTOTokenClient)dto;

            this.Id = tokenClient.Id;
            this.Name = tokenClient.Name;
            this.ReturnUrl = tokenClient.ReturnUrl;
        }
    }
}
