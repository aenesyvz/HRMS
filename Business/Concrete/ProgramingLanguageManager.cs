using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProgramingLanguageManager : IProgramingLanguageService
    {
        private readonly IProgramingLanguageDal _programingLanguageDal;
        public ProgramingLanguageManager(IProgramingLanguageDal programingLanguageDal)
        {
            _programingLanguageDal = programingLanguageDal;
        }
        public IResult Add(ProgramingLanguage programingLanguage)
        {
            _programingLanguageDal.Add(programingLanguage);
            return new SuccessResult(Messages.AddedProgramingLanguage);
        }

        public IResult Delete(ProgramingLanguage programingLanguage)
        {
            _programingLanguageDal.Delete(programingLanguage);
            return new SuccessResult(Messages.DeletedProgramingLanguage);
        }

        public IDataResult<List<ProgramingLanguage>> GetAll(int jobSeekerId)
        {
            return new SuccessDataResult<List<ProgramingLanguage>>(_programingLanguageDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<ProgramingLanguage> GetById(int id)
        {
            return new SuccessDataResult<ProgramingLanguage>(_programingLanguageDal.Get(x => x.Id == id));
        }

        public IResult Update(ProgramingLanguage programingLanguage)
        {
            _programingLanguageDal.Update(programingLanguage);
            return new SuccessResult(Messages.UpdatedProgramingLanguage);
        }
    }
}
