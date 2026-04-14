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
    public partial class rptSatisHareketRaporu : DevExpress.XtraReports.UI.XtraReport
    {
        MandalinaContext context=new MandalinaContext();
        tblCariHareketlerDal tblCariHareketlerDal=new tblCariHareketlerDal();

        public rptSatisHareketRaporu()
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = tblCariHareketlerDal.GetAll(context);
            DataSource=source;
            xrTableTarih.DataBindings.Add("Text", DataSource, "Tarihi");
            xrTableKimlik.DataBindings.Add("Text", DataSource, "Kimlik");
            xrTableUnvan.DataBindings.Add("Text", DataSource, "Unvan");
            xrTableTutar.DataBindings.Add("Text", DataSource, "Tutar");
            xrTableOdenen.DataBindings.Add("Text", DataSource, "Odenen");
            xrTableKalan.DataBindings.Add("Text", DataSource, "Kalan");
            xrTableAciklama.DataBindings.Add("Text", DataSource, "Aciklama");

        }

    }
}
