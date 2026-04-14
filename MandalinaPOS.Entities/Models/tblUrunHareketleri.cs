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
    [Table("tblUrunHareketleri")]
    public class tblUrunHareketleri:IEntity
    {
        [Key]
        public int Kimlik { get; set; } 
        public int CHKimlik { get; set; }
        public int UrunKimlik { get; set; }
        public string Barkodu { get; set; }
        public int Miktar {  get; set; }
        public decimal BFiyat {  get; set; }
        public string Cinsi { get; set; }
        public DateTime Tarihi { get; set; }
        public virtual tblCariHareketler tblCariHareketler { get; set; }
        public virtual tblUrunler tblUrunler { get; set; }
    }
}
