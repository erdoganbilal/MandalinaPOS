using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblGruplarValidator:AbstractValidator<tblGruplar>
    {
        public tblGruplarValidator()
        {
            RuleFor(p => p.GrupAd).NotEmpty().WithMessage("Grup Adı alanını boş bırakılamaz.");
        }
    }
}
