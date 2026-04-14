using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;
using Microsoft.Reporting.WinForms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using MandalinaPOSWF.Raporlar;

namespace MandalinaPOSWF.Forms
{
    public partial class frmDeneme2 : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context = new MandalinaContext();
        tblUrunlerDal tblUrunlerDal = new tblUrunlerDal();  
        tblUrunHareketleriDal tblUrunHareketleriDal=new tblUrunHareketleriDal();
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public frmDeneme2()
        {
            InitializeComponent();
        }

        private void frmDeneme2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport rapor = new rptPosSiparisFisi(35, "PERAKENDE SATIŞ");
            rapor.DataSource = tblUrunHareketleriDal.GetAll(context,u=>u.CHKimlik==35);
            ReportDesignTool designTool = new ReportDesignTool(rapor);
            designTool.ShowRibbonDesignerDialog();
        }
       
    }
}