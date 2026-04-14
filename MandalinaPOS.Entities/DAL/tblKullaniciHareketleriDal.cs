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
    public class tblKullaniciHareketleriDal:EntityRepositoryBase<MandalinaContext,tblKullaniciHareketleri,tblKullaniciHareketleriValidator>
    {
        
        public void KullaniciHareketiEkle(MandalinaContext context, tblKullaniciHareketleri tblKullaniciHareketleri,string Aciklama)
        {
            tblKullaniciHareketleriDal tblKullaniciHareketleriDal = new tblKullaniciHareketleriDal();
            tblKullaniciHareketleri.Tarih=DateTime.Now;
            tblKullaniciHareketleri.Aciklama=Aciklama;
            if (tblKullaniciHareketleriDal.AddOrUpdate(context,tblKullaniciHareketleri))
            {
                tblKullaniciHareketleriDal.Save(context);
            }
        }
    }
}
