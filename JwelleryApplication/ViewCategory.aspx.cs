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
    public partial class ViewCategory : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
         if(!IsPostBack)
            {
                Bind_data();
            }
        }
        public void Bind_data()
        {
            string s = "select * from Category_table";
            DataSet ds = conob.Fun_ExeAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Category_table where Cat_id=" + id + "";
            int d = conob.Fun_exenonquery(del);
            Bind_data();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_data();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[1].Controls[0];
            TextBox img = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox txtdecs = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            string up = "update Category_table set Cat_name='" + txtname.Text + "',Cat_image='"+img.Text+"',Cat_desc='" + txtdecs.Text + "',Cat_status='" + txtstatus.Text + "' where Cat_id="+id+"";
            int u = conob.Fun_exenonquery(up);
            GridView1.EditIndex = -1;
            Bind_data();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_category.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Product.aspx");
        }
    }
}