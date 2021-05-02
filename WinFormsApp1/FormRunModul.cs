using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp1
{
    partial class FormRunModul : Form
    {
        public int Exp_Gained;
        public Kesehatan kesehatan;
        public Belajar belajar;
        public enum Mode { Kesehatan, Belajar }
        public enum Button { Jalankan, Selesai}
        Mode mode;
        Button button;
        public FormRunModul(Kesehatan kesehatan)
        {
            InitializeComponent();
            lblNamaModul.Text = kesehatan.ModulName;
            this.kesehatan = kesehatan;
            mode = Mode.Kesehatan;
            button = Button.Jalankan;
        }

        public FormRunModul(Belajar belajar)
        {
            InitializeComponent();
            lblNamaModul.Text = belajar.ModulName;
            this.belajar = belajar;
            lblDurasi.Text = "Menit";
            mode = Mode.Belajar;
            button = Button.Jalankan;
        }

        private void btnJalankan_Click(object sender, EventArgs e)
        {
            if (button == Button.Jalankan)
            {
                if (mode == Mode.Kesehatan)
                {
                    for (int i = 0; i < kesehatan.Task.Length; i++)
                    {
                        lblTask.Text = kesehatan.Task[i];
                        lblDurasi.Text = kesehatan.drTask[i].ToString();
                        Thread.Sleep(kesehatan.drTask[i] * 1000);
                    }
                }
                else if (mode == Mode.Belajar)
                {
                    for (int i = 0; i < kesehatan.Task.Length; i++)
                    {
                        lblTask.Text = kesehatan.Task[i];
                        lblDurasi.Text = kesehatan.drTask[i].ToString();
                        Thread.Sleep(kesehatan.drTask[i] * 1000 * 60);
                    }
                }
                btnJalankan.Text = "Selesai";
                button = Button.Selesai;
            }
            else if (button == Button.Selesai)
            {
                if (mode == Mode.Kesehatan)
                {
                    Exp_Gained = kesehatan.ExpGained;
                    this.Close();
                }
                else if (mode == Mode.Belajar)
                {
                    Exp_Gained = belajar.ExpGained;
                    this.Close();
                }
            }
        }
    }
}
