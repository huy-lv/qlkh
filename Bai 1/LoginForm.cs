using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlkhNamespace
{
    public partial class LoginForm : Form
    {
        public bool loggedin;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Đăng nhập";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbTenDangNhap.Text == "admin" && tbMatKhau.Text == "admin")
            {
                MainForm f = new MainForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }

        private void btThoatApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
