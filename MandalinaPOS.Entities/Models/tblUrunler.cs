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
    [Table("tblUrunler")]
    public class tblUrunler:IEntity
    {
        [Key]
        public int Kimlik {  get; set; }
        
        public int MarkaKimlik { get; set; }
        
        public int GrupKimlik { get; set; }
        
        public  string Barkodu {  get; set; }
        
        public string Cinsi { get; set; }
        
        public string Birim { get; set; }
        public decimal AFiyat {  get; set; }
        public decimal SFiyat { get; set; }
        public bool HizliSatis { get; set; }

        public string Foto { get; set; }
        public DateTime FZaman { get; set; }= DateTime.Now;
        public DateTime HZaman { get; set; }=DateTime.Now;
        public virtual tblMarkalar tblMarkalar { get; set; }
        public virtual tblGruplar tblGruplar { get; set; }

        public virtual ICollection<tblUrunHareketleri> tblUrunHareketleri { get; set; }


    }
}
