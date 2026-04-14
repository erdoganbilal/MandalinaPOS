using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.KullaniciHareketleri
{
    public partial class frmKullaniciHareketleriListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();    
        tblKullaniciHareketleriDal tblKullaniciHareketleriDal=new tblKullaniciHareketleriDal();
        public frmKullaniciHareketleriListesi(int? kulkimlik = null)
        {
            InitializeComponent();
            if (kulkimlik != null)
            {
                gridControl1.DataSource = tblKullaniciHareketleriDal.GetAll(context, k => k.KullaniciKimlik == kulkimlik);
                return;
            }
            gridControl1.DataSource = tblKullaniciHareketleriDal.GetAll(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}