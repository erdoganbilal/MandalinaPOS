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
    public class tblUrunlerDal : EntityRepositoryBase<MandalinaContext, tblUrunler,tblUrunlerValidator>
    {
        public object UrunListele(MandalinaContext context)
        {
            var liste = (from u in context.tblUrunler 
            select new
            {
                u.Kimlik,
                u.MarkaKimlik,
                u.GrupKimlik,
                GrupAdi=u.tblGruplar.GrupAd,
                MarkaAdi=u.tblMarkalar.Marka,
                u.Barkodu,
                u.Cinsi,
                u.Birim,
                u.AFiyat,
                u.SFiyat,
                u.HizliSatis,
                u.FZaman,
                u.HZaman,
                u.Foto
                
            }).ToList();
            return liste;
        }




    }
}
