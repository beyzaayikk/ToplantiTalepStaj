using FluentValidation;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.ValidationRules

{
    public class TalepValidator:AbstractValidator<Talep>
    {
        public TalepValidator()
        {
            RuleFor(x => x.TalepAd).NotEmpty().WithMessage("Talep adını boş geçemezsiniz");
            //RuleFor(x => x.TalepAciklama).NotEmpty().WithMessage("Talep açıklamasını boş geçemezsiniz");
            //RuleFor(x => x.ToplantiBas).NotEmpty().WithMessage("Toplantı başlangıç saatini boş geçemezsiniz");
            //RuleFor(x => x.ToplantiBitis).NotEmpty().WithMessage("Toplantı bitiş boş geçemezsiniz");
            //RuleFor(x => x.ToplantiTur).NotEmpty().WithMessage("Toplantı türününü boş geçemezsiniz");
            RuleFor(x => x.Kurum).NotEmpty().WithMessage("Kurum Adını boş geçemezsiniz");
            RuleFor(x => x.Departman).NotEmpty().WithMessage("Departman Adını boş geçemezsiniz");
            //RuleFor(x => x.Oda).NotEmpty().WithMessage("Oda seçimini boş geçemezsiniz");
            //RuleFor(x => x.EnvanterTalep).NotEmpty().WithMessage("Envanter talep seçimini boş geçemezsiniz");
            //RuleFor(x => x.EnvanterAciklama).NotEmpty().WithMessage("lütfen 50 karakterden fazla değer girişi yapmayınız");
        }
    }
}
