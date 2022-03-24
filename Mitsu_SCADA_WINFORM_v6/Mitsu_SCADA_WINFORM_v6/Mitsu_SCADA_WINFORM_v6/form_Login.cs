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
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }
        class_Login fn_login = new class_Login();

        private void form_Login_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            if (frm.btnGreenhouse1.Enabled == true)
            {
                btnLogin.Enabled = false;
                tbxUsername.Enabled = false;
                tbxPassword.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
            }
        }
        // Khai báo tên người dùng
        string user1_Name = "admin";        // Tên người dùng 1
        string user1_Password = "123456";   // Pass người dùng 1

        string user2_Name = "user";        // Tên người dùng 2
        string user2_Password = "123456";      // Pass người dùng 2

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Đăng nhập bằng Admin
            if (tbxUsername.Text == user1_Name & tbxPassword.Text == user1_Password)
            {
                fn_login.adminControlElements();
                this.Close(); // Close form đăng nhập
            }
            else if (tbxUsername.Text == user2_Name & tbxPassword.Text == user2_Password)
            {
                fn_login.operatorControlElements();
                this.Close(); // Close form đăng nhập
            }
            else
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            tbxUsername.Enabled = true;
            tbxPassword.Enabled = true;
            fn_login.Not_Login(); // Gọi chương trình con login
        }
    }
}
