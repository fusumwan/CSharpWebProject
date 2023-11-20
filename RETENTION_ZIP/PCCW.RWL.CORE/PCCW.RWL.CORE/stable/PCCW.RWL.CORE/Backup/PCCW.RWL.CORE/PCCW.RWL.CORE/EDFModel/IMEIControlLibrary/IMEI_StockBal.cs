using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-13>
///-- Description:	<Description,Table :[IMEI_Stock],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [IMEI_Stock] Business layer
    /// </summary>


    public class IMEI_StockBal 
    {

        #region Constructor
        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public IMEI_StockBal()
        {
            
        }
        #endregion

        public static bool CreateImeiHistory(int x_iOrder_id,string x_sIMEI_no , string x_sUid)
        {

            string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
            string _sToday2 = DateTime.Now.ToString("yyyy-MM-dd");
            int x_iRecordID = x_iOrder_id + 100000;



            OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND DUMMY4='" + (x_iRecordID).ToString() + "' AND IMEI='" + x_sIMEI_no + "' AND (IMEI not like 'FG%' or IMEI=' ' or IMEI is null)");
            while (_oDr2.Read())
            {
                string _sImei = Func.FR(_oDr2["IMEI"]);
                string _sCreate_Date = Func.FR(_oDr2["Create_Date"]);
                string _sDummy1 = Func.FR(_oDr2["Dummy1"]);
                string _sDummy2 = Func.FR(_oDr2["Dummy2"]);
                string _sKit_Code = Func.FR(_oDr2["Kit_Code"]);
                string _sModel = Func.FR(_oDr2["Model"]);
                string _sStatus = Func.FR(_oDr2["Status"]);
                string _sReferenceNo = Func.FR(_oDr2["ReferenceNo"]);
                string _sDummy4 = Func.FR(_oDr2["DUMMY4"]);
                string _sStock_In_Date = Func.FR(_oDr2["Stock_In_Date"]);
                string _sUID = x_sUid;
                string _sAment_Date = GetAmendmentDate(_sDummy1, _sCreate_Date);
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) VALUES ");
                _oQuery.Append(" ('" + _sKit_Code + "','" + _sModel + "','" + _sStatus + "','" + _sReferenceNo + "','" + _sDummy4 + "',to_date('" + _sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "','" + _sDummy1 + "','" + _sDummy2 + "','" + _sStock_In_Date + "','" + _sImei + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
                

                GetORDB().ExplicitNonQuery(_oQuery.ToString());
            }
            _oDr2.Close();
            _oDr2.Dispose();
            return true;
        }

        protected static string GetAmendmentDate(string x_sDummy1,string x_sCreate_Date){

            string[] _sFormat = { "yyyyMMdd", "yyyyMMdd HH:mm:ss", "yyyyMMdd H:mm:ss", "MM/dd/yyyy", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy H:mm:ss" };
            if (string.IsNullOrEmpty(x_sDummy1))
            {
                DateTime _dCreateDate;
                if (DateTime.TryParseExact(x_sCreate_Date, _sFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCreateDate))
                    return _dCreateDate.ToString("yyyyMMdd");
                else
                    return x_sDummy1;
            }
            else
                 return x_sDummy1;
        }

        #region Get Oracle DB
        protected static ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        public static bool SaveByGift_imei(
            string x_sDUMMY4, string x_sSTAFF_RECD, string x_sDUMMY1, 
            string x_sMOBILE_NO, string x_sCOMPLETED_DATE, string x_sSTATUS, 
            string x_sKIT_CODE, string x_sIMEI)
        {
            bool _bResult = false;
            string _sQuery = "UPDATE  IMEI_Stock  SET STAFFNO=null,DUMMY4='" + x_sDUMMY4 + "',STAFF_RECD='" + x_sSTAFF_RECD + "',DUMMY1='" + x_sDUMMY1 + "',MOBILE_NO='" + x_sMOBILE_NO + "',COMPLETED_DATE='" + x_sCOMPLETED_DATE + "',STATUS='" + x_sSTATUS + "' WHERE KIT_CODE='" + x_sKIT_CODE + "' AND IMEI='" + x_sIMEI + "' AND DUMMY2='CC RET'";
            using (global::System.Data.Odbc.OdbcConnection _oConn = SYSConn<ODBCConnect>.Connect().GetConnection())
            {
                global::System.Data.Odbc.OdbcCommand _oCmd = new global::System.Data.Odbc.OdbcCommand(_sQuery, _oConn);
                try
                {
                    _oConn.Open();
                    _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
            }
            return _bResult;
        }


        #region Get Oracle DB
        protected static ODBCConnect GetDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

    }
}


