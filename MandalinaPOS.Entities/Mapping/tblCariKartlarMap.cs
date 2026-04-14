using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOS.Entities.Mapping
{
    public class tblCariKartlarMap : EntityTypeConfiguration<tblCariKartlar>
    {
        public tblCariKartlarMap()
        {
            this.ToTable("tblCariKartlar");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Unvan).HasColumnType("varchar").HasMaxLength(255);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(500);
            this.Property(p => p.Adres).HasColumnType("varchar").HasMaxLength(255);
            this.Property(p => p.Telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Eposta).HasColumnType("varchar").HasMaxLength(150);
            



        }
    }
}
