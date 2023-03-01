using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace JwelleryApplication
{
    public partial class Add_Product : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string d = "select Cat_id,Cat_name from Category_table";
                DataSet ds = conob.Fun_ExeAdapter(d);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Cat_name";
                DropDownList1.DataValueField = "Cat_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "--select--");
             }

             }

            protected void Button1_Click(object sender, EventArgs e)
        {
            string d = DropDownList1.SelectedItem.Value;
            string img = "~/Product_img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            string ins= "insert into Product_table values('"+d+"','"+Pro_Name.Text+"','"+img+"','"+Pro_Desc.Text+"','"+Pro_price.Text+"','"+ pro_status.Text + "','"+Pro_Stock.Text+"')";
            int i = conob.Fun_exenonquery(ins);
            if(i!=0)
            {
                Label7.Text = "Successfully inserted";
            }

        }
    }
}