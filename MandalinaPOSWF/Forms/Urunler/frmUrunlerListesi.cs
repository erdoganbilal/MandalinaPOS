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
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.Forms.UrunHareketleri;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace MandalinaPOSWF.Forms.Urunler
{
    public partial class frmUrunlerListesi : DevExpress.XtraEditors.XtraForm
    {
        private MandalinaContext context = new MandalinaContext();
        private tblUrunlerDal tblUrunlerDal=new tblUrunlerDal();
          
        public frmUrunlerListesi()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = tblUrunlerDal.UrunListele(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmUrunBilgi frm= new frmUrunBilgi(new tblUrunler());
            frm.ShowDialog();
            if (frm.Kaydet) 
            {  
                Listele(); 
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int SecilmisUrunKimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            if(SecilmisUrunKimlik>0)
            {
                frmUrunBilgi frm = new frmUrunBilgi(tblUrunlerDal.GetByFilter(context,u=>u.Kimlik==SecilmisUrunKimlik));
                frm.ShowDialog();
                if (frm.Kaydet)
                {
                    Listele();
                }

            }
            else
            {
                XtraMessageBox.Show("Listeden ürün seçilmemiş.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = e.Item.Tag.ToString();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (e.Item == btnExcelExport) { gridView1.ExportToXlsx(saveFileDialog.FileName); }
                else if (e.Item == btnWordExport) { gridView1.ExportToDocx(saveFileDialog.FileName); }
                else if (e.Item == btnPdfExport) { gridView1.ExportToPdf(saveFileDialog.FileName); }
            }
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUrunHareketleri_Click(object sender, EventArgs e)
        {
            int? urunkimlik= Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            if (urunkimlik>0)
            {
                frmUrunHareketleriListesi frm= new frmUrunHareketleriListesi(urunkimlik);
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Listeden ürün seçilmemiş.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExceldenAl_Click(object sender, EventArgs e)
        {
            frmEcxeldenUrunAl frm = new frmEcxeldenUrunAl();
            frm.ShowDialog();
            Listele();
        }
    }
}