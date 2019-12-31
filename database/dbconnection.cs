using System;
using System.Collections.Generic;
using System.Text;
using Sudoko.view_controller;
using System.Data;
using System.Data.SqlClient;
namespace Sudoko.database
{
    class dbconnection
    {
        SqlConnection con;
        public dbconnection()
        {
            string connection = "Data Source=.;Initial Catalog=Sudoku;Integrated Security=True";
            con = new SqlConnection(connection);
        }
        public int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {  con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;}
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }}}
        public DataTable getdata(string query)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            }   }
}
