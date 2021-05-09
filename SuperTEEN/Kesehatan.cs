using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SuperTEEN
{
    class Kesehatan : Modul
    {
        public int NOTask;
        public int Durasi;

        public Kesehatan(string modulName, int exp, int n,int Durasi) : base(modulName, exp)
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
            return;
        }
    }
}
