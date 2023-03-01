using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace JwelleryApplication
{
    public partial class Login : System.Web.UI.Page
    {
        Conclass conobj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LOGIN_BUTTON_Click(object sender, EventArgs e)
        {
            string l = "select count(Reg_id) from log_table where User_name='" + usernametxt.Text + "' and Password='" + passwordtxt.Text + "'";
            string s = conobj.Fun_exectscalar(l);
            if (s != null)
            {
                string str = "select Reg_id,Log_type from log_table where User_name='" + usernametxt.Text + "' and Password='" + passwordtxt.Text + "'";
                SqlDataReader dr = conobj.Fun_ExeReader(str);
                while (dr.Read())
                {
                    Session["userid"] = dr["Reg_id"].ToString();
                    string utype = dr["Log_type"].ToString();
                    if (utype == "Admin")
                    {
                        Response.Redirect("ViewCategory.aspx");
                    }
                    else if (utype == "User")
                    {
                        Response.Redirect("View_Shop.aspx");
                    }
                }
             

                
            }
        }
    }
}