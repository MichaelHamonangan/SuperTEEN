using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class FormKategori : Form
    {
        public enum Mode {Kesehatan,Belajar,Motivasi}
        Mode mode;
        public FormKategori(Motivasi[] motivasi)
        {
            InitializeComponent();
            mode = Mode.Motivasi;
            lblKategori.Text = "Modul-Modul Motivasi";

            //Masukkan dari database bagian Motivasi kedalam List Box
            foreach (Motivasi item in motivasi)
            {
                cbNamaModul.Items.Add(item.ModulName);
            }
        }

        public FormKategori(Belajar[] belajar)
        {
            InitializeComponent();
            mode = Mode.Belajar;
            lblKategori.Text = "Modul-Modul Belajar";

            //Masukkan dari database bagian Belajar kedalam List Box
            foreach (Belajar item in belajar)
            {
                cbNamaModul.Items.Add(item.ModulName);
            }
        }

        public FormKategori(Kesehatan[] kesehatan)
        {
            InitializeComponent();
            mode = Mode.Kesehatan;
            lblKategori.Text = "Modul-Modul Kesehatan";

            //Masukkan dari database bagian Kesehatan kedalam List Box
            foreach (Kesehatan item in kesehatan)
            {
                cbNamaModul.Items.Add(item.ModulName);
            }

            //Belum mencoba yang dimasukkan ke combo box adalah itemnya atau hanya ModulName saja (harus menunggu database)
            //Sementara dianggap yang masuk adalah itemnya 
        }

        private void btnJalankan_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Motivasi)
            {
                Motivasi temp = cbNamaModul.SelectedItem as Motivasi;
                this.Hide();
                FormRunMotivasi run = new FormRunMotivasi(temp);
                run.ShowDialog();
            } 
            else if (mode == Mode.Belajar)
            {
                Belajar temp = cbNamaModul.SelectedItem as Belajar;
                this.Hide();
                FormRunModul run = new FormRunModul(temp);
                run.ShowDialog();
            }
            else if (mode == Mode.Kesehatan)
            {
                Kesehatan temp = cbNamaModul.SelectedItem as Kesehatan;
                this.Hide();
                FormRunModul run = new FormRunModul(temp);
                run.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
