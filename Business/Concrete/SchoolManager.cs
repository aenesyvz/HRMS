using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SchoolManager : ISchoolService
    {
        private readonly ISchoolDal _schoolDal;
        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }
        public IResult Add(School school)
        {
            _schoolDal.Add(school);
            return new SuccessResult(Messages.AddedSchool);
        }

        public IResult Delete(School school)
        {
            _schoolDal.Delete(school);
            return new SuccessResult(Messages.DeletedSchool);
        }

        public IDataResult<List<School>> GetAll(int jobSeekerId)
        {
            return new SuccessDataResult<List<School>>(_schoolDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<School> GetById(int id)
        {
            return new SuccessDataResult<School>(_schoolDal.Get(x => x.Id == id));
        }

        public IResult Update(School school)
        {
            _schoolDal.Update(school);
            return new SuccessResult(Messages.UpdatedSchool);
        }
    }
}
