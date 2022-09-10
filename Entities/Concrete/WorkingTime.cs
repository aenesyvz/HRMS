using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class WorkingTime : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string DescriptionOfTime { get; set; }
    }
}
