using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Pengguna
    {
        string Username;
        int Level;
        int exp;

        public Pengguna()
        {
            //constructor
        }

        public void PilihModul()
        {
            ModulGenerator();

            FormModul Form = new FormModul(Username);
            Form.ShowDialog();
        }

        private void ModulGenerator()
        {
            //generates all modul
        }
    }
}
