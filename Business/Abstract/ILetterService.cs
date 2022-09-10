using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILetterService
    {
        IResult Add(Letter letter);
        IResult Delete(Letter letter);
        IResult Update(Letter letter);
        IDataResult<List<Letter>> GetAll(int jobSeekerId);
        IDataResult<Letter> GetById(int id);
    }
}
