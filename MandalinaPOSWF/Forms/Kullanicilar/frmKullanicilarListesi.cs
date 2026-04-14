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
using MandalinaPOSWF.Forms.KullaniciHareketleri;
using MandalinaPOSWF.Forms.UrunHareketleri;
using MandalinaPOSWF.Forms.Urunler;
using MandalinaPOSWF.Roles;

namespace MandalinaPOSWF.Forms.Kullanicilar
{
    public partial class frmKullanicilarListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        tblKullanicilarDal tblKullanicilarDal=new tblKullanicilarDal(); 
        public frmKullanicilarListesi()
        {
            InitializeComponent();
            KullaniciYetki.AdminMi(context, btnEkle, btnDuzenle);
            Listele();
        }
        private void Listele()
        {
            gridControl1.DataSource=tblKullanicilarDal.GetAll(context,k=>k.KullaniciAdi!="bilal");

        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frm = new frmKullaniciKayit(new tblKullanicilar());
            frm.ShowDialog();
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int SecilmisKisiKimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            frmKullaniciKayit frm = new frmKullaniciKayit(tblKullanicilarDal.GetByFilter(context, u => u.Kimlik == SecilmisKisiKimlik));
            frm.ShowDialog();
            Listele();            
        }

        private void btnKullaniciHareketleri_Click(object sender, EventArgs e)
        {
            int? kulkimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            frmKullaniciHareketleriListesi frm = new frmKullaniciHareketleriListesi(kulkimlik);
            frm.ShowDialog();
        }

        private void btnKullaniciRolleri_Click(object sender, EventArgs e)
        {
            int? kulkimlik = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colKimlik));
            frmKullaniciRolleriListesi frm = new frmKullaniciRolleriListesi(kulkimlik);
            frm.ShowDialog();
        }
    }
}