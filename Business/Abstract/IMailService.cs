using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IMailService
    {
        IResult SendMail();
    }
}
