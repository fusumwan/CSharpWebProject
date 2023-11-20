using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using DnaExpress.Web.UI.WebControls.AspxGridViewCommon;
using PCCW.RWL.CORE;
public partial class UI_MasterDetailDeliveryTime : DnaExpress.Web.UI.UserControl
{

    [Bindable(true)]
    [Category("Data")]
    [Description("location")]
    [DefaultValue(-1)]
    public string location
    {
        get
        {
            object o = ViewState["location"];
            return o == null ? string.Empty : (string)o;
        }
        set
        {
            ViewState["location"] = value;
            DeliveryTimeObj.SelectParameters[0].DefaultValue = value.ToString();
        }
    }

    protected bool IsLoad
    {
        get
        {
            if (ViewState["IsLoad"] == null)
                ViewState["IsLoad"] = false;
            return (bool)ViewState["IsLoad"];
        }
        set
        {
            ViewState["IsLoad"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        DeliveryTimeObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
        if (MasterDetailCommandArgument != null)
        {
            string _slocation;
            _slocation = MasterDetailCommandArgument.ToString();
            if (IsLoad == false && location != _slocation && DeliveryTimeGv.EditIndex==-1)
            {
                location = _slocation;
                DeliveryTimeObj.DataBind();
                IsLoad = true;
            }
        }
    }
    protected void DeliveryTimeObj_Init(object sender, EventArgs e)
    {
        DeliveryTimeObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
}
