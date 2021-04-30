using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormModul : Form
    {
        public FormModul(string Nama,int level,int exp)
        {
            InitializeComponent();
            lblUsername.Text = Nama;
            lblLevel.Text = level.ToString() ;
            //komponen komponen lain akan dilanjutkan disini
        }

        private void mdlKesehatan_MouseHover(object sender, EventArgs e)
        {
            mdlKesehatan.BackColor = Color.DarkRed;
        }

        private void mdlKesehatan_MouseLeave(object sender, EventArgs e)
        {
            mdlKesehatan.BackColor = Color.Red;
        }

        private void mdlBelajar_MouseHover(object sender, EventArgs e)
        {
            mdlBelajar.BackColor = Color.DimGray;
        }

        private void mdlBelajar_MouseLeave(object sender, EventArgs e)
        {
            mdlBelajar.BackColor = Color.Teal;
        }

        private void mdlMotivasi_MouseHover(object sender, EventArgs e)
        {
            mdlMotivasi.BackColor = Color.DarkBlue;
        }

        private void mdlMotivasi_MouseLeave(object sender, EventArgs e)
        {
            mdlMotivasi.BackColor = Color.Blue;
        }
    }
}
