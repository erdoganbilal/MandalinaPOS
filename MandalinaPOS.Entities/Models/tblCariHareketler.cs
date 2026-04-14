using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Interfaces;


namespace MandalinaPOS.Entities.Models
{
    [Table("tblCariHareketler")]
    public class tblCariHareketler:IEntity
    {
        [Key]
        public int Kimlik { get; set; }
        public string BelgeNo { get; set; }
        public string Unvan { get; set; }
        public decimal Tutar {  get; set; }
        public decimal Odenen { get; set; }
        public decimal Kalan { get; set; }  
        public string Aciklama {  get; set; }
        public DateTime Tarihi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public bool Durumu { get; set; }
        public int? CariKimlik { get; set; }
        public int? KullaniciKimlik { get; set; }
        public virtual tblKullanicilar tblKullanicilar { get; set; }
        public virtual tblCariKartlar TblCariKartlar { get; set; }


        public virtual ICollection<tblOdemeHareketleri> tblOdemeHareketleri { get; set; }
        public virtual ICollection<tblUrunHareketleri> tblUrunHareketleri { get; set; }

    }
}
