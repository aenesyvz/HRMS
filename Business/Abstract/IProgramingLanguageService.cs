using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProgramingLanguageService
    {
        IResult Add(ProgramingLanguage programingLanguage);
        IResult Delete(ProgramingLanguage programingLanguage);
        IResult Update(ProgramingLanguage programingLanguage);
        IDataResult<List<ProgramingLanguage>> GetAll(int jobSeekerId);
        IDataResult<ProgramingLanguage> GetById(int id);
    }
}
