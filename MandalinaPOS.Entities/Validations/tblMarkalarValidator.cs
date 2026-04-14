using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblMarkalarValidator:AbstractValidator<tblMarkalar>
    {
        public tblMarkalarValidator()
        {
            RuleFor(p => p.Marka).NotEmpty().WithMessage("Marka alanını boş bırakılamaz.");
        }
    }
}
