using FluentValidation;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.ValidationRules
{
    public class DepartmanValidator:AbstractValidator<Departman>
    {
        public DepartmanValidator()
        {
            RuleFor(x => x.DepartmanAd).NotEmpty().WithMessage("Departman adını boş geçemezsiniz!");
        }
    }
}
