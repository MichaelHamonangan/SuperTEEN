using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SuperTEEN
{
    class Pengguna
    {
        private string username;
        private int level;
        private int exp;
        private Exp pengalaman;
        public Belajar[] arrBelajar;
        public Kesehatan[] arrKesehatan;
        public Motivasi[] arrMotivasi;
        //TbBelajar tbbelajar;
        //TbKesehatan tbkesehatan;
        //TbMotivasi tbmotivasi;

        public string Username { get => username; set => username = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        internal Exp Pengalaman { get => pengalaman; set => pengalaman = value; }

        public Pengguna(string username, int level, int exp)
        {
            Username = username;
            Level = level;
            Exp = exp;

            Pengalaman = new Exp(level,exp);
        }

        public void ModulGenerator()
        {
            List<Belajar> lstBelajar = new List<Belajar>();
            List<Kesehatan> lstKesehatan = new List<Kesehatan>();
            List<Motivasi> lstMotivasi = new List<Motivasi>();

            using (var db = new DatabaseModul())
            {
                var query1 = from tbmotivasi in db.TbMotivasis select tbmotivasi;
                foreach (var item in query1)
                {
                    Motivasi motivasi = new Motivasi(item.Nama_Modul, item.Exp_Gain, item.Task);
                    lstMotivasi.Add(motivasi);
                }

                var query2 = from tbbelajar in db.TbBelajars select tbbelajar;
                foreach (var item in query2)
                {
                    Belajar belajar = new Belajar(item.Nama_Modul, item.Exp_Gain, item.Jumlah_Task, item.Durasi);
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
                    lstBelajar.Add(belajar);
                }

                var query3 = from tbkesehatan in db.TbKesehatans select tbkesehatan;
                foreach (var item in query3)
                {
                    Kesehatan kesehatan = new Kesehatan(item.Nama_Modul, item.Exp_Gain, item.Jumlah_Task, item.Durasi);
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
                    lstKesehatan.Add(kesehatan);
                }
            }

            arrBelajar = lstBelajar.ToArray();
            arrKesehatan = lstKesehatan.ToArray();
            arrMotivasi = lstMotivasi.ToArray();
        }
    }
}
