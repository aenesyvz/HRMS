﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfExperiemceDal : EfEntityRepostiryBase<Experience, ContextDB>, IExperienceDal
    {

    }
}
