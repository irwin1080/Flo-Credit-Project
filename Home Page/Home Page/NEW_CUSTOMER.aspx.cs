using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Home_Page
{
    public partial class NEW_CUSTOMER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection(@"Data Source=customer-flo-credit.database.windows.net;Initial Catalog=CUSTOMER_DB;User ID=Customer;Password=FloCredit1;Connect Timeout=60;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("spAddCustomer", connectionString);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@DOB", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Email", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Street1", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Street2", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@City", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@State", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@SSN", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Income", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@UserName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Password", txtFirstName.Text);

            connectionString.Open();

            cmd.ExecuteNonQuery();

            connectionString.Close(); 


        }
    }

}