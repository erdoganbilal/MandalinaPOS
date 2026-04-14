using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalinaPOS.Entities.Mapping;
using MandalinaPOS.Entities.Tools;

namespace MandalinaPOS.Entities.Models
{
    public class MandalinaContext:DbContext
    {
        public MandalinaContext():base("Data source=.\\SQLEXPRESS;Initial Catalog=MandalinaPOS;Integrated Security=true;")
        {
                
        }
        public DbSet<tblGruplar> tblGruplar { get; set; }
        public DbSet<tblMarkalar> tblMarkalar { get; set; }
        public DbSet<tblUrunler> tblUrunler { get; set; }
        public DbSet<tblCariHareketler> tblCariHareketler { get; set; }
        public DbSet<tblKullaniciHareketleri> tblKullaniciHareketleri { get; set; }    
        public DbSet<tblKullanicilar> tblKullanicilar { get; set; }
        public DbSet<tblKullaniciRoller> tblKullaniciRoller { get; set; }  
        public DbSet<tblOdemeHareketleri> tblOdemeHareketleri { get; set; }   
        public DbSet<tblUrunHareketleri> tblUrunHareketleris { get; set; }
        public DbSet<tblCariKartlar> tblCariKartlar { get; set; }
        public DbSet<tblAyarlar> tblAyarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new tblCariHareketlerMap());
            modelBuilder.Configurations.Add(new tblGruplarMap());
            modelBuilder.Configurations.Add(new tblKullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new tblKullanicilarMap());
            modelBuilder.Configurations.Add(new tblKullaniciRollerMap());
            modelBuilder.Configurations.Add(new tblMarkalarMap());
            modelBuilder.Configurations.Add(new tblOdemeHareketleriMap());
            modelBuilder.Configurations.Add(new tblUrunHareketleriMap());
            modelBuilder.Configurations.Add(new tblUrunlerMap());
            modelBuilder.Configurations.Add(new tblCariKartlarMap());

        }
    }
}
