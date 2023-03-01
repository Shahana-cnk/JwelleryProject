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
    public partial class View_single_product : System.Web.UI.Page
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
            string sel = "select Pdt_id,Pdt_name,Pdt_image,Pdt_desc,Pdt_price,Pdt_status from Product_table where Pdt_id= '" + Session["pdt_id"] + "'";
            SqlDataReader dr = conob.Fun_ExeReader(sel);
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int i =Convert.ToInt32( e.CommandArgument);


        }

       
    }
}