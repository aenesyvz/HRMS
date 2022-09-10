using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfOperationClaimDal : EfEntityRepostiryBase<OperationClaim, ContextDB>, IOperationClaimDal
    {

    }
}
