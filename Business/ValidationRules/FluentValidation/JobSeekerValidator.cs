using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class JobSeekerValidator : AbstractValidator<JobSeeker>
    {
        public JobSeekerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Adınızı giriniz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyadınızı giriniz");
            RuleFor(x => x.NationalId).NotEmpty().WithMessage("Kimlik numaranızı giriniz");
            RuleFor(x => x.BirthOfDate).NotEmpty().WithMessage("Doğum tarihinizi giriniz");
        }
    }
}
