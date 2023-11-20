using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

public partial class Web_AccessRight_ProfileTeamExport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WebFunc.PrivilegeCheck(this.Page);
        if (Session["ProfileTeamSql"] != null)
        {
            DataSet _oDataSet = SYSConn<MSSQLConnect>.Connect().GetDS(Session["ProfileTeamSql"].ToString());
            //WebFunc.ExportDataSetToExcelAndZip(this.Page, _oDataSet, "ProfileTeamExport", false);
            WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "ProfileTeamExport", false, Encoding.UTF8, WebFunc.ExportContentType.Excel);
        }
    }
}
