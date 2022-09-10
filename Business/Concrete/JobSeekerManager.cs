using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class JobSeekerManager : IJobSeekerService
    {
        private readonly IJobSeekerDal _jobSeekerDal;
        private readonly IUserOperationClaimService _userOperationClaimService;
        public JobSeekerManager(IJobSeekerDal jobSeekerDal,IUserOperationClaimService userOperationClaimService)
        {
            _jobSeekerDal = jobSeekerDal;
            _userOperationClaimService = userOperationClaimService;
        }
        public IResult Add(JobSeeker jobSeeker)
        {
            _jobSeekerDal.Add(jobSeeker);
            var userOperationClaim = new UserOperationClaim()
            {
                OperationClaimId = 1,
                UserId = jobSeeker.UserId
            };
            _userOperationClaimService.Add(userOperationClaim);
            return new SuccessResult();
        }

        public IResult Delete(JobSeeker jobSeeker)
        {
            _jobSeekerDal.Delete(jobSeeker);
            return new SuccessResult();
        }

        public IDataResult<List<JobSeeker>> GetAll()
        {
            return new SuccessDataResult<List<JobSeeker>>(_jobSeekerDal.GetAll());
        }

        public IDataResult<JobSeeker> GetById(int id)
        {
            return new SuccessDataResult<JobSeeker>(_jobSeekerDal.Get(x => x.Id == id));
        }

        public IDataResult<JobSeekerDto> GetByIdDto(int id)
        {
            return new SuccessDataResult<JobSeekerDto>(_jobSeekerDal.GetByIdDto(id));
        }

        public IResult Update(JobSeeker jobSeeker)
        {
            _jobSeekerDal.Update(jobSeeker);
            return new SuccessResult();
        }
    }
}
