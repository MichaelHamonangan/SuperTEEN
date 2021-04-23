using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    abstract class Modul
    {
        public string modulName;
        public int expGained;

        internal Modul(string modulName, int exp)
        {
            this.modulName = modulName;
            expGained = exp;
        }

        void ModulExecute()
        { 
        }
    }
}
