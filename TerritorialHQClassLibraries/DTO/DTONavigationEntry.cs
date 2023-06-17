using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TerritorialHQ_Library.DTO.Interface;
using TerritorialHQ_Library.Entities;

namespace TerritorialHQ_Library.DTO
{
    public class DTONavigationEntry : IDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public bool Public { get; set; }
        public string? ParentId { get; set; }
        public short Order { get; set; }
        public string? ContentPageId { get; set; }
        public string? ContentPageDisplayName { get; set; } 
        public string? ExternalUrl { get; set; }

        public List<DTONavigationEntry>? SubEntries { get; set; }

    }
}
