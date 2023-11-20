using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
using PCCW.RWL.CORE;

public partial class SandBox_GenEDF : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        Response.Write(GetEdf());
        /*
        DateTime logdate = new DateTime(2010, 3, 12, 15, 42, 0);
        int mrt_no = 68556158;
        if (IsDuplicate(logdate, mrt_no))
            Response.Write("True");
        */

        
    }

    protected bool IsDuplicate(global::System.Nullable<DateTime> x_oLog_date, global::System.Nullable<int> x_oMrt_no)
    {
        string _sQuery = "SELECT TOP 1 [MobileRetentionOrder].[mrt_no] FROM MobileRetentionOrder WHERE [MobileRetentionOrder].[log_date]=@log_date AND [MobileRetentionOrder].[mrt_no]=@mrt_no";
        using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
        {
            SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = x_oLog_date;
            _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = x_oMrt_no;
            try
            {
                _oConn.Open();
                _bResult = (_oCmd.ExecuteScalar().ToString()!=string.Empty) ? true : false;
            }
            catch (Exception error)
            {
            }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
    }

    private string GetEdf()
    {
        string _sEDF = string.Empty;
        bool _bFlag = true;
        int _iTime = 10;
        while (_bFlag && _iTime > 0)
        {
            _sEDF = GenEdf();
            if (!CheckEdfNoInDB(_sEDF))
            {
                _bFlag = false;
            }
            _iTime -= 1;
        }
        return _sEDF;
    }

    private string GenEdf()
    {
        string _sRefNo = string.Empty;
        global::System.Data.Odbc.OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT SUNDAY_R1_Serial.NextVal as seq, to_char(sysdate, 'yymon') as cdate FROM dual");
        if (_oDr3.Read())
        {
            //=== get EDF# ===
            _sRefNo = Func.Right(Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr3["seq"]).Trim())), 5) + "/HR" + Func.FR(_oDr3["cdate"]).Trim().ToUpper();
        }
        _oDr3.Close();
        _oDr3.Dispose();
        return _sRefNo;
    }

    protected bool CheckEdfNoInDB(string x_sEdfNo)
    {
        if (string.IsNullOrEmpty(x_sEdfNo)) return false;
        x_sEdfNo = x_sEdfNo.Trim();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(" SELECT referenceNo FROM sunday_Form  WHERE referenceNo='" + x_sEdfNo + "' AND rownum<=1");
        if (_oDr.Read())
        {
            if (!Func.FR(_oDr["referenceNo"]).Trim().Equals(string.Empty))
            {
                _oDr.Close();
                _oDr.Dispose();
                return true;
            }
        }
        _oDr.Close();
        _oDr.Dispose();
        return false;
    }
}
