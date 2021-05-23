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

        public int CurrentExp { get => currentExp; set => currentExp = value; }
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        public string Username { get => username; set => username = value; }

        public Exp(string name, int poin, int level)
        {
            Username = name;
            CurrentExp = poin;
            CurrentLevel = level;
        }

        public void GainExp(int num)
        {
            currentExp += num;

            if (currentExp>1000)
            {
                currentLevel += (currentExp/1000);
                currentExp %= 1000;
            }

            using (var db = new DatabaseUser())
            {
                var result = db.Users.SingleOrDefault(k => k.Username == username);
                result.Level = currentLevel;
                result.Current_Exp = currentExp;
                db.SaveChanges();
            }
        }
    }
}
