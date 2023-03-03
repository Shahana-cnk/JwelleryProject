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
    public partial class View_Buy : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
         if(!IsPostBack)
            {
                Data_bind();
            }
        }
        public void Data_bind()
        {
            string sel= "select * from Product_table where Pdt_id="+Session["pdt_id"]+"";
            SqlDataReader dr = conob.Fun_ExeReader(sel);
            if(dr.Read()==true)
            {
                Label1.Text = dr["Pdt_name"].ToString();
                Label2.Text = dr["Pdt_desc"].ToString();
                ImageButton1.ImageUrl = dr["Pdt_image"].ToString();
                Label3.Text = dr["Pdt_price"].ToString();
                Label4.Text = dr["Pdt_id"].ToString();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Cart_table values('" + Label4.Text + "','"+ Session["userid"] + "','"+TextBox1.Text+"','"+Label3.Text+"')";
            int i = conob.Fun_exenonquery(ins);
            if(i!=0)
            {
                
               // Response.Write("ADDED TO CART");
            }
        }
    }
}