using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblKullanicilarValidator:AbstractValidator<tblKullanicilar>
    {
        public tblKullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Adı SOYADI alanını boş bırakılamaz.");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanını boş bırakılamaz.");
            RuleFor(p => p.KullaniciAdi).MinimumLength(3).WithMessage("Kullanıcı Adı alanını 3 karakterden az olmamalıdır.");
            RuleFor(p => p.KullaniciAdi).MaximumLength(20).WithMessage("Kullanıcı Adı alanını 20 karakterden fazla olmamalıdır.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanını boş bırakılamaz.");
            RuleFor(p => p.Eposta).EmailAddress().WithMessage("E-posta alanına girilen bilgi uygun formatta değil.");
        }
    }
}
