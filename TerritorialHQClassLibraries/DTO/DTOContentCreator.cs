using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.DTO
{
    public class DTOContentCreator : IDto
    {
        public string? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Creator { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Logo File")]
        public string? LogoFile { get; set; }
        [Display(Name = "Banner File")]
        public string? BannerFile { get; set; }
        [Display(Name = "Channel Link")]
        public string? ChannelLink { get; set; }
    }
}
