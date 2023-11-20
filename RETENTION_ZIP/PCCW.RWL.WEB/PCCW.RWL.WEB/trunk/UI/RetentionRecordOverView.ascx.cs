using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UI_RetentionRecordOverView : System.Web.UI.UserControl
{
    public Label _rwl_record_id
    {
        get
        {
            return (Label)this.FindControl("rwl_record_id");
        }
    }
    public Label _rwl_order_id
    {
        get
        {
            return (Label)this.FindControl("rwl_order_id");
        }
    }
    public Label _rwl_edf_no
    {
        get
        {
            return (Label)this.FindControl("rwl_edf_no");
        }
    }
    public Label _rwl_hs_model
    {
        get
        {
            return (Label)this.FindControl("rwl_hs_model");
        }
    }
    public Label _rwl_imei_no
    {
        get
        {
            return (Label)this.FindControl("rwl_imei_no");
        }
    }

    public Label _rwl_sku
    {
        get
        {
            return (Label)this.FindControl("rwl_sku");
        }
    }
    public Label _edf_record_id
    {
        get
        {
            return (Label)this.FindControl("edf_record_id");
        }
    }
    public Label _edf_edf_no
    {
        get
        {
            return (Label)this.FindControl("edf_edf_no");
        }
    }
    public Label _edf_imei_no
    {
        get
        {
            return (Label)this.FindControl("edf_imei_no");
        }
    }
    public Label _edf_actural_delivery
    {
        get
        {
            return (Label)this.FindControl("edf_actural_delivery");
        }
    }
    public Label _edf_dn_remark
    {
        get
        {
            return (Label)this.FindControl("edf_dn_remark");
        }
    }
    public Label _edf_expect_delivery
    {
        get
        {
            return (Label)this.FindControl("edf_expect_delivery");
        }
    }
    public Label _edf_sku
    {
        get
        {
            return (Label)this.FindControl("edf_sku");
        }
    }
    public Label _edf_hs_model
    {
        get
        {
            return (Label)this.FindControl("edf_hs_model");
        }
    }
    public Label _edf_remark
    {
        get
        {
            return (Label)this.FindControl("edf_remark");
        }
    }
    public Label _imei_edf_no
    {
        get
        {
            return (Label)this.FindControl("imei_edf_no");
        }
    }
    public Label _imei_hs_model
    {
        get
        {
            return (Label)this.FindControl("imei_hs_model");
        }
    }
    public Label _imei_imei_no
    {
        get
        {
            return (Label)this.FindControl("imei_imei_no");
        }
    }
    public Label _imei_record_id
    {
        get
        {
            return (Label)this.FindControl("imei_record_id");
        }
    }
    public Label _imei_remark
    {
        get
        {
            return (Label)this.FindControl("imei_remark");
        }
    }
    public Label _imei_sku
    {
        get
        {
            return (Label)this.FindControl("imei_sku");
        }
    }
    public Label _imei_status
    {
        get
        {
            return (Label)this.FindControl("imei_status");
        }
    }
    public TextBox _new_rwl_imei_noTextBox
    {
        get
        {
            return (TextBox)this.FindControl("new_rwl_imei_noTextBox");
        }
    }
    public TextBox _new_edf_imei_noTextBox
    {
        get
        {
            return (TextBox)this.FindControl("new_edf_imei_noTextBox");
        }
    }
    public TextBox _new_imei_imei_noTextBox
    {
        get
        {
            return (TextBox)this.FindControl("new_imei_imei_noTextBox");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }
}
