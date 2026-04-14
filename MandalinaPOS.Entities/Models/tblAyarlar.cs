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
        [Table("tblAyarlar")]
    public class tblAyarlar:IEntity
    {
        [Key]
        public int Kimlik { get; set; }
        public string isletmeUnvan { get; set; }    
        public string isletmeAdres { get; set; }    
        public string isletmeTelefon { get; set; }    
        public string isletmeEposta { get; set; }    
        public string isletmeinstagram { get; set; }
        public string isletmefacebook { get; set; }
        public string FisYazici { get; set; }
        public bool FisYazdir { get; set; }
        public bool DokunmatikMod { get; set; }
        
    }
}
