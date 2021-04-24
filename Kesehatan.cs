using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Kesehatan : Modul
    {
        private int NOTask;
        private string[] Task;
        private int[] drTask;

        public Kesehatan(string modulName, int exp, int i) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;
            NOTask = i;

            Task = new string[NOTask];
            drTask = new int[NOTask];
        }

        public override int ModulExecute()
        {
            //melakukan check task pada database dan memasukkannya ke array Task dan drTask
            for (int i = 0; i < NOTask; i++)
            {
                //nanti akan dibuat form kecil berisi task-task yang akan dilakukan beserta timer
                Console.Write("Lakukan :/n{0}/n/nSelama : {1} detik", Task[i], drTask[i].ToString());
                Thread.Sleep(drTask[i] * 1000);
            }

            return ExpGained;
        }
    }
}
