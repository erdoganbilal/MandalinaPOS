using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using MandalinaPOS.Entities.Tools;
using MandalinaPOSWF.Forms.Ayarlar;
using MandalinaPOSWF.Forms.CariHareketler;
using MandalinaPOSWF.Forms.CariKartlar;
using MandalinaPOSWF.Forms.Gruplar;
using MandalinaPOSWF.Forms.KullaniciHareketleri;
using MandalinaPOSWF.Forms.Kullanicilar;
using MandalinaPOSWF.Forms.Markalar;
using MandalinaPOSWF.Forms.Odemeler;
using MandalinaPOSWF.Forms.RaporFormlari;
using MandalinaPOSWF.Forms.UrunHareketleri;
using MandalinaPOSWF.Forms.Urunler;
using MandalinaPOSWF.Raporlar;
using MandalinaPOSWF.Roles;
using MandalinaPOSWF.WinTools;

namespace MandalinaPOSWF.Forms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MandalinaContext context=new MandalinaContext();
        tblCariHareketlerDal tblCariHareketlerDal = new tblCariHareketlerDal();
        tblKullanicilarDal tblKullanicilarDal= new tblKullanicilarDal();
        tblAyarlarDal tblAyarlarDal= new tblAyarlarDal();
        void FormGoster(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public frmAnaMenu()
        {
            InitializeComponent();

            ConnectionTools.ilkVerileriEkle(context);
            if (!context.tblKullanicilar.Any(k => k.KullaniciAdi == "bilal"))
            {
                tblKullanicilar model = new tblKullanicilar
                {
                    AdSoyad = "Bilal ERDOĞAN",
                    Telefon = "+905436533314",
                    Eposta = "erdoganbilal@gmail.com",
                    Adres = "Kozan Adana",
                    KullaniciAdi = "bilal",
                    Parola = "2878",
                    Gorevi = "Yönetici",
                    HatirlatmaSorusu = "tek",
                    Cevap = "bir",
                    Durumu = true,
                    Admin = true,
                    Tarih = DateTime.Now
                };
                context.tblKullanicilar.Add(model);
                context.SaveChanges();

                foreach (var item in ribbon.Items)
                {
                    if(item is BarButtonItem)
                    {
                        var btn=item as BarButtonItem;
                        if (btn.Caption!="")
                        {
                            tblKullaniciRoller rol = new tblKullaniciRoller
                            {
                                KullaniciKimlik=1,
                                FormName="frmAnaMenu",
                                ControlCaption=btn.Caption, 
                                ControlName=btn.Name,
                                Visible=true
                            };
                            context.tblKullaniciRoller.Add(rol);    
                            context.SaveChanges();  
                        }
                    }
                }
            }

            btnYeniSatisAc.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Shortcut.F4);
            btnYeniSatisAc.ShortcutKeyDisplayString = "F4";

        }

        private void btnGruplarListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGruplarListesi frm= new frmGruplarListesi();
            frm.ShowDialog();
        }

        private void btnMarkalarListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMarkalarListesi frm = new frmMarkalarListesi();
            frm.ShowDialog();
        }

        private void btnUrunlerListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunlerListesi frm= new frmUrunlerListesi(); 
            FormGoster(frm);
        }

        private void btnSatisHareketleriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariHareketlerListesi frm = new frmCariHareketlerListesi();
            FormGoster(frm);
        }

        private void btnCariKartlarListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariKartlarListesi frm = new frmCariKartlarListesi();
            FormGoster(frm);
        }

        private void btnOdemelerListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOdemelerListesi frm = new frmOdemelerListesi();
            FormGoster(frm);
        }

        private void btnYeniSatisAc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new tblCariHareketler
            {
                Unvan = "PERAKENDE SATIŞ",
                BelgeNo = "PS001",
                Tutar = 0,
                Odenen = 0,
                Kalan = 0,
                Tarihi = DateTime.Now,
                SonIslemTarihi = DateTime.Now,
                KullaniciKimlik = KullaniciAyarlari.KulKimlik,
                Durumu = false,
                CariKimlik = 1,
            };
            context.tblCariHareketler.Add(t);
            context.SaveChanges();
            var row = context.tblCariHareketler.OrderByDescending(x => x.Kimlik).FirstOrDefault();
            var CariHareket = tblCariHareketlerDal.GetByFilter(context, c => c.Kimlik == row.Kimlik);

            var DMmodel = context.tblAyarlar.FirstOrDefault();
            if (DMmodel != null)
            {
                bool dmod = DMmodel.DokunmatikMod;
                if (dmod)
                {
                    frmHizliSatisFotoBtn frm1= new frmHizliSatisFotoBtn(CariHareket);
                    frm1.ShowDialog();
                }
                else
                {
                    frmHizliSatis frm = new frmHizliSatis(CariHareket);
                    frm.ShowDialog();
                }
            }
        }

        private void btnSatisHareketleriRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptSatisHareketRaporu report = new rptSatisHareketRaporu();
            frmRaporOnizle frm = new frmRaporOnizle(report);
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKisiselRaporOlusturma frm=new frmKisiselRaporOlusturma();
            frm.ShowDialog();
        }

        private void btnUrunHareketleriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunHareketleriListesi frm = new frmUrunHareketleriListesi();
            FormGoster(frm);
        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm=new frmDashBord();
            FormGoster(frm);
        }

        private void btnKullanıcılarListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm=new frmKullanicilarListesi();
            FormGoster(frm);
        }

        private void btnKullaniciHareketleriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmKullaniciHareketleriListesi();
            FormGoster(frm);
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            var DMmodel = context.tblAyarlar.FirstOrDefault();
            this.Text = "MandalinaPOS   |   " + DMmodel.isletmeUnvan.ToString();

            frmGiris frm = new frmGiris();
            frm.ShowDialog();
            KullaniciYetki.YetkileriGetir(context, ribbon);

        }

        private void btnKullaniciRolleriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciRolleriListesi frm = new frmKullaniciRolleriListesi(KullaniciAyarlari.KulKimlik);
            FormGoster(frm);
        }

        private void btnKullaniciBilgilerim_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciKayit frm = new frmKullaniciKayit(tblKullanicilarDal.GetByFilter(context, u => u.Kimlik == KullaniciAyarlari.KulKimlik));
            frm.ShowDialog();
        }

        private void btnYedekAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmYedekAl frm = new frmYedekAl();
            frm.ShowDialog();
        }

        private void btnUrunSatisAnaliz_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunlerGrafik frm = new frmUrunlerGrafik();
            frm.ShowDialog();
        }

        private void btnYardim_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnProgramHakkinda_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHakkinda frm = new frmHakkinda();
            frm.ShowDialog();
        }

        private void btnProgramAyarlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAyarlar frm = new frmAyarlar(tblAyarlarDal.GetByFilter(context, u => u.Kimlik == 1));
            frm.ShowDialog();
        }

        private void btnUrunlerListesiHizliFiyatGuncelleme_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunlerListesiHizliFiyatGuncelleme frm = new frmUrunlerListesiHizliFiyatGuncelleme();
            FormGoster(frm);
        }

    }
}