using Core.Entities;
using System;

namespace Entities.Dtos
{
    public class ExperienceDto : IDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public string Status { get; set; }
    }
}
