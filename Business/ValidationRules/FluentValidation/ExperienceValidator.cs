using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.StartingDate).NotEmpty().WithMessage("İş başlangıç tarihi boş geçilemez");
            RuleFor(x => x.IsContinue).NotEmpty().WithMessage("Devam durumu boş geçilemez");
        }
    }
}
