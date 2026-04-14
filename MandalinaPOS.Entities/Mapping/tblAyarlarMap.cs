using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOS.Entities.Mapping
{
    public class tblAyarlarMap : EntityTypeConfiguration<tblAyarlar>
    {
        public tblAyarlarMap()
        {
            this.ToTable("tblAyarlar");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.isletmeUnvan).HasColumnType("varchar").HasMaxLength(250);

        }
    }
}
