using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOTokenClient : IDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? ReturnUrl { get; set; }

    }
}
