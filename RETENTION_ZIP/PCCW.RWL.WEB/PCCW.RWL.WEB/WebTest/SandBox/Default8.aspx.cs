using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class SandBox_Default8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[, ,] array3D = new int[,,] {
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            }, 
                                 
            {
                { 7, 8, 9 }, 
                { 10, 11, 12 } 
            } 
        };

        Response.Write(array3D[1, 2, 3].ToString());

        GridView1.PageIndex = 1;
        GridView1.DataBind();
    }
    protected void GridView1_DataBinding(object sender, EventArgs e)
    {

    }
    protected void GridView1_DataBound(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
    }
    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {

    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {

    }
}
