using Sudoko.modal;
using Sudoko.view_controller;
using Sudoku;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Sudoko
{
    public partial class registrationform : Form
    {
        public registrationform()
        {
            InitializeComponent();
        }       


        private void btn_Save_Click(object sender, EventArgs e)
        {
            player s = new player("","");
            if (s.checkUsername(txtEmail.Text))
            {
                MessageBox.Show("enter your email");
            }
            else if (s.checkPassword(txtPassword.Text))
            {
                MessageBox.Show("enter your password");
            }
            else
            {
                s = new player(txtEmail.Text, txtPassword.Text);
                s.register();
                MessageBox.Show("register sucessfull");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login r = new login();
            r.ShowDialog();
            r.Close();

        }
    }
}

   
    

