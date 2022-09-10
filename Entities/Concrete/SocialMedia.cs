using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class SocialMedia : IEntity {
        [Key]
        public int Id { get; set; }
        public int Type { get; set; }
        public string Link { get; set; }
        public int JobSeekerId { get; set; }
    }
}
