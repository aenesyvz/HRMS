using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfLetterDal : EfEntityRepostiryBase<Letter, ContextDB>, ILetterDal
    {

    }
}
