using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.WinTools;

namespace MandalinaPOSWF.Forms.Kullanicilar
{
    public partial class frmGiris : DevExpress.XtraEditors.XtraForm
    {
        bool giris;
        string PKimlik;
        MandalinaContext context=new MandalinaContext();
        tblKullaniciHareketleriDal tblKullaniciHareketleriDal=new tblKullaniciHareketleriDal();
        tblKullaniciHareketleri entity=new tblKullaniciHareketleri();
        // Beni haıtrla işaretlenirse bilgileri getirmek için aşağıdaki BilgileriGetir Void bloğunu kullanıyoruz
        void BeniHatirlaBilgileriniGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullaniciAdi.Text=Properties.Settings.Default.KullaniciAdi;
                txtParola.Text=Properties.Settings.Default.Parola;
                checkBeniHatirla.EditValue=Properties.Settings.Default.BeniHatirla;
            }
            else 
            {
                txtKullaniciAdi.Text=null; 
                txtParola.Text=null; 
                checkBeniHatirla.EditValue = false; 
            }
        }
        // Beni Hatırla ya tıklayınca bilgileri hatırlamak üzere kaydetmek için bu metod kullanılacak
        void BeniHatirlaBilgileriniKaydet()
        {
            if((bool)checkBeniHatirla.EditValue)
            {
                Properties.Settings.Default.KullaniciAdi=txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola=txtParola.Text;
                Properties.Settings.Default.BeniHatirla=true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }
        public frmGiris()
        {
            InitializeComponent();
            BeniHatirlaBilgileriniGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris) {Application.Exit(); }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var model=context.tblKullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtParola.Text);
            //if(context.tblKullanicilar.Any(k=>k.KullaniciAdi==txtKullaniciAdi.Text && k.Parola == txtParola.Text))
            if(model != null)
            {
                giris = true;
                BeniHatirlaBilgileriniKaydet(); 
                KullaniciAyarlari.KulKimlik=model.Kimlik;
                entity.KullaniciKimlik=model.Kimlik;
                string Aciklama = model.KullaniciAdi + " isimli kullanıcı programa giriş yaptı.";
                tblKullaniciHareketleriDal.KullaniciHareketiEkle(context,entity,Aciklama);
                if(Properties.Settings.Default.ProgramKimlik==PKimlik)
                {
                    this.Close();
                }
                else
                {
                    giris=false;
                    XtraMessageBox.Show("Program install error the system registry contains invalid file paths.\nMandalinaPOS E-posta İletişim :\nerdoganbilal@gmail.com\nGSM & WhatsApp No :\n+90 543 653 33 14", "Visual Stodio Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya parola eşleşmedi.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frm=new frmKullaniciKayit(new tblKullanicilar());
            frm.ShowDialog();
        }

        private void btnUnuttum_Click(object sender, EventArgs e)
        {
            frmParolamiUnuttum frm = new frmParolamiUnuttum();
            frm.ShowDialog();
        }
        public void PCBilgi()
        {
            try
            {
                // Anakart seri numarasını al
                string motherboardSerial = "";
                ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject info in motherboardSearcher.Get())
                {
                    motherboardSerial = info["SerialNumber"]?.ToString() ?? "MbSnNULL";
                    break; // İlk sonucu al ve çık
                }

                // İşlemci seri numarasını al
                string processorSerial = "";
                ManagementObjectSearcher processorSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject info in processorSearcher.Get())
                {
                    processorSerial = info["ProcessorId"]?.ToString() ?? "CpuSnNULL";
                    break; // İlk sonucu al ve çık
                }

                // Seri numaralarını MessageBox ile göster
                //string message = $"Anakart Seri Numarası: {motherboardSerial}\nİşlemci Seri Numarası: {processorSerial}";
                //MessageBox.Show(message, "Donanım Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PKimlik = $"{motherboardSerial}Ğ{processorSerial}";
                //MessageBox.Show(PKimlik,"bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            this.KeyPreview = true; 

        }

        private void frmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.M)
            {
                //PCBilgi();
                Properties.Settings.Default.ProgramKimlik = PKimlik;
                Properties.Settings.Default.Save();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            PCBilgi();
            
        }

        private void hyperlinkLabelControl1_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:"+hyperlinkLabelControl1.Text);
        }
    }
}