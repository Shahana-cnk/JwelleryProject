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
    public partial class View_Products : System.Web.UI.Page
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
            string sel = "select * from Product_table";
            DataSet ds = conob.Fun_ExeAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

        //protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    int i = e.RowIndex;
        //    int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
        //    string del = "delete from Product_table where Pdt_id=" + id + "";
        //    int d = conob.Fun_exenonquery(del);
        //    Bind_data();
        //}

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
            TextBox txtimage = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtprice = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtstock = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];

            string up= "update Product_table set Pdt_name='"+ txtname.Text + "',Pdt_image='" + txtimage.Text + "',Pdt_desc='" + txtdesc.Text + "',Pdt_price='"+ txtprice.Text + "',Pdt_status='"+ txtstatus.Text + "',Pdt_stock='"+ txtstock.Text + "' where Pdt_id="+id+"";
            int u = conob.Fun_exenonquery(up);
            GridView1.EditIndex = -1;
            Bind_data();

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}





