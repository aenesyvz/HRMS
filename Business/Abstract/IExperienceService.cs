using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IExperienceService
    {
        IResult Add(Experience experience);
        IResult Delete(Experience experience);
        IResult Update(Experience experience);
        IDataResult<Experience> GetById(int id);
        IDataResult<List<Experience>> GetAll(int jobSeekerId);
    }
}
