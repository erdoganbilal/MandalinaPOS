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
    public class tblKullaniciHareketleriMap : EntityTypeConfiguration<tblKullaniciHareketleri>
    {
        public tblKullaniciHareketleriMap()
        {
            this.ToTable("tblKullaniciHareketleri");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.HasRequired(x => x.tblKullanicilar).WithMany(x => x.tblKullaniciHareketleri).HasForeignKey(x => x.KullaniciKimlik);

        }
    }
}
