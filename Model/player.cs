using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Sudoko.modal;
using Sudoko.database;
using Sudoko.view_controller;


namespace Sudoko.modal
{
    class player
    {
        dbconnection db = new dbconnection();
        private string fullName;
        private string email;
        private string password;
        private string confirmPassword;


        public player(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        public DataTable register()
        {
            try
            {
                string query = "insert into tbl_players values('" + Email + "','" + Password + "')";
                DataTable dt = db.getdata(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean checkUsername(string email)
        {
            if (string.IsNullOrEmpty(email))

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable login()
        {
            try
            {
                string query;
                query = "select * from tbl_players where email='" + email + "' and  password='" + password + "'";
                DataTable dt = db.getdata(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean checkuser(string n, string m)
        {
            DataTable dt = login();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
