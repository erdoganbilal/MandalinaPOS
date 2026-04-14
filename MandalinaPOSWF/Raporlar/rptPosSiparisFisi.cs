using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Raporlar
{
    public partial class rptPosSiparisFisi : DevExpress.XtraReports.UI.XtraReport
    {
        MandalinaContext context=new MandalinaContext();    
        tblUrunHareketleriDal tblUrunHareketleriDal=new tblUrunHareketleriDal();
        tblOdemeHareketleriDal tblOdemeHareketleriDal = new tblOdemeHareketleriDal();
        public rptPosSiparisFisi(int? _chkimlik, string unvan, tblCariHareketler tblCariHareketler = null)
        {
            InitializeComponent();
            xrLabelBilgi.Text = _chkimlik.ToString();
            xrLabelUnvan.Text = unvan;
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = tblUrunHareketleriDal.GetAll(context, c => c.CHKimlik == _chkimlik);
            DetailReport.DataSource = source;
            this.DataSource = source;


            //tableCell7.DataBindings.Add("Text", source.DataSource, "Miktar");
            //tableCell9.DataBindings.Add("Text", source.DataSource, "BFiyat");
            //xrTableCinsi.DataBindings.Add("Text", source.DataSource, "Cinsi");
            
            //ObjectDataSource source2 = new ObjectDataSource();
            //source2.DataSource = tblOdemeHareketleriDal.GetAll(context, o=> o.CHKimlik==_chkimlik);
            //DetailReport1.DataSource = source2;
            //this.DataSource = source2;
            //xrTableCell1.DataBindings.Add("Text", source.DataSource, "Tarihi");
            //xrTableCell3.DataBindings.Add("Text", source.DataSource, "OdemeTuru");
            //xrTableCell4.DataBindings.Add("Text", source.DataSource, "Odenen");

        }

    }
}
