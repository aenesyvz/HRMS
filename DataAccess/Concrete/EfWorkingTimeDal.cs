using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfWorkingTimeDal : EfEntityRepostiryBase<WorkingTime, ContextDB>, IWorkingTimeDal
    {

    }
}
