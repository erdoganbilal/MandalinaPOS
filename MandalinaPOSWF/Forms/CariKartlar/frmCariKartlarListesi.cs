using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.Forms.CariHareketler;

namespace MandalinaPOSWF.Forms.CariKartlar
{
    public partial class frmCariKartlarListesi : DevExpress.XtraEditors.XtraForm
    {
        private MandalinaContext context = new MandalinaContext();

        public frmCariKartlarListesi()
        {
            InitializeComponent();
            context.tblCariKartlar.Load();
            gridControl1.DataSource=context.tblCariKartlar.Local.ToBindingList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();    
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçili Cari Kart silinsin mi?", "İkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCariHareletListesi_Click(object sender, EventArgs e)
        {
            int? cKimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            frmCariHareketlerListesi frm=new frmCariHareketlerListesi(cKimlik);
            frm.ShowDialog();
        }
    }
}