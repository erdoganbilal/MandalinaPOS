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

namespace MandalinaPOSWF.Forms.Gruplar
{
    public partial class frmGruplarListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        public int YeniEklenenGrupKimlik { get; private set; } // Yeni Grubun kimlik bilgisini saklar
        public frmGruplarListesi()
        {
            InitializeComponent();
            context.tblGruplar.Load();
            gridControl1.DataSource= context.tblGruplar.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            gridView1.UpdateCurrentRow();
            context.SaveChanges();
            gridView1.RefreshData();
            YeniEklenenGrupKimlik = (int)gridView1.GetFocusedRowCellValue("Kimlik"); // Yeni grubun Kimlik bilgisini al
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Seçili ürün grubu silinsin mi?","İkaz",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGruplarListesi_Load(object sender, EventArgs e)
        {
            gridView1.MoveLast();
            gridView1.AddNewRow();
            gridView1.FocusedRowHandle = GridControl.NewItemRowHandle;
        }
    }
}