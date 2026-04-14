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
using DevExpress.Charts.Native;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraTab;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Interfaces;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.Forms.Odemeler;
using MandalinaPOSWF.Forms.RaporFormlari;
using MandalinaPOSWF.Forms.Urunler;
using MandalinaPOSWF.Raporlar;

namespace MandalinaPOSWF.Forms.CariHareketler
{
    public partial class frmHizliSatisFotoBtn : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context = new MandalinaContext();
        tblUrunlerDal tblUrunlerDal = new tblUrunlerDal();
        tblOdemeHareketleriDal tblOdemeHareketleriDal = new tblOdemeHareketleriDal();
        tblCariHareketlerDal tblCariHareketlerDal= new tblCariHareketlerDal();  
        private tblCariHareketler _entity;
        //private tblCariHareketlerDal tblCariHareketlerDal = new tblCariHareketlerDal();
        private tblCariKartlarDal tblCariKartlarDal = new tblCariKartlarDal();
        tblUrunHareketleriDal tblUrunHareketleriDal = new tblUrunHareketleriDal();

        public int _filter = 1;
        private int? _Kimlik = null;
        public bool kaydet = false;
        public frmHizliSatisFotoBtn(tblCariHareketler entity, int? kimlik = null)
        {
            InitializeComponent();
            //DOKUNMATİK MOD İÇİN AŞAĞIDAKİ KODU KULLANABLİRSİN
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            _Kimlik=kimlik;
            HSGrupGetir();
            context.tblUrunHareketleris.Where(h => h.CHKimlik == _Kimlik).Load();
            context.tblOdemeHareketleri.Where(o => o.CHKimlik == _Kimlik).Load();
            context.tblUrunler.Load();
            gridControlUrunler.DataSource = context.tblUrunHareketleris.Local.ToBindingList();
            gridControlOdemeler.DataSource = context.tblOdemeHareketleri.Local.ToBindingList();
            lookUpCariKimlik.Properties.DisplayMember = "Unvan";
            lookUpCariKimlik.Properties.ValueMember = "Kimlik";
            lookUpCariKimlik.Properties.DataSource = tblCariKartlarDal.GetAll(context);

            _entity = entity;
            txtKimlik.DataBindings.Add("Text", _entity, "Kimlik");
            txtBelgeNo.DataBindings.Add("Text", _entity, "BelgeNo");
            //txtUnvan.DataBindings.Add("Text", _entity, "Unvan");
            calcTutar.DataBindings.Add("EditValue", _entity, "Tutar");
            calcOdenen.DataBindings.Add("EditValue", _entity, "Odenen");
            calcKalan.DataBindings.Add("EditValue", _entity, "Kalan");
            dateTarihi.Text = _entity.Tarihi.ToString("dd.MM.yyyy");
            dateSonIslemTarihi.Text = _entity.SonIslemTarihi.ToString("dd.MM.yyyy");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            lookUpCariKimlik.DataBindings.Add("EditValue", _entity, "CariKimlik", true);
        }
        public void HSGrupGetir()
        {
            var mdlu = context.tblUrunler
                .Where(m => m.HizliSatis == true)
                .GroupBy(u => u.GrupKimlik)
                .Select(g => new { GrupID = g.Key, Count = g.Count() });

            var mdlg = mdlu.Join(context.tblGruplar, g => g.GrupID, c => c.Kimlik, (g, c) => new { kimlik = c.Kimlik, GAd = c.GrupAd, count = g.Count }).OrderBy(r => r.GAd).ToList();
            for (int b = 0; b < mdlg.Count; b++)
            {
                var page = new XtraTabPage();
                page.Text = mdlg[b].GAd.ToString();
                page.Name = mdlg[b].kimlik.ToString();
                xtraTabControl1.TabPages.Add(page);
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                page.Controls.Add(panel);
                _filter = mdlg[b].kimlik;
                var HSUrunleri = tblUrunlerDal.GetAll(context, u => u.HizliSatis && u.GrupKimlik == _filter);
                foreach (var urun in HSUrunleri)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Text = urun.Cinsi;
                    btn.Name = urun.Kimlik.ToString();
                    btn.Margin = new Padding(1, 1, 1, 1);
                    btn.Size = new Size(100, 125);
                    btn.Appearance.Font = new Font("Calibri", 8);
                    btn.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
                    btn.AutoWidthInLayoutControl = true;
                    //Size bestSize = btn.CalcBestSize();
                    //btn.Width = bestSize.Width;
                    //btn.Height = bestSize.Height;
                    btn.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
                    //btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    btn.ImageOptions.Location = ImageLocation.TopCenter;
                    var image = Image.FromFile(urun.Foto);
                    ımageList1.Images.Add(image);
                    btn.ImageList = ımageList1;
                    btn.Image = ımageList1.Images[0];
                    btn.Appearance.BackColor = Control.DefaultBackColor;
                    btn.BorderStyle = BorderStyles.NoBorder;

                    ımageList1.Images.RemoveAt(0);
                    panel.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var senderbtn = sender as SimpleButton;
            int _UrunKimlik = Convert.ToInt32(senderbtn.Name);
            var model = tblUrunlerDal.GetByFilter(context, u => u.Kimlik == _UrunKimlik);
            if (model != null)
            {
                tblUrunHareketleri entity = new tblUrunHareketleri
                {
                    CHKimlik = Convert.ToInt32(txtKimlik.Text),
                    UrunKimlik = Convert.ToInt32(senderbtn.Name),
                    Cinsi = model.Cinsi,
                    Barkodu = model.Barkodu,
                    Miktar = Convert.ToInt32(calcMiktar.Text),
                    BFiyat = model.SFiyat,
                    Tarihi = DateTime.Now
                };
                // Ürünün son satış zamanını güncelle
                var urunmodel =context.tblUrunler.FirstOrDefault (u=> u.Kimlik == _UrunKimlik);
                urunmodel.HZaman=DateTime.Now;

                if (tblUrunHareketleriDal.AddOrUpdate(context, entity))
                {
                    gridViewUrunler.RefreshData();
                    Hesapla();
                    calcMiktar.Text = "1";
                    txtBarkod.Text = "";
                    txtBarkod.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("Ürün satışa eklenemedi.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Hesapla()
        {
            calcTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcOdenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
            calcKalan.Value = calcTutar.Value - calcOdenen.Value;
        }
        private void btnOdemeler_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(calcKalan.Text) > 0)
            {
                var btn1 = sender as SimpleButton;
                frmOdeme frm = new frmOdeme(Convert.ToInt32(txtKimlik.Text), btn1.Text, Convert.ToDecimal(calcKalan.Text));
                frm.ShowDialog();
                if (frm.odemeKaydedildi)
                {
                    if (tblOdemeHareketleriDal.AddOrUpdate(context, frm.tblOdemeHareketleri))
                    {
                        gridViewOdemeler.RefreshData();
                        Hesapla();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Kalan bakiye yok. Ödeme alınamaz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtBarkod.Focus();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            //DOKUNMATİK MOD İÇİN AŞAĞIDAKİ KODU KULLANABLİRSİN
            //DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.Close();
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            frmUrunSec frm = new frmUrunSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                tblUrunHareketleri entity = new tblUrunHareketleri
                {
                    CHKimlik = Convert.ToInt32(txtKimlik.Text),
                    UrunKimlik = frm.urunModel.Kimlik,
                    Cinsi = frm.urunModel.Cinsi,
                    Barkodu = frm.urunModel.Barkodu,
                    Miktar = Convert.ToInt32(calcMiktar.Text),
                    BFiyat = frm.urunModel.SFiyat,
                    Tarihi = DateTime.Now

                };
                // Ürünün son satış zamanını güncelle
                var urunmodel = context.tblUrunler.FirstOrDefault(u => u.Kimlik == frm.urunModel.Kimlik);
                urunmodel.HZaman = DateTime.Now;
                if (tblUrunHareketleriDal.AddOrUpdate(context, entity))
                {
                    gridViewUrunler.RefreshData();
                    Hesapla();
                    calcMiktar.Text = "1";
                    txtBarkod.Text = "";
                    txtBarkod.Focus();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Satış kaydı ve bu kayda bağlı ödeme ve ürün hareketleri silinsin mi?", "Kayıt Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                tblOdemeHareketleriDal.Delete(context, o => o.CHKimlik == _Kimlik);
                tblUrunHareketleriDal.Delete(context, u => u.CHKimlik == _Kimlik);
                tblCariHareketlerDal.Delete(context, c => c.Kimlik == _Kimlik);
                tblOdemeHareketleriDal.Save(context);
                tblUrunHareketleriDal.Save(context);
                tblCariHareketlerDal.Save(context);
                DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
                this.Close();
            }
        }

        private void txtBarkod_Enter(object sender, EventArgs e)
        {
            txtBarkod.BackColor = Color.FromArgb(126, 255, 245);
        }

        private void txtBarkod_Leave(object sender, EventArgs e)
        {
            txtBarkod.BackColor = Color.White;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
            {
                if (calcKalan.Value != 0 && Convert.ToInt32(lookUpCariKimlik.EditValue) == 1)
                {
                    XtraMessageBox.Show("Perakende Satış hesbına veresiye satılamaz. Farklı bir cari kart seçmelisiniz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (_entity.Kimlik != 0)
                    {
                        _entity.SonIslemTarihi = DateTime.Now;
                        _entity.Tutar = Convert.ToDecimal(calcTutar.Text);
                        _entity.Odenen = Convert.ToDecimal(calcOdenen.Text);
                        _entity.Kalan = Convert.ToDecimal(calcKalan.Text);
                        _entity.Unvan = lookUpCariKimlik.Text;
                        _entity.CariKimlik = Convert.ToInt32(lookUpCariKimlik.EditValue);
                        tblCariHareketlerDal.Save(context);
                    }
                    if (tblCariHareketlerDal.AddOrUpdate(context, _entity))
                    {
                        tblCariHareketlerDal.Save(context);
                        context.SaveChanges();
                        kaydet = true;
                    }
                    context.SaveChanges();
                }
            }
            BilgiFisiniBaskıOnizle();

        }

        private void btnHizliYazdir_Click(object sender, EventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
            {
                if (calcKalan.Value != 0 && Convert.ToInt32(lookUpCariKimlik.EditValue) == 1)
                {
                    XtraMessageBox.Show("Perakende Satış hesbına veresiye satılamaz. Farklı bir cari kart seçmelisiniz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (_entity.Kimlik != 0)
                    {
                        _entity.SonIslemTarihi = DateTime.Now;
                        _entity.Tutar = Convert.ToDecimal(calcTutar.Text);
                        _entity.Odenen = Convert.ToDecimal(calcOdenen.Text);
                        _entity.Kalan = Convert.ToDecimal(calcKalan.Text);
                        _entity.Unvan = lookUpCariKimlik.Text;
                        _entity.CariKimlik = Convert.ToInt32(lookUpCariKimlik.EditValue);
                        tblCariHareketlerDal.Save(context);
                    }
                    if (tblCariHareketlerDal.AddOrUpdate(context, _entity))
                    {
                        tblCariHareketlerDal.Save(context);
                        context.SaveChanges();
                        kaydet = true;
                    }
                    context.SaveChanges();
                }
            }
            BilgiFisiniHizliYazdir();

        }

        private void gridViewOdemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnMikA_Click(object sender, EventArgs e)
        {
            calcMiktar.Text = Convert.ToString(Convert.ToInt32(calcMiktar.Text) + 1);
            txtBarkod.Focus();
        }

        private void btnMikE_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(calcMiktar.Text) > 1)
                calcMiktar.Text = Convert.ToString(Convert.ToInt32(calcMiktar.Text) - 1);
            txtBarkod.Focus();
        }

        private void calcMiktar_Validated(object sender, EventArgs e)
        {
            if (calcMiktar.Value <= 0)
            {
                XtraMessageBox.Show("Miktar sıfır veya sıfırdan küçük bir değer olamaz. Lütfen miktarı sıfırdan büyük bir değer giriniz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                calcMiktar.Focus();
            }
        }

        private void txtBarkod_Validated(object sender, EventArgs e)
        {
            if (txtBarkod.Text.Length > 0)
            {
                var Bmodel = tblUrunlerDal.GetByFilter(context, u => u.Barkodu == txtBarkod.Text);
                if (Bmodel != null)
                {
                    tblUrunHareketleri entity = new tblUrunHareketleri
                    {
                        CHKimlik = Convert.ToInt32(txtKimlik.Text),
                        UrunKimlik = Bmodel.Kimlik,
                        Cinsi = Bmodel.Cinsi,
                        Barkodu = Bmodel.Barkodu,
                        Miktar = Convert.ToInt32(calcMiktar.Text),
                        BFiyat = Bmodel.SFiyat,
                        Tarihi = DateTime.Now
                    };
                    // Ürünün son satış zamanını güncelle
                    var urunmodel = context.tblUrunler.FirstOrDefault(u => u.Kimlik == Bmodel.Kimlik);
                    urunmodel.HZaman = DateTime.Now;

                    if (tblUrunHareketleriDal.AddOrUpdate(context, entity))
                    {
                        gridViewUrunler.RefreshData();
                        Hesapla();
                    }
                }
                else
                {
                    XtraMessageBox.Show(txtBarkod.Text + " - barkod bilgisine sahip ürün bulunamadı.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarkod.Text = "";
                    txtBarkod.Focus();
                }
                calcMiktar.Text = "1";
                txtBarkod.Text = "";
                txtBarkod.Focus();

            }
        }

        private void gridViewUrunler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void repositoryOdemeSil_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Ödeme Hareketi silinecek emin msiniz.", "İkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOdemeler.DeleteSelectedRows();
                Hesapla();
                txtBarkod.Focus();
            }
        }

        private void repositoryUrunSil_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Ürün silinecek emin msiniz.", "İkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewUrunler.DeleteSelectedRows();
                Hesapla();
                txtBarkod.Focus();
            }
        }

        private void BilgiFisiniBaskıOnizle()
        {
            try
            {
                // Proje klasöründeki raporlar klasörüne giden yol
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string reportsFolder = Path.Combine(projectDirectory, "Raporlar");
                string reportPath = Path.Combine(reportsFolder, "rptPosFisi.repx");

                // Rapor dosyasının varlığını kontrol et
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Rapor dosyası bulunamadı: " + reportPath, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var fymodel = context.tblAyarlar.FirstOrDefault();
                if (fymodel != null)
                {
                    string _FisYazici = fymodel.FisYazici;
                    if (_FisYazici.Length > 0)
                    {
                        int CariKimlik = Convert.ToInt32(txtKimlik.Text);
                        XtraReport rapor = new XtraReport();
                        rapor.LoadLayout(reportPath);
                        rapor.FilterString = "[Kimlik]=" + CariKimlik;
                        ReportPrintTool printTool = new ReportPrintTool(rapor);
                        printTool.ShowPreviewDialog(); // Raporu önizleme olmadan yazdır
                    }
                    else
                    {
                        XtraMessageBox.Show("Program Ayarlarında Fiş yazıcı ayarlanmamış. Yönetici ile iletişim kurunuz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BilgiFisiniHizliYazdir()
        {
            try
            {
                // Proje klasöründeki raporlar klasörüne giden yol
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string reportsFolder = Path.Combine(projectDirectory, "Raporlar");
                string reportPath = Path.Combine(reportsFolder, "rptPosFisi.repx");

                // Rapor dosyasının varlığını kontrol et
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Rapor dosyası bulunamadı: " + reportPath, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var fymodel = context.tblAyarlar.FirstOrDefault();
                if (fymodel != null)
                {
                    string _FisYazici = fymodel.FisYazici;
                    if (_FisYazici.Length > 0)
                    {
                        int CariKimlik = Convert.ToInt32(txtKimlik.Text);
                        XtraReport rapor = new XtraReport();
                        rapor.LoadLayout(reportPath);
                        rapor.FilterString = "[Kimlik]=" + CariKimlik;
                        ReportPrintTool printTool = new ReportPrintTool(rapor);
                        printTool.Print(_FisYazici); // Raporu önizleme olmadan yazdır
                    }
                    else
                    {
                        XtraMessageBox.Show("Program Ayarlarında Fiş yazıcı ayarlanmamış. Yönetici ile iletişim kurunuz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHizliSatisFotoBtn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
            {
                // Kullanıcıya onay sor
                var result = XtraMessageBox.Show(
                    "Değişiklikler kaydedilmedi. Kaydetmek ister misiniz?",
                    "Kayıt Onayı",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //btnKaydet_Click(sender, e);
                    Hesapla();
                    if (calcKalan.Value != 0 && Convert.ToInt32(lookUpCariKimlik.EditValue) == 1)
                    {
                        XtraMessageBox.Show("Perakende Satış hesbına veresiye satılamaz. Farklı bir cari kart seçmelisiniz.", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Cancel = true;
                        return;
                    }
                    try
                    {
                        // Değişiklikleri kaydet
                        if (_entity.Kimlik != 0)
                        {
                            _entity.SonIslemTarihi = DateTime.Now;
                            _entity.Tutar = Convert.ToDecimal(calcTutar.Text);
                            _entity.Odenen = Convert.ToDecimal(calcOdenen.Text);
                            _entity.Kalan = Convert.ToDecimal(calcKalan.Text);
                            _entity.Unvan = lookUpCariKimlik.Text;
                            _entity.CariKimlik = Convert.ToInt32(lookUpCariKimlik.EditValue);
                            tblCariHareketlerDal.Save(context);
                        }
                        if (tblCariHareketlerDal.AddOrUpdate(context, _entity))
                        {
                            tblCariHareketlerDal.Save(context);
                            context.SaveChanges();
                            kaydet = true;
                        }
                        context.SaveChanges();
                        DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
                        MessageBox.Show("Değişiklikler kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fisyazmodel = context.tblAyarlar.FirstOrDefault();
                        if (fisyazmodel != null)
                        {
                            bool fisYaz = fisyazmodel.FisYazdir;
                            if (fisYaz)
                            {
                                BilgiFisiniHizliYazdir();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda kullanıcıyı bilgilendir
                        MessageBox.Show($"Kayıt sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // Kapanışı iptal et
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // Cancel seçilirse formun kapanmasını engelle
                    e.Cancel = true;
                    DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
                }
                else if (result == DialogResult.No)
                {
                    // No seçilirse hiçbir şey yapmadan kapanır
                    DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
                }
            }
            else
            {
                DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            }
        }

        private void btnHizliNakitTahsilat_Click(object sender, EventArgs e)
        {
            if (calcKalan.Value > 0)
            {
                var o = new tblOdemeHareketleri
                {
                    CHKimlik = Convert.ToInt32(txtKimlik.Text),
                    OdemeTuru = "Nakit",
                    Odenen = Convert.ToDecimal(calcKalan.Text),
                    Aciklama = "Nakit Tahsilat İşlemi",
                    Tarihi = DateTime.Now,
                };
                context.tblOdemeHareketleri.Add(o);
                context.SaveChanges();
                Hesapla();
                if (_entity.Kimlik != 0)
                {
                    _entity.SonIslemTarihi = DateTime.Now;
                    _entity.Tutar = Convert.ToDecimal(calcTutar.Text);
                    _entity.Odenen = Convert.ToDecimal(calcOdenen.Text);
                    _entity.Kalan = Convert.ToDecimal(calcKalan.Text);
                    _entity.Unvan = lookUpCariKimlik.Text;
                    _entity.CariKimlik = Convert.ToInt32(lookUpCariKimlik.EditValue);
                    tblCariHareketlerDal.Save(context);
                }
                if (tblCariHareketlerDal.AddOrUpdate(context, _entity))
                {
                    tblCariHareketlerDal.Save(context);
                    context.SaveChanges();
                    kaydet = true;
                }
                context.SaveChanges();
                this.Close();
                DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            }
            else
            {
                MessageBox.Show(
                    "Bakiye olmadığı için bu işlem gerçekleştirilemez.",
                    "İşlem Reddedildi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnHizliKrediKartiTahsilat_Click(object sender, EventArgs e)
        {
            if (calcKalan.Value > 0)
            {
                var o = new tblOdemeHareketleri
                {
                    CHKimlik = Convert.ToInt32(txtKimlik.Text),
                    OdemeTuru = "Kredi Kartı",
                    Odenen = Convert.ToDecimal(calcKalan.Text),
                    Aciklama = "Kredi Kartı Tahsilat İşlemi",
                    Tarihi = DateTime.Now,
                };
                context.tblOdemeHareketleri.Add(o);
                context.SaveChanges();
                Hesapla();
                if (_entity.Kimlik != 0)
                {
                    _entity.SonIslemTarihi = DateTime.Now;
                    _entity.Tutar = Convert.ToDecimal(calcTutar.Text);
                    _entity.Odenen = Convert.ToDecimal(calcOdenen.Text);
                    _entity.Kalan = Convert.ToDecimal(calcKalan.Text);
                    _entity.Unvan = lookUpCariKimlik.Text;
                    _entity.CariKimlik = Convert.ToInt32(lookUpCariKimlik.EditValue);
                    tblCariHareketlerDal.Save(context);
                }
                if (tblCariHareketlerDal.AddOrUpdate(context, _entity))
                {
                    tblCariHareketlerDal.Save(context);
                    context.SaveChanges();
                    kaydet = true;
                }
                context.SaveChanges();
                this.Close();
                DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            }
            else
            {
                MessageBox.Show(
                    "Bakiye olmadığı için bu işlem gerçekleştirilemez.",
                    "İşlem Reddedildi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    
    }
}