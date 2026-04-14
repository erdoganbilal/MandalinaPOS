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
using DevExpress.XtraGrid.Views.Grid;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.Forms.Odemeler;
using MandalinaPOSWF.WinTools;

namespace MandalinaPOSWF.Forms.CariHareketler
{
    public partial class frmCariHareketlerListesi : DevExpress.XtraEditors.XtraForm
    {
        private MandalinaContext context=new MandalinaContext();
        private tblCariHareketlerDal tblCariHareketlerDal=new tblCariHareketlerDal();
        tblOdemeHareketleriDal tblOdemeHareketleriDal=new tblOdemeHareketleriDal();
        tblUrunHareketleriDal tblUrunHareketleriDal = new tblUrunHareketleriDal();
        private int kimlik;
        private int? _cKimlik;
        public frmCariHareketlerListesi(int? cKimlik=null)
        {
            InitializeComponent();
            _cKimlik = cKimlik;
            if (_cKimlik != null)
            {
                gridControl1.DataSource = tblCariHareketlerDal.GetAll(context, h => h.CariKimlik == _cKimlik)
                    .OrderByDescending(x=> x.Tarihi)
                    .ToList();
                btnEkleAc.Enabled = false;  
                btnDuzenle.Enabled = false;
                return;
            }
            else Listele();

        }

        private void Listele()
        {
            gridControl1.DataSource = tblCariHareketlerDal.GetAll(context)
                .OrderByDescending(x => x.Tarihi)
                .ToList(); 
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int SeciliKimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            kimlik=SeciliKimlik;
            var CariHareket= tblCariHareketlerDal.GetByFilter(context,c=>c.Kimlik==SeciliKimlik);

            var DMmodel = context.tblAyarlar.FirstOrDefault();
            if (DMmodel != null)
            {
                bool dmod = DMmodel.DokunmatikMod;
                if (dmod)
                {
                    frmHizliSatisFotoBtn frm1 = new frmHizliSatisFotoBtn(CariHareket,kimlik);
                    frm1.ShowDialog();
                }
                else
                {
                    frmHizliSatis frm = new frmHizliSatis(CariHareket,kimlik);
                    frm.ShowDialog();
                }
            }
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliKimlik=Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            if(XtraMessageBox.Show("Seçili satış hareketi ve bu satışa bağlı tüm ödeme ve ürün hareketleri silinsin mi?", "İkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                tblOdemeHareketleriDal.Delete(context, o=> o.CHKimlik == seciliKimlik);
                tblUrunHareketleriDal.Delete(context, u=> u.CHKimlik == seciliKimlik);
                tblCariHareketlerDal.Delete(context, c=> c.Kimlik == seciliKimlik);
                tblOdemeHareketleriDal.Save(context);
                tblUrunHareketleriDal.Save(context);
                tblCariHareketlerDal.Save(context);
                Listele();  
            }
        }

        private void btnKilitAc_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int SeciliKimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
                var CariHareket = tblCariHareketlerDal.GetByFilter(context, c => c.Kimlik == SeciliKimlik);
                if (CariHareket.Durumu)
                {
                    CariHareket.Durumu = false;
                }
                else if (!CariHareket.Durumu)
                {
                    CariHareket.Durumu = true;
                }
                tblCariHareketlerDal.Save(context);
                Listele();
            }
        }

        private void btnEkleAc_Click(object sender, EventArgs e)
        {
            var t = new tblCariHareketler
            {
                Unvan = "PERAKENDE SATIŞ",
                BelgeNo="PS001",
                Tutar=0,
                Odenen=0,
                Kalan=0,
                Tarihi=DateTime.Now,    
                SonIslemTarihi=DateTime.Now,    
                KullaniciKimlik=KullaniciAyarlari.KulKimlik,
                Durumu=false,
                CariKimlik=1,
            };
            context.tblCariHareketler.Add(t);
            context.SaveChanges();
            Listele();

            var row = context.tblCariHareketler.OrderByDescending(x => x.Kimlik).FirstOrDefault();
            
            //int SeciliKimlik = Convert.ToInt32(row.Kimlik.ToString());
            //XtraMessageBox.Show(SeciliKimlik.ToString());
            //kimlik = SeciliKimlik;
            var CariHareket = tblCariHareketlerDal.GetByFilter(context, c => c.Kimlik == row.Kimlik);

            var DMmodel = context.tblAyarlar.FirstOrDefault();
            if (DMmodel != null)
            {
                bool dmod = DMmodel.DokunmatikMod;
                if (dmod)
                {
                    frmHizliSatisFotoBtn frm1 = new frmHizliSatisFotoBtn(CariHareket);
                    frm1.ShowDialog();
                }
                else
                {
                    frmHizliSatis frm = new frmHizliSatis(CariHareket);
                    frm.ShowDialog();
                }
            }
                Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int chkimlik =Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik).ToString());
            frmOdemelerListesi frm= new frmOdemelerListesi(chkimlik);
            frm.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle) return;
            if (e.Column.FieldName != "Kalan") return;
            if(Convert.ToInt32(e.CellValue) > 0)
            {
                e.Appearance.BackColor = Color.FromArgb(60,Color.Salmon);
            }
        }

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter=e.Item.Tag.ToString();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (e.Item == btnExcelExport) { gridView1.ExportToXlsx(saveFileDialog.FileName); }
                else if (e.Item == btnWordExport) { gridView1.ExportToDocx(saveFileDialog.FileName); }
                else if (e.Item == btnPdfExport) { gridView1.ExportToPdf(saveFileDialog.FileName); }
            }
        }

        private void btnSatisAc_Click(object sender, EventArgs e)
        {
        }
    }
}