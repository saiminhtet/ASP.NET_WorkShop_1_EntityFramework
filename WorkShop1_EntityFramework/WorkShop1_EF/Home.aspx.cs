using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;

namespace WorkShop1_EF
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IIdentity id = User.Identity;
            Label1.Text = String.Format("IsAuthenticated:{0}, Name:{1}, Type:{2}",
                id.IsAuthenticated, id.Name, id.AuthenticationType);
        }
    }
}