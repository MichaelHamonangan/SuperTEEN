using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Motivasi : Modul
    {
        private string Task;

        public Motivasi(string modulName, int exp) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;

            //generate variabel Task dari database
        }

        public int MotivasiExecute()
        {
            var rand = new Random();
            int angkaRandom = rand.Next(101));
            
            //membandingkan angka random dengan id pada database, lalu mengambil task namenya dan menampilkannya
            return ExpGained;
        }
    }
}
