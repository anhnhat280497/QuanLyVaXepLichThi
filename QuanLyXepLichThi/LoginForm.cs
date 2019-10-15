using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXepLichThi
{
    public partial class LoginForm : Form
    {
        public LoginForm() 
        {
            InitializeComponent();
        }

        private void SimpleButtonLogin_Click(object sender, EventArgs e)
        {
            if(textEditUsername.Text.Trim() != Program.usernameAdmin)
            {
                MessageBox.Show("Sai Username!");
                return;
            }
            if (textEditPassword.Text.Trim() != Program.passwordAdmin)
            {
                MessageBox.Show("Sai Password!");
                return;
            }

            Program.formMain = new MainForm();
            Program.formMain.Visible = true;
            Program.formLogin.Visible = false;
        }
    }
}
