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
    public class DTOAppUser : IDto
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public ulong DiscordId { get; set; }
        public bool Public { get; set; }
        public AppUserRole? Role { get; set; }
    }
}
