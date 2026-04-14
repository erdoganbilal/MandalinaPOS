using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.Forms.Gruplar;
using MandalinaPOSWF.Forms.Markalar;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace MandalinaPOSWF.Forms.Urunler
{
    public partial class frmUrunBilgi : DevExpress.XtraEditors.XtraForm
    {
        private MandalinaContext _context = new MandalinaContext();
        private tblGruplarDal tblGruplarDal = new tblGruplarDal();
        private tblMarkalarDal tblMarkalarDal = new tblMarkalarDal();

        private tblUrunlerDal tblUrunlerDal = new tblUrunlerDal();
        private tblUrunler _entity;
        public bool Kaydet = false;
        public frmUrunBilgi(tblUrunler entity)
        {
            InitializeComponent();
            MarkalarLookUpEditButonEkle();
            GruplarLookUpEditButonEkle();

            _entity = entity;
            lookUpGrupAd.Properties.DataSource = tblGruplarDal.GetAll(_context);
            lookUpMarka.Properties.DataSource = tblMarkalarDal.GetAll(_context);
            var birimler = new[] { "AD", "KG", "LT", "KT", "KL" };
            lookUpBirim.Properties.DataSource = birimler;

            txtKimlik.DataBindings.Add("Text", _entity, "Kimlik");
            txtBarkodu.DataBindings.Add("Text", _entity, "Barkodu");
            txtCinsi.DataBindings.Add("Text", _entity, "Cinsi");
            lookUpBirim.DataBindings.Add("EditValue", _entity, "Birim");
            lookUpGrupAd.DataBindings.Add("EditValue", _entity, "GrupKimlik");
            lookUpMarka.DataBindings.Add("EditValue", _entity, "MarkaKimlik");
            toggleHizliSatis.DataBindings.Add("EditValue", _entity, "HizliSatis");
            calcAFiyat.DataBindings.Add("Text", _entity, "AFiyat", true);
            calcSFiyat.DataBindings.Add("Text", _entity, "SFiyat", true);
            dateFZaman.DataBindings.Add("Text", _entity, "FZaman", true);
            dateHZaman.DataBindings.Add("Text", _entity, "HZaman", true);

            if (_entity.Kimlik != 0)
            {
                if (_entity.Foto != null)
                {
                    try
                    {
                        pictureFoto.Image = Image.FromFile(_entity.Foto);
                    }
                    catch (Exception e)
                    {
                        XtraMessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GruplarLookUpEditButonEkle()
        {
            // Özel buton ekleme
            EditorButton customButton = new EditorButton
            {
                Kind = ButtonPredefines.Glyph, // Buton türü (Glyph, OK, Cancel vb.)
                Caption = "...", // Buton üzerinde görünecek metin
                ToolTip = "Yeni Grup Ekle", // Butonun tooltip'i
                Width = 25 // Buton genişliği
            };

            // Butonu LookUpEdit'e ekleme
            lookUpGrupAd.Properties.Buttons.Add(customButton);

            // Buton tıklama olayını bağlama
            lookUpGrupAd.ButtonClick += LookUpGrupAd_ButtonClick;
        }

        private void LookUpGrupAd_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            // Hangi butona tıklandığını kontrol etme (birden fazla buton olabilir)
            if (e.Button.Caption == "...")
            {
                // Grup Ekleme için form açma
                frmGruplarListesi frm = new frmGruplarListesi();
                frm.ShowDialog(); // Modal olarak açar, Show() ile modalsiz açabilirsiniz
                if (frm.DialogResult == DialogResult.OK)
                {
                    
                    lookUpGrupAd.Properties.DataSource = tblGruplarDal.GetAll(_context);
                    int yeniGrupKimlik = frm.YeniEklenenGrupKimlik;
                    lookUpGrupAd.EditValue = yeniGrupKimlik;
                }

            }
        }

        private void MarkalarLookUpEditButonEkle()
        {
            // Özel buton ekleme
            EditorButton customButton = new EditorButton
            {
                Kind = ButtonPredefines.Glyph, // Buton türü (Glyph, OK, Cancel vb.)
                Caption = "...", // Buton üzerinde görünecek metin
                ToolTip = "Yeni Marka Ekle", // Butonun tooltip'i
                Width = 25 // Buton genişliği
            };

            // Butonu LookUpEdit'e ekleme
            lookUpMarka.Properties.Buttons.Add(customButton);

            // Buton tıklama olayını bağlama
            lookUpMarka.ButtonClick += LookUpMarka_ButtonClick1;
        }

        private void LookUpMarka_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            // Hangi butona tıklandığını kontrol etme (birden fazla buton olabilir)
            if (e.Button.Caption == "...")
            {
                // Marka Ekleme için form açma
                frmMarkalarListesi frm = new frmMarkalarListesi();
                frm.ShowDialog(); // Modal olarak açar, Show() ile modalsiz açabilirsiniz
                if (frm.DialogResult == DialogResult.OK)
                {
                    //lookUpMarka.Properties.ForceInitialize(); //Listeyi yenile
                    lookUpMarka.Properties.DataSource = tblMarkalarDal.GetAll(_context);
                    // Örneğin, MarkalarForm'dan yeni eklenen MarkaId'yi döndür
                    int yeniMarkaKimlik = frm.YeniEklenenMarkaKimlik;
                    lookUpMarka.EditValue = yeniMarkaKimlik;
                }

            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pictureFoto.GetLoadedImageLocation() != "")
            {
                string FotoHedef = $"{Application.StartupPath}\\Image\\{txtBarkodu.Text}-{txtCinsi.Text}.jpg";
                if (File.Exists(FotoHedef))
                {
                    File.Delete(FotoHedef);
                }
                File.Copy(pictureFoto.GetLoadedImageLocation(), FotoHedef);
                _entity.Foto = $"Image\\{txtBarkodu.Text}-{txtCinsi.Text}.jpg";
            }
            //if (pictureFoto.GetLoadedImageLocation() == null)
            else
            {
                _entity.Foto = $"Image\\resimyok.jpg";
            }


            if (tblUrunlerDal.AddOrUpdate(_context, _entity))
            {
                tblUrunlerDal.Save(_context);
                _context.SaveChanges();
                Kaydet = true;
                this.Close();
            }
        }
        private void txtBarkodu_Validating(object sender, CancelEventArgs e)
        {
            string barkodu = txtBarkodu.Text.Trim();
            if (!string.IsNullOrEmpty(barkodu))
            {
                bool exists = _context.tblUrunler.Any(u => u.Barkodu == barkodu && u.Kimlik!= _entity.Kimlik);
                //bool exists = _context.tblUrunler.Any(u => u.Barkodu == barkodu && u.Id != mevcutUrunId);
                if (exists)
                {
                    XtraMessageBox.Show("Bu barkod zaten kayıtlı.", "Uyarı: Mükerrer Barkod", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
        private void calcSFiyat_Validated(object sender, EventArgs e)
        {
            dateFZaman.Text = DateTime.Now.ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // DbContext üzerindeki tüm değişiklikleri geri al
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.State = EntityState.Unchanged; // Değişiklikleri geri al
                }
                else if (entry.State == EntityState.Added)
                {
                    entry.State = EntityState.Detached; // Yeni eklenenleri kaldır
                }
                // Silinen kayıtlar için: entry.State = EntityState.Unchanged;               
            }
            // Formu kapat
            this.Close();
        }
    }
}