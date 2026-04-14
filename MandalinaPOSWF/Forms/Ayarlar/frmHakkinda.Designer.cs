namespace MandalinaPOSWF.Forms.Ayarlar
{
    partial class frmHakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHakkinda));
            this.lblProgramAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.lblGelistirici = new DevExpress.XtraEditors.LabelControl();
            this.lblEFversion = new DevExpress.XtraEditors.LabelControl();
            this.lblBilgi = new DevExpress.XtraEditors.LabelControl();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgramAdi
            // 
            this.lblProgramAdi.Location = new System.Drawing.Point(180, 16);
            this.lblProgramAdi.Name = "lblProgramAdi";
            this.lblProgramAdi.Size = new System.Drawing.Size(75, 16);
            this.lblProgramAdi.TabIndex = 0;
            this.lblProgramAdi.Text = "labelControl1";
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(180, 38);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(75, 16);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "labelControl1";
            // 
            // lblGelistirici
            // 
            this.lblGelistirici.Location = new System.Drawing.Point(180, 60);
            this.lblGelistirici.Name = "lblGelistirici";
            this.lblGelistirici.Size = new System.Drawing.Size(75, 16);
            this.lblGelistirici.TabIndex = 0;
            this.lblGelistirici.Text = "labelControl1";
            // 
            // lblEFversion
            // 
            this.lblEFversion.Location = new System.Drawing.Point(180, 82);
            this.lblEFversion.Name = "lblEFversion";
            this.lblEFversion.Size = new System.Drawing.Size(75, 16);
            this.lblEFversion.TabIndex = 0;
            this.lblEFversion.Text = "labelControl1";
            // 
            // lblBilgi
            // 
            this.lblBilgi.Location = new System.Drawing.Point(180, 104);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(75, 16);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "labelControl1";
            // 
            // btnTamam
            // 
            this.btnTamam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTamam.ImageOptions.Image")));
            this.btnTamam.Location = new System.Drawing.Point(482, 170);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(128, 53);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmHakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 235);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lblEFversion);
            this.Controls.Add(this.lblGelistirici);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblProgramAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHakkinda";
            this.Text = "Program Hakkında";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblProgramAdi;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.LabelControl lblGelistirici;
        private DevExpress.XtraEditors.LabelControl lblEFversion;
        private DevExpress.XtraEditors.LabelControl lblBilgi;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}