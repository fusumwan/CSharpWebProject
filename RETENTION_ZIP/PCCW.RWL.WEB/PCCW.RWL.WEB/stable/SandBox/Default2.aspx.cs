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
public partial class SandBox_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        RWLFramework.DataBaseConfigSetting();

        /*
        string[] arr = { "one", "two", "three" };
        Response.Write(string.Join(",", arr)); // "string" can be lowercase, or
        Response.Write("<br>");
        Response.Write(String.Join(",", arr)); // "String" can be uppercase
        */

        RWLFramework.DataBaseConfigSetting();

        BusinessTrade _oBusinessTrade = new BusinessTrade(SYSConn<MSSQLConnect>.Connect());
        _oBusinessTrade.SetActive(true);
        _oBusinessTrade.SetProgram("NETVIGATOR EVERYWHERE");
        _oBusinessTrade.SetRetention_type("1");
        _oBusinessTrade.SetNormal_rebate(true);
        _oBusinessTrade.SetRate_plan("3GHSDPA0328A");
        _oBusinessTrade.SetCon_per("18");
        _oBusinessTrade.SetFree_mon("6");
        _oBusinessTrade.SetHs_model("Y");
        _oBusinessTrade.SetTrade_field("3GHSDPA0328(RET)HSREBATE18M(F6M)(E180)");
        _oBusinessTrade.SetBundle_name("3GHSDPA0328AHSBUNDLE(E180)");
        _oBusinessTrade.SetPlan_fee("328");
        _oBusinessTrade.SetCancel_renew(false);
        _oBusinessTrade.SetChannel("ALL");
        _oBusinessTrade.SetSdate(new DateTime(2009, 12, 12));


    }
}
