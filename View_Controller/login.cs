using Sudoku;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sudoko.database;
using Sudoko.modal;

namespace Sudoko.view_controller
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            player p = new player(txtemail.Text, txtpass.Text);

            if (p.checkUsername(txtemail.Text))
            {
                MessageBox.Show("enter your email");
            }
            else if (p.checkPassword(txtpass.Text))
            {
                MessageBox.Show("enter your password");
            }
            else
            {

                bool validuser = p.checkuser(txtemail.Text, txtemail.Text);
                if (validuser)
                {
                    this.Hide();
                    SudokuMainForm s = new SudokuMainForm();
                    s.ShowDialog();
                }
                else
                {
                    MessageBox.Show("incorrect username and password");
                    txtemail.Text = txtpass.Text = "";
                }
            }
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationform r = new registrationform();
            r.ShowDialog();
            this.Close();
        }
    }
}
