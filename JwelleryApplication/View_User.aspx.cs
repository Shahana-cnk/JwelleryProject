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
    public partial class View_User : System.Web.UI.Page
    {
        Conclass conob = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string user = "select User_table.User_id,User_table.User_name,User_table.User_age,User_table.User_address,User_table.User_state,User_table.User_pincode,User_table.User_contact,Log_table.User_name,Log_table.Status from User_table join Log_table on User_table.User_id=Log_table.Reg_id";
                var ds = conob.Fun_ExeReader(user);
                DataList1.DataSource = ds; 
                DataList1.DataBind();
            }

        }
    }
}