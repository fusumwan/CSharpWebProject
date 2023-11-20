using System;
using System.Text;
using System.Data.Odbc;
using System.Threading;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

namespace PCCW.RWL.CORE.SERIAL
{
    public class OrderSerialNumberControl
    {
        public int Order_id = -1;
        public string Issue_type = "3G_RETENTION";
        public string ReferenceNumber
        {
            get
            {
                return GenerateReferenceNumber(Issue_type);
            }
        }

        public string GenerateReferenceNumber()
        {
            return GenerateReferenceNumber("3G_RETENTION");
        }


        public string GenerateReferenceNumber(string x_sIssue_type)
        {
            string _sRefNo = string.Empty;
            global::System.Data.Odbc.OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT SUNDAY_R1_Serial.NextVal as seq, to_char(sysdate, 'yymon') as cdate FROM dual");
            if (_oDr3.Read())
            {
                //=== get EDF# ===
                string _sEdf_type = string.Empty;
                switch (x_sIssue_type)
                {
                    case "GO_WIRELESS":
                    case "OLD_MOBILE_LITE":
                    case "MOBILE_LITE":
                    case "3G_RETENTION":
                    case "2G_RETENTION":
                        _sEdf_type = "HR";
                        break;
                    case "WIN":
                        _sEdf_type = "MG";
                        break;
                    case "UPGRADE":
                        _sEdf_type = "UP";
                        break;
                    default:
                        _sEdf_type = "HR";
                        break;
                }

                _sRefNo = Func.Right(Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr3["seq"]).Trim())), 5) + "/" + _sEdf_type + Func.FR(_oDr3["cdate"]).Trim().ToUpper();
            }
            _oDr3.Close();
            _oDr3.Dispose();
            return _sRefNo;
        }


        public bool CheckEdfNoInDB(string x_sEdfNo)
        {
            if (string.IsNullOrEmpty(x_sEdfNo)) return false;
            x_sEdfNo = x_sEdfNo.Trim();
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo FROM sunday_Form  WHERE referenceNo='" + x_sEdfNo + "' AND rownum<=1");
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
        public OrderSerialNumberControl()
        {

        }
        public OrderSerialNumberControl(int x_iOrder_id)
        {
            SetOrder_id(x_iOrder_id);
        }

        public void SetOrder_id(int x_iOrder_id)
        {
            this.Order_id = x_iOrder_id;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT TOP 1 issue_type FROM MobileRetentionOrder WHERE issue_type IS NOT NULL AND order_id=" + x_iOrder_id.ToString());
            this.Issue_type = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString()).Trim().ToUpper();
            if (this.Issue_type.Equals(string.Empty))
                this.Issue_type = "3G_RETENTION";
        }
    }
}
