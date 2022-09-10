using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Experience : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public int EmployerId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public bool IsContinue { get; set; }
    }
}
