using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace JwelleryApplication
{
    public class Conclass
    {


            SqlConnection con;
            SqlCommand cmd;
            public Conclass()
            {
                con = new SqlConnection(@"server=LAPTOP-2T71K6I6\SQLEXPRESS;database=E_Commerce;Integrated security=true");
            }
            public int Fun_exenonquery(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            public string Fun_exectscalar(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                string s = cmd.ExecuteScalar().ToString();
                con.Close();
                return s;

            }

            public SqlDataReader Fun_ExeReader(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            public DataSet Fun_ExeAdapter(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }

        

    }
}