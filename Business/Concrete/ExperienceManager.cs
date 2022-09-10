using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public IResult Add(Experience experience)
        {
            //experience.JobSeekerId = jobSeekerId;
            _experienceDal.Add(experience);
            return new SuccessResult();
        }

        public IResult Delete(Experience experience)
        {
            //experience.JobSeekerId = jobSeekerId;
            _experienceDal.Delete(experience);
            return new SuccessResult();
        }

        public IDataResult<List<Experience>> GetAll(int jobSeekerId)
        {
            return new SuccessDataResult<List<Experience>>(_experienceDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<Experience> GetById(int id)
        {
            return new SuccessDataResult<Experience>(_experienceDal.Get(x => x.Id == id));
        }

        public IResult Update(Experience experience)
        {
            //experience.JobSeekerId = jobSeekerId;
            _experienceDal.Update(experience);
            return new SuccessResult();
        }
    }
}
