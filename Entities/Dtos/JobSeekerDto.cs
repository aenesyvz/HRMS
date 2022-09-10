using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Entities.Dtos
{
    public class JobSeekerDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime BirthOfDate { get; set; }
        public List<ProgramingLanguage> ProgramingLanguages { get; set; }
        public List<Language> Languages { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<School> Schools { get; set; }
        public string LetterDescription  { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
