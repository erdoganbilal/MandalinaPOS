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
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.UrunHareketleri
{
    public partial class frmUrunHareketleriListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context= new MandalinaContext();
        tblUrunHareketleriDal tblUrunHareketleriDal= new tblUrunHareketleriDal();
        public frmUrunHareketleriListesi(int? urunkimlik=null)
        {
            InitializeComponent();
            if (urunkimlik != null)
            {
                gridControl1.DataSource = tblUrunHareketleriDal.GetAll(context,u=>u.UrunKimlik==urunkimlik);
                return;
            }
                gridControl1.DataSource = tblUrunHareketleriDal.GetAll(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}