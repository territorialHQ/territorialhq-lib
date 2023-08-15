using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TerritorialHQ_Library.Entities;

public enum AppUserRole
{
    [Display(Name = "Administrator")]
    Administrator = 1,
    [Display(Name = "Clan Staff Member")]
    Staff = 2,
    [Display(Name = "Journalist")]
    Journalist = 3,
    [Display(Name = "Moderator")]
    Moderator = 4,
    [Display(Name = "Editor")]
    Editor = 5,
    [Display(Name = "Writer")]
    Writer = 6
}
