using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfSocialMediaDal : EfEntityRepostiryBase<SocialMedia, ContextDB>, ISocialMediaDal
    {

    }
}
