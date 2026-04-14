using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOS.Entities.Mapping
{
    public class tblGruplarMap:EntityTypeConfiguration<tblGruplar>
    {
        public tblGruplarMap()
        {
            this.ToTable("tblGruplar");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p=> p.GrupAd).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
