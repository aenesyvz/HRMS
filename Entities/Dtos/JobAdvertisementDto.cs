using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class JobAdvertisementDto : IDto
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public List<City> Cities { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public int NumberOfPosition { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public int JobPositionId { get; set; }
        public string JobPositionName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsConfirm { get; set; }
        public int WorkingTypeId { get; set; }
        public string WorkingTypeName { get; set; }
        public int WorkingTimeId { get; set; }
        public string WorkingTimeName { get; set; }
        public List<ProgramingLanguage> ProgramingLanguages { get; set; }
        public List<Language> Languages { get; set; }
    }
}
