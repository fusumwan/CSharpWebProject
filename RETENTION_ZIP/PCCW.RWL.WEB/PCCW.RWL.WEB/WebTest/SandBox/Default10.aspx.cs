using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.STOCK;

public partial class SandBox_Default10 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string _sQuery = "[CRM_SP_GET_CUSTINFO_by_MRT]";
        MSSQLConnect DB = GetDB();
        SqlConnection _oConn = DB.GetConnection();
        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
        _oCmd.Parameters.Clear();
        bool _bResult = false;
        global::System.Data.SqlClient.SqlParameter _oPar;
        try
        {
            _oPar = _oCmd.Parameters.Add("@mrt", global::System.Data.SqlDbType.NVarChar, 8);
            _oPar.Direction = global::System.Data.ParameterDirection.Input;
            _oPar.Value = "62014818";
            _oCmd.CommandType = CommandType.StoredProcedure;
            _oConn.Open();
            SqlDataReader _oDr = _oCmd.ExecuteReader();
            if (_oDr.Read())
            {
                if (_oDr["cust_name"] != null)
                {
                    Response.Write(Func.FR(_oDr["cust_name"]).ToString());
                }
            }
            _oDr.Close();

        }
        catch (Exception exp) { string _sError = exp.ToString(); }
        finally
        {
            _oConn.Close();
            _oCmd.Dispose();
            _oConn.Dispose();
        }

    }



    public MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr("CRM");
        return _oDB;
    }
}