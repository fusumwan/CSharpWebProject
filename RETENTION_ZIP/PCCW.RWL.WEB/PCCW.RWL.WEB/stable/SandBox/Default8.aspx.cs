using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class SandBox_Default8 : System.Web.UI.Page
{
    ArrayList _oOrderList = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();

    }

    public void BackUpOrder(int x_iOrder_id,string x_sRebate)
    {
        if (!_oOrderList.Contains(x_iOrder_id))
        {
            _oOrderList.Add(x_iOrder_id);
            MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
            _oMobileRetentionOrder.SetOrder_id(x_iOrder_id);
            if (!_oMobileRetentionOrder.Retrieve()) return;
            _oMobileRetentionOrder.SetRebate(x_sRebate);
            _oMobileRetentionOrder.Save();
            MobileRetentionOrderBal.BackUpOrder(x_iOrder_id, "A8350006");
        }
    }
}
