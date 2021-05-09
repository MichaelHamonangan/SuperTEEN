using System;
using System.Collections.Generic;
using System.Text;

namespace SuperTEEN
{
    class Exp
    {
        private int currentExp;
        private int currentLevel;

        public int CurrentExp { get => currentExp; set => currentExp = value; }
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }

        public Exp(int poin, int level)
        {
            CurrentExp = poin;
            CurrentLevel = level;
        }

        public void GainExp(int Exp)
        {
            currentExp += Exp;

            //konvert ke level apabila exp sudah di limit, sementara akan di limit 1000 pada semua level
            if (currentExp>1000)
            {
                currentLevel += (currentExp/1000);
                currentExp %= 1000;
            }
        }
    }
}
