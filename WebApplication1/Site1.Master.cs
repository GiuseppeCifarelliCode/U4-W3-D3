using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies != null)
            {
                loginButton.Text = "Logout";
                loginButton.CssClass = "btn btn-danger";
            }
            else
            {
                loginButton.Text = "Login";
                loginButton.CssClass = "btn btn-primary";
            }

        }


        protected void loginButton_Click(object sender, EventArgs e)
        {
            if(loginButton.Text == "Login")
            Response.Redirect(FormsAuthentication.LoginUrl);
            else
            {
                FormsAuthentication.SignOut();
                Response.Redirect(FormsAuthentication.LoginUrl);
            }
        }
    }
}