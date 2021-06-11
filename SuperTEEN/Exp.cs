using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SuperTEEN
{
    class Exp
    {
        private string username;
        private int currentExp;
        private int currentLevel;
        private int expToLevelUp;

        public int CurrentExp { get => currentExp; set => currentExp = value; }
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        public string Username { get => username; set => username = value; }
        public int ExpToLevelUp { get => expToLevelUp; set => expToLevelUp = value; }


        public Exp(string name, int poin, int level)
        {
            Username = name;
            CurrentExp = poin;
            CurrentLevel = level;

            if (level < 38)
                expToLevelUp = 500 + (level - 1) * 250;
            else
                expToLevelUp = 10000;
        }

        public void GainExp(int num)
        {
            currentExp += num;

            if (currentExp>= expToLevelUp)
            {
                currentLevel += (currentExp/ expToLevelUp);
                currentExp %= expToLevelUp;
            }

            using (var db = new DatabaseUser())
            {
                var result = db.Users.SingleOrDefault(k => k.Username == username);
                result.Level = currentLevel;
                result.Current_Exp = currentExp;
                db.SaveChanges();
            }

            if (currentLevel < 38)
                expToLevelUp = 500 + (currentLevel - 1) * 250;
            else
                expToLevelUp = 10000;
        }
    }
}
