using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperTEEN
{
    partial class FormModul : Form
    {
        public Pengguna User;
        public FormModul(Pengguna user)
        {
            User = user;
            InitializeComponent();
            lblUsername.Text = User.Username;
            lblLevel.Text = User.Pengalaman.CurrentLevel.ToString();

            ttLevel.SetToolTip(lblLevel, "Your current exp : " + User.Pengalaman.CurrentExp.ToString());
            ttLevel.SetToolTip(lblTextLevel, "Your current exp : " + User.Pengalaman.CurrentExp.ToString());
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
            FormKategori kesehatan = new FormKategori(User.Pengalaman, "kesehatan");
            kesehatan.ShowDialog();
        }

        private void btnBelajar_Click(object sender, EventArgs e)
        {
            FormKategori belajar = new FormKategori(User.Pengalaman, "belajar");
            belajar.ShowDialog();
        }

        private void btnMotivasi_Click(object sender, EventArgs e)
        {
            FormKategori motivasi = new FormKategori(User.Pengalaman, "motivasi");
            motivasi.ShowDialog();
        }

        private void FormModul_MouseEnter(object sender, EventArgs e)
        {
            lblLevel.Text = User.Pengalaman.CurrentLevel.ToString();

            ttLevel.SetToolTip(lblLevel, "Your current exp : " + User.Pengalaman.CurrentExp.ToString());
            ttLevel.SetToolTip(lblTextLevel, "Your current exp : " + User.Pengalaman.CurrentExp.ToString());
        }
    }
}
