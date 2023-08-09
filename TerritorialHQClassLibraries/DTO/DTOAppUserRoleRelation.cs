using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTOAppUserRoleRelation : IDto
    {
        public string? Id { get; set; }
        public string? AppUserId { get; set; }
        public AppUserRole? Role { get; set; }
    }
}
