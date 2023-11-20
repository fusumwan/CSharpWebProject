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
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class K610iSpecial : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);
        WebFunc.PrivilegeCheck(this.Page);
       if(!IsPostBack)  k610i_DataBind();
    }

    #region k610i_DataBind
    protected void k610i_DataBind()
    {
        string _sQuery = "SELECT order_id, edf_no FROM " +Configurator.MSSQLTablePrefix+ "MobileRetentionOrder WITH (nolock) WHERE edf_no in('02951/HR07NOV','02972/HR07NOV','02973/HR07NOV','02976/HR07NOV','02977/HR07NOV','02983/HR07NOV','02992/HR07NOV','02994/HR07NOV','02995/HR07NOV','02996/HR07NOV','02998/HR07NOV','03001/HR07NOV','03006/HR07NOV','03008/HR07NOV','03039/HR07NOV','03041/HR07NOV','03042/HR07NOV','03045/HR07NOV','03059/HR07NOV','03065/HR07NOV','03077/HR07NOV','03078/HR07NOV','03079/HR07NOV','03083/HR07NOV','03087/HR07NOV','03088/HR07NOV','03089/HR07NOV','03090/HR07NOV','03091/HR07NOV','03096/HR07NOV','03100/HR07NOV','03101/HR07NOV','03106/HR07NOV','03113/HR07NOV','03115/HR07NOV','03118/HR07NOV','03311/HR07NOV')";
        k610i_rp.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        k610i_rp.DataBind();
    }
    #endregion

    protected void k610i_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!(-1).Equals(e.Item.ItemIndex))
        {
            Literal _oEdf_no = (Literal)e.Item.FindControl("edf_no");
            Literal _oActual_del_date =(Literal) e.Item.FindControl("actual_del_date");
            Literal _oCnt =(Literal) e.Item.FindControl("cnt");
            string _sQuery = "SELECT actual_del_date From sunday_Form WHERE CREATED_BY='CC RET' AND referenceNo='" +_oEdf_no.Text+ "' ";
            OdbcDataReader _oReader = GetORDB().GetSearch(_sQuery);
            if (_oReader.Read())
                _oActual_del_date.Text = _oReader["actual_del_date"].ToString();
            _oReader.Close();
            _oReader.Dispose();
            _sQuery = "SELECT count(1) as cnt FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder WITH (nolock) WHERE edf_no='" + _oEdf_no.Text + "' ";
            
            SqlDataReader  _oReader2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oReader2.Read()) { _oCnt.Text = _oReader2["cnt"].ToString(); }
        }
    }


    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
