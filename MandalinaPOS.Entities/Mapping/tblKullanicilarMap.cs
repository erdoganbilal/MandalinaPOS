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
    public class tblKullanicilarMap: EntityTypeConfiguration<tblKullanicilar>
    {
        public tblKullanicilarMap()
        {
            this.ToTable("tblKullanicilar");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AdSoyad).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Adres).HasColumnType("varchar").HasMaxLength(255);
            this.Property(p => p.Telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Eposta).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Gorevi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.KullaniciAdi).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.Parola).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.HatirlatmaSorusu).HasColumnType("varchar").HasMaxLength(255);
            this.Property(p => p.Cevap).HasColumnType("varchar").HasMaxLength(50);

            
        }
    }
}
