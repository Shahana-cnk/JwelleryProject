using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JwelleryApplication
{
    public partial class Admin_Reg : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sr = "select max(Reg_id) from Log_table";
            string Reg_id = conob.Fun_exectscalar(sr);
            int reg_id = 0;
            if(Reg_id=="")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(Reg_id);
                reg_id = newregid + 1;
            }
            string ins="insert into Admin_table values('"+ reg_id + "','"+name.Text+"','"+address.Text+"','"+phone.Text+"','"+email.Text+"')";
            int i = conob.Fun_exenonquery(ins);
            string inslog = "insert into Log_table values('" + reg_id + "','Admin','" + username.Text + "','" + cnfrmpassword.Text + "','Active')";
            int s = conob.Fun_exenonquery(inslog);
            if(i!=0 && s!=0)
            {
                Label8.Text = "Registered!!!";
            }
        }

      
    }
}