using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.Models;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace MandalinaPOSWF.Forms.Ayarlar
{
    public partial class frmYedekAl : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();

        public frmYedekAl()
        {
            InitializeComponent();
            Server sunucuAdi=new Server();
            var model=context.Database.SqlQuery<Database>("select * from sys.databases").ToList();
            foreach (var item in model)
            {
                comboVT.Properties.Items.Add(item.Name);
            }
            txtSunucuAd.Text = ".\\SQLEXPRESS";
            comboVT.EditValue = "MandalinaPOS";
            txtKullaniciAd.Text = "sa";
            txtParola.Text = "masterkey";
            txtKonum.Text = "D:\\Yedek\\MandalinaPOS_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")+".bak";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            xtraSaveFileDialog1.Filter = "Yedekleme (Backup) Dosyaları (*.bak)|*.bak";
            xtraSaveFileDialog1.Title = "Yedeklenecek Konum";
            if (xtraSaveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtKonum.Text = xtraSaveFileDialog1.FileName;
            }
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {
            progressBarControl1.EditValue = 0;
            try
            {
                //Aynı isimde yedek dosyası varsa silinmesi için
                if (System.IO.File.Exists(txtKonum.Text))
                {
                    File.Delete(txtKonum.Text);
                }
                Server dbserver = new Server(new ServerConnection(txtSunucuAd.Text,txtKullaniciAd.Text,txtParola.Text));
                Backup dbBackup = new Backup();
                dbBackup.Action=BackupActionType.Database;
                dbBackup.Database = comboVT.Text;
                dbBackup.Devices.AddDevice(txtKonum.Text,DeviceType.File);
                dbBackup.Initialize=true;
                //Progresbar hesaplamasını burada yapıyoruz
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbserver);
                btnYedekAl.Enabled = false;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Hata :\n"+exception.Message,"İkaz",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnYedekAl.Enabled = true;
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                lblBilgi.Invoke((MethodInvoker)delegate
                {
                    lblBilgi.Text = e.Error.Message;
                });
            }
            XtraMessageBox.Show("Yedeklenen Dosya Bilgisi :\n"+txtKonum.Text+"\n" + "\n"+"Veritabanı yedekleme işlemi başarıyla tamamlandı.", "Yedek Alma Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarControl1.Invoke((MethodInvoker)delegate
            {
                progressBarControl1.EditValue = e.Percent;
                progressBarControl1.Update();
            });
        }
    }
}