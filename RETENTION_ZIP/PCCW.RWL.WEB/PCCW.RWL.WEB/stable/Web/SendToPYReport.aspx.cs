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
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class Web_SendToPYReport : NEURON.WEB.UI.BasePage
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
    public void InitFrame()
    {
        if (WebFunc.qsOrder_id != null)
        {
            int _iOrder_id = ((int)WebFunc.qsOrder_id) - 100000;
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);

            StringBuilder _oInsertQuery = new StringBuilder();
            _oInsertQuery.Append("INSERT INTO MobileOrderReportHistory (rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate ,reactive_sn,reactive_date) ");
            _oInsertQuery.Append(" SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" +RWLFramework.CurrentUser[this.Page].Uid+ "',getdate() ,reactive_sn,reactive_date FROM MobileOrderReport with (nolock) ");
            _oInsertQuery.Append(" WHERE order_id='" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + "'");
            bool _bInsertFlag = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oInsertQuery.ToString());
            StringBuilder _oUpdateQuery = new StringBuilder();
            Boolean isMobileLite = false;
            string query = "select * from MobileRetentionOrder where order_id = "+Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString()+" AND (program = 'MOBILE LITE (SIM ONLY)' OR program='MOBILE LITE (HS OFFER)')";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(query);
            if (_oDr.Read())
            {
                isMobileLite = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            if (isMobileLite)
            {
                _oUpdateQuery.Append("UPDATE MobileOrderReport SET sent_again=1,report_type='rwl_ml_mod',reactive_sn='" + RWLFramework.CurrentUser[this.Page].Uid + "',reactive_date=getdate() FROM MobileOrderReport a WHERE a.order_id=" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + " and a.mid=(SELECT MAX(MobileOrderReport.mid) FROM MobileOrderReport  with (nolock)  where active=1 and order_id=" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + " )");
                bool _bUpdateFlag = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oUpdateQuery.ToString());
            }
            else
            {
                if (_oMobileRetentionOrder.GetIssue_type() == "3G_RETENTION")
                {
                    _oUpdateQuery.Append("UPDATE MobileOrderReport SET sent_again=1,reactive_sn='" + RWLFramework.CurrentUser[this.Page].Uid + "',reactive_date=getdate() FROM MobileOrderReport a WHERE a.order_id=" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + " and a.mid=(SELECT MAX(MobileOrderReport.mid) FROM MobileOrderReport  with (nolock)  where active=1 and order_id=" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + " )");
                }
                else if (_oMobileRetentionOrder.GetIssue_type() == "2G_RETENTION")
                {
                    _oUpdateQuery.Append("UPDATE MobileOrderReport SET sent_again=2,reactive_sn='" + RWLFramework.CurrentUser[this.Page].Uid + "',reactive_date=getdate() FROM MobileOrderReport a WHERE a.order_id=" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + " and a.mid=(SELECT MAX(MobileOrderReport.mid) FROM MobileOrderReport  with (nolock)  where active=1 and order_id=" + Func.IDSubtract100000(((int)WebFunc.qsOrder_id)).ToString() + " )");
                }
                bool _bUpdateFlag = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oUpdateQuery.ToString());
            }
            Response.Redirect("~/Web/SearchRetentionOrderViewDetail.aspx?order_id=" +((int)WebFunc.qsOrder_id).ToString() + "&pass=pass");
        }
        else
            Response.Redirect("~/Web/SearchRetentionOrderView.aspx");
    }
    #endregion
}
