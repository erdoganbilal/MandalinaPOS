namespace MandalinaPOSWF.Forms.Urunler
{
    partial class frmUrunSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunSec));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
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
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1191, 100);
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
            this.labelControl1.Size = new System.Drawing.Size(169, 64);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ürünler Listesi";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1049, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 57);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapa&t";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSec.Location = new System.Drawing.Point(913, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(130, 57);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1191, 517);
            this.gridControl1.TabIndex = 7;
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
            this.colMarka,
            this.colGrup,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colKimlik
            // 
            this.colKimlik.FieldName = "Kimlik";
            this.colKimlik.MinWidth = 25;
            this.colKimlik.Name = "colKimlik";
            this.colKimlik.Visible = true;
            this.colKimlik.VisibleIndex = 0;
            this.colKimlik.Width = 67;
            // 
            // colMarkaKimlik
            // 
            this.colMarkaKimlik.FieldName = "MarkaKimlik";
            this.colMarkaKimlik.MinWidth = 25;
            this.colMarkaKimlik.Name = "colMarkaKimlik";
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
            this.colBarkodu.VisibleIndex = 1;
            this.colBarkodu.Width = 145;
            // 
            // colCinsi
            // 
            this.colCinsi.FieldName = "Cinsi";
            this.colCinsi.MinWidth = 25;
            this.colCinsi.Name = "colCinsi";
            this.colCinsi.Visible = true;
            this.colCinsi.VisibleIndex = 2;
            this.colCinsi.Width = 405;
            // 
            // colBirim
            // 
            this.colBirim.FieldName = "Birim";
            this.colBirim.MinWidth = 25;
            this.colBirim.Name = "colBirim";
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            this.colBirim.Width = 63;
            // 
            // colAFiyat
            // 
            this.colAFiyat.Caption = "Alış Fiyatı";
            this.colAFiyat.FieldName = "AFiyat";
            this.colAFiyat.MinWidth = 25;
            this.colAFiyat.Name = "colAFiyat";
            this.colAFiyat.Visible = true;
            this.colAFiyat.VisibleIndex = 4;
            this.colAFiyat.Width = 101;
            // 
            // colSFiyat
            // 
            this.colSFiyat.Caption = "Satış Fiyatı";
            this.colSFiyat.FieldName = "SFiyat";
            this.colSFiyat.MinWidth = 25;
            this.colSFiyat.Name = "colSFiyat";
            this.colSFiyat.Visible = true;
            this.colSFiyat.VisibleIndex = 5;
            this.colSFiyat.Width = 86;
            // 
            // colHizliSatis
            // 
            this.colHizliSatis.Caption = "Hızlı Satış";
            this.colHizliSatis.FieldName = "HizliSatis";
            this.colHizliSatis.MinWidth = 25;
            this.colHizliSatis.Name = "colHizliSatis";
            this.colHizliSatis.Visible = true;
            this.colHizliSatis.VisibleIndex = 8;
            this.colHizliSatis.Width = 94;
            // 
            // colFoto
            // 
            this.colFoto.FieldName = "Foto";
            this.colFoto.MinWidth = 25;
            this.colFoto.Name = "colFoto";
            this.colFoto.Width = 94;
            // 
            // colFZaman
            // 
            this.colFZaman.Caption = "Son Fiyat Güncelleme";
            this.colFZaman.FieldName = "FZaman";
            this.colFZaman.MinWidth = 25;
            this.colFZaman.Name = "colFZaman";
            this.colFZaman.Visible = true;
            this.colFZaman.VisibleIndex = 9;
            this.colFZaman.Width = 135;
            // 
            // colHZaman
            // 
            this.colHZaman.Caption = "Son Hareket Tarihi";
            this.colHZaman.FieldName = "HZaman";
            this.colHZaman.MinWidth = 25;
            this.colHZaman.Name = "colHZaman";
            this.colHZaman.Visible = true;
            this.colHZaman.VisibleIndex = 10;
            this.colHZaman.Width = 138;
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Markası";
            this.colMarka.FieldName = "MarkaAdi";
            this.colMarka.MinWidth = 25;
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 6;
            this.colMarka.Width = 80;
            // 
            // colGrup
            // 
            this.colGrup.Caption = "Ürün Grubu";
            this.colGrup.FieldName = "GrupAdi";
            this.colGrup.MinWidth = 25;
            this.colGrup.Name = "colGrup";
            this.colGrup.Visible = true;
            this.colGrup.VisibleIndex = 7;
            this.colGrup.Width = 158;
            // 
            // gridColumn1
            // 
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // frmUrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 617);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmUrunSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUrunSec";
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
        private DevExpress.XtraEditors.SimpleButton btnSec;
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
        private DevExpress.XtraGrid.Columns.GridColumn colHizliSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colFZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colHZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colGrup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}