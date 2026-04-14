using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MandalinaPOSWF.Forms.Ayarlar
{
    public partial class frmHakkinda : DevExpress.XtraEditors.XtraForm
    {
        public frmHakkinda()
        {
            InitializeComponent();
            hakkinda();

        }
        private void hakkinda()
        {
            // Program sürümünü al
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var efVersion = typeof(DbContext).Assembly.GetName().Version.ToString();
             
            // Label'lara bilgileri ata
            lblProgramAdi.Text = "Program Adı: MandalinaPOS WF";
            lblVersion.Text = $"Sürüm: {version}";
            lblGelistirici.Text = "Geliştirici: Bilal ERDOĞAN";
            lblBilgi.Text = "Açıklama: Bu uygulama Entity Framework ile geliştirilmiştir.";
            lblEFversion.Text = $"Entity Framework Sürümü: {efVersion}";
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}