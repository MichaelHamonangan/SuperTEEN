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
using System.Collections.Concurrent;
using System.Speech.Synthesis;

namespace SuperTEEN
{
    partial class FormRunModul : Form
    {
        Exp exp;
        public Kesehatan kesehatan;
        public Belajar belajar;
        bool Audio = true;
        public enum Mode { Kesehatan, Belajar }
        public enum Button { Jalankan, Selesai }
        Mode mode;
        Button button;

        public FormRunModul(Kesehatan kesehatan, Exp exp)
        {
            InitializeComponent();
            this.kesehatan = kesehatan;
            this.exp = exp;

            lblNamaModul.Text = kesehatan.ModulName;
            lblTime.Text = kesehatan.Durasi.ToString();
            mode = Mode.Kesehatan;
            button = Button.Jalankan;
        }

        public FormRunModul(Belajar belajar, Exp exp)
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

                btnJalankan.Enabled = false;
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
                btnJalankan.Enabled = true;
                btnBatalkan.Enabled = false;
            }
            else if (button == Button.Selesai)
            {
                lblNamaModul.Text = "";
                if (mode == Mode.Kesehatan)
                {
                    exp.GainExp(kesehatan.ExpGained);
                    this.Close();
                }
                else if (mode == Mode.Belajar)
                {
                    exp.GainExp(belajar.ExpGained);
                    this.Close();
                }
            }
        }

        int i = 1;
        BlockingCollection<int> _sleeper = new BlockingCollection<int>();
        private void TaskExecute(string task, int duration)
        {
            int dummy;
            if (mode == Mode.Kesehatan)
            {
                lblTask.Text = task;
                if (Audio == true)
                {
                    SystemSounds.Beep.Play();
                    using (SpeechSynthesizer synth = new SpeechSynthesizer())
                    {
                        synth.SetOutputToDefaultAudioDevice();
                        string audio = "Task" + i.ToString();
                        i++;
                        synth.Speak(audio);
                    }
                }
                while (duration>=0)
                {
                    lblTime.Text = duration.ToString();
                    Application.DoEvents();
                    _sleeper.TryTake(out dummy, 1000);
                    duration--;
                }
            }
            else if(mode == Mode.Belajar)
            {
                lblTask.Text = task;
                if (Audio == true)
                {
                    SystemSounds.Beep.Play();
                    using (SpeechSynthesizer synth = new SpeechSynthesizer())
                    {
                        synth.SetOutputToDefaultAudioDevice();
                        string audio = "Task" + i.ToString();
                        i++;
                        synth.Speak(audio);
                    }
                }
                int temp = duration * 60;
                while (temp > 0)
                {
                    temp--;
                    duration = temp / 60 + 1;
                    lblTime.Text = duration.ToString();
                    Application.DoEvents();
                    _sleeper.TryTake(out dummy, 1000);
                }
            }
        }

        private void btnBatalkan_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Kesehatan)
            {
                Audio = false;
                for (int i = 0; i < (kesehatan.Durasi*2); i++)
                {
                    _sleeper.Add(0);
                }
                this.Close();
            }
            else if (mode == Mode.Belajar)
            {
                Audio = false;
                for (int i = 0; i < (belajar.Durasi*2)*60; i++)
                {
                    _sleeper.Add(0);
                }
                this.Close();
            }
        }
    }
}
