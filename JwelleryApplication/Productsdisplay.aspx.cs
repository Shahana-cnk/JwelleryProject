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
    public partial class Productsdisplay : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Data_Bind();
            }
        }
        public void Data_Bind()
        {
            Response.Write(Session["Cat_id"]);
            string sel = "select Pdt_Id,Pdt_name,Pdt_image,Pdt_desc,Pdt_price,Pdt_status from Product_table where Cat_id='" + Session["Cat_id"] + "'";
            SqlDataReader ds = conob.Fun_ExeReader(sel);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["pdt_id"] = id;
            Response.Redirect("View_single_product.aspx");
        }
    }
}