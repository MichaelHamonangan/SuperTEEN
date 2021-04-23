using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Belajar : Modul
    {
        int i;
        //i adalah banyaknya task

        public Belajar(string modulName, int exp, int i) : base(modulName, exp)
        {
            this.modulName = modulName;
            expGained = exp;
            this.i = i;
        }
    }
}
