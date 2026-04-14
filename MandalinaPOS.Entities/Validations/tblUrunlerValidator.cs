using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblUrunlerValidator:AbstractValidator<tblUrunler>
    {
        public tblUrunlerValidator()
        {
            RuleFor(p => p.Barkodu).NotEmpty().WithMessage("Barkodu alanını boş bırakılamaz.");
            RuleFor(p => p.Cinsi).NotEmpty().WithMessage("Cinsi alanını boş bırakılamaz.");
            RuleFor(p => p.Birim).NotEmpty().WithMessage("Birim alanını boş bırakılamaz.");
            RuleFor(p => p.AFiyat).NotEmpty().WithMessage("Alış Fiyatı alanını boş bırakılamaz.");
            RuleFor(p => p.AFiyat).GreaterThan(0).WithMessage("Alış Fiyatı alanını sıfırdan büyük olmalıdır.");
            RuleFor(p => p.SFiyat).GreaterThan(0).WithMessage("Satış Fiyatı alanını sıfırdan büyük olmalıdır.");
            RuleFor(p => p.SFiyat).NotEmpty().WithMessage("Satış Fiyatı alanını boş bırakılamaz.");
        }
    }
}
