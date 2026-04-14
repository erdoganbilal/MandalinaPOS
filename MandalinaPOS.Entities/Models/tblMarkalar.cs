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
    [Table("tblMarkalar")]
    public class tblMarkalar:IEntity
    {
        [Key]
        public int Kimlik { get; set; }
        
        public string Marka { get; set; }
        
        public string MarkaBilgi { get; set; }
        public virtual ICollection<tblUrunler> tblUrunler { get; set; }


    }
}
