using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Exp
    {
        public int currentExp;
        public int currentLevel;

        public Exp(int poin, int level)
        {
            currentExp = poin;
            currentLevel = level;
        }

        public void GainExp(int Exp)
        {
            currentExp += Exp;

            //konvert ke level apabila exp sudah di limit, sementara limit 1000 pada semua level
            if (currentExp>1000)
            {
                currentLevel += (currentExp/1000);
                currentExp %= 1000;
            }
        }
    }
}
