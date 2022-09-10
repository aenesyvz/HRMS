using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HRMS;Integrated Security=true");
        }

        public DbSet<User> Users  { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobAdvertisement> JobAdvertisements { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Letter> Letters { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<WorkingTime> WorkingTimes { get; set; }
        public DbSet<WorkingType> WorkingTypes { get; set; }
        public DbSet<ProgramingLanguage> ProgramingLanguages { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
