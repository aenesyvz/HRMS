using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class JobPositionManager : IJobPositionService
    {
        private readonly IJobPositionDal _jobPositionDal;
        public JobPositionManager(IJobPositionDal jobPositionDal)
        {
            _jobPositionDal = jobPositionDal;
        }
        public IResult Add(JobPosition jobPosition)
        {
            _jobPositionDal.Add(jobPosition);
            return new SuccessResult(Messages.AddedJobPosition);
        }

        public IResult Delete(JobPosition jobPosition)
        {
            _jobPositionDal.Delete(jobPosition);
            return new SuccessResult(Messages.DeletedJobPosition);
        }

        public IDataResult<List<JobPosition>> GetAll()
        {
            return new SuccessDataResult<List<JobPosition>>(_jobPositionDal.GetAll());
        }

        public IDataResult<JobPosition> GetById(int id)
        {
            return new SuccessDataResult<JobPosition>(_jobPositionDal.Get(x => x.Id == id));
        }

        public IResult Update(JobPosition jobPosition)
        {
            _jobPositionDal.Update(jobPosition);
            return new SuccessResult(Messages.UpdatedJobPosition);
        }
    }
}
