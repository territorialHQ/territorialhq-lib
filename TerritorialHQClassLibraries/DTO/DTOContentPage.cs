using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOContentPage : IDto
    {
        public string? Id { get; set; }
        [Display(Name = "Display Name (internal)")]
        public string? DisplayName { get; set; }
        [Display(Name = "Content")]
        public string? Content { get; set; }
        [Display(Name = "Sidebar Content")]
        public string? SidebarContent { get; set; }
        [Display(Name = "Banner image")]
        public string? BannerImage { get; set; }
        [Display(Name = "Published")]
        public bool IsPublished { get; set; }
        [Display(Name = "In Review")]
        public bool InReview { get; set; }

        public List<DTOContentPageUserRelation> AssignedAppUsers { get; set; } = new();
    }
}
