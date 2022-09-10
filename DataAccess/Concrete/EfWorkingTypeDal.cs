using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfWorkingTypeDal : EfEntityRepostiryBase<WorkingType,ContextDB>, IWorkingTypeDal
    {

    }
}
