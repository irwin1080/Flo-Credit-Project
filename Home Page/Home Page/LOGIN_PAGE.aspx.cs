﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Home_Page
{
    public partial class LOGIN_PAGE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public string conString = "Data Source=customer-flo-credit.database.windows.net;Initial Catalog=CUSTOMER_DB;Persist Security Info=True;User ID=Customer;Password=***********";

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            if(con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into Test(id, name)values('" + txtUserID.Text.ToString() + "','" + txtPassword.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                Response.Redirect("EXISTING_USER.aspx");
            }
            else
                Response.Redirect("NEW_CUSTOMER.aspx");
        }
    }
}