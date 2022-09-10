using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISocialMediaService
    {
        IResult Add(SocialMedia socialMedia);
        IResult Delete(SocialMedia socialMedia);
        IResult Update(SocialMedia socialMedia);
        IDataResult<List<SocialMedia>> GetAll(int jobSeekerId);
        IDataResult<SocialMedia> GetById(int id);
    }
}
