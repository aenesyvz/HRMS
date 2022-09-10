using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Letter : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public string LetterExplain { get; set; }
    }
}
