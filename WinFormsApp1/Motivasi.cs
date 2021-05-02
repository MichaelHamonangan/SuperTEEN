using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Motivasi : Modul
    {
        public string Task;

        public Motivasi(string modulName, int exp, string Task) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;
            this.Task = Task;
        }

        public int MotivasiExecute()
        {
            var rand = new Random();
            int angkaRandom = rand.Next(101);
            
            //membandingkan angka random dengan id pada database, lalu mengambil task namenya dan menampilkannya
            return ExpGained;
        }
    }
}
