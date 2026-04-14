namespace MandalinaPOSWF.Forms.Kullanicilar
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelBanner = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydol = new DevExpress.XtraEditors.SimpleButton();
            this.checkBeniHatirla = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 70);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(189, 410);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // labelBanner
            // 
            this.labelBanner.Appearance.BackColor = System.Drawing.Color.OrangeRed;
            this.labelBanner.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBanner.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBanner.Appearance.Options.UseBackColor = true;
            this.labelBanner.Appearance.Options.UseFont = true;
            this.labelBanner.Appearance.Options.UseForeColor = true;
            this.labelBanner.Appearance.Options.UseTextOptions = true;
            this.labelBanner.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelBanner.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBanner.Location = new System.Drawing.Point(0, 0);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(485, 64);
            this.labelBanner.TabIndex = 6;
            this.labelBanner.Text = "MandalinaPOS Kullanıcı Girişi";
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.btnKapat.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnKapat.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnKapat.Appearance.Options.UseBackColor = true;
            this.btnKapat.Appearance.Options.UseBorderColor = true;
            this.btnKapat.Appearance.Options.UseForeColor = true;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(201, 327);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(274, 57);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Çı&kış";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.AppearanceHovered.BackColor = System.Drawing.Color.Gold;
            this.btnGiris.AppearanceHovered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.btnGiris.AppearanceHovered.Options.UseForeColor = true;
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(201, 264);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGiris.Size = new System.Drawing.Size(274, 57);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "&Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnUnuttum
            // 
            this.btnUnuttum.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnUnuttum.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnUnuttum.Appearance.Options.UseBackColor = true;
            this.btnUnuttum.Appearance.Options.UseForeColor = true;
            this.btnUnuttum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnuttum.ImageOptions.Image")));
            this.btnUnuttum.Location = new System.Drawing.Point(201, 390);
            this.btnUnuttum.Name = "btnUnuttum";
            this.btnUnuttum.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUnuttum.Size = new System.Drawing.Size(274, 57);
            this.btnUnuttum.TabIndex = 5;
            this.btnUnuttum.Text = "Şifremi Unuttum";
            this.btnUnuttum.Click += new System.EventHandler(this.btnUnuttum_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(201, 95);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtKullaniciAdi.Properties.Appearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtKullaniciAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseBorderColor = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtKullaniciAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.Image")));
            this.txtKullaniciAdi.Properties.NullText = "Kullanıcı Adınızı Giriniz...";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(274, 28);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(201, 136);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtParola.Properties.Appearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtParola.Properties.Appearance.Options.UseBackColor = true;
            this.txtParola.Properties.Appearance.Options.UseBorderColor = true;
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtParola.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImageOptions.Image")));
            this.txtParola.Properties.NullText = "Parolanızı Giriniz...";
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(274, 28);
            this.txtParola.TabIndex = 1;
            // 
            // btnKaydol
            // 
            this.btnKaydol.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.btnKaydol.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnKaydol.Appearance.Options.UseBackColor = true;
            this.btnKaydol.Appearance.Options.UseForeColor = true;
            this.btnKaydol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydol.ImageOptions.Image")));
            this.btnKaydol.Location = new System.Drawing.Point(201, 453);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKaydol.Size = new System.Drawing.Size(274, 57);
            this.btnKaydol.TabIndex = 6;
            this.btnKaydol.Text = "Kayıt Ol";
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Location = new System.Drawing.Point(201, 227);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Properties.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.checkBeniHatirla.Properties.Appearance.Options.UseForeColor = true;
            this.checkBeniHatirla.Properties.OffText = "Beni Unut";
            this.checkBeniHatirla.Properties.OnText = "Beni Hatırla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(274, 24);
            this.checkBeniHatirla.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(53, 554);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 34);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "+90 543 653 33 14";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 516);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(35, 41);
            this.pictureEdit2.TabIndex = 9;
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.hyperlinkLabelControl1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(53, 527);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(181, 21);
            this.hyperlinkLabelControl1.TabIndex = 11;
            this.hyperlinkLabelControl1.Text = "erdoganbilal@gmail.com";
            this.hyperlinkLabelControl1.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.hyperlinkLabelControl1_HyperlinkClick);
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(12, 547);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit3.Size = new System.Drawing.Size(35, 41);
            this.pictureEdit3.TabIndex = 12;
            // 
            // frmGiris
            // 
            this.ActiveGlowColor = System.Drawing.Color.Black;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelBanner);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.btnUnuttum);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InactiveGlowColor = System.Drawing.Color.Black;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenli Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelBanner;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.SimpleButton btnUnuttum;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton btnKaydol;
        private DevExpress.XtraEditors.ToggleSwitch checkBeniHatirla;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
    }
}