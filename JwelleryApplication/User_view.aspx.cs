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
    public partial class User_view : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_grid();
            }

        }
        public void Bind_grid()
        {
            string sel= "select User_table.User_id,User_table.User_name,Log_table.User_name,Log_table.Status from User_table join Log_table on User_table.User_id = Log_table.Reg_id";
            DataSet ds = conob.Fun_ExeAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
       

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            string upd = "update Log_table set Status='Inactive' where Reg_id='" + id+"' ";
            int u= conob.Fun_exenonquery(upd);
            GridView1.EditIndex = -1;
            Bind_grid();
        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_grid();

        }
    }
}