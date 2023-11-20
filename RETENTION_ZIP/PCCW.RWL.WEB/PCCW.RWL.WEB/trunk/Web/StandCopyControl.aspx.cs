using System;
using System.Collections;
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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class StandCopyControl : NEURON.WEB.UI.BasePage
{
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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

    }

    public void InitFrame()
    {
        string _sCust_name = string.Empty;
        string _sFamily_name = string.Empty;
        string _sGiven_name = string.Empty;
        string _sId_type = string.Empty;
        string _sHkid = string.Empty;
        string _sHkid2 = string.Empty;
        string _sRecord_id = Func.RQ(Request["record_id"]).ToString().Trim();
        int _iRecord_id;
        if (!_sRecord_id.Equals(string.Empty) && int.TryParse(_sRecord_id, out _iRecord_id))
        {
            string _sOrder_id = Func.IDSubtract100000(_iRecord_id).ToString().Trim();
            SqlDataReader _oReader = MobileRetentionOrderBal.GetSearch(GetDB(), "cust_name,family_name,given_name,id_type,hkid", "order_id='" + _sOrder_id + "'", null, null);
            if (_oReader != null)
            {
                if (_oReader.Read())
                {
                    _sCust_name = Func.FR(_oReader[MobileRetentionOrder.Para.cust_name]).ToString();
                    _sFamily_name = Func.FR(_oReader[MobileRetentionOrder.Para.family_name]).ToString();
                    _sGiven_name = Func.FR(_oReader[MobileRetentionOrder.Para.given_name]).ToString();
                    _sId_type = Func.FR(_oReader[MobileRetentionOrder.Para.id_type]).ToString().Trim();
                    if ("HKID".Equals(_sId_type))
                    {
                        _sHkid = Func.FR(_oReader[MobileRetentionOrder.Para.hkid]).ToString().Substring(0, Func.FR(_oReader[MobileRetentionOrder.Para.hkid]).ToString().Length - 1);
                        _sHkid2 = Func.FR(_oReader[MobileRetentionOrder.Para.hkid]).ToString().Substring(Func.FR(_oReader["hkid"]).ToString().Length - 1, 1);
                    }
                    else
                    {
                        _sHkid = Func.FR(_oReader[MobileRetentionOrder.Para.hkid]).ToString();
                        _sHkid2 = string.Empty;
                    }
                }
                if (_oReader != null)
                {
                    _oReader.Close();
                    _oReader.Dispose();
                }
            }
            Response.Write("<script language=\"javascript\">");

            Response.Write("try{");
            Response.Write("if(window.opener.document.getElementById('cust_name')!=undefined){window.opener.document.getElementById('cust_name').value=\"" + _sCust_name + "\";}else{alert('cust_name => undefine');}");
            Response.Write("if(window.opener.document.getElementById('family_name')!=undefined){window.opener.document.getElementById('family_name').value=\"" + _sFamily_name + "\";}else{alert('family_name => family_name');}");
            Response.Write("if(window.opener.document.getElementById('given_name')!=undefined){window.opener.document.getElementById('given_name').value=\"" + _sGiven_name + "\";}else{alert('given_name => given_name');}");
            Response.Write("if(window.opener.document.getElementById('id_type')!=undefined){window.opener.document.getElementById('id_type').value=\"" + _sId_type + "\";}else{alert('id_type => undefine');}");
            Response.Write("if(window.opener.document.getElementById('hkid')!=undefined){window.opener.document.getElementById('hkid').value=\"" + _sHkid + "\";}else{alert('hkid => undefine');}");
            Response.Write("if(window.opener.document.getElementById('hkid2')!=undefined){window.opener.document.getElementById('hkid2').value=\"" + _sHkid2 + "\";} else {alert('hkid2 => undefine');} ");
            Response.Write("if(window.opener.document.getElementById('check_easy_id')!=undefined){window.opener.document.getElementById('check_easy_id').value=\"true\";}else{alert('check_easy_id => undefine');}");
            Response.Write("}catch(e){");
            Response.Write("alert(e);");
            Response.Write("}");

            Response.Write("</script>"); 
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
