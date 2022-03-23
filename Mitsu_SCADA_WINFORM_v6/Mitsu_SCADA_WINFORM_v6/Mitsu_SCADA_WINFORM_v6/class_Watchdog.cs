using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    class class_Watchdog
    {
        static string valold = "";
        // Chương trình con Watch dog
        public static void WatchdogStatus(Button btn, string valnow)
        {
            if (valnow != valold)
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
            }
            valold = valnow;
        }
    }
}
