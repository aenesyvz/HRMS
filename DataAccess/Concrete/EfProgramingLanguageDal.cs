using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfProgramingLanguageDal : EfEntityRepostiryBase<ProgramingLanguage, ContextDB>, IProgramingLanguageDal
    {

    }
}
