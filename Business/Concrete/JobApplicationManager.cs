using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class JobApplicationManager : IJobApplicationService
    {
        private readonly IJobApplicationDal _jobApplicationDal;
        public JobApplicationManager(IJobApplicationDal jobApplicationDal)
        {
            _jobApplicationDal = jobApplicationDal;
        }
        public IResult Add(JobApplication jobApplication)
        {
            _jobApplicationDal.Add(jobApplication);
            return new SuccessResult(Messages.AddedJobApplication);
        }

        public IResult Delete(JobApplication jobApplication)
        {
            _jobApplicationDal.Delete(jobApplication);
            return new SuccessResult(Messages.DeletedJobApplication);
        }

        public IDataResult<List<JobApplication>> GetAllByJobAdvertisement(int jobAdvertisementId)
        {
            return new SuccessDataResult<List<JobApplication>>(_jobApplicationDal.GetAll(x => x.JobAdvertisementId == jobAdvertisementId));
        }

        public IDataResult<List<JobApplication>> GetAllByJobSeeker(int jobSeekerId)
        {
            return new SuccessDataResult<List<JobApplication>>(_jobApplicationDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<JobApplication> GetById(int id)
        {
            return new SuccessDataResult<JobApplication>(_jobApplicationDal.Get(x => x.Id == id));
        }

        public IResult Update(JobApplication jobApplication)
        {
            _jobApplicationDal.Update(jobApplication);
            return new SuccessResult(Messages.UpdatedJobApplication);
        }
    }
}
