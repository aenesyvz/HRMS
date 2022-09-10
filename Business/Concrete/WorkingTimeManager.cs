using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class WorkingTimeManager : IWorkingTimeService
    {
        private readonly IWorkingTimeDal _workingTimeDal;
        public WorkingTimeManager(IWorkingTimeDal workingTimeDal)
        {
            _workingTimeDal = workingTimeDal;
        }
        public IResult Add(WorkingTime workingTime)
        {
            _workingTimeDal.Add(workingTime);
            return new SuccessResult(Messages.AddedWorkingTime);
        }

        public IResult Delete(WorkingTime workingTime)
        {
            _workingTimeDal.Delete(workingTime);
            return new SuccessResult(Messages.DeletedWorkingTime);
        }

        public IDataResult<List<WorkingTime>> GetAll()
        {
            return new SuccessDataResult<List<WorkingTime>>(_workingTimeDal.GetAll());
        }

        public IDataResult<WorkingTime> GetById(int id)
        {
            return new SuccessDataResult<WorkingTime>(_workingTimeDal.Get(x => x.Id == id));
        }

        public IResult Update(WorkingTime workingTime)
        {
            _workingTimeDal.Update(workingTime);
            return new SuccessResult(Messages.UpdatedWorkingTime);
        }
    }
}
