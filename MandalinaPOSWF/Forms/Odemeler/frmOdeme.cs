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
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.Odemeler
{
    public partial class frmOdeme : DevExpress.XtraEditors.XtraForm
    {
        private int _CHKimlik;
        private string _OdemeTuru;
        private decimal _kalantutar;
        public tblOdemeHareketleri tblOdemeHareketleri;
        public bool odemeKaydedildi;
        public frmOdeme(int chkimlik, string odemeturu, decimal kalantutar)
        {
            InitializeComponent();
            _CHKimlik = chkimlik;   
            _OdemeTuru = odemeturu;
            _kalantutar = kalantutar;
            if(_OdemeTuru=="Nakit")
            {
                lblBanner.Text = "Nakit Ödeme İşlemi";
            }
            else if(_OdemeTuru=="Kredi Kartı")
            {
                lblBanner.Text = "Kredi Kartı ile Ödeme İşlemi";
            }
            calcOdenenTutar.Text = _kalantutar.ToString();
            dateTarihi.EditValue=DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            tblOdemeHareketleri = new tblOdemeHareketleri
            {
                CHKimlik = _CHKimlik,
                OdemeTuru = _OdemeTuru,
                Odenen = Convert.ToDecimal(calcOdenenTutar.Text),
                Aciklama = txtAciklama.Text,
                Tarihi =Convert.ToDateTime(dateTarihi.EditValue)
            };
            odemeKaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}