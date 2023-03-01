using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JwelleryApplication
{
    public partial class User_Reg : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_id) from Log_table";
            string regid = conob.Fun_exectscalar(sel);
            int Reg_id = 0;
            if(regid=="")
            {
                Reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                Reg_id = newregid + 1;
            }
            string ch = DropDownList1.SelectedItem.Text;
            string r = RadioButtonList1.SelectedItem.Text;
            string img = "~/userpic/"+FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            
            string insuser = "insert into User_table values("+Reg_id+",'"+name.Text+"',"+age.Text+",'"+address.Text+"','"+ch+"','"+pincode.Text+"','"+phone.Text+"','"+email.Text+"','"+r+"','"+img+"')";
            int i = conob.Fun_exenonquery(insuser);
            string inslog = "insert into Log_table values(" +Reg_id+ ",'User','" + username.Text + "','" + Password.Text+ "','Active')";
            int s = conob.Fun_exenonquery(inslog);
            if (i != 0 && s != 0)
            {
                Label8.Text = "Registered!!!";
            }
        }
    }
}