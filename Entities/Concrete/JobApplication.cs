using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class JobApplication : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public int EmployerId { get; set; }
        public int JobAdvertisementId { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsConfirm { get; set; }
    }
}
