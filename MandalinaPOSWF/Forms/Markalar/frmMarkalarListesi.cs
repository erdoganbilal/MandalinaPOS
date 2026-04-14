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
using DevExpress.XtraGrid;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.Markalar
{
    public partial class frmMarkalarListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context = new MandalinaContext();
        public int YeniEklenenMarkaKimlik { get; private set; } // Yeni markanın ID'sini saklar
        public frmMarkalarListesi()
        {
            InitializeComponent();
            context.tblMarkalar.Load();
            gridControl1.DataSource = context.tblMarkalar.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            gridView1.UpdateCurrentRow();   
            context.SaveChanges();
            gridView1.RefreshData();
            YeniEklenenMarkaKimlik = (int)gridView1.GetFocusedRowCellValue("Kimlik"); // Yeni markanın Kimlik bilgisini al
            DialogResult = DialogResult.OK;
            Close();    
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçili ürün markası silinsin mi?", "İkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMarkalarListesi_Load(object sender, EventArgs e)
        {
            gridView1.MoveLast();
            gridView1.AddNewRow();  
            gridView1.FocusedRowHandle= GridControl.NewItemRowHandle;
        }
    }
}