using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using Microsoft.SqlServer.Management.Sdk.Sfc;


namespace MandalinaPOSWF.Forms.Urunler
{
    public partial class frmUrunlerListesiHizliFiyatGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context = new MandalinaContext();
        tblUrunler tblUrunler = new tblUrunler();
        private tblMarkalar tblMarkalar = new tblMarkalar();

        public frmUrunlerListesiHizliFiyatGuncelleme()
        {
            InitializeComponent();
            
            //var model = context.tblUrunler
            //    .Include(u=> u.tblMarkalar)
            //    .Select(u=> new
            //    {
            //        u.Kimlik,
            //        u.Cinsi,
            //        u.Birim,
            //        u.MarkaKimlik,
            //        u.GrupKimlik,
            //        u.AFiyat,
            //        u.SFiyat,
            //        u.Barkodu,
            //        u.FZaman,   
            //        u.HZaman
            //    }).ToList();   
            //gridControl1.DataSource = model;
            //gridView1.OptionsBehavior.Editable = true; // Düzenlemeyi etkinleştir
            //gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True; // Çift tıklama ile düzenleme
            //RepositoryItemSpinEdit spinEdit = new RepositoryItemSpinEdit();
            //spinEdit.MinValue = 0;
            //spinEdit.MaxValue = 100000;
            //gridControl1.RepositoryItems.Add(spinEdit);
            //gridView1.Columns["SFiyat"].ColumnEdit = spinEdit;
        }


        private void UrunleriGetir(int? grupKimlik = null)
        {
            //using (var context = new MandalinaContext())
            //{
                // Ürünleri sorgulama
                var urunler = context.tblUrunler.AsQueryable();

                // Grup kimliğine göre filtreleme
                if (grupKimlik.HasValue && grupKimlik != -1)
                {
                    urunler = urunler.Where(u => u.GrupKimlik == grupKimlik);
                }

                // GridControl'e veri bağlama
                gridControl1.DataSource = urunler.ToList();
            //}
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUrunlerListesiHizliFiyatGuncelleme_Load(object sender, EventArgs e)
        {
            using (var context = new MandalinaContext())
            {
                // Gruplar tablosundan veri çekme
                var gruplar = context.tblGruplar
                    .Select(g => new { Kimlik = g.Kimlik, GrupAdi = g.GrupAd })
                    .ToList();

                // "Tüm Gruplar" seçeneğini ekleme
                var tumGruplar = new { Kimlik = -1, GrupAdi = "Tüm Gruplar" };
                gruplar.Insert(0, tumGruplar);

                // LookUpEdit ayarları
                lookUpEditGruplar.Properties.DataSource = gruplar;
                lookUpEditGruplar.Properties.DisplayMember = "GrupAdi";
                lookUpEditGruplar.Properties.ValueMember = "Kimlik";
                lookUpEditGruplar.Properties.NullText = "Bir grup seçin";
            }
            UrunleriGetir();
            gridView1.OptionsFind.AlwaysVisible = true;
        }

        private void lookUpEditGruplar_EditValueChanged(object sender, EventArgs e)
        {
            // Seçilen grup kimliğini al
            var secilenGrupKimlik = lookUpEditGruplar.EditValue as int?;

            // Ürünleri yükle
            UrunleriGetir(secilenGrupKimlik);
        }

        private void btnUrunHareketleri_Click(object sender, EventArgs e)
        {
            context.SaveChanges();  
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SFiyat")
            {
                var row = gridView1.GetRow(e.RowHandle) as tblUrunler;
                if (row != null)
                {
                    row.FZaman = DateTime.Now;
                }
            }
        }
    }
}