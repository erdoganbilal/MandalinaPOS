using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MandalinaPOS.Entities.Models;
using MandalinaPOS.Entities.Tools;
using MandalinaPOSWF.Forms.AnaMenu;

namespace MandalinaPOSWF
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionTools.BaglantiKontrol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAnaMenu());
        }
    }
}
