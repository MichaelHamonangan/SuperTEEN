using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace SuperTEEN
{
    class Belajar : Modul
    {
        public int NOTask;
        public int Durasi;

        public Belajar(string modulName, int exp, int n,int Durasi) : base(modulName, exp)
        {
            ModulName = modulName;
            ExpGained = exp;
            NOTask = n;
            this.Durasi = Durasi;
        }

        public override void AddTask(string task, int duration)
        {
            lstTask.Add(task);
            lstDuration.Add(duration);
            return ;
        }
    }
}
