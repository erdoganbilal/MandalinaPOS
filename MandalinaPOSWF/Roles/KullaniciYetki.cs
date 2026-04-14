using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using MandalinaPOS.Entities.Models;
using MandalinaPOSWF.WinTools;

namespace MandalinaPOSWF.Roles
{
    public class KullaniciYetki
    {
        public static void YetkileriGetir(MandalinaContext context, RibbonControl ribbon)
        {
            foreach (var item in ribbon.Items)
            {
                foreach (var roller in context.tblKullaniciRoller.Where(r=>r.KullaniciKimlik==KullaniciAyarlari.KulKimlik).ToList())
                {
                    if(item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;    
                        if(btn.Name == roller.ControlName && roller.Visible)
                        {
                            btn.Enabled = true;
                        }                        
                        if(btn.Name == roller.ControlName && !roller.Visible)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }
        public static void AdminMi(MandalinaContext context, params dynamic[] obj)
        {
            var adminKontrol = context.tblKullanicilar.FirstOrDefault(k => k.Kimlik == KullaniciAyarlari.KulKimlik);
            if (adminKontrol.Admin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled=true;   
                }                
            } 
            else if (!adminKontrol.Admin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = false;
                }
            }
        }
    }
}
