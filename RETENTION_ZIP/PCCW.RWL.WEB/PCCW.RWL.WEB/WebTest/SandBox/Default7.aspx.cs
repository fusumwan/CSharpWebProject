using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SandBox_Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Apple")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("AAA");
            DropDownList2.Items.Add("AAA");
            DropDownList2.Items.Add("AAA");
        }
        else
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("BBB");
            DropDownList2.Items.Add("BBB");
            DropDownList2.Items.Add("BBB");
        }
    }
}
