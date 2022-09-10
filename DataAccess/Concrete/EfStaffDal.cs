using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfStaffDal : EfEntityRepostiryBase<Staff, ContextDB>, IStaffDal
    {

    }
}
