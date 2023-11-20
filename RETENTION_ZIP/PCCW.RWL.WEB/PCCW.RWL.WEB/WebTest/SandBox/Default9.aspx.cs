using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.STOCK;
public partial class SandBox_Default9 : System.Web.UI.Page
{
    MobileOrderViewControler n_oMobileOrderViewControler = new MobileOrderViewControler();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        CheckDuplicateMRT("98004028");
    }
    
    protected bool CheckDuplicateMRT(string x_sMRT)
    {
        MobileOrderViewControler _oMobileOrderViewControler = new MobileOrderViewControler();
        _oMobileOrderViewControler.SetDB(SYSConn<MSSQLConnect>.Connect());
        _oMobileOrderViewControler.SetPrefix(Configurator.MSSQLTablePrefix);
        if (Session["lv"] != null)
        {
            if (Func.IsParseInt(Session["lv"].ToString())) n_oMobileOrderViewControler.SetProg_Lv(Convert.ToInt32(Session["lv"].ToString()));
        }
        _oMobileOrderViewControler.SetMrt(x_sMRT);
        _oMobileOrderViewControler.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
        if (_oMobileOrderViewControler.InitDataByMRT())
        {
            if (_oMobileOrderViewControler.GetAdd_flag() == 1 || _oMobileOrderViewControler.GetDup_flag() == 1)
            {
                return true;
            }
        }
        return false;
    }

    public MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr("CRM");
        return _oDB;
    }
}
