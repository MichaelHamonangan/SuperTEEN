using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Motivasi : Modul
    {

        public Motivasi(string modulName, int exp) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;
        }

        public int MotivasiExecute()
        {
            //secara random menampilkan modul-modul motivasi

            return ExpGained;
        }
    }
}
