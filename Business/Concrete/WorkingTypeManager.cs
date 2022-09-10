using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class WorkingTypeManager : IWorkingTypeService
    {
        private readonly IWorkingTypeDal _workingTypeDal;
        public WorkingTypeManager(IWorkingTypeDal workingTypeDal)
        {
            _workingTypeDal = workingTypeDal;
        }
        public IResult Add(WorkingType workingType)
        {
            _workingTypeDal.Add(workingType);
            return new SuccessResult(Messages.AddedWorkingType);
        }

        public IResult Delete(WorkingType workingType)
        {
            _workingTypeDal.Delete(workingType);
            return new SuccessResult(Messages.DeletedWorkingType);
        }

        public IDataResult<List<WorkingType>> GetAll()
        {
            return new SuccessDataResult<List<WorkingType>>(_workingTypeDal.GetAll());
        }

        public IDataResult<WorkingType> GetById(int id)
        {
            return new SuccessDataResult<WorkingType>(_workingTypeDal.Get(x => x.Id == id));
        }

        public IResult Update(WorkingType workingType)
        {
            _workingTypeDal.Update(workingType);
            return new SuccessResult(Messages.UpdatedWorkingType);
        }
    }
}
