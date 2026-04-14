using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;
using MandalinaPOS.Entities.Repository;
using MandalinaPOS.Entities.Validations;

namespace MandalinaPOS.Entities.DAL
{
    public class tblAyarlarDal : EntityRepositoryBase<MandalinaContext, tblAyarlar, tblAyarlarValidator>
    {

    }
}
