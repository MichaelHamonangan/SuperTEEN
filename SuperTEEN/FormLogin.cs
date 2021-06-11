using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTEEN
{
    public partial class FormLogin : Form
    {
        string tempUsername;
        int tempLevel;
        int tempExp;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != "" && tbPassword.Text != "")
            {
                using (var db = new DatabaseUser())
                {
                    var query = db.Users.SingleOrDefault(k => k.Username == tbUsername.Text);
                    if (query != null)
                    {
                        if (query.Password == tbPassword.Text)
                        {
                            tempUsername = query.Username;
                            tempLevel = query.Level;
                            tempExp = query.Current_Exp;

                            this.Hide();
                            Pengguna user = new Pengguna(tempUsername, tempLevel, tempExp);
                            FormModul Modul = new FormModul(user);
                            Modul.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Password tidak sesuai!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Username atau Password Harus Diisi!!!!");
            }
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

        private void cbShow_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
