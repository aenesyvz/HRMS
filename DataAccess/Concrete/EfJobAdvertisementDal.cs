using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfJobAdvertisementDal : EfEntityRepostiryBase<JobAdvertisement, ContextDB>, IJobAdvertisementDal
    {
        public JobAdvertisementDto GetByIdDto(int id)
        {
            using (var context = new ContextDB())
            {
                var result = from jobAdvert in context.JobAdvertisements.Where(x=>x.Id == id)
                             join emp in context.Employers on jobAdvert.EmployerId equals emp.Id
                             join jobPos in context.JobPositions on jobAdvert.JobPositionId equals jobPos.Id
                             join workTime in context.WorkingTimes on jobAdvert.WorkingTimeId equals workTime.Id
                             join workType in context.WorkingTypes on jobAdvert.WorkingTypeId equals workType.Id
                             select new JobAdvertisementDto
                             {
                                 Id = jobAdvert.Id,
                                 Description = jobAdvert.Description,
                                 FinishedDate = jobAdvert.FinishedDate,
                                 StartingDate = jobAdvert.StartingDate,
                                 IsActive = jobAdvert.IsActive,
                                 IsConfirm = jobAdvert.IsConfirm,
                                 JobPositionName = jobPos.PositionName,
                                 JobPositionId = jobPos.Id,
                                 NumberOfPosition = jobAdvert.NumberOfPosition,
                                 MinSalary = jobAdvert.MinSalary,
                                 MaxSalary = jobAdvert.MaxSalary,
                                 WorkingTimeId = workTime.Id,
                                 WorkingTimeName = workTime.DescriptionOfTime,
                                 WorkingTypeId = workType.Id,
                                 WorkingTypeName = workType.DescriptionOfType,
                                 EmployerId = emp.Id,
                                 EmployerName = emp.CompanyName,
                                 Cities = jobAdvert.Cities,
                                 Languages = jobAdvert.Languages,
                                 ProgramingLanguages = jobAdvert.ProgramingLanguages
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
