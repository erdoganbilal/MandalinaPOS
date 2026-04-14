namespace MandalinaPOSWF.Forms.Ayarlar
{
    partial class frmYedekAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYedekAl));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblBanner = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtSunucuAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboVT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtKonum = new DevExpress.XtraEditors.TextEdit();
            this.btnKonumSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnYedekAl = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblBilgi = new DevExpress.XtraEditors.LabelControl();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucuAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl3.Size = new System.Drawing.Size(152, 30);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "SQL Server Sunucu Adı :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYedekAl);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.lblBanner);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 100);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(448, 37);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 57);
            this.btnKapat.TabIndex = 1;
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
            this.lblBanner.Text = "Veritabanı Yedekleme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(616, 37);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 57);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "&Kaydet ve Kapat";
            // 
            // txtSunucuAd
            // 
            this.txtSunucuAd.Location = new System.Drawing.Point(170, 106);
            this.txtSunucuAd.Name = "txtSunucuAd";
            this.txtSunucuAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSunucuAd.Properties.Appearance.Options.UseFont = true;
            this.txtSunucuAd.Size = new System.Drawing.Size(408, 28);
            this.txtSunucuAd.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(12, 142);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 30);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Veritabanı Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 248);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 30);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Yedek Alınacak Konum :";
            // 
            // comboVT
            // 
            this.comboVT.Location = new System.Drawing.Point(170, 142);
            this.comboVT.Name = "comboVT";
            this.comboVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboVT.Properties.Appearance.Options.UseFont = true;
            this.comboVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboVT.Size = new System.Drawing.Size(408, 28);
            this.comboVT.TabIndex = 14;
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(170, 250);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtKonum.Properties.Appearance.Options.UseFont = true;
            this.txtKonum.Size = new System.Drawing.Size(337, 28);
            this.txtKonum.TabIndex = 13;
            // 
            // btnKonumSec
            // 
            this.btnKonumSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKonumSec.ImageOptions.Image")));
            this.btnKonumSec.Location = new System.Drawing.Point(513, 250);
            this.btnKonumSec.Name = "btnKonumSec";
            this.btnKonumSec.Size = new System.Drawing.Size(65, 28);
            this.btnKonumSec.TabIndex = 15;
            this.btnKonumSec.Text = "...";
            this.btnKonumSec.Click += new System.EventHandler(this.btnKonumSec_Click);
            // 
            // btnYedekAl
            // 
            this.btnYedekAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYedekAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnYedekAl.Location = new System.Drawing.Point(312, 38);
            this.btnYedekAl.Name = "btnYedekAl";
            this.btnYedekAl.Size = new System.Drawing.Size(130, 57);
            this.btnYedekAl.TabIndex = 1;
            this.btnYedekAl.Text = "&Yedek Al";
            this.btnYedekAl.Click += new System.EventHandler(this.btnYedekAl_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressBarControl1.Location = new System.Drawing.Point(12, 297);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Size = new System.Drawing.Size(566, 34);
            this.progressBarControl1.TabIndex = 16;
            // 
            // lblBilgi
            // 
            this.lblBilgi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBilgi.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.lblBilgi.Appearance.Options.UseBackColor = true;
            this.lblBilgi.Appearance.Options.UseFont = true;
            this.lblBilgi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBilgi.Location = new System.Drawing.Point(12, 337);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(566, 34);
            this.lblBilgi.TabIndex = 17;
            this.lblBilgi.Text = "Bilgi :";
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(12, 178);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(152, 30);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(170, 178);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAd.Size = new System.Drawing.Size(408, 28);
            this.txtKullaniciAd.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(12, 212);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(152, 30);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Şifre :";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(170, 212);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(408, 28);
            this.txtParola.TabIndex = 13;
            // 
            // frmYedekAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 413);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnKonumSec);
            this.Controls.Add(this.comboVT);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.txtSunucuAd);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.progressBarControl1);
            this.Name = "frmYedekAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Yedek Alma Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucuAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl lblBanner;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtSunucuAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboVT;
        private DevExpress.XtraEditors.TextEdit txtKonum;
        private DevExpress.XtraEditors.SimpleButton btnKonumSec;
        private DevExpress.XtraEditors.SimpleButton btnYedekAl;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblBilgi;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtParola;
    }
}