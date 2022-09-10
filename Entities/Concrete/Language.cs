using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Language : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public string LanguageName { get; set; }
        public int Level { get; set; }
    }
}
