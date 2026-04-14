using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOS.Entities.Tools
{
    public class ConnectionTools
    {
       
        public static void BaglantiKontrol()
        {
            using (var context=new MandalinaContext())
            {
                if (!context.Database.Exists())
                {
                    MessageBox.Show("Veritabanı bulunamadı. Şimdi Yeni veritabanı oluşturulacak. İşlem tamamlanınca program açılacaktır.", "MandalinaPOS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    context.Database.CreateIfNotExists();
                }
                else
                {
                    //MessageBox.Show("vt zati var.");
                }
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<MandalinaContext, Entities.Migrations.Configuration>());
            }
        }
        public static void ilkVerileriEkle(MandalinaContext context)
        {
            if (!context.tblCariKartlar.Any())
            {
                List<tblCariKartlar> cklist = new List<tblCariKartlar>()
                {
                    new tblCariKartlar
                    {
                        Unvan="PERAKENDE SATIŞ",
                        Telefon="000 000 00 00",
                        Adres="Adres Bilgisi",
                        Eposta="eposta@posta.com",
                        Aciklama="Peşin Satış Müşterileri için kullanılır.Lütfen Silmeyiniz.",
                        Tarih=DateTime.Now
                    }
                };
                context.tblCariKartlar.AddRange(cklist);
            }
            if (!context.tblMarkalar.Any())
            {
                List<tblMarkalar> mrklist = new List<tblMarkalar>()
                {
                    new tblMarkalar
                    {
                        Marka="MARKASIZ",
                        MarkaBilgi="Markası olmayan ürünler için kullanılır"
                    }
                };
                context.tblMarkalar.AddRange(mrklist);
            }
            if (!context.tblGruplar.Any())
            {
                List<tblGruplar> grplist = new List<tblGruplar>()
                {
                    new tblGruplar
                    {
                        GrupAd="BARKODSUZ"
                    }
                };
                context.tblGruplar.AddRange(grplist);
            }            
            if (!context.tblAyarlar.Any())
            {
                List<tblAyarlar> ayarlist = new List<tblAyarlar>()
                {
                    new tblAyarlar
                    {
                        isletmeUnvan="MandalinaPOS",
                        isletmeAdres="Kozan ADANA",
                        isletmeTelefon="+90 543 653 33 14",
                        isletmeEposta= "erdoganbilal@gmail.com"
                    }
                };
                context.tblAyarlar.AddRange(ayarlist);
            }

        }
    }
}
