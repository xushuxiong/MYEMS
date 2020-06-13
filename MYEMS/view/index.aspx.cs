using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS.view
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string username=(string) Session["username"];
            if (username == null)
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}