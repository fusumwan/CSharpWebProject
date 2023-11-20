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
using System.Data.Odbc;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;



public partial class StaffFindDetail : NEURON.WEB.UI.BasePage
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

        WebFunc.PrivilegeCheck(this.Page);
        RWLFramework.InitModel();
    }

    public void InitFrame()
    {
        string _sSalemancode = string.Empty;
        string _sStaff_name = string.Empty;
        string _sTeamcode = string.Empty;
        string _sChannel = string.Empty;
        string _sTl_name = string.Empty;
        string _sExtn = string.Empty;

        OdbcDataReader _oDr = GetORDB().GetSearch("select extn,salename,salecode from saleinfo where saleid1 = '" + Func.RQ(Request["staff_no"]).ToString() + "'");
        if (_oDr != null)
        {
            if (_oDr.Read())
            {
                _sExtn = Func.FR(_oDr["extn"]).Trim();
                _sSalemancode = Func.FR(_oDr["salecode"]).Trim();
                _sStaff_name = Func.FR(_oDr["salename"]).Trim();
            }
        }
        _oDr.Close();
        _oDr.Dispose();


        Staffinfo_new _oStaffinfo_new = RWLFramework.Control<FromRegisterControler>().Get_StaffInfoEntity(Func.RQ(Request["staff_no"]).ToString());
        if(_sSalemancode.Trim()==string.Empty) _sSalemancode = _oStaffinfo_new.GetSalesman_code();
        if(_sStaff_name.Trim()==string.Empty) _sStaff_name = _oStaffinfo_new.GetStaff_name();
        _sTeamcode = _oStaffinfo_new.GetTeamcode();
        _sTl_name = RWLFramework.Control<FromRegisterControler>().Get_TeamLeader_By_TeamCode(_sTeamcode);
        _sChannel = RWLFramework.Control<FromRegisterControler>().Get_Channel_By_TeamCode(_sTeamcode);

        /*
        if (!"OB".Equals(_sChannel.Trim().ToUpper()))
            Response.Write("<script>window.opener.HiddenTier();</script>");
        else
            Response.Write("<script>window.opener.ShowTier();</script>");
        */
        Response.Write("<script>window.opener.document.getElementById('form1').salesmancode.value='" + _sSalemancode + "';</script>");
        Response.Write("<script>window.opener.document.getElementById('form1').staff_name.value='" + _sStaff_name + "';</script>");
        Response.Write("<script>window.opener.document.getElementById('form1').teamcode.value='" + _sTeamcode + "';</script>");
        Response.Write("<script>window.opener.document.getElementById('form1').channel.value='" + _sChannel + "';</script>");
        Response.Write("<script>window.opener.document.getElementById('form1').tl_name.value='" + _sTl_name + "';</script>");
        Response.Write("<script>window.opener.document.getElementById('form1').extn.value='" + _sExtn + "';</script>");
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS);
        return _oDB;
    }
    #endregion
}
