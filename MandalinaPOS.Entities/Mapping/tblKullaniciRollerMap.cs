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
    public class tblKullaniciRollerMap:EntityTypeConfiguration<tblKullaniciRoller>
    {
        public tblKullaniciRollerMap()
        {
            this.ToTable("tblKullaniciRoller");
            this.HasKey(p => p.Kimlik);
            this.Property(p => p.Kimlik).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.ControlCaption).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.ControlName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.FormName).HasColumnType("varchar").HasMaxLength(50);

        }
    }
}
