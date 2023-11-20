<%@ WebHandler Language="C#" Class="GetWorkingDateAfterIncludingSaturday" %>
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Sql;
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
public class GetWorkingDateAfterIncludingSaturday : IHttpHandler {
    string[] _sFormat = new string[] { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        RWLFramework.DataBaseConfigSetting();

        string _sD_Date = Func.RQ(context.Request["D_Date"]).Trim();
        int _iAddDate;
        if (int.TryParse(Func.RQ(context.Request["AddDate"]).Trim(), out _iAddDate))
        {
            DateTime _dD_Date;
            DateTime? _dResultDate = null;
            if (!string.IsNullOrEmpty(_sD_Date) &&
                DateTime.TryParseExact(_sD_Date, _sFormat, CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces, out _dD_Date))
            {
                _dResultDate = GetValidDeliveryWorkingDate(_dD_Date, _iAddDate);
                if (_dResultDate != null)
                    context.Response.Write(((DateTime)_dResultDate).ToString("dd/MM/yyyy"));
            }
        }
    }

    protected DateTime? GetValidDeliveryWorkingDate(DateTime x_dD_Date, int x_iAddDate)
    {

        string _sErrorMsg = string.Empty;
        DateTime? _dResultDate = null;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT TOP 1 [Common].[dbo].[GetWorkingDateAfterIncludingSaturday] (@D_Date," + x_iAddDate.ToString() + ") AS 'R_Date' ");
        SqlCommand _oCmd = new SqlCommand();
        _oCmd.CommandText = _oQuery.ToString();
        using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect("Common").GetConnection())
        {
            _oCmd.Connection = _oConn;
            _oCmd.CommandType = CommandType.Text;
            _oCmd.Parameters.Clear();
            try
            {
                SqlParameter _oPar = null;
                _oPar = _oCmd.Parameters.Add("@D_Date", SqlDbType.DateTime);
                _oPar.Value = x_dD_Date;
                _oPar.Direction = ParameterDirection.Input;
                if (_oConn.State == ConnectionState.Closed) _oConn.Open();
                SqlDataReader _oDr = _oCmd.ExecuteReader();
                if (_oDr.Read())
                {
                    if (!global::System.Convert.IsDBNull(_oDr["R_Date"])) { _dResultDate = (global::System.Nullable<DateTime>)_oDr["R_Date"]; } else { _dResultDate = null; }
                }
                _oDr.Close();
                _oDr.Dispose();
            }
            catch (Exception exp)
            {
                _sErrorMsg = exp.ToString();
            }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            if (!string.IsNullOrEmpty(_sErrorMsg))
                throw new BusinessObjectNotFoundException(_sErrorMsg);
        }

        return _dResultDate;
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}