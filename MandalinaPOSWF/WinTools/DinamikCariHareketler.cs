using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MandalinaPOS.Entities.Models;

namespace MandalinaPOSWF.WinTools
{
    public class DinamikCariHareketler
    {
        public static void CariHareletleriGetir(MandalinaContext context, FlowLayoutPanel pnl)
        {
            var model=context.tblCariHareketler.ToList();   
            for (int i = 0; i < model.Count; i++)       //kayıt sayısı kadar döngü oluşturduk
            {
                var btn = new CheckButton();    // çekbuton oluşturduk
                btn.Text = model[i].Unvan;
                btn.Name = model[i].Kimlik.ToString();
                btn.Height = 100;
                btn.Width = 80;
                pnl.Controls.Add(btn);  //her kayıt için oluşan butonları panele ekledik.
                
            }
        }
    }
}
