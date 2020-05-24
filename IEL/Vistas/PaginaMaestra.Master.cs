using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ELv1.Pages
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_OnClick(object Source, EventArgs e)
        {
            Session.Abandon();

            Response.Redirect("Login.aspx");
            
        }
    }
}