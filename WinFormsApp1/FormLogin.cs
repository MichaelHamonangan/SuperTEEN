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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Login, check username password dari database
            //Level dan Current Exp diambil dari database
            //Sementara masih contoh dengan masukan level 1 dan Current Exp 0 
            this.Hide();
            Pengguna user = new Pengguna(tbUsername.Text, 1, 0);
            user.ModulGenerator();
            FormModul Modul = new FormModul(user);
            Modul.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp SignUp = new FormSignUp();
            SignUp.ShowDialog();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkGray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkCyan;
        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.DarkGray;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.DarkCyan;
        }
    }
}
