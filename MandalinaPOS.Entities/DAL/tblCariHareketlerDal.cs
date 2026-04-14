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
    public class tblCariHareketlerDal : EntityRepositoryBase<MandalinaContext, tblCariHareketler,tblCariHareketlerValidator>
    {
        public object CarHarListele(MandalinaContext context)
        {
            var model=(from ch in context.tblCariHareketler join k in context.tblKullanicilar on ch.KullaniciKimlik 
                       equals k.Kimlik into kullanici from kullaniciCH in kullanici.DefaultIfEmpty()
                        select new
                        {
                            ch.Kimlik,
                            ch.BelgeNo,
                            ch.Unvan,
                            ch.Tutar,
                            ch.Odenen,
                            ch.Kalan,
                            ch.Tarihi,
                            ch.SonIslemTarihi,
                            ch.Aciklama,
                            ch.Durumu,
                            Kullanici = kullaniciCH.KullaniciAdi
                        }).ToList(); return model;  
        }
    }
}
