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
using PCCW.RWL.CORE.SERIAL;

public partial class SandBox_GenEDF : System.Web.UI.Page
{

    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        Response.Write(_oOrderSerialNumberControl.ReferenceNumber);
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
}
