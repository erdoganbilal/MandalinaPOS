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
    [Table("tblKullanicilar")]
    public class tblKullanicilar:IEntity
    {
        [Key]
        public int Kimlik { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Eposta { get; set; }
        public string Gorevi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durumu { get; set; }=true;
        public bool Admin { get; set; }=false;

        public virtual ICollection<tblKullaniciHareketleri> tblKullaniciHareketleri { get; set; }
        public virtual ICollection<tblCariHareketler> TblCariHareketler { get; set; }

    }
}
