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
    [Table("tblKullaniciHareketleri")]
    public class tblKullaniciHareketleri:IEntity
    {
        public int Kimlik { get; set; }
        public int KullaniciKimlik { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual tblKullanicilar tblKullanicilar { get; set; }

    }
}
