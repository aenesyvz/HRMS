using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobAdvertisementService
    {
        IResult Add(JobAdvertisement jobAdvertisement);
        IResult Delete(JobAdvertisement jobAdvertisement);
        IResult Update(JobAdvertisement jobAdvertisement);
        IDataResult<JobAdvertisement> GetById(int id);
        IDataResult<List<JobAdvertisement>> GetAll();
        IDataResult<JobAdvertisementDto> GetByIdDto(int id);

    }


}
