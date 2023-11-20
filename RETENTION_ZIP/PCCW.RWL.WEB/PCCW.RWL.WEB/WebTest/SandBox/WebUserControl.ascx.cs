using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SandBox_WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["test"] != null)
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["test"] = "abc";

        this.NamingContainer.FindControl("w2").DataBind();
        
    }

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        if (Session["test"] != null)
        {

        }
    }


}
