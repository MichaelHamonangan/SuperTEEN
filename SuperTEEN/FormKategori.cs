using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperTEEN
{
    partial class FormKategori : Form
    {
        Exp Pengalaman;
        public enum Mode {Kesehatan,Belajar,Motivasi}
        Mode mode;
        public FormKategori(Exp pengalaman,string tipe)
        {
            InitializeComponent();
            Pengalaman = pengalaman;

            if (tipe == "motivasi")
            {
                mode = Mode.Motivasi;
                lblKategori.Text = "Modul-Modul Motivasi";

                using (var db = new DatabaseModul())
                {
                    var query = from tbmotivasi in db.TbMotivasis select tbmotivasi;
                    foreach (var item in query)
                    {
                        cbNamaModul.Items.Add(item.Nama_Modul);
                    }
                }
            }
            else if (tipe == "belajar")
            {
                mode = Mode.Belajar;
                lblKategori.Text = "Modul-Modul Belajar";

                using (var db = new DatabaseModul())
                {
                    var query = from tbbelajar in db.TbBelajars select tbbelajar;
                    foreach (var item in query)
                    {
                        cbNamaModul.Items.Add(item.Nama_Modul);
                    }
                }
            }
            else if (tipe == "kesehatan")
            {
                mode = Mode.Kesehatan;
                lblKategori.Text = "Modul-Modul Kesehatan";

                using (var db = new DatabaseModul())
                {
                    var query = from tbkesehatan in db.TbKesehatans select tbkesehatan;
                    foreach (var item in query)
                    {
                        cbNamaModul.Items.Add(item.Nama_Modul);
                    }
                }
            }
        }

        private void btnJalankan_Click(object sender, EventArgs e)
        {
            if (cbNamaModul.SelectedItem != null)
            {
                if (mode == Mode.Motivasi)
                {
                    using (var db = new DatabaseModul())
                    {
                        var query = from tempMotivasi in db.TbMotivasis where tempMotivasi.Nama_Modul == cbNamaModul.SelectedItem.ToString() select tempMotivasi;
                        foreach (var item in query)
                        {
                            Motivasi motivasi = new Motivasi(item.Nama_Modul, item.Exp_Gain, item.Task);
                            FormRunMotivasi form = new FormRunMotivasi(motivasi, Pengalaman);
                            this.Hide();
                            form.ShowDialog();
                        }
                    }
                }

                else if (mode == Mode.Belajar)
                {
                    using (var db = new DatabaseModul())
                    {
                        var query = from tempBelajar in db.TbBelajars where tempBelajar.Nama_Modul == cbNamaModul.SelectedItem.ToString() select tempBelajar;
                        foreach (var item in query)
                        {
                            Belajar belajar = new Belajar(item.Nama_Modul, item.Exp_Gain, item.Jumlah_Task, item.Durasi);
                            FormRunModul form = new FormRunModul(belajar, Pengalaman);
                            if (item.Task_1 != null)
                                belajar.AddTask(item.Task_1, item.drTask_1);
                            if (item.Task_2 != null)
                                belajar.AddTask(item.Task_2, Convert.ToInt32(item.drTask_2));
                            if (item.Task_3 != null)
                                belajar.AddTask(item.Task_3, Convert.ToInt32(item.drTask_3));
                            if (item.Task_4 != null)
                                belajar.AddTask(item.Task_4, Convert.ToInt32(item.drTask_4));
                            if (item.Task_5 != null)
                                belajar.AddTask(item.Task_5, Convert.ToInt32(item.drTask_5));
                            if (item.Task_6 != null)
                                belajar.AddTask(item.Task_6, Convert.ToInt32(item.drTask_6));
                            if (item.Task_7 != null)
                                belajar.AddTask(item.Task_7, Convert.ToInt32(item.drTask_7));
                            if (item.Task_8 != null)
                                belajar.AddTask(item.Task_8, Convert.ToInt32(item.drTask_8));
                            if (item.Task_9 != null)
                                belajar.AddTask(item.Task_9, Convert.ToInt32(item.drTask_9));
                            belajar.ConvertTask();
                            this.Hide();
                            form.ShowDialog();
                        }
                    }
                }

                else if (mode == Mode.Kesehatan)
                {
                    using (var db = new DatabaseModul())
                    {
                        var query = from tempKesehatan in db.TbKesehatans where tempKesehatan.Nama_Modul == cbNamaModul.SelectedItem.ToString() select tempKesehatan;
                        foreach (var item in query)
                        {
                            Kesehatan kesehatan = new Kesehatan(item.Nama_Modul, item.Exp_Gain, item.Jumlah_Task, item.Durasi);
                            FormRunModul form = new FormRunModul(kesehatan, Pengalaman);
                            if (item.Task_1 != null)
                                kesehatan.AddTask(item.Task_1, item.drTask_1);
                            if (item.Task_2 != null)
                                kesehatan.AddTask(item.Task_2, Convert.ToInt32(item.drTask_2));
                            if (item.Task_3 != null)
                                kesehatan.AddTask(item.Task_3, Convert.ToInt32(item.drTask_3));
                            if (item.Task_4 != null)
                                kesehatan.AddTask(item.Task_4, Convert.ToInt32(item.drTask_4));
                            if (item.Task_5 != null)
                                kesehatan.AddTask(item.Task_5, Convert.ToInt32(item.drTask_5));
                            if (item.Task_6 != null)
                                kesehatan.AddTask(item.Task_6, Convert.ToInt32(item.drTask_6));
                            if (item.Task_7 != null)
                                kesehatan.AddTask(item.Task_7, Convert.ToInt32(item.drTask_7));
                            if (item.Task_8 != null)
                                kesehatan.AddTask(item.Task_8, Convert.ToInt32(item.drTask_8));
                            if (item.Task_9 != null)
                                kesehatan.AddTask(item.Task_9, Convert.ToInt32(item.drTask_9));
                            kesehatan.ConvertTask();
                            this.Hide();
                            form.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih salah satu modul yang tersedia untuk dijalankan!!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
