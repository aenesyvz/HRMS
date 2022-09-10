using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IResult ChangeStatusEmployer(Employer employer);
        IResult ChangeStatusJobAdvertisement(JobAdvertisement jobAdvertisement);
        IDataResult<List<Employer>> GetAllByPassiveEmployer();
        IDataResult<List<JobAdvertisement>> GetAllByPassiveJobAdvertisement();
        IResult Add(Staff staff);
        IResult Update(Staff staff);
    }
}
