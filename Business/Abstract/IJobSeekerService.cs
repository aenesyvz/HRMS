using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobSeekerService
    {
        IResult Add(JobSeeker jobSeeker);
        IResult Delete(JobSeeker jobSeeker);
        IResult Update(JobSeeker jobSeeker);
        IDataResult<JobSeeker> GetById(int id);
        IDataResult<List<JobSeeker>> GetAll();
        IDataResult<JobSeekerDto> GetByIdDto(int id);
    }
}
