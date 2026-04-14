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
    public class tblOdemeHareketleriMap : EntityTypeConfiguration<tblOdemeHareketleri>
    {
        public tblOdemeHareketleriMap()
        {
            this.ToTable("tblOdemeHareketleri");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CHKimlik).HasColumnType("int");
            this.Property(p => p.OdemeTuru).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(255);
            this.HasRequired(x => x.tblCariHareketler).WithMany(x => x.tblOdemeHareketleri).HasForeignKey(x => x.CHKimlik);

        }
    }
}
