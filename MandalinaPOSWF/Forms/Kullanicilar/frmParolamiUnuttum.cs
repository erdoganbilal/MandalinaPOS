using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.Kullanicilar
{
    public partial class frmParolamiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        tblKullanicilarDal tblKullanicilarDal=new tblKullanicilarDal();
        tblKullaniciHareketleri tblKullaniciHareketleri = new tblKullaniciHareketleri();
        tblKullaniciHareketleriDal tblKullaniciHareketleriDal = new tblKullaniciHareketleriDal();

        public frmParolamiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = tblKullanicilarDal.GetByFilter(context, k => k.KullaniciAdi == txtKullaniciAdiEposta.Text || k.Eposta == txtKullaniciAdiEposta.Text);
            if (entity != null) 
            {
                if(entity.HatirlatmaSorusu==txtHatirlatmaSorusu.Text && entity.Cevap==txtCevap.Text)
                {
                    if (txtYeniParola.Text == txtParolaTekrar.Text)
                    {
                        entity.Parola=txtYeniParola.Text;
                        if (tblKullanicilarDal.AddOrUpdate(context,entity))
                        {
                            tblKullanicilarDal.Save(context);
                            tblKullaniciHareketleri.KullaniciKimlik = entity.Kimlik;
                            string Aciklama = entity.KullaniciAdi + " isimli kullanıcı parola değişikliği yaptı.";
                            tblKullaniciHareketleriDal.KullaniciHareketiEkle(context, tblKullaniciHareketleri, Aciklama);

                            this.Close();   
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Girdiğiniz Yeni parola ile parola tekrar bilgisi uyuşmuyor. Kontrol ediniz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtYeniParola.Focus();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Girdiğiniz soru veya cevap hatalı.","İkaz",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtHatirlatmaSorusu.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("Girdiğiniz kullanıcı adı veya e-postaya ait bir kullanıcı kaydı bulunamadı.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtKullaniciAdiEposta.Focus();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}