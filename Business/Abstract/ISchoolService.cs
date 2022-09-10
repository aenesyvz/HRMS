using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISchoolService
    {
        IResult Add(School school);
        IResult Delete(School school);
        IResult Update(School school);
        IDataResult<List<School>> GetAll(int jobSeekerId);
        IDataResult<School> GetById(int id);
    }
}
