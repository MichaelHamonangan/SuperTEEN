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

            if (currentExp>1000)
            {
                currentLevel += (currentExp/1000);
                currentExp %= 1000;
            }
        }
    }
}
