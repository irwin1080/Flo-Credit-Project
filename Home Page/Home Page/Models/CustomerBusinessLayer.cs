using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Home_Page.Models
{
    public class CustomerBusinessLayer
    {
        public void EditCustomer(Customer cust)
        {
            {
                String connString = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("spEditCustomer", sqlCon);
                    command.CommandType = CommandType.StoredProcedure;
                    //add the aprameteres to the command object

                    SqlParameter paramCustomerID = new SqlParameter
                    {
                        ParameterName = "@CustomerID",
                        Value = cust.CustomerID
                    };
                    command.Parameters.Add(paramCustomerID);

                    SqlParameter paramFirstName = new SqlParameter
                    {
                        ParameterName = "@FirstName",
                        Value = cust.FirstName
                    };
                    command.Parameters.Add(paramFirstName);

                    SqlParameter paramLastName = new SqlParameter
                    {
                        ParameterName = "@LastName",
                        Value = cust.LastName
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
                        ParameterName = "@Zipcode",
                        Value = cust.ZipCode
                    };
                    command.Parameters.Add(paramZipCode);

                    //open the connection
                    sqlCon.Open();
                    //execut the procedure
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteCustomer(Customer cust)
        {
            {
                String connString = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("spDeleteCustomer", sqlCon);
                    command.CommandType = CommandType.StoredProcedure;
                    //add the aprameteres to the command object

                    SqlParameter paramCustomerID = new SqlParameter
                    {
                        ParameterName = "@CustomerID",
                        Value = cust.CustomerID
                    };
                    command.Parameters.Add(paramCustomerID);
                

                    //open the connection
                    sqlCon.Open();
                    //execut the procedure
                    command.ExecuteNonQuery();
                }
            }
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
                    Value = cust.LastName
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
                    ParameterName = "@Zipcode",
                    Value = cust.ZipCode
                };
                command.Parameters.Add(paramZipCode);

                //open the connection
                sqlCon.Open();
                //execut the procedure
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<Customer> Customers
        {
            get
            {
                String connString = ConfigurationManager.ConnectionStrings["CustomerCon"].ConnectionString;
                List<Customer> cust = new List<Customer>();
                using (SqlConnection con = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Customer", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    //read the info from the database table Customer and store it in reader object
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
                        //add the object to the list
                        cust.Add(customer);
                    }
                    //return the list to the calling method
                    return cust;
                }
            }
        }


    }
}