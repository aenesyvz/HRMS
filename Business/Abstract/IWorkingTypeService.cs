using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IWorkingTypeService
    {
        IResult Add(WorkingType workingType);
        IResult Delete(WorkingType workingType);
        IResult Update(WorkingType workingType);
        IDataResult<List<WorkingType>> GetAll();
        IDataResult<WorkingType> GetById(int id);
    }
}
