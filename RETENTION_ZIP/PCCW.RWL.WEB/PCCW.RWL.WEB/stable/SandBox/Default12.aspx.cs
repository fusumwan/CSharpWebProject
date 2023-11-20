using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SandBox_Default12 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["uid"] = "A8350006";
        Session["lv"] = "65535";
        Session["arprog"] = "RWLN";
        Session["channel"] = string.Empty;
    }
}