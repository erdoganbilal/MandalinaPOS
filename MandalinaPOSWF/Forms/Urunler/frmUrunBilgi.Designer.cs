namespace MandalinaPOSWF.Forms.Urunler
{
    partial class frmUrunBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunBilgi));
            this.labelBanner = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtKimlik = new DevExpress.XtraEditors.TextEdit();
            this.txtBarkodu = new DevExpress.XtraEditors.TextEdit();
            this.txtCinsi = new DevExpress.XtraEditors.TextEdit();
            this.calcAFiyat = new DevExpress.XtraEditors.CalcEdit();
            this.calcSFiyat = new DevExpress.XtraEditors.CalcEdit();
            this.dateFZaman = new DevExpress.XtraEditors.DateEdit();
            this.dateHZaman = new DevExpress.XtraEditors.DateEdit();
            this.pictureFoto = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpBirim = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpGrupAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpMarka = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toggleHizliSatis = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKimlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCinsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFZaman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFZaman.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHZaman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHZaman.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpGrupAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleHizliSatis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBanner
            // 
            this.labelBanner.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBanner.Appearance.Options.UseFont = true;
            this.labelBanner.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBanner.Location = new System.Drawing.Point(0, 0);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(971, 64);
            this.labelBanner.TabIndex = 22;
            this.labelBanner.Text = "Ürün Bilgi Formu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 407);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(971, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(794, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(161, 64);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "İptal";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 31);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 64);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "&Kaydet ve Kapat";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(200, 30);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Kimlik :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(200, 30);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Barkodu :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(12, 142);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(200, 30);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Cinsi :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(12, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(200, 30);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Birimi :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(12, 214);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(200, 30);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Alış Fiyatı :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(12, 250);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(200, 30);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Satış Fiyatı :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(12, 286);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(200, 30);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Ürün Grubu :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(12, 322);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(200, 30);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Ürün Markası :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(523, 286);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(200, 30);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Son Fiyat Güncelleme :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl11.Appearance.Options.UseBorderColor = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(523, 322);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(200, 30);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Son Hareket Zamanı :";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl12.Appearance.Options.UseBorderColor = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl12.Location = new System.Drawing.Point(557, 81);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(200, 30);
            this.labelControl12.TabIndex = 19;
            this.labelControl12.Text = "Fotoğrafı :";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(217, 76);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtKimlik.Properties.Appearance.Options.UseFont = true;
            this.txtKimlik.Size = new System.Drawing.Size(300, 24);
            this.txtKimlik.TabIndex = 0;
            // 
            // txtBarkodu
            // 
            this.txtBarkodu.Location = new System.Drawing.Point(217, 112);
            this.txtBarkodu.Name = "txtBarkodu";
            this.txtBarkodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBarkodu.Properties.Appearance.Options.UseFont = true;
            this.txtBarkodu.Size = new System.Drawing.Size(300, 24);
            this.txtBarkodu.TabIndex = 1;
            this.txtBarkodu.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarkodu_Validating);
            // 
            // txtCinsi
            // 
            this.txtCinsi.Location = new System.Drawing.Point(217, 148);
            this.txtCinsi.Name = "txtCinsi";
            this.txtCinsi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCinsi.Properties.Appearance.Options.UseFont = true;
            this.txtCinsi.Size = new System.Drawing.Size(300, 24);
            this.txtCinsi.TabIndex = 2;
            // 
            // calcAFiyat
            // 
            this.calcAFiyat.Location = new System.Drawing.Point(217, 220);
            this.calcAFiyat.Name = "calcAFiyat";
            this.calcAFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.calcAFiyat.Properties.Appearance.Options.UseFont = true;
            this.calcAFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcAFiyat.Properties.DisplayFormat.FormatString = "C2";
            this.calcAFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcAFiyat.Properties.NullText = "0,00";
            this.calcAFiyat.Size = new System.Drawing.Size(300, 24);
            this.calcAFiyat.TabIndex = 4;
            // 
            // calcSFiyat
            // 
            this.calcSFiyat.Location = new System.Drawing.Point(217, 256);
            this.calcSFiyat.Name = "calcSFiyat";
            this.calcSFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.calcSFiyat.Properties.Appearance.Options.UseFont = true;
            this.calcSFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcSFiyat.Properties.DisplayFormat.FormatString = "C2";
            this.calcSFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcSFiyat.Properties.NullText = "0,00";
            this.calcSFiyat.Size = new System.Drawing.Size(300, 24);
            this.calcSFiyat.TabIndex = 5;
            this.calcSFiyat.Validated += new System.EventHandler(this.calcSFiyat_Validated);
            // 
            // dateFZaman
            // 
            this.dateFZaman.EditValue = null;
            this.dateFZaman.Enabled = false;
            this.dateFZaman.Location = new System.Drawing.Point(729, 292);
            this.dateFZaman.Name = "dateFZaman";
            this.dateFZaman.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateFZaman.Properties.Appearance.Options.UseFont = true;
            this.dateFZaman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFZaman.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFZaman.Size = new System.Drawing.Size(226, 24);
            this.dateFZaman.TabIndex = 9;
            // 
            // dateHZaman
            // 
            this.dateHZaman.EditValue = null;
            this.dateHZaman.Enabled = false;
            this.dateHZaman.Location = new System.Drawing.Point(729, 328);
            this.dateHZaman.Name = "dateHZaman";
            this.dateHZaman.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateHZaman.Properties.Appearance.Options.UseFont = true;
            this.dateHZaman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHZaman.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHZaman.Size = new System.Drawing.Size(226, 24);
            this.dateHZaman.TabIndex = 10;
            // 
            // pictureFoto
            // 
            this.pictureFoto.Location = new System.Drawing.Point(763, 81);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Properties.NullText = "Fotoğraf Yüklenmedi";
            this.pictureFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureFoto.Size = new System.Drawing.Size(192, 192);
            this.pictureFoto.TabIndex = 8;
            // 
            // lookUpBirim
            // 
            this.lookUpBirim.Location = new System.Drawing.Point(217, 184);
            this.lookUpBirim.Name = "lookUpBirim";
            this.lookUpBirim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpBirim.Properties.Appearance.Options.UseFont = true;
            this.lookUpBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBirim.Properties.NullText = "Birimi seçiniz...";
            this.lookUpBirim.Properties.NullValuePrompt = "Birimi seçiniz...";
            this.lookUpBirim.Size = new System.Drawing.Size(300, 24);
            this.lookUpBirim.TabIndex = 3;
            // 
            // lookUpGrupAd
            // 
            this.lookUpGrupAd.Location = new System.Drawing.Point(217, 292);
            this.lookUpGrupAd.Name = "lookUpGrupAd";
            this.lookUpGrupAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpGrupAd.Properties.Appearance.Options.UseFont = true;
            this.lookUpGrupAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpGrupAd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GrupAd", "Ürün Grubu", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.lookUpGrupAd.Properties.DisplayMember = "GrupAd";
            this.lookUpGrupAd.Properties.NullText = "Grubunu seçiniz...";
            this.lookUpGrupAd.Properties.NullValuePrompt = "Grubunu seçiniz...";
            this.lookUpGrupAd.Properties.ValueMember = "Kimlik";
            this.lookUpGrupAd.Size = new System.Drawing.Size(300, 24);
            this.lookUpGrupAd.TabIndex = 6;
            // 
            // lookUpMarka
            // 
            this.lookUpMarka.Location = new System.Drawing.Point(217, 328);
            this.lookUpMarka.Name = "lookUpMarka";
            this.lookUpMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpMarka.Properties.Appearance.Options.UseFont = true;
            this.lookUpMarka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMarka.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Marka", "Markası", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpMarka.Properties.DisplayMember = "Marka";
            this.lookUpMarka.Properties.NullText = "Markasını seçiniz...";
            this.lookUpMarka.Properties.NullValuePrompt = "Markasını seçiniz...";
            this.lookUpMarka.Properties.ValueMember = "Kimlik";
            this.lookUpMarka.Size = new System.Drawing.Size(300, 24);
            this.lookUpMarka.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(12, 358);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 30);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Hızlı Satış Ekranında :";
            // 
            // toggleHizliSatis
            // 
            this.toggleHizliSatis.Location = new System.Drawing.Point(218, 364);
            this.toggleHizliSatis.Name = "toggleHizliSatis";
            this.toggleHizliSatis.Properties.OffText = "Gizle";
            this.toggleHizliSatis.Properties.OnText = "Göster";
            this.toggleHizliSatis.Size = new System.Drawing.Size(95, 24);
            this.toggleHizliSatis.TabIndex = 24;
            // 
            // frmUrunBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(971, 507);
            this.ControlBox = false;
            this.Controls.Add(this.toggleHizliSatis);
            this.Controls.Add(this.lookUpMarka);
            this.Controls.Add(this.lookUpGrupAd);
            this.Controls.Add(this.lookUpBirim);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.dateHZaman);
            this.Controls.Add(this.dateFZaman);
            this.Controls.Add(this.calcSFiyat);
            this.Controls.Add(this.calcAFiyat);
            this.Controls.Add(this.txtCinsi);
            this.Controls.Add(this.txtBarkodu);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelBanner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgi Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKimlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCinsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFZaman.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFZaman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHZaman.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHZaman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpGrupAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleHizliSatis.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelBanner;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtKimlik;
        private DevExpress.XtraEditors.TextEdit txtBarkodu;
        private DevExpress.XtraEditors.TextEdit txtCinsi;
        private DevExpress.XtraEditors.CalcEdit calcAFiyat;
        private DevExpress.XtraEditors.CalcEdit calcSFiyat;
        private DevExpress.XtraEditors.DateEdit dateFZaman;
        private DevExpress.XtraEditors.DateEdit dateHZaman;
        private DevExpress.XtraEditors.PictureEdit pictureFoto;
        private DevExpress.XtraEditors.LookUpEdit lookUpBirim;
        private DevExpress.XtraEditors.LookUpEdit lookUpGrupAd;
        private DevExpress.XtraEditors.LookUpEdit lookUpMarka;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleHizliSatis;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}