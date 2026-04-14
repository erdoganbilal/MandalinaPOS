namespace MandalinaPOSWF.Forms.Kullanicilar
{
    partial class frmKullanicilarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilarListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullaniciRolleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullaniciHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblKullaniciHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTblCariHareketler = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKullaniciRolleri);
            this.groupControl1.Controls.Add(this.btnKullaniciHareketleri);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1112, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İşlemler";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 64);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Kullanıcılar Listesi";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(970, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 57);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapa&t";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKullaniciRolleri
            // 
            this.btnKullaniciRolleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciRolleri.ImageOptions.Image")));
            this.btnKullaniciRolleri.Location = new System.Drawing.Point(610, 31);
            this.btnKullaniciRolleri.Name = "btnKullaniciRolleri";
            this.btnKullaniciRolleri.Size = new System.Drawing.Size(174, 57);
            this.btnKullaniciRolleri.TabIndex = 2;
            this.btnKullaniciRolleri.Text = "Kullanıcı Yetkileri";
            this.btnKullaniciRolleri.Click += new System.EventHandler(this.btnKullaniciRolleri_Click);
            // 
            // btnKullaniciHareketleri
            // 
            this.btnKullaniciHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.Image")));
            this.btnKullaniciHareketleri.Location = new System.Drawing.Point(790, 31);
            this.btnKullaniciHareketleri.Name = "btnKullaniciHareketleri";
            this.btnKullaniciHareketleri.Size = new System.Drawing.Size(174, 57);
            this.btnKullaniciHareketleri.TabIndex = 3;
            this.btnKullaniciHareketleri.Text = "Kullanıcı Hareketleri";
            this.btnKullaniciHareketleri.Click += new System.EventHandler(this.btnKullaniciHareketleri_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(411, 31);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(130, 57);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "&Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(261, 31);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 57);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yeni Kullanıcı &Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1112, 417);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKimlik,
            this.colAdSoyad,
            this.colTelefon,
            this.colAdres,
            this.colEposta,
            this.colGorevi,
            this.colKullaniciAdi,
            this.colParola,
            this.colHatirlatmaSorusu,
            this.colCevap,
            this.colTarih,
            this.colDurumu,
            this.colAdmin,
            this.coltblKullaniciHareketleri,
            this.colTblCariHareketler});
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
            this.colKimlik.Width = 51;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.MinWidth = 25;
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.OptionsColumn.AllowEdit = false;
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 1;
            this.colAdSoyad.Width = 120;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.MinWidth = 25;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 2;
            this.colTelefon.Width = 105;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.MinWidth = 25;
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Width = 66;
            // 
            // colEposta
            // 
            this.colEposta.FieldName = "Eposta";
            this.colEposta.MinWidth = 25;
            this.colEposta.Name = "colEposta";
            this.colEposta.OptionsColumn.AllowEdit = false;
            this.colEposta.Visible = true;
            this.colEposta.VisibleIndex = 3;
            this.colEposta.Width = 121;
            // 
            // colGorevi
            // 
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.MinWidth = 25;
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.OptionsColumn.AllowEdit = false;
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 4;
            this.colGorevi.Width = 88;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.MinWidth = 25;
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 5;
            this.colKullaniciAdi.Width = 89;
            // 
            // colParola
            // 
            this.colParola.FieldName = "Parola";
            this.colParola.MinWidth = 25;
            this.colParola.Name = "colParola";
            this.colParola.OptionsColumn.AllowEdit = false;
            this.colParola.Visible = true;
            this.colParola.VisibleIndex = 6;
            this.colParola.Width = 77;
            // 
            // colHatirlatmaSorusu
            // 
            this.colHatirlatmaSorusu.FieldName = "HatirlatmaSorusu";
            this.colHatirlatmaSorusu.MinWidth = 25;
            this.colHatirlatmaSorusu.Name = "colHatirlatmaSorusu";
            this.colHatirlatmaSorusu.OptionsColumn.AllowEdit = false;
            this.colHatirlatmaSorusu.Width = 55;
            // 
            // colCevap
            // 
            this.colCevap.FieldName = "Cevap";
            this.colCevap.MinWidth = 25;
            this.colCevap.Name = "colCevap";
            this.colCevap.OptionsColumn.AllowEdit = false;
            this.colCevap.Width = 55;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 7;
            this.colTarih.Width = 55;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.MinWidth = 25;
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 8;
            this.colDurumu.Width = 55;
            // 
            // colAdmin
            // 
            this.colAdmin.FieldName = "Admin";
            this.colAdmin.MinWidth = 25;
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.OptionsColumn.AllowEdit = false;
            this.colAdmin.Visible = true;
            this.colAdmin.VisibleIndex = 9;
            this.colAdmin.Width = 55;
            // 
            // coltblKullaniciHareketleri
            // 
            this.coltblKullaniciHareketleri.FieldName = "tblKullaniciHareketleri";
            this.coltblKullaniciHareketleri.MinWidth = 25;
            this.coltblKullaniciHareketleri.Name = "coltblKullaniciHareketleri";
            this.coltblKullaniciHareketleri.OptionsColumn.AllowEdit = false;
            this.coltblKullaniciHareketleri.Width = 55;
            // 
            // colTblCariHareketler
            // 
            this.colTblCariHareketler.FieldName = "TblCariHareketler";
            this.colTblCariHareketler.MinWidth = 25;
            this.colTblCariHareketler.Name = "colTblCariHareketler";
            this.colTblCariHareketler.OptionsColumn.AllowEdit = false;
            this.colTblCariHareketler.Width = 101;
            // 
            // frmKullanicilarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 517);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKullanicilarListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colEposta;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaSorusu;
        private DevExpress.XtraGrid.Columns.GridColumn colCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn coltblKullaniciHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colTblCariHareketler;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciRolleri;
    }
}