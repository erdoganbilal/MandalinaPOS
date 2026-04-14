namespace MandalinaPOSWF.Forms.UrunHareketleri
{
    partial class frmUrunHareketleriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunHareketleriListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCariHareketler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblUrunler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1316, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1174, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 57);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapa&t";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(74, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(280, 64);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ürün Hareketleri Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1316, 631);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKimlik,
            this.colUnvan,
            this.colCHKimlik,
            this.colUrunKimlik,
            this.colBarkodu,
            this.colMiktar,
            this.colBFiyat,
            this.colTutar,
            this.colCinsi,
            this.colTarihi,
            this.coltblCariHareketler,
            this.coltblUrunler});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1051, 634, 326, 271);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colKimlik
            // 
            this.colKimlik.FieldName = "Kimlik";
            this.colKimlik.MinWidth = 25;
            this.colKimlik.Name = "colKimlik";
            this.colKimlik.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Kimlik", "Sayı={0}")});
            this.colKimlik.Visible = true;
            this.colKimlik.VisibleIndex = 0;
            this.colKimlik.Width = 93;
            // 
            // colUnvan
            // 
            this.colUnvan.Caption = "Ünvanı";
            this.colUnvan.FieldName = "tblCariHareketler.Unvan";
            this.colUnvan.MinWidth = 25;
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.Visible = true;
            this.colUnvan.VisibleIndex = 2;
            this.colUnvan.Width = 244;
            // 
            // colCHKimlik
            // 
            this.colCHKimlik.Caption = "Satış Kimlik";
            this.colCHKimlik.FieldName = "CHKimlik";
            this.colCHKimlik.MinWidth = 25;
            this.colCHKimlik.Name = "colCHKimlik";
            this.colCHKimlik.Visible = true;
            this.colCHKimlik.VisibleIndex = 1;
            this.colCHKimlik.Width = 90;
            // 
            // colUrunKimlik
            // 
            this.colUrunKimlik.FieldName = "UrunKimlik";
            this.colUrunKimlik.MinWidth = 25;
            this.colUrunKimlik.Name = "colUrunKimlik";
            this.colUrunKimlik.Width = 94;
            // 
            // colBarkodu
            // 
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.MinWidth = 25;
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 3;
            this.colBarkodu.Width = 128;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 5;
            this.colMiktar.Width = 53;
            // 
            // colBFiyat
            // 
            this.colBFiyat.Caption = "Fiyatı";
            this.colBFiyat.DisplayFormat.FormatString = "C2";
            this.colBFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBFiyat.FieldName = "BFiyat";
            this.colBFiyat.MinWidth = 25;
            this.colBFiyat.Name = "colBFiyat";
            this.colBFiyat.Visible = true;
            this.colBFiyat.VisibleIndex = 6;
            this.colBFiyat.Width = 93;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "colTutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colTutar", "Toplam={0:C2}")});
            this.colTutar.UnboundDataType = typeof(decimal);
            this.colTutar.UnboundExpression = "[Miktar] * [BFiyat]";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 7;
            this.colTutar.Width = 109;
            // 
            // colCinsi
            // 
            this.colCinsi.FieldName = "Cinsi";
            this.colCinsi.MinWidth = 25;
            this.colCinsi.Name = "colCinsi";
            this.colCinsi.Visible = true;
            this.colCinsi.VisibleIndex = 4;
            this.colCinsi.Width = 356;
            // 
            // colTarihi
            // 
            this.colTarihi.FieldName = "Tarihi";
            this.colTarihi.MinWidth = 25;
            this.colTarihi.Name = "colTarihi";
            this.colTarihi.Visible = true;
            this.colTarihi.VisibleIndex = 8;
            this.colTarihi.Width = 120;
            // 
            // coltblCariHareketler
            // 
            this.coltblCariHareketler.FieldName = "tblCariHareketler";
            this.coltblCariHareketler.MinWidth = 25;
            this.coltblCariHareketler.Name = "coltblCariHareketler";
            this.coltblCariHareketler.Width = 94;
            // 
            // coltblUrunler
            // 
            this.coltblUrunler.FieldName = "tblUrunler";
            this.coltblUrunler.MinWidth = 25;
            this.coltblUrunler.Name = "coltblUrunler";
            this.coltblUrunler.Width = 94;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // frmUrunHareketleriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 731);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmUrunHareketleriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürun Hareketleri Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colCHKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCariHareketler;
        private DevExpress.XtraGrid.Columns.GridColumn coltblUrunler;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
    }
}