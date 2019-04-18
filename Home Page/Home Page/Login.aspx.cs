using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Page
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userID, password;

            userID = txtUserID.Text;
            password = txtPassword.Text;

            if (userID == "admin" && password == "admin")
            {
                //lblLoginMsg.Text = " Welcome Admin";
                Response.Redirect("ExistingUser.aspx");
            }
            else
            {
                lblLoginMsg.Text = "ID/Password do not exist";
            }
        }
    }
}