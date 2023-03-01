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
    
    public partial class View_Shop : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Data_bind();
            }

        }
        public void Data_bind()
        {
            string sel = "select Cat_id,Cat_Image,Cat_name from Category_table ";
           
            SqlDataReader ds = conob.Fun_ExeReader(sel);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            
            int id = Convert.ToInt32(e.CommandArgument);
            Session["Cat_id"] = id;
            Response.Redirect("Productsdisplay.aspx");
        }
    }
}