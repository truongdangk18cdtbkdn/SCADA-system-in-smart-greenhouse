using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mitsu_SCADA_WINFORM_v6
{

    public class class_Login
    {
        // Disable toàn bộ khi chưa đăng nhập/ hoặc nhấn đăng xuất
        public void Not_Login()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Các object cần Enable/Disable
            frm.btnGreenhouse1.Enabled = false;
            frm.btnGreenhouse2.Enabled = false;
        }
        // Đăng nhập bằng quyền Admin
        public void adminControlElements()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Các object cần Enable/Disable
            frm.btnGreenhouse1.Enabled = true;
            frm.btnGreenhouse2.Enabled = true;
        }
        public void operatorControlElements()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Các object cần Enable/Disable
            frm.btnGreenhouse1.Enabled = false;
            frm.btnGreenhouse2.Enabled = false;
        }
    }
}
