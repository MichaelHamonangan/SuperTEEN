using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            //Login, check username password
            Hide();
            Pengguna user = new Pengguna();
            user.PilihModul();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            // Create new database about user
        }

        private void Signin_MouseHover(object sender, EventArgs e)
        {
            Signin.BackColor = Color.DarkGray;
        }

        private void Signin_MouseLeave(object sender, EventArgs e)
        {
            Signin.BackColor = Color.DarkCyan;
        }

        private void Signup_MouseHover(object sender, EventArgs e)
        {
            Signup.BackColor = Color.DarkGray;
        }

        private void Signup_MouseLeave(object sender, EventArgs e)
        {
            Signup.BackColor = Color.DarkCyan;
        }
    }
}
