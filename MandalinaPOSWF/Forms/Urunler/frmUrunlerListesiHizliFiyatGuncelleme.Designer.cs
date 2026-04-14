namespace MandalinaPOSWF.Forms.Urunler
{
    partial class frmUrunlerListesiHizliFiyatGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunlerListesiHizliFiyatGuncelleme));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditGruplar = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkaKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHizliSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGruplar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lookUpEditGruplar);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnUrunHareketleri);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1225, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İşlemler";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(526, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ürün Grubu :";
            // 
            // lookUpEditGruplar
            // 
            this.lookUpEditGruplar.Location = new System.Drawing.Point(526, 53);
            this.lookUpEditGruplar.Name = "lookUpEditGruplar";
            this.lookUpEditGruplar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGruplar.Size = new System.Drawing.Size(184, 22);
            this.lookUpEditGruplar.TabIndex = 5;
            this.lookUpEditGruplar.EditValueChanged += new System.EventHandler(this.lookUpEditGruplar_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(396, 64);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ürünler Listesi - Hızlı Fiyat Güncelleme";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1083, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 64);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapa&t";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUrunHareketleri
            // 
            this.btnUrunHareketleri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunHareketleri.ImageOptions.Image")));
            this.btnUrunHareketleri.Location = new System.Drawing.Point(826, 31);
            this.btnUrunHareketleri.Name = "btnUrunHareketleri";
            this.btnUrunHareketleri.Size = new System.Drawing.Size(251, 64);
            this.btnUrunHareketleri.TabIndex = 0;
            this.btnUrunHareketleri.Text = "Değişiklikleri Kaydet";
            this.btnUrunHareketleri.Click += new System.EventHandler(this.btnUrunHareketleri_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1225, 394);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKimlik,
            this.colMarkaKimlik,
            this.colBarkodu,
            this.colCinsi,
            this.colBirim,
            this.colAFiyat,
            this.colSFiyat,
            this.colHizliSatis,
            this.colFZaman,
            this.colHZaman,
            this.colGrup});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.FindNullPrompt = "Aranacak metni girin...";
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colKimlik
            // 
            this.colKimlik.FieldName = "Kimlik";
            this.colKimlik.MinWidth = 25;
            this.colKimlik.Name = "colKimlik";
            this.colKimlik.OptionsColumn.ReadOnly = true;
            this.colKimlik.Visible = true;
            this.colKimlik.VisibleIndex = 0;
            this.colKimlik.Width = 55;
            // 
            // colMarkaKimlik
            // 
            this.colMarkaKimlik.Caption = "Markası";
            this.colMarkaKimlik.FieldName = "MarkaKimlik";
            this.colMarkaKimlik.MinWidth = 25;
            this.colMarkaKimlik.Name = "colMarkaKimlik";
            this.colMarkaKimlik.OptionsColumn.ReadOnly = true;
            this.colMarkaKimlik.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.colMarkaKimlik.Width = 94;
            // 
            // colBarkodu
            // 
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.MinWidth = 25;
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.OptionsColumn.ReadOnly = true;
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 1;
            this.colBarkodu.Width = 89;
            // 
            // colCinsi
            // 
            this.colCinsi.FieldName = "Cinsi";
            this.colCinsi.MinWidth = 25;
            this.colCinsi.Name = "colCinsi";
            this.colCinsi.OptionsColumn.ReadOnly = true;
            this.colCinsi.Visible = true;
            this.colCinsi.VisibleIndex = 2;
            this.colCinsi.Width = 493;
            // 
            // colBirim
            // 
            this.colBirim.FieldName = "Birim";
            this.colBirim.MinWidth = 25;
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.ReadOnly = true;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            this.colBirim.Width = 35;
            // 
            // colAFiyat
            // 
            this.colAFiyat.FieldName = "AFiyat";
            this.colAFiyat.MinWidth = 25;
            this.colAFiyat.Name = "colAFiyat";
            this.colAFiyat.Visible = true;
            this.colAFiyat.VisibleIndex = 4;
            this.colAFiyat.Width = 74;
            // 
            // colSFiyat
            // 
            this.colSFiyat.FieldName = "SFiyat";
            this.colSFiyat.MinWidth = 25;
            this.colSFiyat.Name = "colSFiyat";
            this.colSFiyat.Visible = true;
            this.colSFiyat.VisibleIndex = 5;
            this.colSFiyat.Width = 88;
            // 
            // colHizliSatis
            // 
            this.colHizliSatis.FieldName = "HizliSatis";
            this.colHizliSatis.MinWidth = 25;
            this.colHizliSatis.Name = "colHizliSatis";
            this.colHizliSatis.Visible = true;
            this.colHizliSatis.VisibleIndex = 6;
            this.colHizliSatis.Width = 42;
            // 
            // colFZaman
            // 
            this.colFZaman.Caption = "Son Fiyat Güncelleme";
            this.colFZaman.FieldName = "FZaman";
            this.colFZaman.MinWidth = 25;
            this.colFZaman.Name = "colFZaman";
            this.colFZaman.OptionsColumn.AllowEdit = false;
            this.colFZaman.OptionsColumn.ReadOnly = true;
            this.colFZaman.Visible = true;
            this.colFZaman.VisibleIndex = 7;
            this.colFZaman.Width = 136;
            // 
            // colHZaman
            // 
            this.colHZaman.Caption = "Son Satış Tarihi";
            this.colHZaman.FieldName = "HZaman";
            this.colHZaman.MinWidth = 25;
            this.colHZaman.Name = "colHZaman";
            this.colHZaman.OptionsColumn.AllowEdit = false;
            this.colHZaman.OptionsColumn.ReadOnly = true;
            this.colHZaman.Visible = true;
            this.colHZaman.VisibleIndex = 8;
            this.colHZaman.Width = 183;
            // 
            // colGrup
            // 
            this.colGrup.Caption = "Grubu";
            this.colGrup.FieldName = "tblGruplar.Grup";
            this.colGrup.MinWidth = 25;
            this.colGrup.Name = "colGrup";
            this.colGrup.OptionsColumn.ReadOnly = true;
            this.colGrup.Width = 94;
            // 
            // frmUrunlerListesiHizliFiyatGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 494);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmUrunlerListesiHizliFiyatGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler Listesi Hızlı Fiyat Güncelleme";
            this.Load += new System.EventHandler(this.frmUrunlerListesiHizliFiyatGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGruplar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnUrunHareketleri;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colAFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colSFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colHizliSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colFZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colHZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkaKimlik;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditGruplar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}