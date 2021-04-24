using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    abstract class Modul
    {
        private string modulName;
        private int expGained;

        public string ModulName { get => modulName; set => modulName = value; }
        public int ExpGained { get => expGained; set => expGained= value; }

        internal Modul(string modulName, int exp)
        {
            ModulName = modulName;
            ExpGained = exp;
        }

        public virtual int ModulExecute()
        {
            MessageBox.Show("Task yang harus dilakukan akan tertampil");
            //menampilkan task
            return expGained;
        }
    }
}
