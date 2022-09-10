using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EmployerManager : IEmployerService
    {
        private readonly IEmployerDal _employerDal;
        private readonly IUserOperationClaimService _userOperationClaimService;
        public EmployerManager(IEmployerDal employerDal, IUserOperationClaimService userOperationClaimService)
        {
            _employerDal = employerDal;
            _userOperationClaimService = userOperationClaimService;
        }
        public IResult Add(Employer employer)
        {
            _employerDal.Add(employer);
            var userOperationClaim = new UserOperationClaim()
            {
                OperationClaimId = 2,
                UserId = employer.UserId
            };
            _userOperationClaimService.Add(userOperationClaim);
            return new SuccessResult();
        }

        public IResult Delete(Employer employer)
        {
            _employerDal.Delete(employer);
            return new SuccessResult();
        }

        public IDataResult<List<Employer>> GetAll()
        {
            return new SuccessDataResult<List<Employer>>(_employerDal.GetAll());
        }

        public IDataResult<Employer> GetById(int id)
        {
            return new SuccessDataResult<Employer>(_employerDal.Get(x => x.Id == id));
        }

        public IResult Update(Employer employer)
        {
            _employerDal.Update(employer);
            return new SuccessResult();
        }

        //Business Rules

        
    }
}
