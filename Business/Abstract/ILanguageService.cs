using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILanguageService
    {
        IResult Add(Language language);
        IResult Delete(Language language);
        IResult Update(Language language);
        IDataResult<Language> GetById(int id);
        IDataResult<List<Language>> GetAll(int jobSeekerId);
    }
}
