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
    public class tblUrunHareketleriMap:EntityTypeConfiguration<tblUrunHareketleri>
    {
        public tblUrunHareketleriMap()
        {
            this.ToTable("tblUrunHareketleri");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CHKimlik).HasColumnType("int");
            this.Property(p => p.UrunKimlik).HasColumnType("int");
            this.Property(p => p.Barkodu).HasColumnType("varchar").HasMaxLength(20);
            this.HasRequired(x=> x.tblCariHareketler).WithMany(x=>x.tblUrunHareketleri).HasForeignKey(x=>x.CHKimlik);
            this.HasRequired(x=> x.tblUrunler).WithMany(x=>x.tblUrunHareketleri).HasForeignKey(x=>x.UrunKimlik);

        }
    }
}
