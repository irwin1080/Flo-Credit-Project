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


        protected void btnButton1_Click(object sender, EventArgs e)
        {
            string userID, password;
            userID = txtUserID.Text;
            password = txtPassword.Text;

            string connStr = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
            OleDbConnection connection = new OleDbConnection(connStr);
            //SqlConnection connectionString = new SqlConnection(@"Data Source=customer-flo-credit.database.windows.net;Initial Catalog=CUSTOMER_DB;User ID=Customer;Password=FloCredit1;Connect Timeout=60;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //SqlCommand cmd = new SqlCommand("spEditCustomer", connectionString);
            connection.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM Customer WHERE [UserName]='" + userID + " 'AND [Password]='" + password
                + "'", connection);

            OleDbDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                Response.Redirect("EXISTING_USER.aspx");
            }
            else
            {
                Response.Redirect("NEW_CUSTOMER.aspx");
            }
        }


    }
}