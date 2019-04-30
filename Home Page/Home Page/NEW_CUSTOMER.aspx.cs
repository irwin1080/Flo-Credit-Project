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
            Customer cust = new Customer(); 
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }

    public Create(string firstName, string lastName, string street, string city, string state, int zipcode)
    {
      
        Customer cust = new Customer();
        cust.FirstName = firstName;
        cust.LastName = lastName;
        cust.Street = street;
        cust.City = city;
        cust.State = state;
        cust.ZipCode = zipcode;

        Customer.AddCustomer(cust);


     
    }

    public void AddCustomer(Customer cust)
    {
        String connString = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
        using (SqlConnection sqlCon = new SqlConnection(connString))
        {
            SqlCommand command = new SqlCommand("spAddCustomer", sqlCon);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter paramFirstName = new SqlParameter
            {
                ParameterName = "@FirstName",
                Value = cust.FirstName
            };
            command.Parameters.Add(paramFirstName);

            SqlParameter paramLastName = new SqlParameter
            {
                ParameterName = "@LastName",
                Value = cust.FirstName
            };
            command.Parameters.Add(paramLastName);

            SqlParameter paramStreet = new SqlParameter
            {
                ParameterName = "@Street",
                Value = cust.Street
            };
            command.Parameters.Add(paramStreet);

            SqlParameter paramCity = new SqlParameter
            {
                ParameterName = "@City",
                Value = cust.City
            };
            command.Parameters.Add(paramCity);

            SqlParameter paramState = new SqlParameter
            {
                ParameterName = "@State",
                Value = cust.State
            };
            command.Parameters.Add(paramState);

            SqlParameter paramZipCode = new SqlParameter
            {
                ParameterName = "@ZipCode",
                Value = cust.ZipCode
            };
            command.Parameters.Add(paramZipCode);

            sqlCon.Open();
            command.ExecuteNonQuery();
        }
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

                    custy.Add(customer);
                }
                return custy;
            }
        }
    }
}