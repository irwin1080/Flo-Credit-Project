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
        public IEnumerable<Customer> Customers
        {
            get
            {
                String connString = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
                List<Customer> custy = new List<Customer>();
                using (SqlConnection con = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("Select * From Customer", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = Convert.ToInt32(reader[0]);
                        customer.FirstName = reader[1].ToString();
                        customer.LastName = reader[2].ToString();
                        customer.Street = reader[3].ToString();
                        customer.City = reader[4].ToString();
                        customer.State = reader[5].ToString();
                        customer.ZipCode = Convert.ToInt32(reader[6]);
                        customer.SSN = Convert.ToInt32(reader[7]);
                        customer.Username = reader[8].ToString();
                        customer.Password = reader[9].ToString();
                        customer.AnnualIncome = Convert.ToInt32(reader[10]);



                        custy.Add(customer);
                    }
                    return custy;
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String connString = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("spAddCustomer", sqlCon);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paramFirstName = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = txtFirstName.Text
                };
                command.Parameters.Add(paramFirstName);

                SqlParameter paramLastName = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = txtLastName.Text
                };
                command.Parameters.Add(paramLastName);

                SqlParameter paramStreet1 = new SqlParameter
                {
                    ParameterName = "@Street1",
                    Value = txtStreet1.Text
                };
                command.Parameters.Add(paramStreet1);

                SqlParameter paramStreet2 = new SqlParameter
                {
                    ParameterName = "@Street2",
                    Value = txtStreet2.Text
                };
                command.Parameters.Add(paramStreet2);

                SqlParameter paramCity = new SqlParameter
                {
                    ParameterName = "@City",
                    Value = txtCity.Text
                };
                command.Parameters.Add(paramCity);

                SqlParameter paramState = new SqlParameter
                {
                    ParameterName = "@State",
                    Value = txtState.Text
                };
                command.Parameters.Add(paramState);

                SqlParameter paramZipCode = new SqlParameter
                {
                    ParameterName = "@ZipCode",
                    Value = txtZipCode.Text
                };
                command.Parameters.Add(paramZipCode);

                SqlParameter paramSSN = new SqlParameter
                {
                    ParameterName = "@SSN",
                    Value = txtSSN.Text
                };
                command.Parameters.Add(paramSSN);

                SqlParameter paramUsername = new SqlParameter
                {
                    ParameterName = "@Username",
                    Value = txtUserName.Text
                };
                command.Parameters.Add(paramUsername);

                SqlParameter paramPassword = new SqlParameter
                {
                    ParameterName = "@Password",
                    Value = txtPassword.Text
                };
                command.Parameters.Add(paramPassword);

                SqlParameter paramAnnualIncome = new SqlParameter
                {
                    ParameterName = "@AnnualIncome",
                    Value = txtAnnualIncome.Text
                };
                command.Parameters.Add(paramAnnualIncome);

                sqlCon.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}