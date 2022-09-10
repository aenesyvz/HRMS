using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq;
namespace DataAccess.Concrete
{
    public class EfJobSeekerDal : EfEntityRepostiryBase<JobSeeker, ContextDB>, IJobSeekerDal
    {
        public JobSeekerDto GetByIdDto(int id)
        {
            using (var context = new ContextDB())
            {
                var result = from js in context.JobSeekers.Where(x => x.Id == id)
                             join lttr in context.Letters on js.Id equals lttr.JobSeekerId
                             select new JobSeekerDto
                             {
                                 Id = js.Id,
                                 BirthOfDate = js.BirthOfDate,
                                 FirstName = js.FirstName,
                                 LastName = js.LastName,
                                 NationalId = js.NationalId,
                                 LetterDescription = lttr.LetterExplain,
                                 Schools = context.Schools.Where(x=>x.JobSeekerId == id).ToList(),
                                 Experiences = context.Experiences.Where(x=>x.JobSeekerId == id).ToList(),
                                 Languages = context.Languages.Where(x=>x.JobSeekerId == id).ToList(),
                                 ProgramingLanguages = context.ProgramingLanguages.Where(x=>x.JobSeekerId == id).ToList(),
                                 SocialMedias = context.SocialMedias.Where(x=>x.JobSeekerId == id).ToList(),
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
