using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfLanguageDal : EfEntityRepostiryBase<Language, ContextDB>, ILanguageDal
    {

    }
}
