using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfSchoolDal : EfEntityRepostiryBase<School,ContextDB>, ISchoolDal
    {

    }
}
