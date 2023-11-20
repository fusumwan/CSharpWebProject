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
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class HandSetStockViewAction : NEURON.WEB.UI.BasePage
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
        if (!IsPostBack) InitFrame();
    }

    #region InitFrame
    protected void InitFrame()
    {
        if (!string.IsNullOrEmpty(WebFunc.qsSku))
        {
            string[] sku = WebFunc.qsSku.ToString().Split(","[0]);
            for (int i = 0; i < sku.Length; i++)
            {
                stockplace.Controls.Add(new LiteralControl("<TR>"));
                stockplace.Controls.Add(new LiteralControl("<TD width=\"657\" height=\"24\" class=\"row1\"> <span class=\"gensmall\" style=\"font-size:7pt\">"));
                string _sHs_model=SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT hs_model FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock)  WHERE  active=1 AND item_code='" + sku[i].ToString() + "'");
                stockplace.Controls.Add(new LiteralControl(_sHs_model));
                string _sGift_desc = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT gift_desc FROM " + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock)  WHERE  active=1 AND gift_code='" + sku[i].ToString() + "'");
                stockplace.Controls.Add(new LiteralControl(_sGift_desc));
                stockplace.Controls.Add(new LiteralControl("</span></TD>"));
                OdbcDataReader _oReader = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT Kit_Code, count(1) AS hs_count FROM IMEI_Stock  WHERE  Dummy2='CC RET' AND Kit_Code ='" + sku[i].ToString() + "' AND status='NORMAL' group by Kit_Code");
                if (_oReader.Read())
                {
                    stockplace.Controls.Add(new LiteralControl("<TD width=\"133\" class=\"row1\"><span class=\"gensmall\" style=\"font-size:7pt\">"));
                    string _sHs_count = _oReader["hs_count"].ToString();
                    stockplace.Controls.Add(new LiteralControl(_sHs_count));
                    stockplace.Controls.Add(new LiteralControl("</span></TD>"));
                }
                else
                {
                    _oReader.Close();
                    _oReader.Dispose();
                    _oReader = GetORDB().GetSearch("Select Kit_Code, count(1) as hs_count From IMEI_Stock  WHERE  Dummy2='CC RET' AND Kit_Code ='" + sku[i].ToString() + "'  AND (status='AWAIT' or status='AO') group by Kit_Code");
                    stockplace.Controls.Add(new LiteralControl("<TD width=\"155\" class=\"row1\"><span class=\"gensmall\" style=\"font-size:7pt\">"));
                    if (_oReader.Read())
                    {
                        if (!"0".Equals(_oReader["hs_count"]))
                            stockplace.Controls.Add(new LiteralControl("-"));
                        
                         stockplace.Controls.Add(new LiteralControl(_oReader["hs_count"].ToString()));
                    }
                    else
                        stockplace.Controls.Add(new LiteralControl("0"));

                    stockplace.Controls.Add(new LiteralControl("</span></TD>"));
                }

                stockplace.Controls.Add(new LiteralControl("</TR>"));
                stockplace.DataBind();
                _oReader.Close();
                _oReader.Dispose();
            }
        }
    }
    #endregion

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
