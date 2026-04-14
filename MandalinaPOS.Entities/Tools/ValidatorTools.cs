using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using MandalinaPOS.Entities.Interfaces;

namespace MandalinaPOS.Entities.Tools
{
    public class ValidatorTools
    {
        public static bool Validates(IValidator validator,IEntity entity)
        {
            bool result=true;
            string message = "";
            ValidationContext<IEntity> context=new ValidationContext<IEntity>(entity);
            var ValidationResult=validator.Validate(context);
            if (!ValidationResult.IsValid)
            {
                
                foreach (var error in ValidationResult.Errors)
                {
                    message += error.ErrorMessage + System.Environment.NewLine;
                }
                MessageBox.Show(message);
                result =false;
            }
            
            return result;

        }
    }
}
