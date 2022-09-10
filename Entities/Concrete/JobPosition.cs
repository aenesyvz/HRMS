using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class JobPosition  : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string PositionName { get; set; }
    }
}
