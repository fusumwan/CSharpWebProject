using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using DnaExpress.Web.UI.WebControls;

public partial class UI_MobileManualAssignedHistoryControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MobileManualAssignedHistoryObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    public override void DataBind()
    {
        base.DataBind();
        MobileManualAssignedHistoryGW.DataBind();
    }

    protected void MobileManualAssignedHistoryGW_Init(object sender, EventArgs e)
    {

    }
    protected void MobileManualAssignedHistoryObj_Init(object sender, EventArgs e)
    {
        MobileManualAssignedHistoryObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
}
