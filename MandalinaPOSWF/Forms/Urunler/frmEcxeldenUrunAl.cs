using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
    public partial class frmEcxeldenUrunAl : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();    
        public frmEcxeldenUrunAl()
        {
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Dosyası|*.xlsx|Excel Dosyası 97-2003|*.xls";
            ofd.Title = "Ürünlerin kayıtlı olduğu Excel dosyasını seçiniz...";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                OleDbConnection excelbaglan;
                excelbaglan= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ofd.FileName + "; Extended Properties='Excel 12.0 xml;HDR=YES'");
                excelbaglan.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [Sayfa1$]",excelbaglan);
                DataTable dt = new DataTable(); 
                adapter.Fill(dt);
                gridControl1.DataSource = dt;
                excelbaglan.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
            Cursor.Current = Cursors.WaitCursor;
            int urunsayisi = gridView1.RowCount;
            if (urunsayisi>0)
            {
                for (int i = 0; i < urunsayisi; i++)
                {
                    string barkodu = gridView1.GetRowCellValue(i, "Barkodu").ToString();
                    if (context.tblUrunler.Any(u=> u.Barkodu==barkodu))
                    {
                        var model=context.tblUrunler.FirstOrDefault(u=> u.Barkodu==barkodu);
                        model.AFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(i, "AFiyat").ToString());
                        model.SFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(i, "SFiyat").ToString());
                        model.FZaman = DateTime.Today;
                        context.SaveChanges();
                    }
                    else
                    {
                        tblUrunler u = new tblUrunler();   
                        u.Barkodu = gridView1.GetRowCellValue(i, "Barkodu").ToString();
                        u.Cinsi = gridView1.GetRowCellValue(i, "Cinsi").ToString();
                        u.Birim = "AD";
                        u.AFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(i, "AFiyat").ToString());
                        u.SFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(i, "SFiyat").ToString());
                        u.MarkaKimlik = 1;
                        u.GrupKimlik = 1;
                        u.HizliSatis = false;
                        u.FZaman = DateTime.Today;
                        u.HZaman = DateTime.Today;
                        u.Foto = $"Image\\resimyok.jpg";
                        context.tblUrunler.Add(u);
                        context.SaveChanges();

                    }
                }
            }
            Cursor.Current = Cursors.Default; 
            XtraMessageBox.Show("Veri alma / güncelleme işlemi tamamlandı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show("Bir hata oluştu"+Environment.NewLine+hata.ToString(),"Hata",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}