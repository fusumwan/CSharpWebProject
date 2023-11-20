using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SandBox_WebUserControl2 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["test"] != null)
            Response.Write(Session["test"].ToString());
    }

    public override void DataBind()
    {
        if (Session["test"] != null)
        {

        }
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        if (Session["test"] != null)
        {

        }
    }
}
