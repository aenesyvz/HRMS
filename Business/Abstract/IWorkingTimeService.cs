using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IWorkingTimeService
    {
        IResult Add(WorkingTime workingTime);
        IResult Delete(WorkingTime workingTime);
        IResult Update(WorkingTime workingTime);
        IDataResult<List<WorkingTime>> GetAll();
        IDataResult<WorkingTime> GetById(int id);
    }
}
