using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOContentPage : IDto
    {
        public string? Id { get; set; }
        public string? DisplayName { get; set; }
        public string? Content { get; set; }
        public string? SidebarContent { get; set; }
        public string? BannerImage { get; set; }

    }
}
