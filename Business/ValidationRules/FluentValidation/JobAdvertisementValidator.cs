using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class JobAdvertisementValidator : AbstractValidator<JobAdvertisement>
    {
        public JobAdvertisementValidator()
        {
            RuleFor(x => x.FinishedDate).NotEmpty().WithMessage("Son başvuru tarihi boş geçilemez");
            RuleFor(x => x.StartingDate).NotEmpty().WithMessage("Başlangıç başvuru tarihi boş geçilemez");
            RuleFor(x => x.NumberOfPosition).NotEmpty().WithMessage("Pozisyon sayısı boş geçilemez");
            RuleFor(x => x.WorkingTimeId).NotEmpty().WithMessage("Çalışma zamanı boş geçilemez");
            RuleFor(x => x.WorkingTypeId).NotEmpty().WithMessage("Çalışma tipi boş geçilemez");
        }
    }
}
