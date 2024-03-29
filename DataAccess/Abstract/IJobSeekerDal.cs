﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IJobSeekerDal : IEntityRepositoryDal<JobSeeker>
    {
        JobSeekerDto GetByIdDto(int id);
    }
}
