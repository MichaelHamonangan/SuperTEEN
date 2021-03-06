using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace SuperTEEN
{
    partial class FormRunMotivasi : Form
    {
        Exp exp;
        private Motivasi motivasi;
        public FormRunMotivasi(Motivasi motivasi, Exp exp)
        {
            InitializeComponent();
            lblNamaModul.Text = motivasi.ModulName;
            lblTask.Text = motivasi.task;
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {  
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak("Motivation");
            }
            this.motivasi = motivasi;
            this.exp = exp;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (rtbIsi.TextLength >= 100)
            {
                exp.GainExp(motivasi.ExpGained);
                this.Close();
            }
            else
            {
                MessageBox.Show("Task selesai apabila huruf dalam box lebih dari 100 huruf!!!");
            }
        }
    }
}
