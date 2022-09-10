using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class JobAdvertisementManager : IJobAdvertisementService
    {
        private readonly IJobAdvertisementDal _jobAdvertisementDal;
        public JobAdvertisementManager(IJobAdvertisementDal jobAdvertisementDal)
        {
            _jobAdvertisementDal = jobAdvertisementDal;
        }

        public IResult Add(JobAdvertisement jobAdvertisement)
        {
            _jobAdvertisementDal.Add(jobAdvertisement);
            return new SuccessResult(Messages.AddedJobAdvertisement);
        }

        public IResult Delete(JobAdvertisement jobAdvertisement)
        {
            _jobAdvertisementDal.Delete(jobAdvertisement);
            return new SuccessResult(Messages.DeletedJobAdvertisement);
        }

        public IDataResult<List<JobAdvertisement>> GetAll()
        {
            return new SuccessDataResult<List<JobAdvertisement>>(_jobAdvertisementDal.GetAll());
        }

        public IDataResult<JobAdvertisement> GetById(int id)
        {
            return new SuccessDataResult<JobAdvertisement>(_jobAdvertisementDal.Get(x => x.Id == id));
        }

        public IDataResult<JobAdvertisementDto> GetByIdDto(int id)
        {
            return new SuccessDataResult<JobAdvertisementDto>(_jobAdvertisementDal.GetByIdDto(id));
        }

        public IResult Update(JobAdvertisement jobAdvertisement)
        {
            _jobAdvertisementDal.Update(jobAdvertisement);
            return new SuccessResult(Messages.UpdatedJobAdvertisement);
        }
    }
}
