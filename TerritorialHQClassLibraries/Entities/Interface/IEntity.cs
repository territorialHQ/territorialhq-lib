using System.ComponentModel.DataAnnotations.Schema;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities
{
    public interface IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        string? Id { get; set; }
        DateTime Timestamp { get; set; }
        string? Creator { get; set; }

        void MapDto(IDto dto);
        IDto GetDto();
    }
}
