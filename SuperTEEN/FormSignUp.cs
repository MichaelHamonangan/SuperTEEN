﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperTEEN
{
    public partial class FormSignUp : Form
    {
        User newUser;
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void TambahData()
        {
            if(tbNewUsername.Text != "" && tbNewPassword.Text != "" && tbConfirm.Text != "")
            {
                using (var db = new DatabaseUser())
                {
                    try
                    {
                        newUser = new User
                        {
                            Username = tbNewUsername.Text,
                            Password = tbNewPassword.Text,
                            Level = 1,
                            Current_Exp = 0,
                        };
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("User telah ditambahkan! Silahkan Login!!!");
                        this.Hide();
                        FormLogin login = new FormLogin();
                        login.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Maksimal panjang Username adalah 15 dan panjang Password adalah 50!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!!!");
            }    
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbConfirm.Text)
            {
                TambahData();
            }
            else
            {
                MessageBox.Show("input Password tidak sama!!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
    }
}
