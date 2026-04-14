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
    public class tblUrunHareketleriDal : EntityRepositoryBase<MandalinaContext, tblUrunHareketleri,tblUrunHareketleriValidator>
    {
        public void UrunHareketiEkle(MandalinaContext context, tblUrunHareketleri tblUrunHareketleri)
        {
            tblUrunHareketleriDal tblUrunHareketleriDal = new tblUrunHareketleriDal();
            tblUrunHareketleri.Tarihi = DateTime.Now;
            if (tblUrunHareketleriDal.AddOrUpdate(context, tblUrunHareketleri))
            {
                tblUrunHareketleriDal.Save(context);
            }
        }
    }
}
