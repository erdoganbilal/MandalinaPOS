using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace MandalinaPOSWF.Forms.RaporFormlari
{
    public partial class frmRaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporGoruntule(XtraReport report)
        {
            InitializeComponent();
            //int height = Screen.PrimaryScreen.Bounds.Height;
            //int width = Screen.PrimaryScreen.Bounds.Width;
            //this.Size = new Size(width, height);
            documentViewer1.DocumentSource = report;    
        }
    }
}