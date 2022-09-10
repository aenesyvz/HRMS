using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployerValidator : AbstractValidator<Employer>
    {
        public EmployerValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Şirket adı boş geçilemez");
            RuleFor(x => x.CompanyWebSite).NotEmpty().WithMessage("Şirket web sitesi boş geçilemez");
        }
    }
}
