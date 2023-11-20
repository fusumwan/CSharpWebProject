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
using System.IO;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class TierAutoSelectionViewAndModify : NEURON.WEB.UI.BasePage
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


    protected void TierSource_Init(object sender, EventArgs e)
    {
        TierSource.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    protected void TierSource_Updating(object sender, SqlDataSourceCommandEventArgs e)
    {

    }
    protected void TierViewGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        DateTime newStartDate = DateTime.ParseExact((string)e.NewValues["start_date"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        e.NewValues["start_date"] = newStartDate;
        DateTime oldStartDate = DateTime.ParseExact((string)e.OldValues["start_date"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        e.OldValues["start_date"] = oldStartDate;

        DateTime newEndDate = DateTime.ParseExact((string)e.NewValues["end_date"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        e.NewValues["end_date"] = newEndDate;
        DateTime oldEndDate = DateTime.ParseExact((string)e.OldValues["end_date"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        e.OldValues["end_date"] = oldEndDate;

        DateTime newPoDate = DateTime.ParseExact((string)e.NewValues["po_date"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        e.NewValues["po_date"] = newEndDate;
        DateTime oldPoDate = DateTime.ParseExact((string)e.OldValues["po_date"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        e.OldValues["po_date"] = oldEndDate;

    }
}
