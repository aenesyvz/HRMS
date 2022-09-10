using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Update(UserOperationClaim operationClaim);
        IResult Delete(UserOperationClaim userOperationClaim);
        IDataResult<UserOperationClaim> GetById(int id);
        IDataResult<UserOperationClaim> GetByUserId(int userId);

    }
}
