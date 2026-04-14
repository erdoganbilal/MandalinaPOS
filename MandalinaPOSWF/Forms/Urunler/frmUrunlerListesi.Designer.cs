namespace MandalinaPOSWF.Forms.Urunler
{
    partial class frmUrunlerListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunlerListesi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExport = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnWordExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfExport = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkaKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHizliSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExceldenAl = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 64);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ürünler Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnExceldenAl);
            this.groupControl1.Controls.Add(this.btnUrunHareketleri);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1408, 100);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.DropDownControl = this.popupMenu1;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(1165, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 57);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Ver";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfExport)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Caption = "Excel Dosyası (*.xlsx)";
            this.btnExcelExport.Id = 0;
            this.btnExcelExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.Image")));
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Tag = "Excel Dosyası (*.xlsx)|*.xlsx";
            this.btnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnWordExport
            // 
            this.btnWordExport.Caption = "Word Dosyası (*.docx)";
            this.btnWordExport.Id = 1;
            this.btnWordExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWordExport.ImageOptions.Image")));
            this.btnWordExport.Name = "btnWordExport";
            this.btnWordExport.Tag = "Word Dosyası (*.docx)|*.docx";
            this.btnWordExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.Caption = "PDF Dosyası(*.pdf)";
            this.btnPdfExport.Id = 2;
            this.btnPdfExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.ImageOptions.Image")));
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Tag = "PDF Dosyası(*.pdf)|*.pdf";
            this.btnPdfExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExcelExport,
            this.btnWordExport,
            this.btnPdfExport});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1408, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1408, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 754);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1408, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 754);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1266, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 57);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapa&t";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUrunHareketleri
            // 
            this.btnUrunHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunHareketleri.ImageOptions.Image")));
            this.btnUrunHareketleri.Location = new System.Drawing.Point(683, 31);
            this.btnUrunHareketleri.Name = "btnUrunHareketleri";
            this.btnUrunHareketleri.Size = new System.Drawing.Size(174, 57);
            this.btnUrunHareketleri.TabIndex = 0;
            this.btnUrunHareketleri.Text = "Ürün Hareketleri";
            this.btnUrunHareketleri.Click += new System.EventHandler(this.btnUrunHareketleri_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(547, 31);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 57);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "&Sil";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(411, 31);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(130, 57);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "&Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(275, 31);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 57);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yeni Ürün &Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1408, 654);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKimlik,
            this.colMarkaKimlik,
            this.colGrupKimlik,
            this.colBarkodu,
            this.colCinsi,
            this.colBirim,
            this.colAFiyat,
            this.colSFiyat,
            this.colHizliSatis,
            this.colFoto,
            this.colFZaman,
            this.colHZaman,
            this.colMarkaAdi,
            this.colGrupAd});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1148, 657, 321, 271);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colKimlik
            // 
            this.colKimlik.FieldName = "Kimlik";
            this.colKimlik.MinWidth = 25;
            this.colKimlik.Name = "colKimlik";
            this.colKimlik.OptionsColumn.AllowEdit = false;
            this.colKimlik.Visible = true;
            this.colKimlik.VisibleIndex = 0;
            this.colKimlik.Width = 64;
            // 
            // colMarkaKimlik
            // 
            this.colMarkaKimlik.Caption = "Markası";
            this.colMarkaKimlik.FieldName = "MarkaKimlik";
            this.colMarkaKimlik.MinWidth = 25;
            this.colMarkaKimlik.Name = "colMarkaKimlik";
            this.colMarkaKimlik.OptionsColumn.AllowEdit = false;
            this.colMarkaKimlik.Width = 121;
            // 
            // colGrupKimlik
            // 
            this.colGrupKimlik.FieldName = "GrupKimlik";
            this.colGrupKimlik.MinWidth = 25;
            this.colGrupKimlik.Name = "colGrupKimlik";
            this.colGrupKimlik.Width = 132;
            // 
            // colBarkodu
            // 
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.MinWidth = 25;
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 3;
            this.colBarkodu.Width = 127;
            // 
            // colCinsi
            // 
            this.colCinsi.FieldName = "Cinsi";
            this.colCinsi.MinWidth = 25;
            this.colCinsi.Name = "colCinsi";
            this.colCinsi.Visible = true;
            this.colCinsi.VisibleIndex = 4;
            this.colCinsi.Width = 363;
            // 
            // colBirim
            // 
            this.colBirim.FieldName = "Birim";
            this.colBirim.MinWidth = 25;
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 5;
            this.colBirim.Width = 53;
            // 
            // colAFiyat
            // 
            this.colAFiyat.Caption = "Alış Fiyatı";
            this.colAFiyat.FieldName = "AFiyat";
            this.colAFiyat.MinWidth = 25;
            this.colAFiyat.Name = "colAFiyat";
            this.colAFiyat.Visible = true;
            this.colAFiyat.VisibleIndex = 6;
            this.colAFiyat.Width = 85;
            // 
            // colSFiyat
            // 
            this.colSFiyat.Caption = "Satış Fiyatı";
            this.colSFiyat.FieldName = "SFiyat";
            this.colSFiyat.MinWidth = 25;
            this.colSFiyat.Name = "colSFiyat";
            this.colSFiyat.Visible = true;
            this.colSFiyat.VisibleIndex = 7;
            this.colSFiyat.Width = 79;
            // 
            // colHizliSatis
            // 
            this.colHizliSatis.Caption = "Hızlı Satış";
            this.colHizliSatis.FieldName = "HizliSatis";
            this.colHizliSatis.MinWidth = 25;
            this.colHizliSatis.Name = "colHizliSatis";
            this.colHizliSatis.Visible = true;
            this.colHizliSatis.VisibleIndex = 8;
            this.colHizliSatis.Width = 72;
            // 
            // colFoto
            // 
            this.colFoto.FieldName = "Foto";
            this.colFoto.MinWidth = 25;
            this.colFoto.Name = "colFoto";
            this.colFoto.OptionsColumn.AllowEdit = false;
            this.colFoto.Width = 94;
            // 
            // colFZaman
            // 
            this.colFZaman.Caption = "Son Fiyat Güncelleme";
            this.colFZaman.FieldName = "FZaman";
            this.colFZaman.MinWidth = 25;
            this.colFZaman.Name = "colFZaman";
            this.colFZaman.OptionsColumn.AllowEdit = false;
            this.colFZaman.Visible = true;
            this.colFZaman.VisibleIndex = 9;
            this.colFZaman.Width = 131;
            // 
            // colHZaman
            // 
            this.colHZaman.Caption = "Son Hareket Tarihi";
            this.colHZaman.FieldName = "HZaman";
            this.colHZaman.MinWidth = 25;
            this.colHZaman.Name = "colHZaman";
            this.colHZaman.OptionsColumn.AllowEdit = false;
            this.colHZaman.Visible = true;
            this.colHZaman.VisibleIndex = 10;
            this.colHZaman.Width = 119;
            // 
            // colMarkaAdi
            // 
            this.colMarkaAdi.Caption = "Markası";
            this.colMarkaAdi.FieldName = "MarkaAdi";
            this.colMarkaAdi.MinWidth = 25;
            this.colMarkaAdi.Name = "colMarkaAdi";
            this.colMarkaAdi.Visible = true;
            this.colMarkaAdi.VisibleIndex = 2;
            this.colMarkaAdi.Width = 117;
            // 
            // colGrupAd
            // 
            this.colGrupAd.Caption = "Grup Adı";
            this.colGrupAd.FieldName = "GrupAdi";
            this.colGrupAd.MinWidth = 25;
            this.colGrupAd.Name = "colGrupAd";
            this.colGrupAd.Visible = true;
            this.colGrupAd.VisibleIndex = 1;
            this.colGrupAd.Width = 168;
            // 
            // btnExceldenAl
            // 
            this.btnExceldenAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnExceldenAl.Location = new System.Drawing.Point(985, 31);
            this.btnExceldenAl.Name = "btnExceldenAl";
            this.btnExceldenAl.Size = new System.Drawing.Size(174, 57);
            this.btnExceldenAl.TabIndex = 0;
            this.btnExceldenAl.Text = "Excelden Ürün Alma";
            this.btnExceldenAl.Click += new System.EventHandler(this.btnExceldenAl_Click);
            // 
            // frmUrunlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 754);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmUrunlerListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürunler Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkaKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colAFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colSFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colFZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colHZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colHizliSatis;
        private DevExpress.XtraEditors.SimpleButton btnUrunHareketleri;
        private DevExpress.XtraEditors.DropDownButton btnExport;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnExcelExport;
        private DevExpress.XtraBars.BarButtonItem btnWordExport;
        private DevExpress.XtraBars.BarButtonItem btnPdfExport;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAd;
        private DevExpress.XtraEditors.SimpleButton btnExceldenAl;
    }
}