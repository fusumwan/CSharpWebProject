using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using System.Data.Odbc;
using System.Linq;
using System.Web.UI;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;


namespace PCCW.RWL.CORE
{
    public class AssignIMEIControl
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
        public bool UploadStockOrder(int x_iRecord_ID,string x_sUid, string x_sIMEI, string x_sSKU)
        {
            int _iOrderID = x_iRecord_ID - 100000;
            _oEDFStatusProfile.CheckIMEISTOCK(_iOrderID);
            _oOrderSerialNumberControl.SetOrder_id(_iOrderID);
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            if (string.IsNullOrEmpty(x_sSKU)) return false;
            string _sQuery = "SELECT IMEI FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID + "' AND kit_code='" + x_sSKU + "' AND STATUS='STOCK'  AND IMEI IS NOT NULL AND IMEI<>' ' ";
            OdbcDataReader _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
            if (!_oChkDr.Read())
            {
                _oChkDr.Close();
                _oChkDr.Dispose();
                return false;
            }
            _oChkDr.Close();
            _oChkDr.Dispose();


            SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
            string n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
            string n_sTime1 = DateTime.Now.AddMinutes(-30).ToString("HH:mm:ss");
            int _iHour = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("HH"));
            int _iMinute = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("mm"));
            int _iSecond = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("ss"));

            if (!string.IsNullOrEmpty(x_sUid) &&
                !x_sIMEI.Equals(string.Empty) &&
                !x_sIMEI.Equals("AO") &&
                !x_sIMEI.Equals("AWAIT") &&
                x_iRecord_ID > 0)
            {

                #region ================= Control only one staff can update status ==================
                global::System.Text.StringBuilder _oUpdateIMEIQuery = new StringBuilder();
                _oUpdateIMEIQuery.Append(" UPDATE IMEI_Stock SET STAFF_RECD='" + x_sUid + "' ");
                _oUpdateIMEIQuery.Append(" Where Dummy2='CC RET' AND Status='STOCK' ");
                _oUpdateIMEIQuery.Append(" AND (STAFF_RECD is null or STAFF_RECD='' ) AND DUMMY4='" + x_iRecord_ID + "' AND rownum<=1");
                bool _bUpdateSuccess = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIQuery.ToString());
                if (_bUpdateSuccess) { WebFunc.SaveQuery(_oUpdateIMEIQuery.ToString()); }
                #endregion ================= End of control only one staff can update status ==================

                global::System.Text.StringBuilder _oSelectOrderQuery = new StringBuilder();
                _oSelectOrderQuery.Append(" SELECT datediff(d,getdate(),d_date) as date_diff,");
                _oSelectOrderQuery.Append(" CONVERT(VARCHAR,log_date,103) log_date, * FROM ");
                _oSelectOrderQuery.Append(Configurator.MSSQLTablePrefix + "MobileRetentionOrder ");
                _oSelectOrderQuery.Append(" with (nolock) WHERE active=1 ");
                _oSelectOrderQuery.Append(" AND (imei_no='AWAIT' OR imei_no='Await' OR imei_no='AO') ");
                _oSelectOrderQuery.Append(" AND d_date is not null");
                _oSelectOrderQuery.Append(" AND Order_id+100000 = '" + x_iRecord_ID + "'");
                global::System.Data.SqlClient.SqlDataReader _oDr =
                    SYSConn<MSSQLConnect>.Connect().GetSearch(_oSelectOrderQuery.ToString());
                if (_oDr.Read())
                {
                    if (Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Equals(string.Empty)) {
                        _oDr.Close();
                        _oDr.Dispose();
                        return false; 
                    }
                    string _sRecordId = x_iRecord_ID.ToString();
                    if (_sRecordId == string.Empty) Logger.WarnFormat("User cannot be found the result with empty({0}) value in this function.", "_sRecordId");
                    {
                        #region Update Imei stock
                        string n_sImei_no = string.Empty;
                        string n_sRefNo = string.Empty;
                        if (Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim() != string.Empty && !Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim().Equals("0"))
                        {
                            #region === check Stock ===
                            global::System.Text.StringBuilder _oSelectStockQuery = new StringBuilder();
                            _oSelectStockQuery.Append(" SELECT * FROM IMEI_Stock ");
                            _oSelectStockQuery.Append(" WHERE Dummy2='CC RET' AND ");
                            _oSelectStockQuery.Append(" Kit_Code='" + Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim() + "' ");
                            _oSelectStockQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]))) + "' ");
                            _oSelectStockQuery.Append(" AND Status='STOCK' AND IMEI<>' ' and STAFF_RECD='" + x_sUid + "'");

                            global::System.Data.Odbc.OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_oSelectStockQuery.ToString());
                            #region _oDr2
                            if (_oDr2.Read())
                            {
                                string _sAment_Date = string.Empty;
                                n_sImei_no = Func.FR(_oDr2["IMEI"]).Trim();
                                //=== get EDF# ===
                                if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no])))
                                {
                                    n_sRefNo = _oOrderSerialNumberControl.ReferenceNumber;
                                }
                                else
                                    n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim();

                                if (global::System.Convert.IsDBNull(_oDr2["Dummy1"]) || "".Equals(_oDr2["Dummy1"].ToString().Trim()))
                                {
                                    DateTime _dAment_Date;
                                    int _IOrdinal = _oDr2.GetOrdinal("Create_Date");
                                    _dAment_Date = _oDr2.GetDateTime(_IOrdinal);
                                    _sAment_Date = _dAment_Date.ToString("yyyyMMdd");
                                    //if(DateTime.TryParseExact(_oDr2["Create_Date"].ToString()
                                    // _sAment_Date = DateTime.ParseExact(_oDr2["Create_Date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToString("yyyyMMdd");

                                }
                                else
                                    _sAment_Date = _oDr2["Dummy1"].ToString();
                                if (!n_sRefNo.Equals(string.Empty) && !n_sImei_no.Equals(string.Empty))
                                {
                                    //'=== back up ===
                                    global::System.Text.StringBuilder _oBackUpIMEIStockQuery = new StringBuilder();
                                    _oBackUpIMEIStockQuery.Append(" INSERT INTO IMEI_Stock_hist ");
                                    _oBackUpIMEIStockQuery.Append(" (Kit_Code,Model,Status,ReferenceNo,Create_Date,");
                                    _oBackUpIMEIStockQuery.Append(" Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,IMEI,Ament_Date) ");
                                    _oBackUpIMEIStockQuery.Append(" VALUES ('" + Func.FR(_oDr2["Kit_Code"]) + "','");
                                    _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["Model"]) + "','" + Func.FR(_oDr2["Status"]) + "','");
                                    _oBackUpIMEIStockQuery.Append(n_sRefNo + "',to_date('" + n_sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'auto','");
                                    _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["Dummy1"]) + "','" + Func.FR(_oDr2["Dummy2"]) + "','");
                                    _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["Dummy3"]) + "','" + Func.FR(_oDr2["Stock_In_Date"]) + "','");
                                    _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["IMEI"]) + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
                                    bool _bBack_upImei = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oBackUpIMEIStockQuery.ToString());
                                    if (_bBack_upImei) { WebFunc.SaveQuery(_oBackUpIMEIStockQuery.ToString()); }
                                    //'=== update status ===
                                    global::System.Text.StringBuilder _oUpdateIMEIStockQuery = new StringBuilder();
                                    _oUpdateIMEIStockQuery.Append(" UPDATE IMEI_Stock SET ");
                                    _oUpdateIMEIStockQuery.Append(" Status='SOLD',STAFF_RECD=null, Dummy1='" + n_sToday1 + "', ");
                                    _oUpdateIMEIStockQuery.Append(" ReferenceNo='" + n_sRefNo + "', StaffNo='" + Func.FR(_oDr[MobileRetentionOrder.Para.staff_no]) + "' ,");
                                    _oUpdateIMEIStockQuery.Append(" Mobile_no='" + Func.FR(_oDr[MobileRetentionOrder.Para.mrt_no]) + "' ,Completed_Date='" + n_sToday1 + "' ");
                                    _oUpdateIMEIStockQuery.Append(" WHERE Dummy2='CC RET' and IMEI='" + n_sImei_no + "' ");
                                    _oUpdateIMEIStockQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]))) + "' ");
                                    _oUpdateIMEIStockQuery.Append(" AND Kit_Code='" + Func.FR(_oDr[MobileRetentionOrder.Para.sku]) + "' ");
                                    _oUpdateIMEIStockQuery.Append(" AND STAFF_RECD='" + x_sUid + "' AND Status='STOCK'");
                                    bool _bUpdateImei = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockQuery.ToString());
                                    if (_bUpdateImei) { WebFunc.SaveQuery( _oUpdateIMEIStockQuery.ToString()); }
                                }
                            }
                            else
                                n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim();
                            _oDr2.Close();
                            _oDr2.Dispose();
                            #endregion
                            #endregion
                        }
                        #endregion

                        MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase =
                        new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());

                        if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim()) &&
                            !string.IsNullOrEmpty(n_sRefNo))
                        {
                            if (_oEDFStatusProfile.AllowInsertEDFIMEI(n_sRefNo, n_sImei_no))
                            {
                                //=== back up ===
                                MobileRetentionOrderBal.BackUpOrder(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()), x_sUid);
                                #region === update EDF# & IMEI# ===
                                global::System.Text.StringBuilder _oUpdateEDFIMEISql = new global::System.Text.StringBuilder();
                                _oUpdateEDFIMEISql.Append(" UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder ");
                                _oUpdateEDFIMEISql.Append(" SET imei_no='" + n_sImei_no + "',edf_no='" + n_sRefNo + "',");
                                _oUpdateEDFIMEISql.Append(" cid='" + x_sUid + "',cdate=getdate() ");
                                _oUpdateEDFIMEISql.Append(" WHERE order_id='" + Func.FR(_oDr[MobileRetentionOrder.Para.order_id]) + "'");
                                bool _bUpdateWebLog = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oUpdateEDFIMEISql.ToString());
                                #endregion
                                int _iAmount = 0;
                                if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.amount]).Trim()))
                                    _iAmount = 0;
                                else
                                    _iAmount = Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.amount]).Trim());

                                int _iAccessory_price = 0;
                                if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.accessory_price]).Trim()))
                                    _iAccessory_price = 0;
                                else
                                    _iAccessory_price = Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.accessory_price]).Trim());

                                global::System.Text.StringBuilder _oSelectSundayFormSql = new global::System.Text.StringBuilder();
                                _oSelectSundayFormSql.Append(" SELECT referenceNo from sunday_Form ");
                                _oSelectSundayFormSql.Append(" WHERE CREATED_BY='CC RET' AND Agree_no='" + _sRecordId + "' AND cancelled='N' ");
                                global::System.Data.Odbc.OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_oSelectSundayFormSql.ToString());
                                if (!_oDr2.Read() &&
                                    _bUpdateWebLog &&
                                    _oEDFStatusProfile.AllowInsertEDFIMEI(n_sRefNo, n_sImei_no))
                                {
                                    MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id])));
                                    global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();
                                    if(!_oEDFStatusProfile.InsertEDF(x_iRecord_ID - 100000,3))
                                        throw new BusinessObjectNotFoundException("Class[AssignIMEIControl] Cannot Insert The RWL Order To EDF  [Record ID:" + x_iRecord_ID.ToString() + "]");

                                }
                                _oDr2.Close();
                                _oDr2.Dispose();
                            }
                        }
                        else
                        {
                            string _sRefNo1 = string.Empty;
                            bool _bAllEDFIMEI = _oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim(), n_sImei_no);
                            if (_bAllEDFIMEI)
                            {
                                global::System.Text.StringBuilder _oSelectRecordIDSql = new global::System.Text.StringBuilder();
                                _oSelectRecordIDSql.Append(" SELECT RECORD_ID From SUNDAY_AMENT ");
                                _oSelectRecordIDSql.Append(" WHERE ReferenceNo='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim() + "' ");
                                _oSelectRecordIDSql.Append(" And Field_Name='IMEI' And SUPPORT_PRINT is Null");
                                global::System.Data.Odbc.OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch(_oSelectRecordIDSql.ToString());
                                #region _oDr3
                                if (_oDr3.Read())
                                {
                                    #region Update Sunday_Ament
                                    global::System.Text.StringBuilder _oUpdateSundayAmentSql = new global::System.Text.StringBuilder();
                                    _oUpdateSundayAmentSql.Append(" UPDATE SUNDAY_Ament SET ");
                                    _oUpdateSundayAmentSql.Append(" Ament_Date=to_date('" + n_sToday.Trim() + "' ,");
                                    _oUpdateSundayAmentSql.Append(" 'dd/mm/yyyy hh24:mi:ss'),AMENT_BY='auto',");
                                    _oUpdateSundayAmentSql.Append(" Change_To='" + n_sImei_no.Trim() + "' Where Record_ID='" + Func.FR(_oDr3["record_id"]) + "'");
                                    bool _bSundayAment = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateSundayAmentSql.ToString());
                                    if (_bSundayAment) { WebFunc.SaveQuery(_oUpdateSundayAmentSql.ToString()); }
                                    #endregion
                                }
                                else
                                {

                                    global::System.Text.StringBuilder _oInertSundayAmentSql = new global::System.Text.StringBuilder();

                                    _sRefNo1 = _oOrderSerialNumberControl.ReferenceNumber;
                                    _oInertSundayAmentSql.Append(" INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,");
                                    _oInertSundayAmentSql.Append(" REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) ");
                                    _oInertSundayAmentSql.Append(" Values ('" + _sRefNo1 + "','CC RET','" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "',");
                                    _oInertSundayAmentSql.Append(" to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'auto' ,");
                                    _oInertSundayAmentSql.Append(" 'IMEI','" + Func.FR(_oDr["imei_no"]) + "','" + n_sImei_no + "')");
                                    bool _bSundayAment = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oInertSundayAmentSql.ToString());
                                    if (_bSundayAment) { WebFunc.SaveQuery(_oInertSundayAmentSql.ToString()); }

                                }
                                _oDr3.Close();
                                _oDr3.Dispose();
                            }
                                #endregion
                            #region Update Sunday_Form
                            if (_bAllEDFIMEI)
                            {
                                global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();
                                _oQuery.Append("UPDATE sunday_Form SET ");
                                //** log_date is converted from datetime to string by sql **//
                                _oQuery.Append("Applicat_date = to_date('" + Func.FR(_oDr["log_date"]).ToString() + "','dd/mm/yyyy'),");
                                _oQuery.Append("IMEI = '" + n_sImei_no.Trim() + "',");
                                _oQuery.Append("ament_counter = ament_counter + 1 ,");
                                _oQuery.Append("last_update='" + n_sToday + " auto' ");
                                _oQuery.Append("WHERE referenceNo ='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "'");
                                bool _bSundayFromUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                                if (_bSundayFromUpdate) { WebFunc.SaveQuery(_oQuery.ToString()); }
                            }
                            #endregion

                            MobileRetentionOrderBal.BackUpOrder(_iOrderID, x_sUid);
                            #region Update MobileRetentionOrder
                            if (!string.IsNullOrEmpty(n_sRefNo) && !string.IsNullOrEmpty(n_sImei_no) &&
                                            !n_sImei_no.Trim().ToUpper().Equals("AO") &&
                                            !n_sImei_no.Trim().ToUpper().Equals("AWAIT"))
                            {
                                MobileRetentionOrderEntity _oMobileRetentionOrderEntity = new MobileRetentionOrderEntity(SYSConn<MSSQLConnect>.Connect());
                                _oMobileRetentionOrderEntity.SetOrder_id(_iOrderID);
                                if (_oMobileRetentionOrderEntity.Retrieve())
                                {
                                    _oMobileRetentionOrderEntity.SetEdf_no(n_sRefNo);
                                    _oMobileRetentionOrderEntity.SetImei_no(n_sImei_no);
                                    _oMobileRetentionOrderEntity.SetCid(x_sUid);
                                    _oMobileRetentionOrderEntity.SetCdate(DateTime.Now);
                                    if (!_oMobileRetentionOrderEntity.Save())
                                        throw new BusinessObjectNotFoundException("Class[AssignIMEIControl] Cannot Update The Order  [Order_id:" + _iOrderID.ToString() + "]");
                                }
                                else
                                    throw new BusinessObjectNotFoundException("Class[AssignIMEIControl] Cannot Update The Order  [Order_id:" + _iOrderID.ToString() + "]");
                            }
                            else
                                throw new BusinessObjectNotFoundException("Class[AssignIMEIControl] Cannot Update The Order  [Order_id:" + _iOrderID.ToString() + "]");
                            #endregion
                        }
                        if (_oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(n_sRefNo, n_sImei_no) && !string.IsNullOrEmpty(x_sUid) && !string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()))
                        {
                            string _sQueryUpdate = "UPDATE MobileRetentionOrder SET imei_no='" + n_sImei_no + "',edf_no='" + n_sRefNo + "',cid='" + x_sUid + "',cdate=getdate() WHERE order_id='" + Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim() + "'";
                            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryUpdate);
                        }
                    }
                }
                _oDr.Close();
                _oDr.Dispose();
                #region Update IMEI Stock
                global::System.Text.StringBuilder _oUpdateIMEIStockSql = new global::System.Text.StringBuilder();
                _oUpdateIMEIStockSql.Append(" UPDATE IMEI_Stock SET STAFF_RECD=null ");
                _oUpdateIMEIStockSql.Append(" WHERE Dummy2='CC RET' ");
                _oUpdateIMEIStockSql.Append(" AND Status='STOCK' AND STAFF_RECD='" + x_sUid + "'");
                bool _bUpdated = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockSql.ToString());
                if (_bUpdated) { WebFunc.SaveQuery( _oUpdateIMEIStockSql.ToString()); }
                #endregion

            }
            return true;
        }



        protected bool CheckIMEINoInDB(string x_sIMEI)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            x_sIMEI = x_sIMEI.Trim();
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei FROM sunday_Form  WHERE referenceNo is not null AND referenceNo<>'' AND imei='" + x_sIMEI + "' AND rownum<=1");
            if (_oDr.Read())
            {
                if (!Func.FR(_oDr["imei"]).Trim().Equals(string.Empty))
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


        #region GetDB
        protected MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Get Oracle DB
        protected ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
    }
}
