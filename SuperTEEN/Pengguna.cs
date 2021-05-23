using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SuperTEEN
{
    class Pengguna
    {
        private string username;
        private int level;
        private int exp;
        private Exp pengalaman;

        public string Username { get => username; set => username = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        internal Exp Pengalaman { get => pengalaman; set => pengalaman = value; }

        public Pengguna(string username, int level, int exp)
        {
            Username = username;
            Level = level;
            Exp = exp;

            Pengalaman = new Exp(username, exp, level);
        }
    }
}
