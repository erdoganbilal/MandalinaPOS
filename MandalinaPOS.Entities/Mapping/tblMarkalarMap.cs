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
    public class tblMarkalarMap:EntityTypeConfiguration<tblMarkalar>
    {
        public tblMarkalarMap()
        {
            this.ToTable("tblMarkalar");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Marka).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.MarkaBilgi).HasColumnType("varchar").HasMaxLength(255);

        }
    }
}
