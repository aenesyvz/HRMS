using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobPositionService
    {
        IResult Add(JobPosition jobPosition);
        IResult Delete(JobPosition jobPosition);
        IResult Update(JobPosition jobPosition);
        IDataResult<List<JobPosition>> GetAll();
        IDataResult<JobPosition> GetById(int id);
    }
}
