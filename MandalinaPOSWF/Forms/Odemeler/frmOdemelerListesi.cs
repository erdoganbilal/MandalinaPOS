using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using MandalinaPOS.Entities.DAL;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.Forms.Odemeler
{
    public partial class frmOdemelerListesi : DevExpress.XtraEditors.XtraForm
    {
        MandalinaContext context=new MandalinaContext();
        tblOdemeHareketleriDal tblOdemeHareketleriDal=new tblOdemeHareketleriDal();
        
        public frmOdemelerListesi(int? chkimlik=null)
        {
            InitializeComponent();
            int ck = Convert.ToInt32(chkimlik);

            if (chkimlik==null )
            {
                gridControl1.DataSource = tblOdemeHareketleriDal.GetAll(context)
                    .OrderByDescending(x => x.Tarihi)
                    .ToList();
            }
            else if(chkimlik!=null )
            {
                gridControl1.DataSource = tblOdemeHareketleriDal.GetAll(context,o=> o.CHKimlik==chkimlik)
                    .OrderByDescending(x => x.Tarihi)
                    .ToList();
            }
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}