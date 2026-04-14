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

namespace MandalinaPOSWF.Forms.Urunler
{
    public partial class frmUrunSec : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        tblUrunlerDal tblUrunlerDal = new tblUrunlerDal();
        public tblUrunler urunModel;
        public bool secildi;
        public frmUrunSec()
        {
            InitializeComponent();
            gridControl1.DataSource = tblUrunlerDal.UrunListele(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)      // Eğer seçilen bir satır var ise
            {
                int urunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
                urunModel = tblUrunlerDal.GetByFilter(context, u => u.Kimlik == urunId);
                secildi = true;
                this.Close(); 
            }
        }
    }
}