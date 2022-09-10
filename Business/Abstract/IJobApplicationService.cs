using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobApplicationService
    {
        IResult Add(JobApplication jobApplication);
        IResult Delete(JobApplication jobApplication);
        IResult Update(JobApplication jobApplication);
        IDataResult<List<JobApplication>> GetAllByJobAdvertisement(int jobAdvertisementId);
        IDataResult<List<JobApplication>> GetAllByJobSeeker(int jobSeekerId);
        IDataResult<JobApplication> GetById(int id);
    }
}
