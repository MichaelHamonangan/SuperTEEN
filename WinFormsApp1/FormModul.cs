using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class FormModul : Form
    {
        public Pengguna User;
        public FormModul(Pengguna user)
        {
            User = user;
            InitializeComponent();
            lblUsername.Text = user.Username;
            lblLevel.Text = user.Level.ToString();
        }

        private void btnKesehatan_MouseHover(object sender, EventArgs e)
        {
            btnKesehatan.BackColor = Color.DarkRed;
        }

        private void btnKesehatan_MouseLeave(object sender, EventArgs e)
        {
            btnKesehatan.BackColor = Color.Red;
        }

        private void btnBelajar_MouseHover(object sender, EventArgs e)
        {
            btnBelajar.BackColor = Color.DimGray;
        }

        private void btnBelajar_MouseLeave(object sender, EventArgs e)
        {
            btnBelajar.BackColor = Color.Teal;
        }

        private void btnMotivasi_MouseHover(object sender, EventArgs e)
        {
            btnMotivasi.BackColor = Color.DarkBlue;
        }

        private void btnMotivasi_MouseLeave(object sender, EventArgs e)
        {
            btnMotivasi.BackColor = Color.Blue;
        }

        private void btnKesehatan_Click(object sender, EventArgs e)
        {
            FormKategori kesehatan = new FormKategori(User.arrKesehatan);
            kesehatan.ShowDialog();
        }

        private void btnBelajar_Click(object sender, EventArgs e)
        {
            FormKategori belajar = new FormKategori(User.arrBelajar);
            belajar.ShowDialog();
        }

        private void btnMotivasi_Click(object sender, EventArgs e)
        {
            FormKategori motivasi = new FormKategori(User.arrMotivasi);
            motivasi.ShowDialog();
        }
    }
}
