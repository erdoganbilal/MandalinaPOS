using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using FluentValidation;

namespace MandalinaPOS.Entities.Validations
{
    public class tblCariHareketlerValidator:AbstractValidator<tblCariHareketler>
    {
        public tblCariHareketlerValidator()
        {
            RuleFor(p => p.BelgeNo).NotEmpty().WithMessage("Belge No alanını boş bırakılamaz.");
        }
    }
}
