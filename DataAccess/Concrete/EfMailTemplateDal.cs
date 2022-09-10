using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfMailTemplateDal : EfEntityRepostiryBase<MailTemplate,ContextDB>, IMailTemplateDal
    {

    }
}
