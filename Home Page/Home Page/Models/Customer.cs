using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home_Page.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}