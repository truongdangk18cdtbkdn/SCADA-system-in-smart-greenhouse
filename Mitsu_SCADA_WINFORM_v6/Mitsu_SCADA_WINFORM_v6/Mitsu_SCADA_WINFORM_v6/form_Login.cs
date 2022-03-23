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

        }
        // Khai báo tên người dùng
        string user1_Name = "admin";        // Tên người dùng 1
        string user1_Password = "123456";   // Pass người dùng 1

        string user2_Name = "user";        // Tên người dùng 2
        string user2_Password = "123456";      // Pass người dùng 2

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Đăng nhập bằng Admin
            if (txt_Username.Text == user1_Name & txt_Password.Text == user1_Password)
            {
                fn_login.adminControlElements();
                this.Close(); // Close form đăng nhập
            }
            else if (txt_Username.Text == user2_Name & txt_Password.Text == user2_Password)
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
            fn_login.Not_Login(); // Gọi chương trình con login
        }
    }
}
