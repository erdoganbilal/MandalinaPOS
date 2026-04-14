namespace MandalinaPOSWF.Forms
{
    partial class frmKullaniciRolleriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciRolleriListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblBanner = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciKimlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.lblBanner);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1131, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(978, 37);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 57);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapa&t";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBanner
            // 
            this.lblBanner.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBanner.Appearance.Options.UseFont = true;
            this.lblBanner.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBanner.Location = new System.Drawing.Point(74, 31);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(280, 64);
            this.lblBanner.TabIndex = 5;
            this.lblBanner.Text = "Kullanıcı Rol Yetkileri Listesi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(616, 37);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 57);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "&Kaydet ve Kapat";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1131, 428);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKimlik,
            this.colKullaniciKimlik,
            this.colFormName,
            this.colControlName,
            this.colControlCaption,
            this.colVisible});
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
            this.colKimlik.Width = 65;
            // 
            // colKullaniciKimlik
            // 
            this.colKullaniciKimlik.FieldName = "KullaniciKimlik";
            this.colKullaniciKimlik.MinWidth = 25;
            this.colKullaniciKimlik.Name = "colKullaniciKimlik";
            this.colKullaniciKimlik.OptionsColumn.AllowEdit = false;
            this.colKullaniciKimlik.Width = 104;
            // 
            // colFormName
            // 
            this.colFormName.Caption = "Yetki Alınan Form(Form.Name)";
            this.colFormName.FieldName = "FormName";
            this.colFormName.MinWidth = 25;
            this.colFormName.Name = "colFormName";
            this.colFormName.OptionsColumn.AllowEdit = false;
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 1;
            this.colFormName.Width = 189;
            // 
            // colControlName
            // 
            this.colControlName.Caption = "Yetki Alınan Nesne(Control.Name)";
            this.colControlName.FieldName = "ControlName";
            this.colControlName.MinWidth = 25;
            this.colControlName.Name = "colControlName";
            this.colControlName.OptionsColumn.AllowEdit = false;
            this.colControlName.Visible = true;
            this.colControlName.VisibleIndex = 2;
            this.colControlName.Width = 230;
            // 
            // colControlCaption
            // 
            this.colControlCaption.Caption = "Yetki Alınan Nesne Etiketi(Control.Caption)";
            this.colControlCaption.FieldName = "ControlCaption";
            this.colControlCaption.MinWidth = 25;
            this.colControlCaption.Name = "colControlCaption";
            this.colControlCaption.OptionsColumn.AllowEdit = false;
            this.colControlCaption.Visible = true;
            this.colControlCaption.VisibleIndex = 3;
            this.colControlCaption.Width = 306;
            // 
            // colVisible
            // 
            this.colVisible.Caption = "Yetili mi?";
            this.colVisible.FieldName = "Visible";
            this.colVisible.MinWidth = 25;
            this.colVisible.Name = "colVisible";
            this.colVisible.Visible = true;
            this.colVisible.VisibleIndex = 4;
            this.colVisible.Width = 111;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ControlName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 230;
            // 
            // frmKullaniciRolleriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 528);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKullaniciRolleriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Rolleri Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl lblBanner;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciKimlik;
        private DevExpress.XtraGrid.Columns.GridColumn colFormName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colVisible;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}