using FluentValidation;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProject.WebUI.Models;

namespace MyHotelProject.WebUI.ValidationRules.StaffValidationRules
{
    public class StaffValidator:AbstractValidator<AddStaffViewModel>
    {
        
        public StaffValidator()
        {
            Int16 TitleMinLength = 5;
            Int16 FullNameMaxLength = 30;
            RuleFor(x=>x.FullName).NotEmpty().WithMessage("İşçinin ad və soyadını daxil edin");
            RuleFor(x=>x.FullName).MaximumLength(FullNameMaxLength).WithMessage($"Ən çoxu {FullNameMaxLength} simvol ola bilər");
            RuleFor(y => y.Title).NotEmpty().WithMessage("Başlıq daxil etmək zəruridir");
            RuleFor(z => z.Title).MinimumLength(TitleMinLength).WithMessage($"Ən azı {TitleMinLength} simvol ola bilər");
            RuleFor(x => x.FullName).NotEqual(x => x.Title).WithMessage("Başlıq ilə tam ad eyni ola bilməz");
        }
    }
}
