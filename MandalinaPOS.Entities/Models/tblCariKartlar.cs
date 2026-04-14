using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Interfaces;

namespace MandalinaPOS.Entities.Models
{
    public class tblCariKartlar:IEntity
    {
        public int Kimlik { get; set; } 
        public string Unvan { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Eposta { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual ICollection<tblCariHareketler> TblCariHareketler { get; set; }


    }
}
