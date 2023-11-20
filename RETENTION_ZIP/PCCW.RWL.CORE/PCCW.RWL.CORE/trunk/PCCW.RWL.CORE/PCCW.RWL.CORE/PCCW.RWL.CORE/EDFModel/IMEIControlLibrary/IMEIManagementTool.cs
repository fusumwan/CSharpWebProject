using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
namespace PCCW.RWL.CORE
{
    public class IMEIManagementTool
    {
        public static bool ChkExistingOrder(string x_sEdf_no)
        {
            if (!string.IsNullOrEmpty(x_sEdf_no))
            {
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT TOP 1 ORDER_ID FROM ");
                _oQuery.Append("MOBILERETENTIONORDER WHERE EDF_no='" + x_sEdf_no + "'");
                string _sOrder_id = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
                if (!string.IsNullOrEmpty(_sOrder_id))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ChkExistingIMEI(string x_sIMEI_no)
        {
            if (!string.IsNullOrEmpty(x_sIMEI_no))
            {
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT IMEI FROM ");
                _oQuery.Append("IMEI_STOCK WHERE IMEI='" + x_sIMEI_no + "' AND rownum<=1");
                string _sIMEI = SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
                if (!string.IsNullOrEmpty(_sIMEI))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ChkExistingIMEIStatus(string x_sIMEI_no)
        {
            if (!string.IsNullOrEmpty(x_sIMEI_no))
            {
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT STATUS FROM ");
                _oQuery.Append("IMEI_STOCK WHERE IMEI='" + x_sIMEI_no + "' AND ROWNUM<=1");
                string _sStatus = SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
                return _sStatus.ToUpper().Trim();
            }
            return string.Empty;
        }

        public static string ChkExistingIMEISku(string x_sIMEI_no)
        {
            if (!string.IsNullOrEmpty(x_sIMEI_no))
            {
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT KIT_CODE FROM ");
                _oQuery.Append("IMEI_STOCK WHERE IMEI='" + x_sIMEI_no + "' AND ROWNUM<=1");
                string _sSku = SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
                return _sSku.ToUpper().Trim();
            }
            return string.Empty;
        }
    }
}
