using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using System.Media;

namespace SuperTEEN
{
    partial class FormRunModul : Form
    {
        public int Exp_Gained;
        public Kesehatan kesehatan;
        public Belajar belajar;
        public enum Mode { Kesehatan, Belajar }
        public enum Button { Jalankan, Selesai }
        Mode mode;
        Button button;

        public FormRunModul(Kesehatan kesehatan)
        {
            InitializeComponent();
            this.kesehatan = kesehatan;

            lblNamaModul.Text = kesehatan.ModulName;
            lblTime.Text = kesehatan.Durasi.ToString();
            mode = Mode.Kesehatan;
            button = Button.Jalankan;
        }

        public FormRunModul(Belajar belajar)
        {
            InitializeComponent();
            this.belajar = belajar;

            lblNamaModul.Text = belajar.ModulName;
            lblTime.Text = belajar.Durasi.ToString();
            lblDetik.Text = "Menit";
            mode = Mode.Belajar;
            button = Button.Jalankan;
        }

        private void btnJalankan_Click(object sender, EventArgs e)
        {
            if (button == Button.Jalankan)
            {
                lblDurasi.Text = "Durasi Task :";
                Application.DoEvents();

                if (mode == Mode.Kesehatan)
                {
                    for (int i = 0; i < kesehatan.NOTask; i++)
                    {
                        TaskExecute(kesehatan.Task[i], kesehatan.drTask[i]);
                    }
                }
                else if (mode == Mode.Belajar)
                {
                    for (int i = 0; i < belajar.NOTask; i++)
                    {
                        TaskExecute(belajar.Task[i], belajar.drTask[i]);
                    }
                }
                button = Button.Selesai;
                btnJalankan.Text = "Selesai";
            }
            else if (button == Button.Selesai)
            {
                lblNamaModul.Text = "";
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

        private void TaskExecute(string task, int duration)
        {
            if(mode == Mode.Kesehatan)
            {
                SystemSounds.Beep.Play();
                lblTask.Text = task;
                while(duration>=0)
                {
                    lblTime.Text = duration.ToString();
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    duration--;
                }
            }
            else if(mode == Mode.Belajar)
            {
                SystemSounds.Beep.Play();
                lblTask.Text = task;
                while (duration > 0)
                {
                    lblTime.Text = duration.ToString();
                    Application.DoEvents();
                    Thread.Sleep(1000*60);
                    duration--;
                }
            }
        }
    }
}
