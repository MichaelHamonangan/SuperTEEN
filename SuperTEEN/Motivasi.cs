using System;
using System.Collections.Generic;
using System.Text;

namespace SuperTEEN
{
    class Motivasi : Modul
    {
        public string task;

        public Motivasi(string modulName, int exp, string Task) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;
            task = Task;
        }
    }
}
