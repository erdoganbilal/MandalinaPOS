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
    [Table("tblKullaniciRoller")]
    public class tblKullaniciRoller:IEntity
    {
        [Key]
        public int Kimlik { get; set; }
        public int KullaniciKimlik { get; set; }
        public string FormName { get; set; }    
        public string ControlName { get; set; }
        public string ControlCaption { get; set; }
        public bool Visible { get; set; }
    }
}
