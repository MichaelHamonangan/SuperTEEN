using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbConfirm.Text)
            {
                //Masukkan data ke database
                this.Hide();
                FormLogin login = new FormLogin();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password tidak sesuai");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
    }
}
