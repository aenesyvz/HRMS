using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class WorkingType : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string DescriptionOfType { get; set; }
    }
}
