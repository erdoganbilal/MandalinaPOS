using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblUrunHareketleriValidator:AbstractValidator<tblUrunHareketleri>
    {
        public tblUrunHareketleriValidator()
        {
            RuleFor(p => p.CHKimlik).NotEmpty().WithMessage("CHKimlik alanını boş bırakılamaz.");
            RuleFor(p => p.UrunKimlik).NotEmpty().WithMessage("UrunKimlik alanını boş bırakılamaz.");
            RuleFor(p => p.Cinsi).NotEmpty().WithMessage("Cinsi alanını boş bırakılamaz.");
            RuleFor(p => p.BFiyat).NotEmpty().WithMessage("Birim Fiyat alanını boş bırakılamaz.");
            RuleFor(p => p.Miktar).NotEmpty().WithMessage("Miktar alanını boş bırakılamaz.");
            RuleFor(p => p.Miktar).GreaterThan(0).WithMessage("Miktar alanının değeri sıfırdan büyük olmalıdır.");
        }
    }
}
