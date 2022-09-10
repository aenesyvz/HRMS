using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class LetterManager : ILetterService
    {
        private readonly ILetterDal _letterDal;
        public LetterManager(ILetterDal letterDal)
        {
            _letterDal = letterDal;
        }
        public IResult Add(Letter letter)
        {
            _letterDal.Add(letter);
            return new SuccessResult(Messages.AddedLetter);
        }

        public IResult Delete(Letter letter)
        {
            _letterDal.Delete(letter);
            return new SuccessResult(Messages.DeletedLetter);
        }

        public IDataResult<List<Letter>> GetAll(int jobSeekerId)
        {
            return new SuccessDataResult<List<Letter>>(_letterDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<Letter> GetById(int id)
        {
            return new SuccessDataResult<Letter>(_letterDal.Get(x => x.Id == id));
        }

        public IResult Update(Letter letter)
        {
            _letterDal.Update(letter);
            return new SuccessResult(Messages.UpdatedLetter);
        }
    }
}
