using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class Web_MessageShowView : NEURON.WEB.UI.BasePage
{
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
        RWLFramework.DataBaseConfigSetting();
        if (!IsPostBack) InitFrame();
    }

    public void InitFrame()
    {
        if (WebFunc.qsMid != null)
        {
            int _iMid = (int)WebFunc.qsMid;
            string _sQuery = "SELECT TOP 1 * FROM dbo." + EventMsgDetail.Para.TableName() + " with (nolock) WHERE mid='" + _iMid.ToString() + "' order by cdate desc";

            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.Read())
            {
                string _sCid = Func.FR(_oDr[EventMsgDetail.Para.cid]).Trim();
                Staffinfo_new _oStaffinfo_new = new Staffinfo_new(SYSConn<MSSQLConnect>.Connect(), _sCid, _sCid);
                if (_oStaffinfo_new.GetFound())
                {
                    staff_name.Text = _oStaffinfo_new.GetStaff_name().Trim();
                }
                if (_oDr["cdate"] != null)
                    cdate.Text = ((DateTime)_oDr["cdate"]).ToString("dd/MM/yyyy");

                subject.Text = Func.LatinToBig5(Func.FR(_oDr[EventMsgDetail.Para.subject]).Trim());
                message.Text = Func.LatinToBig5(Func.FR(_oDr[EventMsgDetail.Para.message]).Replace("\n", "<br>"));


            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }
}
