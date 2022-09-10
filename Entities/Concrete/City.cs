using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
