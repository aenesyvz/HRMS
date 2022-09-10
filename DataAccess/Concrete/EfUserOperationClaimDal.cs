using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfUserOperationClaimDal : EfEntityRepostiryBase<UserOperationClaim, ContextDB>, IUserOperationClaimDal
    {

    }
}
