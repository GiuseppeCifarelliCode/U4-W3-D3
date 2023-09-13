using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMessage.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string psw = password.Text;
            if (user == ConfigurationManager.AppSettings["user"]
                && psw == ConfigurationManager.AppSettings["psw"])
            {
                FormsAuthentication.SetAuthCookie(username.Text, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
            else errorMessage.Visible = true;
        }
    }
}