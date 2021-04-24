using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Kesehatan : Modul
    {
        private int task;
        //i adalah banyaknya task

        public Kesehatan(string modulName, int exp, int i) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;
            task = i;
        }

        public override int ModulExecute()
        {
            //melakukan check jumlah task pada database
            for (int i = 0; i < task; i++)
            {
                //Menampilkan task dengan placeholder melalui database + 2*i
                //Durasi task pada placeholder task+1
            }

            return ExpGained;
        }
    }
}
