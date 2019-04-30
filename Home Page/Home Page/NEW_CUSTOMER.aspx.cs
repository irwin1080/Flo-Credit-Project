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
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Street1", txtStreet1.Text);
            cmd.Parameters.AddWithValue("@Street2", txtStreet2.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@State", txtState.Text);
            cmd.Parameters.AddWithValue("@SSN", txtSSN.Text);
            cmd.Parameters.AddWithValue("@Income", txtAnnualIncome.Text);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            connectionString.Open();

            cmd.ExecuteNonQuery();

            connectionString.Close();

            Response.Redirect("EXISTING_USER.aspx");

        }
    }

}