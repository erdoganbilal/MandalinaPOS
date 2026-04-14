using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.Forms.AnaMenu;
using MandalinaPOSWF.Roles;
using MandalinaPOSWF.WinTools;

namespace MandalinaPOSWF.Forms.Kullanicilar
{
    public partial class frmKullaniciKayit : DevExpress.XtraEditors.XtraForm
    {
        public MandalinaContext context=new MandalinaContext();
        tblKullanicilarDal tblKullanicilarDal=new tblKullanicilarDal();
        tblKullanicilar _entity;
        tblKullaniciHareketleri tblKullaniciHareketleri=new tblKullaniciHareketleri();
        tblKullaniciHareketleriDal tblKullaniciHareketleriDal=new tblKullaniciHareketleriDal();
        public bool kaydet=false;   
        public frmKullaniciKayit(tblKullanicilar entity)
        {
            InitializeComponent();

            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtKimlik.DataBindings.Add("Text", _entity, "Kimlik");
            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtEposta.DataBindings.Add("Text", _entity, "Eposta");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi");
            txtParola.DataBindings.Add("Text", _entity, "Parola");
            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "Cevap");
            toggleAdmin.DataBindings.Add("EditValue", _entity, "Admin");

            if(_entity.Kimlik==0)
            {
                lblBanner.Text = "Yeni Kullanıcı";
            }            
            else if(_entity.Kimlik!=0)
            {
                lblBanner.Text = _entity.AdSoyad;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtParola.Text==txtParolaTekrar.Text)
            {
                _entity.Tarih = DateTime.Now;
                if (tblKullanicilarDal.AddOrUpdate(context, _entity))
                {
                    tblKullanicilarDal.Save(context);
                    var model = context.tblKullanicilar.Max(k => k.Kimlik);
                    tblKullaniciHareketleri.Kimlik = model;
                    string Aciklama = "Yeni kullanıcı eklendi";
                    tblKullaniciHareketleri.Tarih=DateTime.Now; 
                    tblKullaniciHareketleriDal.KullaniciHareketiEkle(context,tblKullaniciHareketleri,Aciklama);
                    kaydet = true;

     //kullanıcı yetkilendirme

                    frmAnaMenu frm=new frmAnaMenu();
                    if (lblBanner.Text=="Yeni Kullanıcı")
                    {
                        foreach (var item in frm.ribbon.Items)
                        {
                            if (item is BarButtonItem)
                            {
                                var btn = item as BarButtonItem;
                                if (btn.Caption != "")
                                {
                                    tblKullaniciRoller rol = new tblKullaniciRoller
                                    {
                                        KullaniciKimlik = context.tblKullanicilar.Max(k => k.Kimlik),
                                        FormName = "frmAnaMenu",
                                        ControlCaption = btn.Caption,
                                        ControlName = btn.Name,
                                        Visible = false
                                    };
                                    context.tblKullaniciRoller.Add(rol);
                                    context.SaveChanges();
                                }
                            }
                        } 
                    }
                    this.Close();
                } 
            }
            else
            {
                XtraMessageBox.Show("Parola ile Parola Tekrar eşleşmiyor. Lütfen kontrol ediniz.","İkaz",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtParola.Focus();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {
            if (lblBanner.Text == "Yeni Kullanıcı")
            {
                toggleDurumu.EditValue = false; 
                toggleAdmin.EditValue = false;  
                toggleAdmin.Enabled = false;
                toggleDurumu.Enabled = false;
            }
            if (!_entity.Admin)
            {
                toggleAdmin.Enabled = false;
                toggleDurumu.Enabled = false;
            }
        }
    }
}