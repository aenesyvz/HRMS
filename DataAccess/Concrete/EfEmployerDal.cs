﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfEmployerDal : EfEntityRepostiryBase<Employer,ContextDB>, IEmployerDal
    {

    }
}
