namespace MandalinaPOSWF.Forms.AnaMenu
{
    partial class frmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKimlik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtisletmeUnvan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtisletmeAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtisletmeTelefon = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtisletmefacebook = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtisletmeinstagram = new DevExpress.XtraEditors.TextEdit();
            this.txtisletmeEposta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.toggleFisYazdir = new DevExpress.XtraEditors.ToggleSwitch();
            this.lookUpPrinter = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.toggleDokunmatikMod = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKimlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmefacebook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeinstagram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleFisYazdir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrinter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDokunmatikMod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(683, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(541, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 64);
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
            this.labelControl1.Text = "Program Ayarları";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(360, 31);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(164, 64);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "&Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(104, 37);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtKimlik.Properties.Appearance.Options.UseFont = true;
            this.txtKimlik.Size = new System.Drawing.Size(567, 24);
            this.txtKimlik.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 24);
            this.labelControl2.TabIndex = 14;
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
            this.labelControl3.Location = new System.Drawing.Point(12, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 24);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Ünvanı :";
            // 
            // txtisletmeUnvan
            // 
            this.txtisletmeUnvan.Location = new System.Drawing.Point(104, 67);
            this.txtisletmeUnvan.Name = "txtisletmeUnvan";
            this.txtisletmeUnvan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtisletmeUnvan.Properties.Appearance.Options.UseFont = true;
            this.txtisletmeUnvan.Size = new System.Drawing.Size(567, 24);
            this.txtisletmeUnvan.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(12, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 24);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Adresi :";
            // 
            // txtisletmeAdres
            // 
            this.txtisletmeAdres.Location = new System.Drawing.Point(104, 97);
            this.txtisletmeAdres.Name = "txtisletmeAdres";
            this.txtisletmeAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtisletmeAdres.Properties.Appearance.Options.UseFont = true;
            this.txtisletmeAdres.Size = new System.Drawing.Size(567, 24);
            this.txtisletmeAdres.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(12, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 24);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Telefon :";
            // 
            // txtisletmeTelefon
            // 
            this.txtisletmeTelefon.Location = new System.Drawing.Point(104, 127);
            this.txtisletmeTelefon.Name = "txtisletmeTelefon";
            this.txtisletmeTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtisletmeTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtisletmeTelefon.Size = new System.Drawing.Size(567, 24);
            this.txtisletmeTelefon.TabIndex = 15;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtisletmefacebook);
            this.groupControl2.Controls.Add(this.txtisletmeTelefon);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtKimlik);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtisletmeinstagram);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtisletmeEposta);
            this.groupControl2.Controls.Add(this.txtisletmeAdres);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtisletmeUnvan);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 100);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(683, 392);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "İşletme Bilgileri :";
            // 
            // txtisletmefacebook
            // 
            this.txtisletmefacebook.Location = new System.Drawing.Point(104, 217);
            this.txtisletmefacebook.Name = "txtisletmefacebook";
            this.txtisletmefacebook.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtisletmefacebook.Properties.Appearance.Options.UseFont = true;
            this.txtisletmefacebook.Size = new System.Drawing.Size(567, 24);
            this.txtisletmefacebook.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(12, 217);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(87, 24);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Facebook :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(12, 157);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 24);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "E-posta :";
            // 
            // txtisletmeinstagram
            // 
            this.txtisletmeinstagram.Location = new System.Drawing.Point(104, 187);
            this.txtisletmeinstagram.Name = "txtisletmeinstagram";
            this.txtisletmeinstagram.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtisletmeinstagram.Properties.Appearance.Options.UseFont = true;
            this.txtisletmeinstagram.Size = new System.Drawing.Size(567, 24);
            this.txtisletmeinstagram.TabIndex = 15;
            // 
            // txtisletmeEposta
            // 
            this.txtisletmeEposta.Location = new System.Drawing.Point(104, 157);
            this.txtisletmeEposta.Name = "txtisletmeEposta";
            this.txtisletmeEposta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtisletmeEposta.Properties.Appearance.Options.UseFont = true;
            this.txtisletmeEposta.Size = new System.Drawing.Size(567, 24);
            this.txtisletmeEposta.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(12, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 24);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "İnstagram :";
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.toggleDokunmatikMod);
            this.groupControl3.Controls.Add(this.toggleFisYazdir);
            this.groupControl3.Controls.Add(this.lookUpPrinter);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 347);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(683, 145);
            this.groupControl3.TabIndex = 17;
            this.groupControl3.Text = "Program Ayarları :";
            // 
            // toggleFisYazdir
            // 
            this.toggleFisYazdir.Location = new System.Drawing.Point(175, 59);
            this.toggleFisYazdir.Name = "toggleFisYazdir";
            this.toggleFisYazdir.Properties.OffText = "Yazdırma";
            this.toggleFisYazdir.Properties.OnText = "Otomatik Yazdır";
            this.toggleFisYazdir.Size = new System.Drawing.Size(179, 24);
            this.toggleFisYazdir.TabIndex = 17;
            // 
            // lookUpPrinter
            // 
            this.lookUpPrinter.Location = new System.Drawing.Point(175, 31);
            this.lookUpPrinter.Name = "lookUpPrinter";
            this.lookUpPrinter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPrinter.Properties.NullText = "Bilgi fişi için yazıcı seçiniz...";
            this.lookUpPrinter.Properties.NullValuePrompt = "Bilgi fişi için yazıcı seçiniz...";
            this.lookUpPrinter.Size = new System.Drawing.Size(496, 22);
            this.lookUpPrinter.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(11, 59);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(157, 24);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Satıştan Sonra Bilgi Fişi :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(12, 29);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(157, 24);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Fiş Yazıcı :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl11.Appearance.Options.UseBorderColor = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(11, 89);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(157, 24);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "Dokunmatik Ekran Modu :";
            // 
            // toggleDokunmatikMod
            // 
            this.toggleDokunmatikMod.Location = new System.Drawing.Point(175, 89);
            this.toggleDokunmatikMod.Name = "toggleDokunmatikMod";
            this.toggleDokunmatikMod.Properties.OffText = "Kapalı";
            this.toggleDokunmatikMod.Properties.OnText = "Aktif";
            this.toggleDokunmatikMod.Size = new System.Drawing.Size(179, 24);
            this.toggleDokunmatikMod.TabIndex = 17;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 492);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAyarlar";
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKimlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmefacebook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeinstagram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisletmeEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleFisYazdir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrinter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDokunmatikMod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtKimlik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtisletmeUnvan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtisletmeAdres;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtisletmeTelefon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtisletmefacebook;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtisletmeinstagram;
        private DevExpress.XtraEditors.TextEdit txtisletmeEposta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrinter;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ToggleSwitch toggleFisYazdir;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ToggleSwitch toggleDokunmatikMod;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}