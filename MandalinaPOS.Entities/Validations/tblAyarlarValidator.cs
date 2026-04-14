using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblAyarlarValidator:AbstractValidator<tblAyarlar>
    {
        public tblAyarlarValidator()
        {
            RuleFor(p => p.isletmeUnvan).NotEmpty().WithMessage("Ünvanı alanını boş bırakılamaz.");
            RuleFor(p => p.isletmeAdres).NotEmpty().WithMessage("Adresi alanını boş bırakılamaz.");
            RuleFor(p => p.isletmeTelefon).NotEmpty().WithMessage("Telefon alanını boş bırakılamaz.");
            RuleFor(p => p.isletmeTelefon).NotEmpty().WithMessage("Telefon alanını boş bırakılamaz.");
            RuleFor(p => p.isletmeEposta).NotEmpty().WithMessage("E-posta alanını boş bırakılamaz.");
            RuleFor(p => p.isletmeEposta).EmailAddress().WithMessage("E-posta alanına girilen bilgi uygun formatta değil.");

        }
    }
}
