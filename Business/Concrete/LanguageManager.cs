using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class LanguageManager : ILanguageService
    {
        private readonly ILanguageDal _languageDal;
        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }
        public IResult Add(Language language)
        {
            _languageDal.Add(language);
            return new SuccessResult(Messages.AddedLanguage);
        }

        public IResult Delete(Language language)
        {
            _languageDal.Delete(language);
            return new SuccessResult(Messages.DeletedLanguage);
        }

        public IDataResult<List<Language>> GetAll(int jobSeekerId)
        {
            return new SuccessDataResult<List<Language>>(_languageDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<Language> GetById(int id)
        {
            return new SuccessDataResult<Language>(_languageDal.Get(x => x.Id == id));
        }

        public IResult Update(Language language)
        {
            _languageDal.Update(language);
            return new SuccessResult(Messages.UpdatedLanguage);
        }
    }
}
