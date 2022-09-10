using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        IResult Add(Employer employer);
        IResult Update(Employer employer);
        IResult Delete(Employer employer);
        IDataResult<Employer> GetById(int id);
        IDataResult<List<Employer>> GetAll();
    }


}
