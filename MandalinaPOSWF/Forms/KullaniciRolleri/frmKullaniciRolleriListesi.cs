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
using MandalinaPOSWF.Roles;

namespace MandalinaPOSWF.Forms
{
    public partial class frmKullaniciRolleriListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        tblKullaniciRollerDal tblKullaniciRollerDal=new tblKullaniciRollerDal();
        int? _kulkimlik;
        public frmKullaniciRolleriListesi(int? kulkimlik)
        {
            InitializeComponent();
            KullaniciYetki.AdminMi(context, btnKaydet);

            _kulkimlik = kulkimlik;
            gridControl1.DataSource = tblKullaniciRollerDal.GetAll(context,r=>r.KullaniciKimlik==_kulkimlik);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblKullaniciRollerDal.Save(context);
            gridView1.RefreshData();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}