using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class FormRunMotivasi : Form
    {
        public int ExpGained;
        private Motivasi motivasi;
        public FormRunMotivasi(Motivasi motivasi)
        {
            InitializeComponent();
            lblNamaModul.Text = motivasi.ModulName;
            lblTask.Text = motivasi.Task;
            this.motivasi = motivasi;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            ExpGained = motivasi.ExpGained;
            this.Close();
        }
    }
}
