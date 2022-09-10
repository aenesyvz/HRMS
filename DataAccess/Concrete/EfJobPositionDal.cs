using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfJobPositionDal : EfEntityRepostiryBase<JobPosition, ContextDB>, IJobPositionDal
    {

    }
}
