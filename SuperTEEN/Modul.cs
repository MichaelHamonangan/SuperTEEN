using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SuperTEEN
{
    abstract class Modul
    {
        private string modulName;
        private int expGained;
        internal string[] Task;
        internal int[] drTask;
        internal List<string> lstTask = new List<string>();
        internal List<int> lstDuration = new List<int>();

        public string ModulName { get => modulName; set => modulName = value; }
        public int ExpGained { get => expGained; set => expGained= value; }

        internal Modul(string modulName, int exp)
        {
            ModulName = modulName;
            ExpGained = exp;
        }
        public virtual void ConvertTask()
        {
            Task = lstTask.ToArray();
            drTask = lstDuration.ToArray();
            return;
        }

        public virtual void AddTask(string task, int duration)
        {
            return;
        }

        public virtual int ModulExecute()
        {
            MessageBox.Show("Task yang harus dilakukan akan tertampil");
            return expGained;
        }
    }
}
