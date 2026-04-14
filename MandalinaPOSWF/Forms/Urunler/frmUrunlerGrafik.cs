using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DashboardWin.Design;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.Urunler
{
    public partial class frmUrunlerGrafik : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        public frmUrunlerGrafik()
        {
            InitializeComponent();
            dateilk.Text = DateTime.Now.AddMonths(-1).ToString();   
            dateSon.Text = DateTime.Now.ToString();
            GrafikGetir();
        }
        public void GrafikGetir()
        {
            DateTime ilkTarih = Convert.ToDateTime(dateilk.Text);
            DateTime sonTarih = Convert.ToDateTime(dateSon.Text);
            var model = context.tblUrunHareketleris.Where(u => u.Tarihi >= ilkTarih && u.Tarihi <= sonTarih)
                .GroupBy(u => u.Cinsi)
                .Select(s => new
                {
                    UrunCinsi = s.Key,
                    Miktar = s.Sum(u => u.Miktar),
                })
                .OrderByDescending(u => u.Miktar)
                .Take(20)
                .ToList();
            foreach (var item in model)
            {
                
                chartControl1.Series["Satış Grafiği"].Points.AddPoint(item.UrunCinsi, Convert.ToDouble(item.Miktar));
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
              
            GrafikGetir();
           
            //((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            //chartControl1.RefreshData();    
        }
    }
}