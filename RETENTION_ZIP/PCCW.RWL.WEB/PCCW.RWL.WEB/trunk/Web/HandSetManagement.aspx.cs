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
using System.Data.Odbc;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class HandSetManagement : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e){
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
        product.Text=Request.QueryString["sku"].ToString().Trim();
        if (Request.QueryString["location"] != null)
        {
            location.Text = Request.QueryString["location"].ToString().Trim();
        }
        else
        {
            location.Text = string.Empty;
        }
        string _sQuery1 = "select Kit_Code, count(1) as hs_count from IMEI_Stock Where Dummy2='CC RET'  " + ((location.Text != string.Empty) ? " AND  dummy3='" + location.Text + "' " : "") + " and Status='NORMAL' and Kit_Code='" + product.Text + "' group by Kit_Code";
        string _sQuery2 = "Select Kit_Code, count(1) as hs_count From IMEI_Stock Where Dummy2='CC RET'  "+((location.Text!=string.Empty)?" AND dummy3='" + location.Text + "' ":"")+" and Kit_Code ='" + product.Text + "' and (status='AWAIT' or status='AO') group by Kit_Code";
        hs_count.Text = string.Empty;
        try
        {
            OdbcDataReader _oReader =SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
            if (_oReader != null)
            {
                if (_oReader.Read())
                    hs_count.Text = _oReader["hs_count"].ToString();
                else
                {
                    _oReader.Close();
                    _oReader.Dispose();
                    _oReader = GetORDB().GetSearch(_sQuery2);
                    if (_oReader != null){
                        if (_oReader.Read()){
                            if (_oReader["hs_count"].ToString() != "0")
                            {
                                hs_count.Text = "-";
                            }
                            hs_count.Text +=_oReader["hs_count"].ToString();
                        }
                        else
                            hs_count.Text = hs_count.Text + "0";
                    }
                }
                if(_oReader!=null) if(_oReader!=null) _oReader.Close();
            }
        }
        catch
        {

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
