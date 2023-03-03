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

        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //    DataList1.SelectedIndex = e.Item.ItemIndex;
        //    label4.Text = "You selected: " + ((Label)DataList1.SelectedItem.FindControl("Label1")).Text;
        //    myTempLabel.Visible = true;
        //    int price = DataList1.DataKeys[];
        //    //string ins = "insert into Cart_table values()";

        //}

        //protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        //{
        //    DataList1.SelectedIndex = e.Item.ItemIndex;
        //    Label4.Text = "You selected: " + ((Label)DataList1.SelectedItem.FindControl("Label1")).Text;
        //    myTempLabel.Visible = true;
        //}

        protected void DataList1_ItemCommand1(object source, DataListCommandEventArgs e)
        {

        }
    }
}