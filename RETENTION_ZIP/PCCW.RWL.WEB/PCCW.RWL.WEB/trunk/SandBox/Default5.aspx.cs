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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


public partial class SandBox_Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery=new StringBuilder();
        _oQuery.Append("SELECT edf_no,order_id FROM MobileRetentionOrder WHERE (edf_no is not null or edf_no !='') AND active=0 AND cdate>'01/07/2010' AND cdate<'01/10/2010' ");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while(_oDr.Read())
        {
            string _sEDF_no=Func.FR(_oDr["edf_no"]);
            if(_sEDF_no!=string.Empty){
                StringBuilder _oQuery2 = new StringBuilder();
                _oQuery2.Append("SELECT referenceno FROM SUNDAY_FORM WHERE referenceno='" + _sEDF_no + "' AND rownum<=1");
                OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery2.ToString());
                while (!_oDr2.Read())
                {
                    Response.Write(Func.FR(_oDr["order_id"]) + "<br>");
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}