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
using System.Drawing.Printing;
using MandalinaPOS.Entities.Models;
using MandalinaPOS.Entities.DAL;

namespace MandalinaPOSWF.Forms.AnaMenu
{
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        tblAyarlarDal tblAyarlarDal = new tblAyarlarDal();
        tblAyarlar _entity;

        public frmAyarlar(tblAyarlar entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKimlik.DataBindings.Add("Text", _entity, "Kimlik");
            txtisletmeUnvan.DataBindings.Add("Text", _entity, "isletmeUnvan");
            txtisletmeAdres.DataBindings.Add("Text", _entity, "isletmeAdres");
            txtisletmeEposta.DataBindings.Add("Text", _entity, "isletmeEposta");
            txtisletmeTelefon.DataBindings.Add("Text", _entity, "isletmeTelefon");
            txtisletmeinstagram.DataBindings.Add("Text", _entity, "isletmeinstagram");
            txtisletmefacebook.DataBindings.Add("Text", _entity, "isletmefacebook");
            lookUpPrinter.DataBindings.Add("EditValue", _entity, "FisYazici");
            toggleFisYazdir.DataBindings.Add("EditValue", _entity, "FisYazdir");
            toggleDokunmatikMod.DataBindings.Add("EditValue", _entity, "DokunmatikMod");
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            
            // Yazıcı isimlerini tutmak için bir liste oluştur
            List<string> printers = new List<string>();

            // Sistemdeki tüm yazıcıları al
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printers.Add(printer);
            }

            // LookUpEdit'e veri kaynağını ata
            lookUpPrinter.Properties.DataSource = printers;
            lookUpPrinter.Properties.DisplayMember = null; // Yazıcı isimleri doğrudan string olduğu için
            lookUpPrinter.Properties.ValueMember = null;   // Değer de aynı string olacak
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tblAyarlarDal.AddOrUpdate(context, _entity))
            {
                tblAyarlarDal.Save(context);
                //Kaydet = true;
                this.Close();
            }
        }
    }
}