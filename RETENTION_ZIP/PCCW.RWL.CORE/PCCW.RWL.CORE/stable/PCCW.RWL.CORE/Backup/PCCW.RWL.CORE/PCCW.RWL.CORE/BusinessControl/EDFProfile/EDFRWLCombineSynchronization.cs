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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE.WEBFUNC;
using PCCW.RWL.CORE.SERIAL;

using log4net;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-Wed>
///-- Description:	<Description,Class :EDFRWLCombineSynchronizationl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class EDFRWLCombineSynchronizationl
    {
        public string CheckRecordID = string.Empty;
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
        bool _bAllowInsertEDF = true;
        public bool _bWebRun = false;


        public void UpdateImei()
        {
            SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
            n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
            n_sTime1 = DateTime.Now.AddMinutes(-30).ToString("HH:mm:ss");
            int _iHour = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("HH"));
            int _iMinute = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("mm"));
            int _iSecond = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("ss"));
            if (n_oAlertMsgList != null)
                n_oAlertMsgList.Clear();
            else
                n_oAlertMsgList = new List<string>();
            if (!string.IsNullOrEmpty(n_sUid))
            {
                #region ================= Control only one staff can update status ==================
                global::System.Text.StringBuilder _oUpdateIMEIQuery = new StringBuilder();
                _oUpdateIMEIQuery.Append(" UPDATE IMEI_Stock SET STAFF_RECD='" + n_sUid + "' ");
                //_oUpdateIMEIQuery.Append(" Where Dummy2='CC RET' AND Status='STOCK' AND STAFF_RECD!='AUTOASSIGNID' ");

                _oUpdateIMEIQuery.Append(" Where Dummy2='CC RET' AND Status='STOCK' ");
                if (n_sUid != "AUTORUN")
                {
                    _oUpdateIMEIQuery.Append(" AND (STAFF_RECD is null or STAFF_RECD=' ')");
                }
                bool _bUpdateSuccess = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIQuery.ToString());
                #endregion ================= End of control only one staff can update status ==================

                global::System.Text.StringBuilder _oSelectOrderQuery = new StringBuilder();
                _oSelectOrderQuery.Append(" SELECT datediff(d,getdate(),d_date) as date_diff,");
                _oSelectOrderQuery.Append(" CONVERT(VARCHAR,log_date,103) log_date, sku,* FROM ");
                _oSelectOrderQuery.Append(Configurator.MSSQLTablePrefix + "MobileRetentionOrder ");
                _oSelectOrderQuery.Append(" with (nolock) WHERE active=1 ");
                _oSelectOrderQuery.Append(" AND (imei_no='AWAIT' OR imei_no='Await' OR imei_no='AO')  ");
                _oSelectOrderQuery.Append(" AND d_date is not null   ");

                global::System.Data.SqlClient.SqlDataReader _oDr =
                    SYSConn<MSSQLConnect>.Connect().GetSearch(_oSelectOrderQuery.ToString());
                while (_oDr.Read())
                {
                    if (!_bWebRun)
                    {
                        if (_oEDFStatusProfile.CheckClose())
                        {
                            UnLock(n_sUid);
                            _oDr.Close();
                            _oDr.Dispose();
                            return;
                        }
                    }



                    int _iOrder_id;
                    if (int.TryParse(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]), out _iOrder_id))
                        _oEDFStatusProfile.CheckIMEISTOCK(_iOrder_id);
                    else
                        continue;

                    _oOrderSerialNumberControl.SetOrder_id(_iOrder_id);

                    string _sRwl_imei_no = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT TOP 1 IMEI_NO FROM MOBILERETENTIONORDER WHERE ORDER_ID='" + _iOrder_id + "'");
                    if (!_sRwl_imei_no.Trim().ToUpper().Equals("AWAIT") && !_sRwl_imei_no.Trim().ToUpper().Equals("AO"))
                        continue;


                    if (Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Equals(string.Empty)) { continue; }
                    string _sRecordId = Func.IDAdd100000(_iOrder_id);
                    if (_sRecordId == string.Empty) Logger.WarnFormat("User cannot be found the result with empty({0}) value in this function.", "_sRecordId");
                    if (_sRecordId == CheckRecordID)
                        _sRecordId = _sRecordId;

                    if (_iHour > 14 || _iHour == 14 && _iHour >= 30)
                        n_iD_date = 1;
                    else
                        n_iD_date = 0;
                    string _sDate_diff = ("".Equals(Func.FR(_oDr["date_diff"]).Trim())) ? "-1" : Func.FR(_oDr["date_diff"]).Trim();
                    int _iDate_diff = -1;
                    if (!int.TryParse(_sDate_diff, out _iDate_diff))
                        _iDate_diff = -1;

                    if (_iDate_diff <= n_iD_date)
                        n_oAlertMsgList.Add("alert(\"Cannot Follow up!\n Please Re-confirm delivery date\")");
                    else
                    {
                        n_sImei_no = string.Empty;
                        n_sRefNo = string.Empty;
                        if (Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim() != string.Empty && !Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim().Equals("0"))
                        {
                            #region === check Stock ===
                            global::System.Text.StringBuilder _oSelectStockQuery = new StringBuilder();
                            _oSelectStockQuery.Append(" SELECT * FROM IMEI_Stock ");
                            _oSelectStockQuery.Append(" WHERE Dummy2='CC RET' AND ");
                            _oSelectStockQuery.Append(" Kit_Code='" + Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim() + "' ");
                            _oSelectStockQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]))) + "' ");
                            _oSelectStockQuery.Append(" AND Status='STOCK' AND IMEI<>' ' and STAFF_RECD='" + n_sUid + "'");

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


                                _bAllowInsertEDF = _oEDFStatusProfile.AllowInsertEDFIMEI(n_sRefNo, n_sImei_no);
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
                                if (!n_sRefNo.Equals(string.Empty) && !n_sImei_no.Equals(string.Empty) && _bAllowInsertEDF)
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
                                    //'=== update status ===
                                    global::System.Text.StringBuilder _oUpdateIMEIStockQuery = new StringBuilder();
                                    _oUpdateIMEIStockQuery.Append(" UPDATE IMEI_Stock SET ");
                                    _oUpdateIMEIStockQuery.Append(" Status='SOLD',STAFF_RECD=null, Dummy1='" + n_sToday1 + "', ");
                                    _oUpdateIMEIStockQuery.Append(" ReferenceNo='" + n_sRefNo + "', StaffNo='" + Func.FR(_oDr[MobileRetentionOrder.Para.staff_no]) + "' ,");
                                    _oUpdateIMEIStockQuery.Append(" Mobile_no='" + Func.FR(_oDr[MobileRetentionOrder.Para.mrt_no]) + "' ,Completed_Date='" + n_sToday1 + "' ");
                                    _oUpdateIMEIStockQuery.Append(" WHERE Dummy2='CC RET' and IMEI='" + n_sImei_no + "' ");
                                    _oUpdateIMEIStockQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]))) + "' ");
                                    _oUpdateIMEIStockQuery.Append(" AND Kit_Code='" + Func.FR(_oDr[MobileRetentionOrder.Para.sku]) + "' ");
                                    _oUpdateIMEIStockQuery.Append(" AND STAFF_RECD='" + n_sUid + "' AND Status='STOCK'");
                                    bool _bUpdateImei = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockQuery.ToString());
                                    if (_bUpdateImei)
                                    {
                                        WebFunc.SaveQuery(_oUpdateIMEIStockQuery.ToString());
                                    }
                                }
                            }
                            else
                                n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim();
                            _oDr2.Close();
                            _oDr2.Dispose();
                            #endregion
                            #endregion
                        }

                        MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase =
                        new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());
                        if (!string.IsNullOrEmpty(n_sRefNo))
                        {
                            if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim()) &&
                                !string.IsNullOrEmpty(n_sRefNo) &&
                                _bAllowInsertEDF &&
                                !string.IsNullOrEmpty(n_sImei_no) &&
                                !CheckIMEINoInDB(n_sImei_no))
                            {

                                //=== back up ===
                                MobileRetentionOrderBal.BackUpOrder(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()), n_sUid);

                                #region === update EDF# & IMEI# ===
                                bool _bUpdateWebLog = false;
                                if (_oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(n_sRefNo, n_sImei_no))
                                {
                                    if (UpdateIMEIInWebLog(_iOrder_id, n_sRefNo, n_sImei_no, n_sUid) > 0)
                                        _bUpdateWebLog = true;
                                    else
                                        _bUpdateWebLog = false;

                                }
                                #endregion

                                if (_bUpdateWebLog)
                                    _oEDFStatusProfile.InsertEDF(_iOrder_id, 3);
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
                                        if (n_sImei_no.Trim() != string.Empty)
                                        {
                                            #region Update Sunday_Ament
                                            global::System.Text.StringBuilder _oUpdateSundayAmentSql = new global::System.Text.StringBuilder();
                                            _oUpdateSundayAmentSql.Append(" UPDATE SUNDAY_Ament SET ");
                                            _oUpdateSundayAmentSql.Append(" Ament_Date=to_date('" + n_sToday.Trim() + "' ,");
                                            _oUpdateSundayAmentSql.Append(" 'dd/mm/yyyy hh24:mi:ss'),AMENT_BY='auto',");
                                            _oUpdateSundayAmentSql.Append(" Change_To='" + n_sImei_no.Trim() + "' Where Record_ID='" + Func.FR(_oDr3["record_id"]) + "'");
                                            SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateSundayAmentSql.ToString());
                                            #endregion
                                        }
                                    }
                                    else
                                    {

                                        global::System.Text.StringBuilder _oInertSundayAmentSql = new global::System.Text.StringBuilder();
                                        if (n_sImei_no.Trim() != string.Empty)
                                        {
                                            _sRefNo1 = _oOrderSerialNumberControl.ReferenceNumber;
                                            _oInertSundayAmentSql.Append(" INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,");
                                            _oInertSundayAmentSql.Append(" REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) ");
                                            _oInertSundayAmentSql.Append(" Values ('" + _sRefNo1 + "','CC RET','" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "',");
                                            _oInertSundayAmentSql.Append(" to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'auto' ,");
                                            _oInertSundayAmentSql.Append(" 'IMEI','" + Func.FR(_oDr["imei_no"]) + "','" + n_sImei_no + "')");
                                            bool _bSundayAment = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oInertSundayAmentSql.ToString());
                                        }

                                    }
                                    _oDr3.Close();
                                    _oDr3.Dispose();
                                    #endregion
                                }

                                #region Update Sunday_Form
                                if (_bAllEDFIMEI)
                                {
                                    if (n_sImei_no.Trim() != string.Empty)
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
                                    }
                                }
                                #endregion

                                MobileRetentionOrderBal.BackUpOrder(_iOrder_id, n_sUid);

                                #region Update MobileRetentionOrder
                                IQueryable<MobileRetentionOrderEntity> _oRwlOrderList =
                                from sRwlOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                                where
                                sRwlOrderList.edf_no == Func.FR(_oDr[MobileRetentionOrder.Para.edf_no])
                                select sRwlOrderList;
                                if (_oRwlOrderList.Count<MobileRetentionOrderEntity>() > 0)
                                {
                                    bool _bUpdateOrder = false;
                                    int _iUpdateOrder_id = -1;
                                    ISession<MSSQLConnect> _oSession = null;
                                    using (_oSession = _oSessionFactory.OpenSession())
                                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                                    {
                                        n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]);
                                        if (!string.IsNullOrEmpty(n_sRefNo) && !string.IsNullOrEmpty(n_sImei_no) &&
                                            !n_sImei_no.Trim().ToUpper().Equals("AO") &&
                                            !n_sImei_no.Trim().ToUpper().Equals("AWAIT"))
                                        {
                                            MobileRetentionOrderEntity _oMobileRetentionOrderEntity = _oRwlOrderList.First<MobileRetentionOrderEntity>();
                                            _oMobileRetentionOrderEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
                                            _oMobileRetentionOrderEntity.SetEdf_no(n_sRefNo);
                                            _oMobileRetentionOrderEntity.SetImei_no(n_sImei_no);
                                            _oMobileRetentionOrderEntity.SetCid(n_sUid);
                                            _oMobileRetentionOrderEntity.SetCdate(DateTime.Now);
                                            _bUpdateOrder = _oSession.Update(_oMobileRetentionOrderEntity);
                                            if (_bUpdateOrder)
                                                _oTransaction.Commit();
                                            else
                                                _oTransaction.Rollback();
                                            if (_oMobileRetentionOrderEntity.GetOrder_id() != null)
                                            {
                                                _iUpdateOrder_id = (int)_oMobileRetentionOrderEntity.GetOrder_id();
                                            }
                                        }
                                    }
                                    if (_bUpdateOrder &&
                                        _iUpdateOrder_id > 0)
                                    {
                                        MobileRetentionOrderBal.BackUpOrder(_iUpdateOrder_id, n_sUid);
                                    }

                                    if (n_sImei_no == string.Empty && n_sRefNo != string.Empty)
                                    {
                                        MobileRetentionOrderEntity _oMobileRetentionOrderEntity = _oRwlOrderList.First<MobileRetentionOrderEntity>();
                                        if (_oMobileRetentionOrderEntity.GetEdf_no() != string.Empty &&
                                            _oMobileRetentionOrderEntity.GetSku() != string.Empty &&
                                            _oMobileRetentionOrderEntity.GetOrder_id() != null)
                                        {
                                            StringBuilder _oImeiQuery = new StringBuilder();
                                            _oImeiQuery.AppendLine("SELECT IMEI FROM IMEI_Stock WHERE Dummy2='CC RET' AND  Kit_Code='" + _oMobileRetentionOrderEntity.GetSku() + "'  AND DUMMY4='" + _sRecordId + "' ");
                                            _oImeiQuery.AppendLine("AND Status='SOLD' AND IMEI<>' ' AND referenceno='" + _oMobileRetentionOrderEntity.GetEdf_no() + "' AND rownum<=1");

                                            OdbcDataReader _oImeiDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oImeiQuery.ToString());
                                            if (_oImeiDr.Read())
                                            {
                                                string _sImei_no = Func.FR(_oImeiDr["IMEI"]);
                                                if (!_sImei_no.Equals(string.Empty))
                                                {
                                                    _oMobileRetentionOrderEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
                                                    _oMobileRetentionOrderEntity.SetImei_no(_sImei_no);
                                                    bool _bUpdateImei = _oMobileRetentionOrderEntity.Save();
                                                }
                                            }
                                            _oImeiDr.Close();
                                            _oImeiDr.Dispose();

                                            StringBuilder _oAwaitQuery = new StringBuilder();
                                            _oAwaitQuery.AppendLine("SELECT IMEI FROM IMEI_Stock WHERE Dummy2='CC RET' AND  Kit_Code='" + _oMobileRetentionOrderEntity.GetSku() + "'  AND DUMMY4='" + _sRecordId + "' ");
                                            _oAwaitQuery.AppendLine("AND Status='STOCK' AND IMEI<>' ' AND referenceno='" + _oMobileRetentionOrderEntity.GetEdf_no() + "' AND rownum<=1");

                                            OdbcDataReader _oAwaitDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oAwaitQuery.ToString());
                                            if (_oAwaitDr.Read())
                                            {
                                                string _sImei_no = Func.FR(_oAwaitDr["IMEI"]);
                                                if (!_sImei_no.Equals(string.Empty))
                                                {
                                                    _oMobileRetentionOrderEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
                                                    _oMobileRetentionOrderEntity.SetImei_no("AWAIT");
                                                    bool _bUpdateImei = _oMobileRetentionOrderEntity.Save();
                                                }
                                            }
                                            _oAwaitDr.Close();
                                            _oAwaitDr.Dispose();
                                        }
                                    }
                                }
                                #endregion
                            }
                            if (_oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(n_sRefNo, n_sImei_no) && !string.IsNullOrEmpty(this.GetUid()) && !string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()))
                            {
                                if (n_sImei_no.Trim() != string.Empty && n_sRefNo != string.Empty)
                                    RWL_IMEI_EDF_UPDATE(n_sImei_no, n_sRefNo, n_sUid, Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim());
                            }
                            n_oAlertMsgList.Add("alert(\"DONE!\nEDF No:" + n_sRefNo + "\nIMEI No:" + n_sImei_no + "\")");
                        }
                        else
                        {
                            n_oAlertMsgList.Add("alert(\"Cannot Follow up!\")");
                        }
                    }
                }
                _oDr.Close();
                _oDr.Dispose();
                UnLock(n_sUid);
            }
        }

        public void AssignNORMALIMEI()
        {
            StringBuilder _oQuery1 = new StringBuilder();
            _oQuery1.Append("SELECT distinct sku FROM MobileRetentionOrder WHERE (imei_no='AO' OR imei_no='AWAIT') AND SKU is not null AND SKU!='' ");
            SqlDataReader _oDr1 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery1.ToString());
            while (_oDr1.Read())
            {
                string _sSku = Func.FR(_oDr1["sku"]).Trim();
                if (!string.IsNullOrEmpty(_sSku))
                {
                    StringBuilder _oQuery2 = new StringBuilder();
                    _oQuery2.Append("SELECT * from IMEI_Stock where Kit_Code='" + _sSku + "' AND Dummy2='CC RET' AND Status in ('AWAIT','AO')  order by Create_Date");
                    global::System.Data.Odbc.OdbcDataReader _oDr2 = GetORDB().GetSearch(_oQuery2.ToString());
                    if (_oDr2.Read())
                    {
                        string _sRecordID = Func.FR(_oDr2["DUMMY4"]).Trim();
                        string _sEdfNo = Func.FR(_oDr2["REFERENCENO"]).Trim();
                        string _sIMEI = Func.FR(_oDr2["IMEI"]).Trim();
                        string _sStatus = Func.FR(_oDr2["STATUS"]).Trim();
                        int _iOrder_id;
                        if (int.TryParse(_sRecordID, out _iOrder_id))
                        {
                            StringBuilder _oQuery3 = new StringBuilder();
                            _oQuery3.Append("SELECT * FROM IMEI_Stock Where Dummy2='CC RET' and Kit_Code='" + _sSku + "' and Status='NORMAL' and IMEI<>' ' and IMEI is not null order by IMEI");
                            OdbcDataReader _oDr3 = GetORDB().GetSearch(_oQuery3.ToString());
                            if (_oDr3.Read())
                            {
                                string _sIMEI_NS = Func.FR(_oDr3["IMEI"]).Trim();
                                string _sStatus_NS = Func.FR(_oDr3["STATUS"]).Trim();
                                bool _oUpdate = true;
                                StringBuilder _oQuery4 = new StringBuilder();
                                StringBuilder _oQuery5 = new StringBuilder();
                                if (_sStatus == "AO")
                                {
                                    if (!GetIMEI_STOCK(_sRecordID, "AWAIT", _sSku) && !GetIMEI_STOCK(_sRecordID, "SOLD", _sSku))
                                    {
                                        _oQuery4.Append("UPDATE IMEI_STOCK SET IMEI='" + _sIMEI_NS + "' , STATUS='STOCK' WHERE DUMMY4='" + _sRecordID + "' AND STATUS='AO' AND DUMMY2='CC RET' AND KIT_CODE='" + _sSku + "' AND ROWNUM<=1");
                                        _oUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery4.ToString());
                                    }
                                    else
                                    {
                                        _oUpdate = false;
                                    }
                                }
                                else if (_sStatus == "AWAIT")
                                {
                                    if (!GetIMEI_STOCK(_sRecordID, "AO", _sSku) && !GetIMEI_STOCK(_sRecordID, "SOLD", _sSku))
                                    {
                                        _oQuery4.Append("UPDATE IMEI_STOCK SET IMEI='" + _sIMEI_NS + "' , STATUS='STOCK' WHERE DUMMY4='" + _sRecordID + "' AND STATUS='AWAIT' AND DUMMY2='CC RET' AND KIT_CODE='" + _sSku + "' AND ROWNUM<=1");
                                        _oUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery4.ToString());
                                    }
                                    else
                                    {
                                        _oUpdate = false;
                                    }
                                }

                                if (_oUpdate)
                                {
                                    _oQuery5.Append("UPDATE IMEI_STOCK SET STATUS='',IMEI='',DUMMY2='',Kit_Code='',MODEL='' WHERE IMEI='" + _sIMEI_NS + "' AND STATUS='NORMAL' AND DUMMY2='CC RET' AND KIT_CODE='" + _sSku + "' AND ROWNUM<=1");
                                    _oUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery5.ToString());
                                    //Response.Write(_oQuery4.ToString() + "<br>");
                                    //if (_oUpdate) { Response.Write(_oQuery5.ToString() + "<br>"); }
                                }
                            }
                            _oDr3.Close();
                            _oDr3.Dispose();
                        }
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
            }
            _oDr1.Close();
            _oDr1.Dispose();
        }




        protected bool GetIMEI_STOCK(string x_sRecordID, string x_sStatus, string x_sSku)
        {
            if (string.IsNullOrEmpty(x_sRecordID)) { return false; }
            if (string.IsNullOrEmpty(x_sStatus)) { return false; }
            if (string.IsNullOrEmpty(x_sSku)) { return false; }
            StringBuilder _oQuery2 = new StringBuilder();
            _oQuery2.Append("SELECT IMEI FROM IMEI_STOCK WHERE DUMMY4='" + x_sRecordID + "' AND Kit_Code='" + x_sSku + "' AND Dummy2='CC RET' AND Status='" + x_sStatus + "' ORDER BY Create_Date");
            global::System.Data.Odbc.OdbcDataReader _oDr2 = GetORDB().GetSearch(_oQuery2.ToString());
            if (_oDr2.Read())
            {
                _oDr2.Close();
                _oDr2.Dispose();
                return true;
            }
            _oDr2.Close();
            _oDr2.Dispose();

            return false;
        }

        protected void UnLock(string x_sUid)
        {
            #region Update IMEI Stock
            global::System.Text.StringBuilder _oUpdateIMEIStockSql = new global::System.Text.StringBuilder();
            _oUpdateIMEIStockSql.Append(" UPDATE IMEI_Stock SET STAFF_RECD=null ");
            _oUpdateIMEIStockSql.Append(" WHERE Dummy2='CC RET' ");
            _oUpdateIMEIStockSql.Append(" AND Status='STOCK' AND STAFF_RECD='" + x_sUid + "'");
            bool _bUpdated = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockSql.ToString());
            #endregion
        }

        protected void RWL_IMEI_EDF_UPDATE(string x_sImei_no, string x_sRef_no, string x_sUid, string x_sOrder_id)
        {
            int _iOrder_id;
            bool _bUpdateOrder = false;
            try
            {
                SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
                if (int.TryParse(x_sOrder_id, out _iOrder_id))
                {
                    ISession<MSSQLConnect> _oSession = null;
                    using (_oSession = _oSessionFactory.OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        MobileRetentionOrderEntity _oMobileRetentionOrderEntity = new MobileRetentionOrderEntity(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
                        if (_oMobileRetentionOrderEntity.GetFound())
                        {
                            _oMobileRetentionOrderEntity.SetImei_no(x_sImei_no);
                            _oMobileRetentionOrderEntity.SetEdf_no(x_sRef_no);
                            _oMobileRetentionOrderEntity.SetCid(x_sUid);
                            _oMobileRetentionOrderEntity.SetCdate(DateTime.Now);
                            _bUpdateOrder = _oSession.Update(_oMobileRetentionOrderEntity);
                            if (_bUpdateOrder)
                                _oTransaction.Commit();
                            else
                                _oTransaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception exp)
            {

            }
            finally
            {

            }
        }

        protected int UpdateIMEIInWebLog(int x_iOrder_id, string x_sRefNo, string x_sImei_no, string x_sUid)
        {
            int _iUpdateOrder_id = -1;
            try
            {
                bool _bUpdateOrder = false;
                SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
                ISession<MSSQLConnect> _oSession = null;
                using (_oSession = _oSessionFactory.OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    MobileRetentionOrderEntity _oMobileRetentionOrderEntity = new MobileRetentionOrderEntity(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
                    if (_oMobileRetentionOrderEntity.GetFound())
                    {
                        _oMobileRetentionOrderEntity.SetEdf_no(x_sRefNo);
                        _oMobileRetentionOrderEntity.SetImei_no(x_sImei_no);
                        _oMobileRetentionOrderEntity.SetCid(x_sUid);
                        _bUpdateOrder = _oSession.Update(_oMobileRetentionOrderEntity);
                        if (_bUpdateOrder)
                            _oTransaction.Commit();
                        else
                        {
                            _oTransaction.Rollback();
                            return -1;
                        }
                        if (_oMobileRetentionOrderEntity.GetOrder_id() != null)
                            _iUpdateOrder_id = (int)_oMobileRetentionOrderEntity.GetOrder_id();
                    }
                }
            }
            catch (Exception exp)
            {

            }
            finally
            {

            }
            return _iUpdateOrder_id;
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
        protected string n_sAment_Date = string.Empty;
        #region m_sAment_Date
        protected string m_sAment_Date
        {
            get
            {
                return this.n_sAment_Date;
            }
            set
            {
                this.n_sAment_Date = value;
            }
        }
        #endregion m_sAment_Date


        protected string n_sToday1 = string.Empty;
        #region m_sToday1
        protected string m_sToday1
        {
            get
            {
                return this.n_sToday1;
            }
            set
            {
                this.n_sToday1 = value;
            }
        }
        #endregion m_sToday1


        protected string n_sTime1 = string.Empty;
        #region m_sTime1
        protected string m_sTime1
        {
            get
            {
                return this.n_sTime1;
            }
            set
            {
                this.n_sTime1 = value;
            }
        }
        #endregion m_sTime1


        protected int n_iAmount = -1;
        #region m_iAmount
        protected int m_iAmount
        {
            get
            {
                return this.n_iAmount;
            }
            set
            {
                this.n_iAmount = value;
            }
        }
        #endregion m_iAmount


        protected string n_sToday = string.Empty;
        #region m_sToday
        protected string m_sToday
        {
            get
            {
                return this.n_sToday;
            }
            set
            {
                this.n_sToday = value;
            }
        }
        #endregion m_sToday


        protected int n_iAccessory_price = -1;
        #region m_iAccessory_price
        protected int m_iAccessory_price
        {
            get
            {
                return this.n_iAccessory_price;
            }
            set
            {
                this.n_iAccessory_price = value;
            }
        }
        #endregion m_iAccessory_price


        protected string n_sUid = string.Empty;
        #region m_sUid
        protected string m_sUid
        {
            get
            {
                return this.n_sUid;
            }
            set
            {
                this.n_sUid = value;
            }
        }
        #endregion m_sUid


        protected global::System.Collections.Generic.List<string> n_oAlertMsgList = new global::System.Collections.Generic.List<string>();
        #region m_oAlertMsgList
        protected global::System.Collections.Generic.List<string> m_oAlertMsgList
        {
            get
            {
                return this.n_oAlertMsgList;
            }
            set
            {
                this.n_oAlertMsgList = value;
            }
        }
        #endregion m_oAlertMsgList


        protected string n_sImei_no = string.Empty;
        #region m_sImei_no
        protected string m_sImei_no
        {
            get
            {
                return this.n_sImei_no;
            }
            set
            {
                this.n_sImei_no = value;
            }
        }
        #endregion m_sImei_no


        protected int n_iD_date = -1;
        #region m_iD_date
        protected int m_iD_date
        {
            get
            {
                return this.n_iD_date;
            }
            set
            {
                this.n_iD_date = value;
            }
        }
        #endregion m_iD_date


        protected string n_sRefNo = string.Empty;
        #region m_sRefNo
        protected string m_sRefNo
        {
            get
            {
                return this.n_sRefNo;
            }
            set
            {
                this.n_sRefNo = value;
            }
        }
        #endregion m_sRefNo


        #region Constructor & Destructor
        public EDFRWLCombineSynchronizationl() { }

        public EDFRWLCombineSynchronizationl(string x_sAment_Date, string x_sToday1, string x_sTime1, int x_iAmount, string x_sToday, int x_iAccessory_price, string x_sUid, global::System.Collections.Generic.List<string> x_oAlertMsgList, string x_sImei_no, int x_iD_date, string x_sRefNo)
        {
            m_sAment_Date = x_sAment_Date;
            m_sToday1 = x_sToday1;
            m_sTime1 = x_sTime1;
            m_iAmount = x_iAmount;
            m_sToday = x_sToday;
            m_iAccessory_price = x_iAccessory_price;
            m_sUid = x_sUid;
            m_oAlertMsgList = x_oAlertMsgList;
            m_sImei_no = x_sImei_no;
            m_iD_date = x_iD_date;
            m_sRefNo = x_sRefNo;
        }

        ~EDFRWLCombineSynchronizationl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetAment_Date() { return this.m_sAment_Date; }
        public string GetToday1() { return this.m_sToday1; }
        public string GetTime1() { return this.m_sTime1; }
        public int GetAmount() { return this.m_iAmount; }
        public string GetToday() { return this.m_sToday; }
        public int GetAccessory_price() { return this.m_iAccessory_price; }
        public string GetUid() { return this.m_sUid; }
        public global::System.Collections.Generic.List<string> GetAlertMsgList() { return this.m_oAlertMsgList; }
        public string GetImei_no() { return this.m_sImei_no; }
        public int GetD_date() { return this.m_iD_date; }
        public string GetRefNo() { return this.m_sRefNo; }

        public bool SetAment_Date(string value)
        {
            this.m_sAment_Date = value;
            return true;
        }
        public bool SetToday1(string value)
        {
            this.m_sToday1 = value;
            return true;
        }
        public bool SetTime1(string value)
        {
            this.m_sTime1 = value;
            return true;
        }
        public bool SetAmount(int value)
        {
            this.m_iAmount = value;
            return true;
        }
        public bool SetToday(string value)
        {
            this.m_sToday = value;
            return true;
        }
        public bool SetAccessory_price(int value)
        {
            this.m_iAccessory_price = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetAlertMsgList(List<string> value)
        {
            this.m_oAlertMsgList = value;
            return true;
        }
        public bool SetImei_no(string value)
        {
            this.m_sImei_no = value;
            return true;
        }
        public bool SetD_date(int value)
        {
            this.m_iD_date = value;
            return true;
        }
        public bool SetRefNo(string value)
        {
            this.m_sRefNo = value;
            return true;
        }
        #endregion



        #region Equals
        public bool Equals(EDFRWLCombineSynchronizationl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sAment_Date.Equals(x_oObj.m_sAment_Date)) { return false; }
            if (!this.m_sToday1.Equals(x_oObj.m_sToday1)) { return false; }
            if (!this.m_sTime1.Equals(x_oObj.m_sTime1)) { return false; }
            if (!this.m_iAmount.Equals(x_oObj.m_iAmount)) { return false; }
            if (!this.m_sToday.Equals(x_oObj.m_sToday)) { return false; }
            if (!this.m_iAccessory_price.Equals(x_oObj.m_iAccessory_price)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_oAlertMsgList.Equals(x_oObj.m_oAlertMsgList)) { return false; }
            if (!this.m_sImei_no.Equals(x_oObj.m_sImei_no)) { return false; }
            if (!this.m_iD_date.Equals(x_oObj.m_iD_date)) { return false; }
            if (!this.m_sRefNo.Equals(x_oObj.m_sRefNo)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_sAment_Date = string.Empty;
            this.m_sToday1 = string.Empty;
            this.m_sTime1 = string.Empty;
            this.m_iAmount = -1;
            this.m_sToday = string.Empty;
            this.m_iAccessory_price = -1;
            this.m_sUid = string.Empty;
            this.m_oAlertMsgList = new global::System.Collections.Generic.List<string>();
            this.m_sImei_no = string.Empty;
            this.m_iD_date = -1;
            this.m_sRefNo = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public EDFRWLCombineSynchronizationl DeepClone()
        {
            EDFRWLCombineSynchronizationl EDFRWLCombineSynchronizationl_Clone = new EDFRWLCombineSynchronizationl();
            EDFRWLCombineSynchronizationl_Clone.SetAment_Date(this.m_sAment_Date);
            EDFRWLCombineSynchronizationl_Clone.SetToday1(this.m_sToday1);
            EDFRWLCombineSynchronizationl_Clone.SetTime1(this.m_sTime1);
            EDFRWLCombineSynchronizationl_Clone.SetAmount(this.m_iAmount);
            EDFRWLCombineSynchronizationl_Clone.SetToday(this.m_sToday);
            EDFRWLCombineSynchronizationl_Clone.SetAccessory_price(this.m_iAccessory_price);
            EDFRWLCombineSynchronizationl_Clone.SetUid(this.m_sUid);
            EDFRWLCombineSynchronizationl_Clone.SetAlertMsgList(this.m_oAlertMsgList);
            EDFRWLCombineSynchronizationl_Clone.SetImei_no(this.m_sImei_no);
            EDFRWLCombineSynchronizationl_Clone.SetD_date(this.m_iD_date);
            EDFRWLCombineSynchronizationl_Clone.SetRefNo(this.m_sRefNo);
            return EDFRWLCombineSynchronizationl_Clone;
        }
        #endregion Clone

    }
}
