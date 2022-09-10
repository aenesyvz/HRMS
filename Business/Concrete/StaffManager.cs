using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;
        private readonly IEmployerService _employerService;
        private readonly IJobAdvertisementService _jobAdvertisementService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        public StaffManager(IStaffDal staffDal,IJobAdvertisementService jobAdvertisementService,IEmployerService employerService,IUserOperationClaimService userOperationClaimService)
        {
            _staffDal = staffDal;
            _jobAdvertisementService = jobAdvertisementService;
            _employerService = employerService;
            _userOperationClaimService = userOperationClaimService;
        }

        public IResult Add(Staff staff)
        {
            _staffDal.Add(staff);
            var userOperationClaim = new UserOperationClaim()
            {
                OperationClaimId = 3,
                UserId = staff.UserId
            };
            _userOperationClaimService.Add(userOperationClaim);
            return new SuccessResult();
        }

        public IResult ChangeStatusEmployer(Employer employer)
        {
            if (!employer.IsConfirm)
            {
                employer.IsConfirm = true;
            }
            employer.IsConfirm = false;
            return new SuccessResult();
        }

        public IResult ChangeStatusJobAdvertisement(JobAdvertisement jobAdvertisement)
        {
            if (!jobAdvertisement.IsConfirm)
            {
                jobAdvertisement.IsConfirm = true;
            }

            jobAdvertisement.IsConfirm = false;
            return new SuccessResult();
        }

        public IDataResult<List<Employer>> GetAllByPassiveEmployer()
        {
            return new SuccessDataResult<List<Employer>>(_employerService.GetAll().Data.Where(x => x.IsConfirm == false).ToList());
        }

        public IDataResult<List<JobAdvertisement>> GetAllByPassiveJobAdvertisement()
        {
            return new SuccessDataResult<List<JobAdvertisement>>(_jobAdvertisementService.GetAll().Data.Where(x => x.IsConfirm).ToList());
        }

        public IResult Update(Staff staff)
        {
            _staffDal.Update(staff);
            return new SuccessResult();
        }
    }
}
