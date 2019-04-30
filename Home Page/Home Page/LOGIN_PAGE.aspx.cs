using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

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
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUserID.Text;
            password = txtPassword.Text;

            string connStr = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
            OleDbConnection connection = new OleDbConnection(connStr);
            connection.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM Customer WHERE [User ID]='" + username + " 'AND [Password]='" + password
                + "'", connection);

            OleDbDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            { 
                Response.Redirect("EXISTING_USER.aspx");
            }
            else
                Response.Redirect("NEW_CUSTOMER.aspx");
        }

  
    }
}