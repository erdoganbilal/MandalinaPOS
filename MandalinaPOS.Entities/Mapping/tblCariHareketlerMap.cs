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
    public class tblCariHareketlerMap:EntityTypeConfiguration<tblCariHareketler>
    {
        public tblCariHareketlerMap()
        {
            this.ToTable("tblCariHareketler");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Unvan).HasColumnType("varchar").HasMaxLength(255);
            this.Property(p => p.BelgeNo).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.CariKimlik).HasColumnType("int");
            this.HasRequired(x => x.TblCariKartlar).WithMany(x => x.TblCariHareketler).HasForeignKey(x => x.CariKimlik);


        }
    }
}
