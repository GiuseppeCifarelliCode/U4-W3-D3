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
            logoutButton.Visible = false;

            if (Request.Cookies != null)
            {
                logoutButton.Visible = true;
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect(FormsAuthentication.LoginUrl);
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(FormsAuthentication.LoginUrl);
        }
    }
}