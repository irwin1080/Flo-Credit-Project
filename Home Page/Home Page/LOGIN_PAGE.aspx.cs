using System;
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


        //signs them into their account if they have one registered 
        //if not, they are redirected to sign up 
        //UsingAcessDB example
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            if(con.State==System.Data.ConnectionState.Open)
            {
                //usingAccessDB example to use SQL to pull info from database
                Response.Redirect("EXISTING_USER.aspx");
            }
            else
                Response.Redirect("NEW_CUSTOMER.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}