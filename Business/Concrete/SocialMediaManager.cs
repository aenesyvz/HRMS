using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public IResult Add(SocialMedia socialMedia)
        {
            _socialMediaDal.Add(socialMedia);
            return new SuccessResult(Messages.AddedSocialMedia);
        }

        public IResult Delete(SocialMedia socialMedia)
        {
            _socialMediaDal.Delete(socialMedia);
            return new SuccessResult(Messages.DeletedSocialMedia);
        }

        public IDataResult<List<SocialMedia>> GetAll(int jobSeekerId)
        {
            return new SuccessDataResult<List<SocialMedia>>(_socialMediaDal.GetAll(x => x.JobSeekerId == jobSeekerId));
        }

        public IDataResult<SocialMedia> GetById(int id)
        {
            return new SuccessDataResult<SocialMedia>(_socialMediaDal.Get(x => x.Id == id));
        }

        public IResult Update(SocialMedia socialMedia)
        {
            _socialMediaDal.Update(socialMedia);
            return new SuccessResult(Messages.UpdatedSocialMedia);
        }
    }
}
