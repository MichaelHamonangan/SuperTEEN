using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
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
            //membuat semua modul dari database dimasukan dalam list modul
            List<Belajar> lstBelajar = new List<Belajar>();
            List<Kesehatan> lstKesehatan = new List<Kesehatan>();
            List<Motivasi> lstMotivasi = new List<Motivasi>();

            //mengubah list ke bentuk array
            arrBelajar = lstBelajar.ToArray();
            arrKesehatan = lstKesehatan.ToArray();
            arrMotivasi = lstMotivasi.ToArray();
        }
    }
}
