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
    public class tblUrunlerMap:EntityTypeConfiguration<tblUrunler>
    {
        public tblUrunlerMap()
        {
            this.ToTable("tblUrunler");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p=>p.Barkodu).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.Birim).HasColumnType("varchar").HasMaxLength(2);
            this.HasRequired(x => x.tblGruplar).WithMany(x => x.tblUrunler).HasForeignKey(x => x.GrupKimlik);
            this.HasRequired(x => x.tblMarkalar).WithMany(x => x.tblUrunler).HasForeignKey(x => x.MarkaKimlik);

        }
    }
}
