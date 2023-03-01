using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JwelleryApplication
{
    public partial class Add_category : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string img = "~/category_img/"+FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            string ins = "insert into Category_table values('" + category_name.Text + "','" + img + "','" + category_description.Text + "','Active')";
            int i = conob.Fun_exenonquery(ins);
            if(i!=0)
            {
                Label4.Text = "Inserted Successfully!!";

            }

        }
    }
}