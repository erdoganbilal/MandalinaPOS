using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOS.Entities.Validations
{
    public class tblCariKartlarValidator : AbstractValidator<tblCariKartlar>
    {
        public tblCariKartlarValidator()
        {
            RuleFor(p => p.Unvan).NotEmpty().WithMessage("Ünvan alanını boş bırakılamaz.");

        }
    }
}
