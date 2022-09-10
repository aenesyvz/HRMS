using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class JobSeeker : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime BirthOfDate { get; set; }
        public List<ProgramingLanguage> ProgramingLanguages { get; set; }
        public List<Language> Languages { get; set; }

    }
}
