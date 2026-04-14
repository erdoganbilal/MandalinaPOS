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
    [Table("tblOdemeHareketleri")]
    public class tblOdemeHareketleri:IEntity
    {
        [Key]
        public int Kimlik { get; set; } 
        public int CHKimlik { get; set; }    
        public string OdemeTuru { get; set; } 
        public decimal Odenen { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarihi {  get; set; }
        public virtual tblCariHareketler tblCariHareketler { get; set; }

    }
}
