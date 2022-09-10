using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class School : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public string SchoolName { get; set; }
        public string Episode { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public bool IsGraduate { get; set; }
    }
}
