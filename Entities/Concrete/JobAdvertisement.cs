using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class JobAdvertisement : IEntity
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public List<City> Cities { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public int NumberOfPosition { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public int JobPositionId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsConfirm { get; set; }
        public int WorkingTypeId { get; set; }
        public int WorkingTimeId { get; set; }
        public List<ProgramingLanguage> ProgramingLanguages { get; set; }
        public List<Language> Languages { get; set; }
    }
}
