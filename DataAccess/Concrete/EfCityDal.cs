using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfCityDal : EfEntityRepostiryBase<City, ContextDB>, ICityDal
    {

    }
}
