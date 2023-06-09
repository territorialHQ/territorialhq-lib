using System.ComponentModel.DataAnnotations.Schema;

namespace TerritorialHQ_Library.Entities
{
    public interface IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        string Id { get; set; }
    }
}
