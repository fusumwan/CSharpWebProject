using System;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-08-11>
///-- Description:	<Description,Class :EDFStatusProfile, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class EDFStatusProfile : IDisposable
    {
        MobileOrderAddress _oRegisteredAddress = new MobileOrderAddress();
        MobileOrderAddress _oBillingAddress = new MobileOrderAddress();
        MobileOrderMNPDetail _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
        MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty();
        List<MobileOrderVasEntity> _oMobileOrderVasArr = new List<MobileOrderVasEntity>();
        SundayActivation _oSundayActivation = new SundayActivation();

        public static bool EDFOrderDelete(int x_iRecordID, string x_sUid, string x_sDeremark)
        {
            string[] n_sDateTimeList = { "dd/MM/yyyy hh24:mi:ss" };
            string[] n_sDateTimeList2 = { "yyyyMMdd" };
            EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
            string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
            string _sToday2 = DateTime.Now.ToString("yyyy-MM-dd");
            string _sTime1 = DateTime.Now.ToString("HH:mm:ss");
            int _iRecord_id = x_iRecordID;

            //string _sOrder_id = Func.IDSubtract100000(_iRecord_id);
            //int _iOrder_id;
            //if (!int.TryParse(_sOrder_id, out _iOrder_id)) { return; }

            int _iOrder_id = Convert.ToInt32(Func.IDSubtract100000(x_iRecordID));
            string _sOrder_id = _iOrder_id.ToString();
            bool _bPassIssue = false;
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            if (_oMobileRetentionOrder.GetFound())
            {
                if (_oMobileRetentionOrder.GetEdf_no() != string.Empty &&
                    _oMobileRetentionOrder.GetSim_item_code() == string.Empty &&
                    _oMobileRetentionOrder.GetSku() == string.Empty)
                {
                    _bPassIssue = true;
                }

                if (_oMobileRetentionOrder.GetCn_mrt_no() != null)
                {
                    _oEDFStatusProfile.LoadData(_oMobileRetentionOrder.GetEdf_no());
                    if (_oEDFStatusProfile.Found)
                    {
                        if (_oEDFStatusProfile.Create_s == "N")
                        {
                            if (SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE MobileNumberProfile SET STATUS='NOTUSED' WHERE mrt_no='" + _oMobileRetentionOrder.GetCn_mrt_no() + "'"))
                            {
                                _oMobileRetentionOrder.SetCn_mrt_no(null);
                                _oMobileRetentionOrder.Save();
                            }
                        }
                    }
                }

            }


            string _sQuery1 = "UPDATE MobileGoWirelessDetail  SET assign=0,assign_staff=null,assign_date=null,order_id=null WHERE order_id ='" + _iOrder_id.ToString() + "'";
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery1);
            MobileRetentionOrderBal.BackUpOrder(_iOrder_id, x_sUid);
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT sku,imei_no,edf_no FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active =1 AND order_id ='" + _sOrder_id + "'");
            if (_oDr.Read())
            {
                if (!"".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no])))
                {
                    string _sQuery2 = "SELECT * FROM SUNDAY_FORM WHERE referenceNO='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "' AND issue='Y'";
                    OdbcDataReader _Dr3 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery2);
                    if (_Dr3.Read() && _bPassIssue == false)
                    {
                        string _sRef_no = GetRdf();
                        string _sQuery3 = "INSERT INTO SUNDAY_Ament (Record_ID,eOrder_Update ,eOrder_U_Date ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "','Y',to_date('" + _sToday2 + "','yyyy-mm-dd'),'CC RET','" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "',to_date('" + _sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "' ,'SS-E Order System Cancelled','No','Yes')";
                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery3);
                        string _sQuery7 = "UPDATE SUNDAY_FORM SET STOCK_RELEASE='Y' WHERE REFERENCENO='" + _sRef_no + "' AND ROWNUM<=1";
                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery7);

                    }
                    else
                    {

                        string _sQuery5 = "INSERT INTO SUNDAY_Ament (Record_ID,eOrder_Update ,eOrder_U_Date ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "','Y',to_date('" + _sToday2 + "','yyyy-mm-dd'),'CC RET','" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "',to_date('" + _sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "' ,'SS-E Order System Cancelled','No','Yes')";
                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery5);

                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET cancelled = 'Y' , cancel_date = to_date('" + DateTime.Now.ToString("dd/MM/yyy") + "','dd/mm/yyyy'), remark = remark || ' Order deleted by " + x_sUid + " (" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ")' where referenceno='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "'");
                        string _sQuery4 = "SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND Status<>'CANCEL' AND DUMMY4='" + _iRecord_id.ToString() + "' ";
                        OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery4);
                        if (_oDr2 != null)
                        {
                            while (_oDr2.Read())
                            {
                                string _sImei_no = Func.FR(_oDr2["Imei"]);
                                string _sAment_Date = string.Empty;
                                if (Convert.IsDBNull(_oDr2["Dummy1"]) || "".Equals(_oDr2["Dummy1"].ToString().Trim()))
                                {
                                    if (!Convert.IsDBNull(_oDr2["Create_Date"]) && _oDr2["Create_Date"] != null)
                                    {
                                        DateTime _dAment_Date = (DateTime)_oDr2["Create_Date"];
                                        _sAment_Date = _dAment_Date.ToString("yyyyMMdd");
                                    }
                                    else
                                    {
                                        _sAment_Date = Func.FR(_oDr2["Dummy1"]).ToString();
                                    }
                                    //_sAment_Date = DateTime.ParseExact(_oDr2["Create_Date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToString("yyyyMMdd");
                                }
                                else
                                    _sAment_Date = _oDr2["Dummy1"].ToString();
                                GetORDB().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) values ('" + Func.FR(_oDr2["Kit_Code"]).ToString() + "','" + Func.FR(_oDr2["Model"]).ToString() + "','" + Func.FR(_oDr2["Status"]).ToString() + "','" + Func.FR(_oDr2["ReferenceNo"]).ToString() + "','" + Func.FR(_oDr2["DUMMY4"]).ToString() + "',to_date('" + _sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "','" + Func.FR(_oDr2["Dummy1"]).ToString() + "','" + Func.FR(_oDr2["Dummy2"]).ToString() + "','" + Func.FR(_oDr2["Stock_In_Date"]).ToString() + "','" + Func.FR(_oDr2["IMEI"]).ToString() + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
                                if (!"".Equals(_sImei_no))
                                {
                                    OdbcDataReader _oDr4 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock where Kit_Code='" + Func.FR(_oDr["sku"]) + "' AND Dummy2='CC RET' AND Status in ('AWAIT','AO') order by Create_Date");
                                    if (_oDr4.Read())
                                    {
                                        if (_sImei_no != string.Empty)
                                        {
                                            //_oEDFStatusProfile.UsedDOAIMEI(_sImei_no, _iOrder_id, IMEISTATUS.NORMAL, false, true);
                                        }
                                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(" UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + _sToday1 + "',IMEI='A" + _sImei_no + "' where Dummy2='CC RET' AND DUMMY4='" + _iRecord_id.ToString() + "' AND imei='" + _sImei_no + "'");
                                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,Create_Date,Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,DUMMY4,IMEI,Ament_Date) values ('" + Func.FR(_oDr4["Kit_Code"]).Trim() + ",'" + Func.FR(_oDr4["Model"]).Trim() + "','" + Func.FR(_oDr4["ReferenceNo"]).Trim() + "','to_date('" + _sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "','" + Func.FR(_oDr4["Dummy1"]).Trim() + "','" + Func.FR(_oDr4["Dummy2"]).Trim() + "','" + Func.FR(_oDr4["Dummy3"]).Trim() + "','" + Func.FR(_oDr4["DUMMY4"]) + "','" + Func.FR(_oDr4["IMEI"]).Trim() + "',to_date('" + _sAment_Date + "','yyyymmdd'))");
                                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(" UPDATE IMEI_Stock SET Status='STOCK', IMEI='" + _sImei_no + "', Completed_Date='" + _sToday1 + "' where Dummy2='CC RET' AND DUMMY4='" + Func.FR(_oDr4["DUMMY4"]) + "' AND Kit_Code='" + Func.FR(_oDr["sku"]) + "' AND Status in ('AWAIT','AO')");
                                    }
                                    else
                                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(" UPDATE IMEI_Stock SET Status='NORMAL', Dummy1='" + _sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND DUMMY4='" + _iRecord_id.ToString() + "' AND imei='" + _sImei_no + "'");

                                    _oDr4.Close();
                                    _oDr4.Dispose();
                                }
                                else
                                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + _sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND DUMMY4='" + _iRecord_id.ToString() + "' AND Status in ('AO','AWAIT')");
                            }
                            _oDr2.Close();
                            _oDr2.Dispose();
                        }
                    }
                    _Dr3.Dispose();
                    _Dr3.Dispose();
                }
                else
                {
                    OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock where Dummy2='CC RET' AND Status<>'CANCEL' AND DUMMY4='" + Func.FR(WebFunc.qsOrder_id) + "'");
                    if (_oDr2 != null)
                    {
                        string _sAment_Date = string.Empty;
                        while (_oDr2.Read())
                        {
                            string _sImei_no = Func.FR(_oDr2["Imei"]);
                            if (Convert.IsDBNull(_oDr2["Dummy1"]) || "".Equals(_oDr2["Dummy1"].ToString().Trim()))
                            {
                                if (!Convert.IsDBNull(_oDr2["Create_Date"]) && _oDr2["Create_Date"] != null)
                                {
                                    DateTime _dAment_Date = (DateTime)_oDr2["Create_Date"];
                                    _sAment_Date = _dAment_Date.ToString("yyyyMMdd");
                                }
                                else
                                {
                                    _sAment_Date = Func.FR(_oDr2["Dummy1"]).ToString();
                                }
                                //_sAment_Date = DateTime.ParseExact(_oDr2["Create_Date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToString("yyyyMMdd");
                            }
                            else
                                _sAment_Date = _oDr2["Dummy1"].ToString();

                            string _sQuery4 = "INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,Create_Date,Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,DUMMY4,IMEI,Ament_Date) values ('" + Func.FR(_oDr2["Kit_Code"]) + "','" + Func.FR(_oDr2["Model"]) + "','" + Func.FR(_oDr2["Status"]) + "','" + Func.FR(_oDr2["ReferenceNo"]) + "',to_date('" + _sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "','" + Func.FR(_oDr2["Dummy1"]) + "','" + Func.FR(_oDr2["Dummy2"]) + "','" + Func.FR(_oDr2["Dummy3"]) + "','" + Func.FR(_oDr2["Stock_In_Date"]) + "','" + Func.FR(_oDr2["DUMMY4"]) + "','" + Func.FR(_oDr2["IMEI"]) + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ";
                            GetORDB().ExplicitNonQuery(_sQuery4);
                            if (!"".Equals(_sImei_no))
                            {
                                OdbcDataReader _oDr4 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock WHERE Kit_Code='" + Func.FR(_oDr["sku"]) + "' AND Dummy2='CC RET' AND Status in ('AWAIT','AO') AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location().Trim() + "' ORDER BY Create_Date");
                                if (_oDr4.Read())
                                {
                                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + _sToday1 + "',IMEI='A" + _sImei_no + "' where Dummy2='CC RET' AND DUMMY4='" + _iRecord_id.ToString() + "' AND imei='" + _sImei_no + "'");
                                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,Create_Date,Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,DUMMY4,IMEI,Ament_Date) values ('" + Func.FR(_oDr4["Kit_Code"]).Trim() + "','" + Func.FR(_oDr4["Model"]).Trim() + "','" + Func.FR(_oDr4["Status"]).Trim() + "','" + Func.FR(_oDr4["ReferenceNo"]).Trim() + "',to_date('" + _sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + x_sUid + "','" + Func.FR(_oDr4["Dummy1"]).Trim() + "','" + Func.FR(_oDr4["Dummy2"]).Trim() + "','" + Func.FR(_oDr4["Dummy3"]).Trim() + "','" + Func.FR(_oDr4["Stock_In_Date"]) + "','" + Func.FR(_oDr4["DUMMY4"]).Trim() + "','" + Func.FR(_oDr4["IMEI"]).Trim() + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
                                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='STOCK', IMEI='" + _sImei_no + "', Completed_Date='" + _sToday + "' where Dummy2='CC RET' AND DUMMY4='" + Func.FR(_oDr4["DUMMY4"]).Trim() + "' AND Kit_Code='" + Func.FR(_oDr["sku"]).Trim() + "' AND Status in ('AWAIT','AO') AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location().Trim() + "' ");
                                }
                                else
                                {
                                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='NORMAL', Dummy1='" + _sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND DUMMY4='" + _iRecord_id.ToString() + "' AND imei='" + _sImei_no + "'");
                                }
                                _oDr4.Close();
                                _oDr4.Dispose();
                            }
                            else
                                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + _sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND DUMMY4='" + _iRecord_id.ToString() + "' AND Status in ('AO','AWAIT')");
                        }
                        _oDr2.Close();
                        _oDr2.Dispose();
                    }
                }
            }
            _oDr.Close();
            _oDr.Dispose();

            string _sQueryOrder = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET active=0,del_remark='" + Func.FR(WebFunc.qsDel_remark).Trim().Replace("'", "''") + "', did='" + x_sUid + "', ddate=getdate() where order_id='" + _sOrder_id + "'";
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryOrder);

            return true;
        }

        #region GetDB
        protected static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Get Oracle DB
        protected static ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion


        public static string GetRdf()
        {
            OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT FTS_CPE5_Serial.NextVal AS seq, to_char(sysdate, 'yymon') AS cdate FROM dual");
            string _sRefNo = string.Empty;
            if (_oDr2 != null)
                if (_oDr2.Read()) { _sRefNo = Func.FR(_oDr2["seq"]).ToString() + "/A/" + Func.FR(_oDr2["cdate"]).ToString(); }
            _oDr2.Close();
            _oDr2.Dispose();
            return _sRefNo;
        }


        public bool ChkAOCaseExisting(string EDFNO, string SKU)
        {
            bool _bFlag = false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT REFERENCENO,IMEI,CREATE_BY,MODEL,KIT_CODE,DUMMY4,STATUS FROM IMEI_STOCK WHERE REFERENCENO='" + EDFNO.ToString() + "' AND KIT_CODE='" + SKU + "' AND STATUS='AO' ");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();


            return _bFlag;
        }

        public bool ChkAWAITCaseExisting(string EDFNO, string SKU)
        {
            bool _bFlag = false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT REFERENCENO,IMEI,CREATE_BY,MODEL,KIT_CODE,DUMMY4,STATUS FROM IMEI_STOCK WHERE REFERENCENO='" + EDFNO.ToString() + "' AND KIT_CODE='" + SKU + "' AND STATUS='AWAIT' ");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();

            return _bFlag;
        }

        public bool InsertAOCase(int x_iOrder_id)
        {
            string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
            StringBuilder _oCheckAOImei = new StringBuilder();
            _oCheckAOImei.Append("SELECT IMEI FROM IMEI_Stock WHERE ");
            _oCheckAOImei.Append(" kit_code='" + _oMobileRetentionOrder.GetSku() + "' ");
            _oCheckAOImei.Append(" AND Model='" + _oMobileRetentionOrder.GetHs_model() + "' ");
            _oCheckAOImei.Append(" AND Status='AO' ");
            _oCheckAOImei.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
            _oCheckAOImei.Append(" AND ReferenceNo='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
            _oCheckAOImei.Append(" AND Dummy2='CC RET'");
            OdbcDataReader _oCheckAODr = SYSConn<ODBCConnect>.Connect().GetSearch(_oCheckAOImei.ToString());
            if (!_oCheckAODr.Read())
            {
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AO','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ) "))
                {
                    _oCheckAODr.Close();
                    _oCheckAODr.Dispose();
                    return true;
                }
            }
            _oCheckAODr.Close();
            _oCheckAODr.Dispose();
            return false;
        }

        public bool InsertAwaitCase(int x_iOrder_id)
        {
            string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT IMEI FROM IMEI_STOCK WHERE ");
            _oQuery.Append(" Kit_Code='" + _oMobileRetentionOrder.GetSku() + "'  ");
            _oQuery.Append(" AND Model='" + _oMobileRetentionOrder.GetHs_model() + "'");
            _oQuery.Append(" AND Status='AWAIT' ");
            _oQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(x_iOrder_id) + "' ");
            _oQuery.Append(" AND ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' ");
            _oQuery.Append(" AND Create_By='" + _oMobileRetentionOrder.GetStaff_no() + "' ");
            _oQuery.Append(" AND StaffNo='" + _oMobileRetentionOrder.GetStaff_no() + "'");
            _oQuery.Append(" AND Dummy2='CC RET' ");
            _oQuery.Append(" AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "'  ");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (!_oDr.Read())
            {
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT into IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AWAIT','" + Func.IDAdd100000(x_iOrder_id) + "','" + _oMobileRetentionOrder.GetEdf_no() + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ) "))
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


        #region Release IMEI
        public static bool RWL_EDFIMEIRelease(string x_sOrder_id)
        {
            if (x_sOrder_id.Equals(string.Empty)) return false;
            string _sQuery9 = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET ";
            _sQuery9 += " edf_no='', ";
            _sQuery9 += " imei_no='' ";
            _sQuery9 += " where order_id='" + x_sOrder_id + "'";
            return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery9);
        }
        #endregion

        public bool CheckIMEISTOCK(int? x_iOrder_id)
        {
            try
            {
                if (x_iOrder_id == null) { return false; }
                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
                _oMobileRetentionOrder.SetOrder_id(x_iOrder_id);
                if (_oMobileRetentionOrder.Retrieve())
                {
                    if (!_oMobileRetentionOrder.GetSku().Equals(string.Empty))
                    {
                        string _sEDF = _oMobileRetentionOrder.GetEdf_no();
                        string _sIMEI = _oMobileRetentionOrder.GetImei_no();
                        int _iRecordID = (int)x_iOrder_id + 100000;
                        if (string.IsNullOrEmpty(_sIMEI)) { return false; }
                        StringBuilder _oQuery = new StringBuilder();
                        if (!string.IsNullOrEmpty(_sEDF))
                        {
                            _oQuery.Append("SELECT REFERENCENO,STOCK_OUT_D,DUMMY4 FROM IMEI_STOCK WHERE REFERENCENO='" + _sEDF + "' AND DUMMY2='CC RET' AND ROWNUM<=1 ");
                            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
                            if (_oDr.Read())
                            {
                                string _sSTOCK_OUT_D = Func.FR(_oDr["STOCK_OUT_D"]).Trim();
                                string _sDUMMY4 = Func.FR(_oDr["DUMMY4"]).Trim();
                                bool _bTrue = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE  IMEI_STOCK SET STOCK_OUT_D='" + _iRecordID.ToString() + "', DUMMY4='" + _iRecordID.ToString() + "'  WHERE REFERENCENO='" + _sEDF + "' AND DUMMY2='CC RET' AND ROWNUM<=1");
                                if (!_bTrue)
                                {
                                    _oDr.Close();
                                    _oDr.Dispose();
                                    return false;
                                }
                            }
                            _oDr.Close();
                            _oDr.Dispose();
                        }
                        else
                        {
                            _oQuery.Append("SELECT REFERENCENO,STOCK_OUT_D,DUMMY4 FROM IMEI_STOCK WHERE REFERENCENO='" + _iRecordID.ToString() + "' AND DUMMY2='CC RET' AND ROWNUM<=1 ");
                            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
                            if (_oDr.Read())
                            {
                                string _sSTOCK_OUT_D = Func.FR(_oDr["STOCK_OUT_D"]).Trim();
                                string _sDUMMY4 = Func.FR(_oDr["DUMMY4"]).Trim();
                                bool _bTrue = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE  IMEI_STOCK SET STOCK_OUT_D='" + _iRecordID.ToString() + "', DUMMY4='" + _iRecordID.ToString() + "'  WHERE REFERENCENO='" + _iRecordID.ToString() + "' AND DUMMY2='CC RET' AND ROWNUM<=1");
                                if (!_bTrue)
                                {
                                    _oDr.Close();
                                    _oDr.Dispose();
                                    return false;
                                }
                            }
                            _oDr.Close();
                            _oDr.Dispose();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {

            }
            return true;
        }

        public bool IMEIRelease(string x_sIMEI)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
            _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND status='SOLD' AND dummy2='CC RET' AND rownum<=1");

            bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            return _bReleaseIMEI;
        }

        public bool IMEIRelease(string x_sIMEI, string x_sKIT_CODE)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
            _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND kit_code='" + x_sKIT_CODE + "' AND status='SOLD' AND dummy2='CC RET' AND rownum<=1");

            bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            return _bReleaseIMEI;
        }

        public bool IMEIRelease(string x_sIMEI, string x_sKIT_CODE, string x_sStatus)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
            _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND kit_code='" + x_sKIT_CODE + "' AND status='" + x_sStatus + "' AND dummy2='CC RET' AND rownum<=1");

            bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            return _bReleaseIMEI;
        }

        public bool AllowUpdateWebLogEDFIMEI(string x_sEDF, string x_sIMEI)
        {
            return true;
        }

        public bool AllowUpdateEDFSystemEDFIMEI(string x_sEDF, string x_sIMEI)
        {
            return true;
        }

        public bool AllowAssignNormalIMEI(string x_sCurrentEDF, string x_sAssignIMEI, string x_sRecord_id)
        {
            return true;
        }

        public bool AllowAssignNormalIMEI(string x_sAssignIMEI)
        {
            return true;
        }

        public bool CheckDAONormalIMEI(string x_sAssignIMEI)
        {
            bool _bFlag1 = false;
            bool _bFlag2 = false;
            if (string.IsNullOrEmpty(x_sAssignIMEI)) return false;
            if (x_sAssignIMEI.Trim().ToUpper().Equals("AO") || x_sAssignIMEI.Trim().ToUpper().Equals("AWAIT")) return false;
            x_sAssignIMEI = x_sAssignIMEI.Trim();
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo ,agree_no FROM sunday_Form  WHERE imei='" + x_sAssignIMEI + "'  AND referenceNo is not null AND referenceNo<>' ' AND cancelled='N' AND created_by='CC RET' AND rownum<=1");
            if (_oDr.Read())
            {
                _bFlag1 = true;
            }
            _oDr.Close();
            _oDr.Dispose();


            OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei  FROM IMEI_STOCK  WHERE imei='" + x_sAssignIMEI + "'  AND STATUS='NORMAL' AND DUMMY2='CC RET' AND rownum<=1");
            if (_oDr2.Read())
            {
                _bFlag2 = true;
            }
            _oDr2.Close();
            _oDr2.Dispose();

            if (_bFlag1 && _bFlag2)
                return true;
            else
                return false;
        }

        public string GetOrderRemarkByIMEI(string x_sAssignIMEI)
        {
            string _sRemark = string.Empty;
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT remark ,dn_remark FROM sunday_Form  WHERE imei='" + x_sAssignIMEI + "'  AND referenceNo is not null AND referenceNo<>' ' AND cancelled='N' AND created_by='CC RET' AND rownum<=1");
            if (_oDr.Read())
            {
                _sRemark = Func.FR(_oDr["remark"]);
            }
            _oDr.Close();
            _oDr.Dispose();
            return _sRemark;
        }

        public string GetOrderDNRemarkByIMEI(string x_sAssignIMEI)
        {
            string _sDN_Remark = string.Empty;
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT remark ,dn_remark FROM sunday_Form  WHERE imei='" + x_sAssignIMEI + "'  AND referenceNo is not null AND referenceNo<>' ' AND cancelled='N' AND created_by='CC RET' AND rownum<=1");
            if (_oDr.Read())
            {
                _sDN_Remark = Func.FR(_oDr["dn_remark"]);
            }
            _oDr.Close();
            _oDr.Dispose();
            return _sDN_Remark;
        }

        public string GetStockRemarkByIMEI(string x_sAssignIMEI)
        {
            string _sRemark = string.Empty;
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT remark FROM IMEI_STOCK  WHERE imei='" + x_sAssignIMEI + "'  AND DUMMY2='CC RET' AND rownum<=1");
            if (_oDr.Read())
            {
                _sRemark = Func.FR(_oDr["remark"]);
            }
            _oDr.Close();
            _oDr.Dispose();
            return _sRemark;
        }

        public bool DeleteAOAWAITIMEI(string x_sRecordID)
        {
            string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
            return SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + _sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND DUMMY4='" + x_sRecordID.ToString() + "' AND Status in ('AO','AWAIT')");
        }

        public string GetIMEISku(string x_sAssignIMEI, string x_sStatus)
        {
            string _sSku = string.Empty;
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT kit_code FROM IMEI_STOCK  WHERE imei='" + x_sAssignIMEI + "'  AND DUMMY2='CC RET'  AND status='" + x_sStatus + "' AND rownum<=1");
            if (_oDr.Read())
            {
                _sSku = Func.FR(_oDr["kit_code"]);
            }
            _oDr.Close();
            _oDr.Dispose();
            return _sSku;
        }

        public bool AllowAssignNormalIMEI(string x_sAssignIMEI, string x_sRecord_id)
        {
            return true;
        }

        public bool HaveAOIMEI_STOCK(string x_sRecord_ID, string x_sSku)
        {
            bool _bFlag = false;
            if (string.IsNullOrEmpty(x_sRecord_ID)) return false;
            if (string.IsNullOrEmpty(x_sSku)) return false;
            x_sRecord_ID = x_sRecord_ID.Trim();
            x_sSku = x_sSku.Trim();
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei FROM IMEI_STOCK  WHERE DUMMY4='" + x_sRecord_ID + "' AND kit_code='" + x_sSku + "'  AND (status='AO' or status='AWAIT') AND rownum<=1");
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }

        public bool AllowInsertEDFIMEI(string x_sEDF, string x_sIMEI)
        {
            return true;
        }

        public bool IsDOAIMEI(string x_sIMEI, string x_sStatus, bool x_bUsed, bool x_bActive)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) { return false; }
            if (string.IsNullOrEmpty(x_sStatus)) { return false; }
            if (x_sIMEI.Equals(IMEISTATUS.AO) || x_sIMEI.Equals(IMEISTATUS.AWAIT)) { return false; }
            x_sIMEI = x_sIMEI.Trim();
            x_sStatus = x_sStatus.Trim();
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT TOP 1 imei_no FROM " + DOAProfileRecord.Para.TableName() + " WHERE active='" + ((x_bActive) ? "1" : "0") + "' AND status='" + x_sStatus.Trim() + "' AND imei_no='" + x_sIMEI.Trim() + "' AND used='" + ((x_bUsed) ? "1" : "0") + "' ");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                _oDr.Close();
                _oDr.Dispose();
                return true;
            }
            _oDr.Close();
            _oDr.Dispose();

            return false;
        }

        public bool UsedDOAIMEI(string x_sIMEI, int x_iOrder_id, string x_sStatus, bool x_bUsed, bool x_bSelectByOrderId)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) { return false; }
            if (string.IsNullOrEmpty(x_sStatus)) { return false; }

            if (x_sIMEI.Equals(IMEISTATUS.AO) || x_sIMEI.Equals(IMEISTATUS.AWAIT)) { return false; }
            x_sIMEI = x_sIMEI.Trim();
            x_sStatus = x_sStatus.Trim();
            bool _bFlag = false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT TOP 1 id FROM " + DOAProfileRecord.Para.TableName() + " WHERE active=1 AND imei_no='" + x_sIMEI + "' AND status='" + x_sStatus + "' " + ((x_bSelectByOrderId && x_iOrder_id > 0) ? " AND order_id='" + x_iOrder_id.ToString() + "' " : ""));
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                int _iId;
                if (int.TryParse(Func.FR(_oDr["id"]), out _iId))
                {
                    DOAProfileRecord _oDOAProfileRecord = new DOAProfileRecord(SYSConn<MSSQLConnect>.Connect());
                    _oDOAProfileRecord.SetId(_iId);
                    if (_oDOAProfileRecord.Retrieve())
                    {
                        _oDOAProfileRecord.SetUsed(x_bUsed);
                        _oDOAProfileRecord.SetEdate(DateTime.Now);
                        _oDOAProfileRecord.SetOrder_id(x_iOrder_id);
                        _bFlag = _oDOAProfileRecord.Save();
                    }
                }
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }


        public bool AllowUpdateEDFIMEI(string x_sEDF, string x_sIMEI, string x_sRecord_id)
        {
            return true;
        }

        public bool DeleteEDFRecord(string x_sEDF, string x_sAgree_no, string x_sAddFilter)
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE sunday_form SET referenceno='', created_by='', create_date='', staffname='',");
            _oQuery.Append("agree_no='', customer_name='', mobile_no='',imei='', ");
            _oQuery.Append(" e_delivery_date='', e_delivery_period='' WHERE referenceno='" + x_sEDF + "' and agree_no='" + x_sAgree_no + "'  " + x_sAddFilter + " and rownum<=1");
            return SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
        }

        public bool CheckClose()
        {
            MobileAutoProgramEntity[] _oMobileAutoProgramEntityArr = MobileAutoProgramBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), null, null, "id desc");
            if (_oMobileAutoProgramEntityArr != null)
            {
                if (_oMobileAutoProgramEntityArr.Length > 0)
                {
                    if (DateTime.Now.Hour == 3 || DateTime.Now.Hour == 4 ||
                                (_oMobileAutoProgramEntityArr[0].GetActive() == false))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void FindNoEdfNoAndInsert()
        {
            DateTime _oDateTime = DateTime.Now.AddMinutes(-10);
            DateTime _oPreDateTime = DateTime.Now.AddDays(-2);
            RWLFramework.DataBaseConfigSetting();
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT edf_no,order_id FROM MobileRetentionOrder WITH (NOLOCK) ");
            _oQuery.Append(" WHERE edf_no is not null AND edf_no<>'' AND ( (log_date is not null AND log_date>'" + _oPreDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "'  AND log_date<'" + _oDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "' ) OR (cdate is not null AND cdate>'" + _oPreDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "'  AND cdate<'" + _oDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "' ) OR (edate is not null  AND  edate>'" + _oPreDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "'  AND edate<'" + _oDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "' )) ");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr.Read())
            {
                if (CheckClose())
                    break;

                int _iOrder_id;
                if (int.TryParse(Func.FR(_oDr["order_id"]), out _iOrder_id))
                {
                    InsertEDF(_iOrder_id);
                }
            }
            _oDr.Close();
            _oDr.Dispose();
        }

        public void FindNoAONoEdfInsert()
        {
            FindNoAONoEdfInsert(-1, -2);
        }

        public void FindNoAONoEdfInsert(int _iDaySc, int _iPreDaySc)
        {
            DateTime _oDateTime = DateTime.Now.AddDays(_iDaySc);
            DateTime _oPreDateTime = DateTime.Now.AddDays(_iPreDaySc);
            RWLFramework.DataBaseConfigSetting();
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT order_id,edf_no,imei_no,hs_model,sku,cdate,d_date,active FROM MobileRetentionOrder WHERE ");
            _oQuery.Append("cdate>='" + _oPreDateTime.ToString("dd/MM/yyyy") + "' AND cdate<='" + _oDateTime.ToString("dd/MM/yyyy 23:59:59") + "' AND cdate is not null AND active=1 AND (sku is not null AND sku<>'') AND ");
            _oQuery.Append("hs_model<>'' AND hs_model is not null AND (imei_no='' AND imei_no is not null) AND (edf_no='' AND edf_no is not null) ");

            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr.Read())
            {
                int _iOrder_id;
                if (int.TryParse(Func.FR(_oDr["order_id"]), out _iOrder_id))
                {
                    string _sRecordId = Func.IDAdd100000(_iOrder_id);
                    MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
                    if (_oMobileRetentionOrder.GetFound() &&
                        !_oMobileRetentionOrder.GetSku().Trim().Equals(string.Empty) &&
                        !_oMobileRetentionOrder.GetHs_model().Trim().Equals(string.Empty) &&
                        _oMobileRetentionOrder.GetEdf_no().Trim().Equals(string.Empty) &&
                        _oMobileRetentionOrder.GetImei_no().Trim().Equals(string.Empty))
                    {
                        _oMobileRetentionOrder.SetImei_no("AO");
                        _oMobileRetentionOrder.Save();
                        string _sQuery1 = "SELECT DUMMY4 FROM IMEI_Stock WHERE Kit_Code='" + _oMobileRetentionOrder.GetSku().Trim() + "'  AND  DUMMY4='" + _sRecordId + "' AND (Status='STOCK' OR Status='AO' OR Status='AWAIT') AND Dummy2='CC RET' AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "'  ";
                        OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
                        if (!_oDr2.Read())
                        {
                            string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _oMobileRetentionOrder.GetSku().Trim() + "','" + _oMobileRetentionOrder.GetHs_model().Trim() + "','AO','" + _sRecordId + "','" + _sRecordId + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ) ";
                            bool _bInsertAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
                        }
                        _oDr2.Close();
                        _oDr2.Dispose();
                    }
                }
            }
            _oDr.Close();
            _oDr.Dispose();
        }


        protected void GetMobileRetentionOrderLeftJoinTableData(int x_iOrder_id, string x_sEdf_no)
        {
            _oRegisteredAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id, "REGISTERED_ADDRESS");
            _oBillingAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id, "BILLING_ADDRESS");
            _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
            _oMobileOrderThreeParty = new MobileOrderThreeParty();
            MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailArr = MobileOrderMNPDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + x_iOrder_id.ToString() + "'", null, null);
            if (_oMobileOrderMNPDetailArr != null)
            {
                if (_oMobileOrderMNPDetailArr.Length > 0)
                {
                    _oMobileOrderMNPDetail = (MobileOrderMNPDetail)_oMobileOrderMNPDetailArr[0];
                }
            }
            MobileOrderThreePartyEntity[] _oMobileOrderThreePartyArr = MobileOrderThreePartyRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + x_iOrder_id.ToString() + "'", null, null);
            if (_oMobileOrderThreePartyArr != null)
            {
                if (_oMobileOrderThreePartyArr.Length > 0)
                {
                    _oMobileOrderThreeParty = (MobileOrderThreeParty)_oMobileOrderThreePartyArr[0];
                }
            }

            _oMobileOrderVasArr = MobileOrderVasRepository.GetListObj(SYSConn<MSSQLConnect>.Connect(), -1, "order_id='" + x_iOrder_id.ToString() + "'", null, null);
            if (!string.IsNullOrEmpty(x_sEdf_no))
                _oSundayActivation.Load(x_sEdf_no);
        }


        public bool UpdateEDF(int x_iOrder_id)
        {
            return UpdateEDF(x_iOrder_id, string.Empty, string.Empty);
        }

        public bool UpdateEDF(int x_iOrder_id, string x_sUID, string x_sRequestIP)
        {
            return UpdateEDF(x_iOrder_id, x_sUID, x_sRequestIP, true);
        }
        public bool UpdateEDF(int x_iOrder_id, string x_sUID, string x_sRequestIP, bool x_bSetLeftJoinData)
        {
            bool bFlag = false;
            string _sRemarksEDF = string.Empty;
            string _sToday = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
            string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
            _oMobileRetentionOrder.SetOrder_id(x_iOrder_id);
            if (_oMobileRetentionOrder.Retrieve())
            {
                if (!_oMobileRetentionOrder.GetEdf_no().Trim().Equals(string.Empty))
                {
                    if (x_bSetLeftJoinData)
                        GetMobileRetentionOrderLeftJoinTableData((int)_oMobileRetentionOrder.GetOrder_id(), _oMobileRetentionOrder.GetEdf_no());

                    OdbcDataReader _oReader = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM sunday_form WHERE referenceNo ='" + _oMobileRetentionOrder.GetEdf_no() + "'");
                    if (_oReader.Read())
                    {
                        _sRemarksEDF = Func.FR(_oReader["remark"]).Trim();
                    }
                    _oReader.Close();
                    _oReader.Dispose();

                    string _sAmount = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAmount()))
                        _sAmount = "0";
                    else
                        _sAmount = _oMobileRetentionOrder.GetAmount();

                    string _sExtra_d_charge = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetExist_cust_plan()))
                        _sExtra_d_charge = "0";
                    else
                        _sExtra_d_charge = _oMobileRetentionOrder.GetExist_cust_plan();

                    string _sAccessory_price = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_price()))
                        _sAccessory_price = "0";
                    else
                        _sAccessory_price = _oMobileRetentionOrder.GetAccessory_price();

                    string _sFirst_month_fee = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetFirst_month_fee()))
                        _sFirst_month_fee = "0";
                    else
                        _sFirst_month_fee = _oMobileRetentionOrder.GetFirst_month_fee();

                    string _sFirst_month_license_fee = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetFirst_month_license_fee()))
                        _sFirst_month_license_fee = "0";
                    else
                        _sFirst_month_license_fee = _oMobileRetentionOrder.GetFirst_month_license_fee();


                    Double _dTotal = 0.0;
                    Double _dAmount2, _dAccessory_price, _dExtra_d_charge, _dFirst_month_fee, _dFirst_month_license_fee;
                    if (Double.TryParse(_sAmount, out _dAmount2))
                        _dTotal += _dAmount2;
                    if (Double.TryParse(_sAccessory_price, out _dAccessory_price))
                        _dTotal += _dAccessory_price;
                    if (Double.TryParse(_sExtra_d_charge, out _dExtra_d_charge))
                        _dTotal += _dExtra_d_charge;
                    if (Double.TryParse(_sFirst_month_fee, out _dFirst_month_fee))
                        _dTotal += _dFirst_month_fee;
                    if (Double.TryParse(_sFirst_month_license_fee, out  _dFirst_month_license_fee))
                        _dTotal += _dFirst_month_license_fee;

                    #region UpdateEDF SQL
                    StringBuilder _oQuery = new StringBuilder();
                    _oQuery.Append("UPDATE sunday_Form SET ");
                    _oQuery.Append("Applicat_date = to_date('" + ((_oMobileRetentionOrder.GetLog_date() != null) ? ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy") : string.Empty) + "','dd/mm/yyyy'),");

                    string _sGender = ((!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGender())) ? _oMobileRetentionOrder.GetGender() + " " : string.Empty);
                    _oQuery.Append("customer_name = '" + _sGender + _oMobileRetentionOrder.GetCustomerName().Trim().Replace("'", "`") + "',");
                    _oQuery.Append("staffNo = '" + _oMobileRetentionOrder.GetStaff_no().Trim() + "',");
                    _oQuery.Append("staffName = '" + _oMobileRetentionOrder.GetStaff_name().Trim().Replace("'", "`") + "',");
                    _oQuery.Append("SalesManCode = '" + _oMobileRetentionOrder.GetSalesmancode() + "',");
                    _oQuery.Append("Extn = '" + _oMobileRetentionOrder.GetExtn() + "',");
                    
                    if (_oMobileRetentionOrder.id_type == "BRNO")
                        _oQuery.Append("customer_ID_type ='BR',");
                    else
                        _oQuery.Append("customer_ID_type ='" + _oMobileRetentionOrder.GetId_type() + "',");
                    if (_oMobileRetentionOrder.id_type == "HKID")
                        _oQuery.Append("customer_id='" + Func.Left(_oMobileRetentionOrder.GetHkid(), _oMobileRetentionOrder.GetHkid().Length - 1) + "(" + Func.Right(_oMobileRetentionOrder.GetHkid(), 1) + ")',");
                    else
                        _oQuery.Append("customer_id='" + _oMobileRetentionOrder.GetHkid() + "',");

                    _oQuery.Append("Mobile_no='" + _oMobileRetentionOrder.GetMrt_no() + "',");
                    _oQuery.Append("Contact_no='" + _oMobileRetentionOrder.GetContact_no() + "',");
                    

                    _oQuery.Append("Order_Amt='" + ((_dTotal == 0.0) ? string.Empty : _dTotal.ToString()) + "',");
                    _oQuery.Append("Delivery_charge='" + _oMobileRetentionOrder.GetExtra_d_charge() + "',");
                    _oQuery.Append("E_delivery_date='" + ((_oMobileRetentionOrder.GetD_date() != null) ? ((DateTime)_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy") : string.Empty) + "',");
                    _oQuery.Append("E_Delivery_period='" + _oMobileRetentionOrder.d_time + "',");
                    _oQuery.Append("Dummy2='" + _oMobileRetentionOrder.GetD_address().Trim().Replace("'", "`").ToUpper() + "',");

                    if (_oMobileRetentionOrder.vip_case != "")
                        _oQuery.Append("Dummy3='" + _oMobileRetentionOrder.GetVip_case().Trim().Replace("'", "`") + "',");
                    else
                        _oQuery.Append("Dummy3='',");
                    _oQuery.Append("ItemCode='" + _oMobileRetentionOrder.GetSku() + "',");
                    _oQuery.Append("ItemDesc = '" + ((_oMobileRetentionOrder.GetHs_model().Length >= 50) ? Func.Left(_oMobileRetentionOrder.GetHs_model(), 50) : _oMobileRetentionOrder.GetHs_model()) + "',");
                    _oQuery.Append("program = '" + _oMobileRetentionOrder.GetProgram() + "',");
                    //_oQuery.Append("PP_CUSTOMER_NAME  = '" + _oMobileRetentionOrder.GetRate_plan().Trim().Substring(0, ((_oMobileRetentionOrder.GetRate_plan().Length >= 20) ? 20 : _oMobileRetentionOrder.GetRate_plan().Length)) + "',");
                    _oQuery.Append("PP_CUSTOMER_NAME  = '" + _oMobileRetentionOrder.GetRate_plan() + "',");
                    _oQuery.Append("contract_period = '" + _oMobileRetentionOrder.GetCon_per() + " MTH',");
                    _oQuery.Append("Plan_code = '" + _oMobileRetentionOrder.GetAccessory_code() + "',");
                    _oQuery.Append("FG_Code = '" + _oMobileRetentionOrder.GetAccessory_desc() + "',");
                    _oQuery.Append("FG_IMEI0 = '" + _oMobileRetentionOrder.GetAccessory_imei() + "',");
                    _oQuery.Append("FreeGift1 = '" + _oMobileRetentionOrder.GetGift_code() + "',");
                    _oQuery.Append("FG_Desc1 = '" + _oMobileRetentionOrder.GetGift_desc() + "',");
                    _oQuery.Append("FG_IMEI1 = '" + _oMobileRetentionOrder.GetGift_imei() + "',");
                    _oQuery.Append("FreeGift2 = '" + _oMobileRetentionOrder.GetGift_code2() + "',");
                    _oQuery.Append("FG_Desc2 = '" + _oMobileRetentionOrder.GetGift_desc2() + "',");
                    _oQuery.Append("FG_IMEI2 = '" + _oMobileRetentionOrder.GetGift_imei2() + "',");
                    _oQuery.Append("FreeGift3 = '" + _oMobileRetentionOrder.GetGift_code3() + "',");
                    _oQuery.Append("FG_Desc3 = '" + _oMobileRetentionOrder.GetGift_desc3() + "',");
                    _oQuery.Append("FG_IMEI3 = '" + _oMobileRetentionOrder.GetGift_imei3() + "',");
                    _oQuery.Append("FreeGift4 = '" + _oMobileRetentionOrder.GetGift_code4() + "',");
                    _oQuery.Append("FG_Desc4 = '" + _oMobileRetentionOrder.GetGift_desc4() + "',");
                    _oQuery.Append("FG_IMEI4 = '" + _oMobileRetentionOrder.GetGift_imei4() + "',");
                    _oQuery.Append("CASH_AMT = '" + _oMobileRetentionOrder.GetAccessory_price() + "',");


                    if (!_oMobileRetentionOrder.GetImei_no().Trim().ToUpper().Equals("AWAIT") &&
                        !_oMobileRetentionOrder.GetImei_no().Trim().ToUpper().Equals("AO"))
                        _oQuery.Append("IMEI = '" + _oMobileRetentionOrder.GetImei_no() + "',");
                    else
                        _oQuery.Append("IMEI = '',");

                    _oQuery.Append("TRADE = '" + _oMobileRetentionOrder.GetTrade_field() + "',");
                    _oQuery.Append("REBATE = '" + _oMobileRetentionOrder.GetRebate_amount() + "',");

                    if (_oMobileRetentionOrder.pay_method == "" || string.IsNullOrEmpty(_oMobileRetentionOrder.GetPay_method()))
                        _oQuery.Append("HS_payment_type = '',");
                    else if (_oMobileRetentionOrder.pay_method == "CREDIT CARD")
                        _oQuery.Append("HS_payment_type = 'CREDIT CARD FULL PAY',");
                    else if (_oMobileRetentionOrder.pay_method == "CREDIT CARD INSTALLMENT")
                        _oQuery.Append("HS_payment_type = '" + _oMobileRetentionOrder.GetBank_code() + "',");
                    else
                        _oQuery.Append("HS_payment_type = 'COD',");

                    _oQuery.Append("HS_CARD_NO='" + _oMobileRetentionOrder.GetCard_no() + "',");


                    if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_holder()))
                        _oQuery.Append("HS_C_HOLDER_NAME='" + _oMobileRetentionOrder.GetCard_holder().Trim().Replace("'", "`") + "',");
                    else
                        _oQuery.Append("HS_C_HOLDER_NAME='',");

                    if (_oMobileRetentionOrder.GetCard_exp_month() != "" && !string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_exp_month()) && _oMobileRetentionOrder.GetCard_exp_year() != "" && !string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_exp_year()))
                    {
                        _oQuery.Append("HS_EXPIRYDATE='" + _oMobileRetentionOrder.GetCard_exp_month() + Func.Right(_oMobileRetentionOrder.GetCard_exp_year(), 2) + "',");
                    }
                    else
                    {
                        _oQuery.Append("HS_EXPIRYDATE='',");
                    }


                    if (_oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") != "" && _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") != "sub")
                    {
                        if (_sRemarksEDF.Trim().ToUpper() !=
                            (_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`")))
                        {
                            _oQuery.Append("Remark=Remark || ' " + _oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "',");
                        }
                    }
                    else
                    {
                        _oQuery.Append("Remark=Remark || ' " + _oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + "',");
                    }

                    //_oQuery.Append("Remark='" + _oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + "',");

                    _oQuery.Append("HS_PAY_AMT='" + _oMobileRetentionOrder.GetAmount() + "',");

                    if (_oMobileRetentionOrder.GetPremium() != "")
                        _oQuery.Append("Premium_Gift='" + _oMobileRetentionOrder.GetPremium() + "',");
                    else
                        _oQuery.Append("Premium_Gift='N/A',");

                    if (_oMobileRetentionOrder.GetExt_place_tel() != "")
                        _oQuery.Append("Contact_No_R='" + _oMobileRetentionOrder.GetExt_place_tel() + "',");
                    else
                        _oQuery.Append("Contact_No_R='N/A',");

                    if (_oMobileRetentionOrder.GetCon_eff_date() != null)
                        _oQuery.Append("COMPANY_NAME='" + ((DateTime)_oMobileRetentionOrder.GetCon_eff_date()).ToString("MM/dd/yyyy") + "',");
                    else
                        _oQuery.Append("COMPANY_NAME='',");

                    _oQuery.Append("VAS='" + _oMobileRetentionOrder.GetBundle_name() + "',");
                    _oQuery.Append("SIM_CARD_TYPE='" + _oMobileRetentionOrder.GetSim_item_name() + "',");
                    _oQuery.Append("SIM_ITEM_CODE='" + _oMobileRetentionOrder.GetSim_item_code() + "',");

                    _oQuery.Append("VAS10='" + _oMobileRetentionOrder.GetDelivery_exchange() + "',");
                    _oQuery.Append("MRT_Serial='" + _oMobileRetentionOrder.GetDelivery_collection_type() + "',");
                    _oQuery.Append("Stock_Serial='" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "',");
                    _oQuery.Append("VAS9='" + _oMobileRetentionOrder.GetDelivery_exchange_option() + "',");

                    _oQuery.Append("User_Name='" + _oMobileRetentionOrder.GetContact_person().Trim().Replace("'", "`") + "',");
                    _oQuery.Append("ament_counter = ament_counter + 1 ,");

                    string _sServiceActivationDate2 =
                        ((_oMobileOrderMNPDetail.GetService_activation_date() != null) ?
                        ((DateTime)_oMobileOrderMNPDetail.GetService_activation_date()).ToString("dd/MM/yyyy") :
                        string.Empty);
                    _oQuery.Append("Activa_Date=to_date('" + _sServiceActivationDate2 + "', 'dd/mm/yyyy') ,");

                    string _sBIRTH_DATE2 =
                        ((_oMobileRetentionOrder.GetDate_of_birth() != null) ?
                        ((DateTime)_oMobileRetentionOrder.GetDate_of_birth()).ToString("dd/MM/yyyy") :
                        string.Empty);
                    _oQuery.Append("BIRTH_DATE='" + _sBIRTH_DATE2 + "',");

                    string _slicense_waiver = FindVasValue1("license_waiver").Trim().ToUpper();
                    _oQuery.Append("Order_Confirm='" + _slicense_waiver + "',");

                    string _sTransferTo3G = ((_oMobileOrderMNPDetail.GetTransfer_to_3g() == true) ? "YES" : "NO");
                    _oQuery.Append("FG_COST5='" + _sTransferTo3G + "',");

                    string _sTransfer_idd_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_idd_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_idd_deposit()).ToString() : string.Empty);

                    _oQuery.Append("FG_COST0='" + _sTransfer_idd_deposit + "',");

                    string _sTransfer_idd_roaming_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit()).ToString() : string.Empty);

                    _oQuery.Append("FG_COST1='" + _sTransfer_idd_roaming_deposit + "',");

                    string _sTransfer_no_hk_id_holder_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit()).ToString() : string.Empty);

                    _oQuery.Append("FG_COST2='" + _sTransfer_no_hk_id_holder_deposit + "',");

                    string _sTransfer_no_add_proof_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit()).ToString() : string.Empty);

                    _oQuery.Append("FG_COST3='" + _sTransfer_no_add_proof_deposit + "',");

                    string _sTransfer_others_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_others_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_others_deposit()).ToString() : string.Empty);

                    _oQuery.Append("FG_COST4='" + _sTransfer_others_deposit + "',");
                    _oQuery.Append("VAS1='" + FindVasValue1("idd_normal_vas") + "',");
                    _oQuery.Append("VAS2='" + FindVasValue1("idd0060_vas") + "',");
                    _oQuery.Append("VAS3='" + FindVasValue1("roaming_vas") + "',");
                    _oQuery.Append("VAS4='" + FindVasValue1("net_vas") + "',");
                    _oQuery.Append("VAS5='" + FindVasValue1("sms_vas") + "',");
                    _oQuery.Append("SS_LANGUAGE='" + _oMobileRetentionOrder.GetLanguage() + "',");
                    _oQuery.Append("PREMIUM_GIFT2='" + _oMobileRetentionOrder.GetAction_of_rate_plan_effective() + "',");
                    if (_oMobileRetentionOrder.GetBill_cut_date() != null)
                        _oQuery.Append("DOA_DATE=to_date('" + ((DateTime)_oMobileRetentionOrder.GetBill_cut_date()).ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy') ,");
                    else
                        _oQuery.Append("DOA_DATE='' ,");

                    if (_oMobileRetentionOrder.GetPlan_eff_date() != null)
                        _oQuery.Append("PAYMENT_I_DATE=to_date('" + ((DateTime)_oMobileRetentionOrder.GetPlan_eff_date()).ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy') ,");
                    else
                        _oQuery.Append("PAYMENT_I_DATE='' ,");

                    _oQuery.Append("Inter_SMS='" + FindVasValue1("upg_act_super") + "',");

                    _oQuery.Append("C_Tone_Service='" + FindVasValue1("upg_1c2n_vas")+ "',");

                    _oQuery.Append("Mobile_MSN='" + FindVasValue1("upg_msn_vas") + "',");

                    _oQuery.Append("EZ_SMS_Pack='" + FindVasValue1("upg_prem3_vas") + "',");

                    _oQuery.Append("GPRS_Mob_Data='" + FindVasValue1("upg_prem4_vas") + "',");

                    _oQuery.Append("Mob_Online_Betting='" + FindVasValue1("min_vas200") + "',");

                    _oQuery.Append("Mob_ESPN_S_Package='" + FindVasValue1("min_vas450") + "', ");

                    _oQuery.Append("last_update='" + _sToday + " " + x_sUID + "' WHERE referenceNo ='" + _oMobileRetentionOrder.GetEdf_no().Trim() + "'");

                    bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                    if (bFlag)
                    {
                        bool _bSFlag = false;
                        _oSundayActivation = SetSundayActivation(_oMobileRetentionOrder);
                        if (_oSundayActivation.IsFound())
                            _bSFlag = _oSundayActivation.Save();
                        else
                            _bSFlag = _oSundayActivation.CreateRecord();

                    }
                    WebFunc.SaveQuery(_oQuery.ToString());
                    _oQuery = new StringBuilder();
                    _oQuery.Append("UPDATE IMEI_Stock SET ReferenceNo='" + _oMobileRetentionOrder.edf_no + "', Mobile_no='" + _oMobileRetentionOrder.mrt_no + "'  WHERE  Dummy2='CC RET' && DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()).Trim() + "' AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "'  ");
                    WebFunc.SaveQuery(_oQuery.ToString());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                    WebFunc.SaveQuery(_oQuery.ToString());
                    if (string.IsNullOrEmpty(x_sRequestIP))
                    {
                        _oQuery = new StringBuilder();
                        _oQuery.Append("INSERT INTO DebugProfile  (edf,imei,page,cid,cdate,mobile,ip) VALUES ('" + _oMobileRetentionOrder.edf_no.Trim() + "', '" + _oMobileRetentionOrder.imei_no.Trim() + "','ModEDF','" + x_sUID + "',getdate(),'" + _oMobileRetentionOrder.mrt_no + "','" + x_sRequestIP + "')");
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                    }

                    if (_oMobileRetentionOrder.GetMrt_no() != null)
                        MobileGList.UpdateMobileGType(_oMobileRetentionOrder.GetEdf_no(), ((int)_oMobileRetentionOrder.GetMrt_no()).ToString());

                    #endregion
                }
                else
                {
                    throw new BusinessObjectNotFoundException("ERROR : [RWL ORDERID (" + x_iOrder_id.ToString() + ")] MODIFY EDF RECORD CANNOT MISSING THE REFRERENCE NUMBER!");
                }
            }
            return bFlag;
        }

        protected string GetEDFIssueType(string x_sIssue_type)
        {
            string _sResult = string.Empty;
            switch (x_sIssue_type)
            {
                case "3G_RETENTION":
                    _sResult = "RET";
                    break;
                case "MOBILE_LITE":
                case "OLD_MOBILE_LITE":
                    _sResult = "3GL";
                    break;
                case "UPGRADE":
                    _sResult = "UPG";
                    break;
                case "2G_RETENTION":
                    _sResult = "2GR";
                    break;
                case "WIN":
                    _sResult = "WIN";
                    break;
            }


            return _sResult;
        }

        protected string FindVasValue1(string x_sVas_Field)
        {
            if (_oMobileOrderVasArr != null)
            {
                for (int i = 0; i < _oMobileOrderVasArr.Count; i++)
                {
                    if (_oMobileOrderVasArr[i].vas_field.ToUpper().Trim().Equals(x_sVas_Field.ToUpper().Trim()))
                        return _oMobileOrderVasArr[i].vas_value;
                }
            }
            return string.Empty;
        }

        public bool InsertEDF(int x_iOrder_id)
        {
            return InsertEDF(x_iOrder_id, -1);
        }

        public bool InsertEDF(int x_iOrder_id, int x_iRetryInsertNum)
        {
            bool bFlag = false;
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
            _oMobileRetentionOrder.SetOrder_id(x_iOrder_id);
            if (_oMobileRetentionOrder.Retrieve())
            {
                string _sQuery = string.Empty;
                bFlag = InsertEDF(_oMobileRetentionOrder, ref _sQuery);
                while (x_iRetryInsertNum > 0 && bFlag == false)
                {
                    Thread.Sleep(2000);
                    bFlag = InsertEDF(_oMobileRetentionOrder, ref _sQuery);
                    if (bFlag == true)
                    {

                        break;
                    }
                    x_iRetryInsertNum -= 1;
                }

                if (bFlag == false)
                    throw new BusinessObjectNotFoundException("MIGRATE RECORD ID:" + (x_iOrder_id + 100000).ToString() + " TO EDF ERROR!  <BR>  SQL : " + _sQuery.ToString());
            }
            return bFlag;
        }

        public SundayActivation SetSundayActivation(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            _oSundayActivation.SetREFERENCENO(x_oMobileRetentionOrder.GetEdf_no());

            if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetChange_payment_type()))
            {
                if (x_oMobileRetentionOrder.GetChange_payment_type().Length >= 15)
                    _oSundayActivation.SetMP_CARD_OWNER(x_oMobileRetentionOrder.GetChange_payment_type().Substring(0, 15));
                else
                    _oSundayActivation.SetMP_CARD_OWNER(x_oMobileRetentionOrder.GetChange_payment_type());
            }
            _oSundayActivation.SetMP_3_PARTY_NAME(x_oMobileRetentionOrder.GetM_card_type());


            _oSundayActivation.SetREGION_CITY(x_oMobileRetentionOrder.GetRebate());
            string _sBank_code = x_oMobileRetentionOrder.GetMonthly_bank_account_bank_code() + " " +
                            x_oMobileRetentionOrder.GetMonthly_bank_account_branch_code() + " " +
                            x_oMobileRetentionOrder.GetMonthly_bank_account_no();

            if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetM_card_no()))
                _oSundayActivation.SetMP_CARDNO(x_oMobileRetentionOrder.GetM_card_no());
            else if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetMonthly_bank_account_bank_code().Trim()) &&
                !string.IsNullOrEmpty(x_oMobileRetentionOrder.GetMonthly_bank_account_branch_code().Trim()) &&
                !string.IsNullOrEmpty(x_oMobileRetentionOrder.GetMonthly_bank_account_no().Trim()))
            {
                _oSundayActivation.SetMP_CARDNO(_sBank_code);
            }
            else
                _oSundayActivation.SetMP_CARDNO(x_oMobileRetentionOrder.GetM_card_no().Trim());

            string _sHolder_name = string.Empty;
            if (x_oMobileRetentionOrder.GetMonthly_payment_type().ToUpper().Equals("CHANGE TO CREDIT CARD"))
                _sHolder_name = x_oMobileRetentionOrder.GetM_card_holder2();
            else if (x_oMobileRetentionOrder.GetMonthly_payment_type().ToUpper().Equals("CHANGE TO BANK ACCOUNT"))
                _sHolder_name = x_oMobileRetentionOrder.GetMonthly_bank_account_holder();

            _oSundayActivation.SetMP_C_HOLDER_NAME(_sHolder_name);

            if (x_oMobileRetentionOrder.GetMonthly_payment_type().ToUpper().Equals("CHANGE TO CREDIT CARD"))
                _oSundayActivation.SetAGREEMENT_NO(x_oMobileRetentionOrder.GetM_3rd_id_type());
            else if (x_oMobileRetentionOrder.GetMonthly_payment_type().ToUpper().Equals("CHANGE TO BANK ACCOUNT"))
                _oSundayActivation.SetAGREEMENT_NO(x_oMobileRetentionOrder.GetMonthly_bank_account_id_type());

            
            _oSundayActivation.SetMP_3_PARTY_ID(x_oMobileRetentionOrder.GetMonthly_bank_account_hkid() + x_oMobileRetentionOrder.GetMonthly_bank_account_hkid2());

            string _sM_card_exp_year = string.Empty;
            if (x_oMobileRetentionOrder.GetM_card_exp_year().Length >= 4)
                _sM_card_exp_year = x_oMobileRetentionOrder.GetM_card_exp_year().Substring(2, 2);

            _oSundayActivation.SetMP_EXPIRYDATE(x_oMobileRetentionOrder.GetM_card_exp_month() + _sM_card_exp_year);
            if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetBill_medium()))
            {
                if (x_oMobileRetentionOrder.GetBill_medium().Equals("0"))
                    _oSundayActivation.SetCUSTOMER_GROUP("SMS bill $0");
                else if (x_oMobileRetentionOrder.GetBill_medium().Equals("1"))
                    _oSundayActivation.SetCUSTOMER_GROUP("Email bill $0");
                else if (x_oMobileRetentionOrder.GetBill_medium().Equals("2"))
                    _oSundayActivation.SetCUSTOMER_GROUP("Paper bill $10");
                else if (x_oMobileRetentionOrder.GetBill_medium().Equals("3"))
                    _oSundayActivation.SetCUSTOMER_GROUP("SMS bill $0 + Email bill $0");
            }
            _oSundayActivation.SetSMS_SUPPRESS(x_oMobileRetentionOrder.GetSms_mrt());
            _oSundayActivation.SetEMAIL(x_oMobileRetentionOrder.GetBill_medium_email());

            string _sBilling_Address = MobileOrderAddressBal.GetAddress(_oBillingAddress).Trim().ToUpper();
            _oSundayActivation.SetBILL_ADDRESS_1(_sBilling_Address.Trim().ToUpper().Replace("'", "`").Replace("``", "`"));

            string _sBill_medium_waive = ((x_oMobileRetentionOrder.GetBill_medium_waive() == true) ? "1" : "0");
            _oSundayActivation.SetEMAIL_BILL(_sBill_medium_waive);
            string _sPrepayment = ((x_oMobileRetentionOrder.GetPrepayment_waive() == true) ? "1" : "0");
            _oSundayActivation.SetPAYMENT_TYPE(_sPrepayment);
            string _sExtra_rebate = x_oMobileRetentionOrder.GetExtra_rebate();
            _oSundayActivation.SetSTUDENT_BIRTH_D(_sExtra_rebate);

            _oSundayActivation.SetBILL_CU_NAME(_oMobileOrderMNPDetail.GetCompany_name());
            _oSundayActivation.SetN2_REGISTERED_NAME(_oMobileOrderMNPDetail.GetRegistered_name());
            _oSundayActivation.SetTICKET_NO(_oMobileOrderMNPDetail.GetTicker_number());
            _oSundayActivation.SetAGREEMENT_DATE(_oMobileOrderMNPDetail.GetService_activation_time());


            string _sRegisteredAddress = MobileOrderAddressBal.GetAddress(_oRegisteredAddress).Trim().ToUpper();

            _oSundayActivation.SetADDRESS_1(_sRegisteredAddress.Trim().ToUpper().Replace("'", "`").Replace("``", "`"));
            _oSundayActivation.SetID_NO_TYPE(_oMobileOrderMNPDetail.GetId_type());
            _oSundayActivation.SetID_NO(_oMobileOrderMNPDetail.GetHkid());
            _oSundayActivation.SetBILL_ADDRESS_3(x_oMobileRetentionOrder.GetUpgrade_handset_offer_rebate_schedule());

            _oSundayActivation.SetBANK_ACCOUNT(x_oMobileRetentionOrder.GetUpgrade_existing_customer_type());
            _oSundayActivation.SetCREATE_DATE(x_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate());
            _oSundayActivation.SetSMARK_EXP_DATE(x_oMobileRetentionOrder.GetUpgrade_existing_contract_edate());
            _oSundayActivation.SetPREPAID_SIM_TO_POSTPAID(x_oMobileRetentionOrder.GetUpgrade_existing_pccw_customer());
            _oSundayActivation.SetOLD_SUB_HK_ID(x_oMobileRetentionOrder.GetUpgrade_service_account_no());
            _oSundayActivation.SetJOINT_PROMOTION_CODE(x_oMobileRetentionOrder.GetUpgrade_service_tenure());

            _oSundayActivation.SetHANDSET_DESC(x_oMobileRetentionOrder.GetExisting_smart_phone_model());
            _oSundayActivation.SetIMEI(x_oMobileRetentionOrder.GetExisting_smart_phone_imei());
            _oSundayActivation.SetDNO(x_oMobileRetentionOrder.GetAction_of_rate_plan_effective());
            if (x_oMobileRetentionOrder.GetBill_cut_num() != null)
                _oSundayActivation.SetFAX(x_oMobileRetentionOrder.GetBill_cut_num().ToString());

            _oSundayActivation.SetVAS_NAME15(x_oMobileRetentionOrder.GetMonthly_payment_type());
            _oSundayActivation.SetCONTACT_PERSON(FindVasValue1("upg_auto_vas"));
            _oSundayActivation.SetOWNER_NAME(FindVasValue1("upg_con_vas"));
            _oSundayActivation.SetBANK_NAME(FindVasValue1("upg_cou1_vas"));
            _oSundayActivation.SetOLD_SUB_NAME_MNP(FindVasValue1("upg_data_vas"));
            _oSundayActivation.SetREG_BUILDING(FindVasValue1("upg_fin_vas"));
            _oSundayActivation.SetREG_ESTATE(FindVasValue1("upg_gprs_vas"));
            _oSundayActivation.SetREG_ST_NAME(FindVasValue1("upg_idd_vas"));
            _oSundayActivation.SetREG_DISTRICT(FindVasValue1("upg_lice_vas"));
            _oSundayActivation.SetBIL_BUILDING(FindVasValue1("upg_min_vas"));
            _oSundayActivation.SetBIL_ESTATE(FindVasValue1("upg_moov_vas"));
            _oSundayActivation.SetBIL_ST_NAME(FindVasValue1("upg_net_vas"));
            _oSundayActivation.SetBIL_DISTRICT(FindVasValue1("upg_now_vas"));
            _oSundayActivation.SetVAS_NAME1(FindVasValue1("upg_oth1_vas"));
            _oSundayActivation.SetVAS_NAME2(FindVasValue1("upg_oth2_vas"));
            _oSundayActivation.SetVAS_NAME3(FindVasValue1("upg_oth3_vas"));
            _oSundayActivation.SetVAS_NAME4(FindVasValue1("upg_oth4_vas"));
            _oSundayActivation.SetVAS_NAME5(FindVasValue1("upg_oth5_vas"));
            _oSundayActivation.SetVAS_NAME6(FindVasValue1("upg_oth6_vas"));
            _oSundayActivation.SetVAS_NAME7(FindVasValue1("upg_sec_vas"));
            _oSundayActivation.SetVAS_NAME8(FindVasValue1("upg_sms1_vas"));
            _oSundayActivation.SetVAS_NAME9(FindVasValue1("upg_sms2_vas"));
            _oSundayActivation.SetVAS_NAME10(FindVasValue1("upg_sms3_vas"));
            _oSundayActivation.SetVAS_NAME11(FindVasValue1("upg_smsb_vas"));
            _oSundayActivation.SetVAS_NAME12(FindVasValue1("upg_spo_vas"));
            _oSundayActivation.SetVAS_NAME13(FindVasValue1("upg_sup_vas"));
            _oSundayActivation.SetVAS_NAME14(FindVasValue1("upg_wifi_vas"));
            _oSundayActivation.SetFAMILY_REFERRAL_DN(x_oMobileRetentionOrder.GetCard_ref_no());
            _oSundayActivation.SetVAS_NAME16(x_oMobileRetentionOrder.GetS_premium1());
            _oSundayActivation.SetVAS_NAME17(x_oMobileRetentionOrder.GetS_premium2());
            _oSundayActivation.SetVAS_NAME19(FindVasValue1("upg_cou2_vas"));
            _oSundayActivation.SetVAS_NAME20(FindVasValue1("upg_prem1_vas"));
            _oSundayActivation.SetDUMMY1(FindVasValue1("upg_prem2_vas"));
            _oSundayActivation.SetVAS_PRICE4(x_oMobileRetentionOrder.GetM_3rd_hkid() + x_oMobileRetentionOrder.GetM_3rd_hkid2());

            _oSundayActivation.SetOFFICE_TEL(x_oMobileRetentionOrder.GetUpgrade_registered_mobile_no());
            

            return _oSundayActivation;
        }

        public bool InsertSundaySundayActivation(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            MobileRetentionOrder _oMobileRetentionOrder = x_oMobileRetentionOrder;
            if (string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no())) return false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT REFERENCENO FROM Sunday_Activation WHERE REFERENCENO='" + x_oMobileRetentionOrder.GetEdf_no() + "' AND ROWNUM<=1");
            bool _bFlag = false;
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (!_oDr.Read())
            {
                _oSundayActivation = SetSundayActivation(x_oMobileRetentionOrder);
                _bFlag = _oSundayActivation.CreateRecord();
            }
            _oDr.Close();
            _oDr.Dispose();

            return _bFlag;
        }

        public bool InsertEDF(MobileRetentionOrder x_oMobileRetentionOrder, int x_iRetryInsertNum)
        {
            bool bFlag = false;
            if (x_oMobileRetentionOrder.Retrieve())
            {
                string _sQuery = string.Empty;
                bFlag = InsertEDF(x_oMobileRetentionOrder, ref _sQuery);
                while (x_iRetryInsertNum > 0 && bFlag == false)
                {
                    Thread.Sleep(2000);
                    bFlag = InsertEDF(x_oMobileRetentionOrder, ref _sQuery);
                    if (bFlag == true) { break; }
                    x_iRetryInsertNum -= 1;
                }
                if (bFlag == false)
                    throw new BusinessObjectNotFoundException("MIGRATE RECORD ID:" + ((int)x_oMobileRetentionOrder.GetOrder_id() + 100000).ToString() + " TO EDF ERROR!  <BR>  SQL : " + _sQuery.ToString());
            }
            return bFlag;
        }

        public bool InsertEDF(MobileRetentionOrder x_oMobileRetentionOrder, ref string x_sQuery)
        {
            bool bFlag = false;
            string _sRemarksEDF = string.Empty;
            string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
            string _sTime1 = DateTime.Now.ToString("HH:mm:ss");
            MobileRetentionOrder _oMobileRetentionOrder = x_oMobileRetentionOrder;
            if (_oMobileRetentionOrder.Retrieve())
            {
                #region have STOCK
                string _sRecordID = Func.IDAdd100000(x_oMobileRetentionOrder.GetOrder_id()).Trim();
                if (!"".Equals(_oMobileRetentionOrder.GetEdf_no())
                    && _oMobileRetentionOrder.GetActive() == true
                    && !string.IsNullOrEmpty(_sRecordID))
                {
                    if (_oMobileRetentionOrder.GetLog_date() != null)
                        _sToday = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm:ss");

                    if (AllowInsertEDFIMEI(_oMobileRetentionOrder.GetEdf_no(), _oMobileRetentionOrder.GetImei_no()) && AllowAssignNormalIMEI(_oMobileRetentionOrder.GetEdf_no(), _oMobileRetentionOrder.GetImei_no(), Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id())))
                    {
                        OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo FROM sunday_Form WHERE referenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' AND CREATED_BY='CC RET' and Agree_no='" + _sRecordID + "' ");
                        if (!_oDr3.Read())
                        {
                            string _sAmount = string.Empty;
                            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAmount()))
                                _sAmount = "0";
                            else
                                _sAmount = _oMobileRetentionOrder.GetAmount();

                            string _sExtra_d_charge = string.Empty;
                            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetExist_cust_plan()))
                                _sExtra_d_charge = "0";
                            else
                                _sExtra_d_charge = _oMobileRetentionOrder.GetExist_cust_plan();

                            string _sAccessory_price = string.Empty;
                            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_price()))
                                _sAccessory_price = "0";
                            else
                                _sAccessory_price = _oMobileRetentionOrder.GetAccessory_price();

                            string _sFirst_month_fee = string.Empty;
                            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetFirst_month_fee()))
                                _sFirst_month_fee = "0";
                            else
                                _sFirst_month_fee = _oMobileRetentionOrder.GetFirst_month_fee();

                            string _sFirst_month_license_fee = string.Empty;
                            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetFirst_month_license_fee()))
                                _sFirst_month_license_fee = "0";
                            else
                                _sFirst_month_license_fee = _oMobileRetentionOrder.GetFirst_month_license_fee();


                            Double _dTotal = 0.0;
                            Double _dAmount2, _dAccessory_price, _dExtra_d_charge, _dFirst_month_fee, _dFirst_month_license_fee;
                            if (Double.TryParse(_sAmount, out _dAmount2))
                                _dTotal += _dAmount2;
                            if (Double.TryParse(_sAccessory_price, out _dAccessory_price))
                                _dTotal += _dAccessory_price;
                            if (Double.TryParse(_sExtra_d_charge, out _dExtra_d_charge))
                                _dTotal += _dExtra_d_charge;
                            if (Double.TryParse(_sFirst_month_fee, out _dFirst_month_fee))
                                _dTotal += _dFirst_month_fee;
                            if (Double.TryParse(_sFirst_month_license_fee, out  _dFirst_month_license_fee))
                                _dTotal += _dFirst_month_license_fee;


                            StringBuilder _oQuery = new StringBuilder();
                            #region Insert into sunday From
                            _oQuery.Append("INSERT INTO sunday_Form (IMEI_2, SS_TO_PLG_DATE, referenceNo,Agree_no,create_date, staffNo, staffName,  SalesManCode, Extn, Sales_channel, Applicat_Date, Customer_name, Customer_ID_Type, Customer_ID, Mobile_no, Contact_no, User_Name, Order_Amt, Delivery_charge, E_delivery_date, E_Delivery_period, Dummy2, Dummy3, Remark,ItemCode, program,PP_CUSTOMER_NAME ,contract_period,Plan_code,FG_Code,FG_IMEI0,FreeGift1,FG_Desc1,FG_IMEI1,FreeGift2,FG_Desc2,FG_IMEI2,FreeGift3,FG_Desc3,FG_IMEI3,FreeGift4,FG_Desc4,FG_IMEI4,CASH_AMT, ItemDesc, IMEI, TRADE, REBATE, HS_PAYMENT_TYPE, HS_CARD_NO, HS_C_HOLDER_NAME, HS_EXPIRYDATE, HS_PAY_AMT,COMPANY_NAME,VAS, doc_receive, cancelled,fo_to_sales, payment_status,create_s,to_plg,issue,pending,created_by,PEND_DOC,Premium_Gift,Contact_No_R,ament_counter,sim_card_type,sim_item_code,sim_card_no,");
                            _oQuery.Append("VAS10,MRT_Serial,Stock_Serial,VAS9,Activa_Date,BIRTH_DATE,Order_Confirm,FG_COST5,FG_COST0,FG_COST1,FG_COST2,FG_COST3,FG_COST4,VAS1,VAS2,VAS3,VAS4,VAS5,SS_LANGUAGE,PREMIUM_GIFT2,DOA_DATE,PAYMENT_I_DATE,Order_Type,PAYMENT_CAT,Inter_SMS,C_Tone_Service,Mobile_MSN,EZ_SMS_Pack,GPRS_Mob_Data,Mob_Online_Betting,Mob_ESPN_S_Package");
                            _oQuery.Append(" ) VALUES ('" + _oMobileRetentionOrder.GetSim_mrt_no() + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),   '" + _oMobileRetentionOrder.GetEdf_no() + "' ,");
                            _oQuery.Append("'" + _sRecordID + "',");
                            _oQuery.Append("to_date('" + _sToday.Trim() + "' , 'dd/mm/yyyy hh24:mi:ss') ,");

                            _oQuery.Append("'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetStaff_name().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetSalesmancode().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetExtn().Trim() + "','PCCW.PCCS',");
                            if (_oMobileRetentionOrder.GetLog_date() != null)
                                _oQuery.Append("to_date('" + Convert.ToDateTime(_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy") + "','dd/mm/yyyy'),'");
                            else
                                _oQuery.Append("','");

                            string _sGender = ((!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGender())) ? _oMobileRetentionOrder.GetGender() + " " : string.Empty);
                            _oQuery.Append(_sGender + _oMobileRetentionOrder.GetCustomerName().Trim().Replace("'", "`").Replace("``", "`") + "','");
                            if ("BRNO".Equals(_oMobileRetentionOrder.GetId_type().Trim()))
                                _oQuery.Append("BR','");
                            else
                                _oQuery.Append(_oMobileRetentionOrder.GetId_type().Trim() + "','");

                            if ("HKID".Equals(_oMobileRetentionOrder.GetId_type().Trim()))
                                _oQuery.Append(Func.Left(_oMobileRetentionOrder.GetHkid().Trim().Trim(), _oMobileRetentionOrder.GetHkid().Trim().Length - 1) + "(" + Func.Right(_oMobileRetentionOrder.GetHkid().Trim(), 1) + ")','");
                            else
                                _oQuery.Append(_oMobileRetentionOrder.GetHkid().Trim() + "','");

                            _oQuery.Append(_oMobileRetentionOrder.GetMrt_no().ToString().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetContact_no().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetContact_person().Trim().Replace("'", "`") + "','");
                            _oQuery.Append(((_dTotal == 0.0) ? string.Empty : _dTotal.ToString()).Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetExtra_d_charge().Trim() + "','");
                            if (_oMobileRetentionOrder.GetD_date() != null)
                                _oQuery.Append(Convert.ToDateTime(_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy") + "','");
                            else
                                _oQuery.Append("','");
                            if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetD_time().Trim()))
                                _oQuery.Append(_oMobileRetentionOrder.GetD_time().Trim() + "','");
                            else
                                _oQuery.Append("','");
                            _oQuery.Append(_oMobileRetentionOrder.GetD_address().Trim().Replace("'", "`").ToUpper() + "','");

                            if (!_oMobileRetentionOrder.GetVip_case().Trim().Equals(string.Empty))
                                _oQuery.Append(_oMobileRetentionOrder.GetVip_case().Trim().Replace("'", "`") + "','");
                            else
                                _oQuery.Append("','");

                            if (!_oMobileRetentionOrder.GetOrd_place_by().Trim().Equals(string.Empty) && !_oMobileRetentionOrder.GetOrd_place_rel().Trim().Equals("sub"))
                            {
                                if (!_oMobileRetentionOrder.GetRemarks2EDF().Trim().Equals(string.Empty))
                                {
                                    string _sRemark = _oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "','";
                                    _oQuery.Append(_sRemark.Trim().ToUpper());
                                }
                                else
                                {
                                    string _sRemark = " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "','";
                                    _oQuery.Append(_sRemark.Trim().ToUpper());
                                }
                            }
                            else
                            {
                                if (!_oMobileRetentionOrder.GetRemarks2EDF().Trim().ToUpper().Equals(string.Empty))
                                    _oQuery.Append(_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`").Trim().ToUpper() + "','");
                                else
                                    _oQuery.Append("','");
                            }

                            _oQuery.Append(_oMobileRetentionOrder.GetSku().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetProgram().Trim() + "','");
                            //_oQuery.Append(_oMobileRetentionOrder.GetRate_plan().Trim().Substring(0, ((_oMobileRetentionOrder.GetRate_plan().Length >= 20) ? 20 : _oMobileRetentionOrder.GetRate_plan().Length)) + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetRate_plan() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetCon_per().Trim() + " MTH','");
                            _oQuery.Append(_oMobileRetentionOrder.GetAccessory_code().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetAccessory_desc().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetAccessory_imei().Trim() + "','");

                            _oQuery.Append(_oMobileRetentionOrder.GetGift_code().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_desc().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_imei().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_code2().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_desc2().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_imei2().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_code3().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_desc3().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_imei3().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_code4().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_desc4().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetGift_imei4().Trim() + "','");

                            _oQuery.Append(_oMobileRetentionOrder.GetAccessory_price().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetHs_model().Trim() + "','");
                            //IMEI
                            if (!_oMobileRetentionOrder.GetImei_no().Equals("AWAIT") &&
                                !_oMobileRetentionOrder.GetImei_no().Equals("AO"))
                            {
                                _oQuery.Append(_oMobileRetentionOrder.GetImei_no().Trim() + "','");
                            }
                            else
                            {
                                _oQuery.Append("','");
                            }
                            _oQuery.Append(_oMobileRetentionOrder.GetTrade_field().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetRebate_amount().Trim() + "','");

                            if (_oMobileRetentionOrder.GetPay_method().Trim().Equals("CREDIT CARD INSTALLMENT"))
                                _oQuery.Append(_oMobileRetentionOrder.GetBank_code().Trim() + "','");
                            else if (_oMobileRetentionOrder.GetPay_method().Equals("CASH"))
                                _oQuery.Append("COD','");
                            else if (_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD"))
                                _oQuery.Append("CREDIT CARD FULL PAY','");
                            else
                                _oQuery.Append(_oMobileRetentionOrder.GetPay_method().Trim() + "','");

                            _oQuery.Append(_oMobileRetentionOrder.GetCard_no().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetCard_holder().Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetCard_exp_month().Trim() + Func.Right(_oMobileRetentionOrder.GetCard_exp_year().Trim(), 2).Trim() + "','");
                            _oQuery.Append(_oMobileRetentionOrder.GetAmount().Trim() + "','");

                            if (_oMobileRetentionOrder.GetCon_eff_date() != null)
                                _oQuery.Append(Convert.ToDateTime(_oMobileRetentionOrder.GetCon_eff_date()).ToString("MM/dd/yyyy") + "','");
                            else
                                _oQuery.Append("','");

                            _oQuery.Append(_oMobileRetentionOrder.GetBundle_name().Trim() + "',");
                            _oQuery.Append("'N','N','N','PNS','N','N','N','N','CC RET','EORDER',");

                            if ("".Equals(_oMobileRetentionOrder.GetPremium().Trim()))
                                _oQuery.Append("'N/A',");
                            else
                                _oQuery.Append("'" + _oMobileRetentionOrder.GetPremium().Trim() + "',");


                            if ("".Equals(_oMobileRetentionOrder.GetExt_place_tel().Trim()))
                                _oQuery.Append("'N/A',");
                            else
                                _oQuery.Append("'" + _oMobileRetentionOrder.GetExt_place_tel().Trim() + "',");

                            _oQuery.Append("0,");


                            _oQuery.Append("'" + _oMobileRetentionOrder.GetSim_item_name().Trim() + "',");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetSim_item_code().Trim() + "',");
                            _oQuery.Append("'',");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetDelivery_exchange().Trim() + "',");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetDelivery_collection_type().Trim() + "',");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetDelivery_exchange_location().Trim() + "',");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetDelivery_exchange_option().Trim() + "', ");
                           
                           GetMobileRetentionOrderLeftJoinTableData((int)x_oMobileRetentionOrder.GetOrder_id(), _oMobileRetentionOrder.GetEdf_no());
                           
                           
                           string _sServiceActivationDate2 =
                           ((_oMobileOrderMNPDetail.GetService_activation_date() != null) ?
                           ((DateTime)_oMobileOrderMNPDetail.GetService_activation_date()).ToString("dd/MM/yyyy HH:mm:ss") :
                           string.Empty);
                           
                            _oQuery.Append("to_date('" + _sServiceActivationDate2 + "', 'dd/mm/yyyy hh24:mi:ss') ,");

                            string _sBIRTH_DATE2 =
                                ((_oMobileRetentionOrder.GetDate_of_birth() != null) ?
                                ((DateTime)_oMobileRetentionOrder.GetDate_of_birth()).ToString("dd/MM/yyyy") :
                                string.Empty);
                            _oQuery.Append("'" + _sBIRTH_DATE2 + "',");

                            string _slicense_waiver = FindVasValue1("license_waiver").Trim().ToUpper();
                            _oQuery.Append("'" + _slicense_waiver + "',");

                            string _sTransferTo3G = ((_oMobileOrderMNPDetail.GetTransfer_to_3g() == true) ? "YES" : "NO");
                            _oQuery.Append("'" + _sTransferTo3G + "',");

                            string _sTransfer_idd_deposit =
                                ((_oMobileOrderMNPDetail.GetTransfer_idd_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_idd_deposit()).ToString() : string.Empty);

                            _oQuery.Append("'" + _sTransfer_idd_deposit + "',");

                            string _sTransfer_idd_roaming_deposit =
                                ((_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit()).ToString() : string.Empty);

                            _oQuery.Append("'" + _sTransfer_idd_roaming_deposit + "',");

                            string _sTransfer_no_hk_id_holder_deposit =
                                ((_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit()).ToString() : string.Empty);

                            _oQuery.Append("'" + _sTransfer_no_hk_id_holder_deposit + "',");

                            string _sTransfer_no_add_proof_deposit =
                                ((_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit()).ToString() : string.Empty);

                            _oQuery.Append("'" + _sTransfer_no_add_proof_deposit + "',");

                            string _sTransfer_others_deposit =
                                ((_oMobileOrderMNPDetail.GetTransfer_others_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_others_deposit()).ToString() : string.Empty);

                            _oQuery.Append("'" + _sTransfer_others_deposit + "', ");
                            _oQuery.Append("'" + FindVasValue1("idd_normal_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("idd0060_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("roaming_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("net_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("sms_vas") + "', ");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetLanguage() + "',");
                            _oQuery.Append("'" + _oMobileRetentionOrder.GetAction_of_rate_plan_effective() + "',");


                            if (_oMobileRetentionOrder.GetBill_cut_date() != null)
                                _oQuery.Append("to_date('" + ((DateTime)_oMobileRetentionOrder.GetBill_cut_date()).ToString("dd/MM/yyyy") + "' , 'dd/mm/yyyy') ,");
                            else
                                _oQuery.Append(" '',");

                            if (_oMobileRetentionOrder.GetPlan_eff_date() != null)
                                _oQuery.Append("to_date('" + ((DateTime)_oMobileRetentionOrder.GetPlan_eff_date()).ToString("dd/MM/yyyy") + "' , 'dd/mm/yyyy') ,");
                            else
                                _oQuery.Append(" '', ");


                            _oQuery.Append("'" + GetEDFIssueType(_oMobileRetentionOrder.GetIssue_type()) + "', ");
                            if(_oMobileRetentionOrder.GetCn_mrt_no()!=null)
                                _oQuery.Append("'" + ((long)_oMobileRetentionOrder.GetCn_mrt_no()).ToString() + "' ");
                            else
                                _oQuery.Append("'', ");


                            _oQuery.Append("'" + FindVasValue1("upg_act_super") + "',");
                            _oQuery.Append("'" + FindVasValue1("upg_1c2n_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("upg_msn_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("upg_prem3_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("upg_prem4_vas") + "',");
                            _oQuery.Append("'" + FindVasValue1("min_vas200") + "',");
                            _oQuery.Append("'" + FindVasValue1("min_vas450") + "'");


                            _oQuery.Append(")");




                            bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                            if (bFlag)
                            {
                                WebFunc.SaveQuery(_oQuery.ToString());
                                InsertSundaySundayActivation(_oMobileRetentionOrder);
                            }
                            if (_oMobileRetentionOrder.GetEdf_no() != "")
                            {
                                bool _bUpdate1 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET created_by='CC RET' where referenceno='" + _oMobileRetentionOrder.GetEdf_no() + "' and agree_no='" + _sRecordID + "'");
                                bool _bUpdate2 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' WHERE Dummy2='CC RET' AND DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()) + "' AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ");
                            }

                            x_sQuery = _oQuery.ToString();

                            if (_oMobileRetentionOrder.GetMrt_no() != null)
                                MobileGList.UpdateMobileGType(_oMobileRetentionOrder.GetEdf_no(), ((int)_oMobileRetentionOrder.GetMrt_no()).ToString());

                            #endregion

                        }
                        _oDr3.Close();
                        _oDr3.Dispose();
                    }
                }
                #endregion
            }
            return bFlag;
        }


        public void ToEDFError(int? x_iOrder_id, string x_sUid, string x_sRemark, string x_sError_msg)
        {

            EDFErrorCase _oEDFErrorCase = new EDFErrorCase(SYSConn<MSSQLConnect>.Connect());
            if (x_iOrder_id != null) { _oEDFErrorCase.SetOrder_id(x_iOrder_id); }
            _oEDFErrorCase.SetStatus("TO EDF");
            _oEDFErrorCase.SetCid(x_sUid);
            _oEDFErrorCase.SetRemark(x_sRemark);
            _oEDFErrorCase.SetError_msg(x_sError_msg);
            _oEDFErrorCase.SetCdate(DateTime.Now);
            _oEDFErrorCase.SetActive(true);
            EDFErrorCaseBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oEDFErrorCase);

        }

        public void ToAddNewOrderError(int? x_iOrder_id, string x_sUid, string x_sRemark, string x_sError_msg)
        {

            EDFErrorCase _oEDFErrorCase = new EDFErrorCase(SYSConn<MSSQLConnect>.Connect());
            if (x_iOrder_id != null) { _oEDFErrorCase.SetOrder_id(x_iOrder_id); }
            _oEDFErrorCase.SetStatus("ADD NEW ORDER");
            _oEDFErrorCase.SetCid(x_sUid);
            _oEDFErrorCase.SetRemark(x_sRemark);
            _oEDFErrorCase.SetError_msg(x_sError_msg);
            _oEDFErrorCase.SetCdate(DateTime.Now);
            _oEDFErrorCase.SetActive(true);
            EDFErrorCaseBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oEDFErrorCase);
        }


        public void ModifyEDFError(int? x_iOrder_id, string x_sUid, string x_sRemark, string x_sError_msg)
        {
            EDFErrorCase _oEDFErrorCase = new EDFErrorCase(SYSConn<MSSQLConnect>.Connect());
            if (x_iOrder_id != null) { _oEDFErrorCase.SetOrder_id(x_iOrder_id); }
            _oEDFErrorCase.SetStatus("MODIFY EDF");
            _oEDFErrorCase.SetCid(x_sUid);
            _oEDFErrorCase.SetRemark(x_sRemark);
            _oEDFErrorCase.SetError_msg(x_sError_msg);
            _oEDFErrorCase.SetCdate(DateTime.Now);
            _oEDFErrorCase.SetActive(true);
            EDFErrorCaseBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oEDFErrorCase);
        }

        public void AddEDFAmentLog(int x_iOrder_id, string x_sUid)
        {
            AddEDFAmentLog(x_iOrder_id, x_sUid, true);
        }

        public void AddEDFAmentLog(int x_iOrder_id, string x_sUid, bool x_bSetLeftJoinData)
        {
            string _sRemarksEDF = string.Empty;
            string _sToday = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
            string _sToday1 = DateTime.Now.ToString("yyyy-MM-dd");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
            if (!_oMobileRetentionOrder.GetFound()) return;

            if (x_bSetLeftJoinData)
                GetMobileRetentionOrderLeftJoinTableData(x_iOrder_id, _oMobileRetentionOrder.GetEdf_no());

            OdbcDataReader _oReader = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM sunday_form WHERE referenceNo ='" + _oMobileRetentionOrder.GetEdf_no() + "'");
            if (_oReader.Read())
            {
                int _iEdfXSize = 146;
                int _iEdfYSize = 6;
                if (!Func.FR(_oReader["cancelled"]).ToUpper().Equals('Y'))
                {
                    #region edfField
                    string[,] edfField = EDFHelper.GetEDFField(_iEdfXSize, _iEdfYSize);

                    edfField[0, 1] = string.Empty;
                    edfField[1, 1] = string.Empty;
                    string _sCustom_name = _oMobileRetentionOrder.GetGender() + " " + _oMobileRetentionOrder.GetCustomerName().Trim().ToUpper().Replace("'", "`");
                    if (!Func.FR(_oReader["customer_name"]).Trim().ToUpper().Equals(_sCustom_name))
                    {
                        edfField[2, 1] = "1";
                        edfField[2, 2] = _sCustom_name;
                        edfField[2, 3] = Func.FR(_oReader["customer_name"]).Trim().Replace("'", "`");
                    }
                    if (_oMobileRetentionOrder.GetMrt_no() != null)
                    {
                        if (!Func.FR(_oReader["mobile_no"]).Trim().ToUpper().Equals(Func.ParseString(_oMobileRetentionOrder.GetMrt_no()).Trim().ToUpper()))
                        {
                            edfField[3, 1] = "1";
                            edfField[3, 2] = Func.ParseString(_oMobileRetentionOrder.GetMrt_no());
                            edfField[3, 3] = Func.FR(_oReader["mobile_no"]).Trim();
                        }
                    }
                    if (!Func.FR(_oReader["contact_no"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetContact_no().Trim().ToUpper()))
                    {
                        edfField[4, 1] = "1";
                        edfField[4, 2] = _oMobileRetentionOrder.GetContact_no().Trim();
                        edfField[4, 3] = Func.FR(_oReader["contact_no"]).Trim();
                    }

                    double _dOrder_amt;
                    double _dAmount;

                    string _sAmount = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAmount()))
                        _sAmount = "0";
                    else
                        _sAmount = _oMobileRetentionOrder.GetAmount();

                    string _sExtra_d_charge = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetExist_cust_plan()))
                        _sExtra_d_charge = "0";
                    else
                        _sExtra_d_charge = _oMobileRetentionOrder.GetExist_cust_plan();

                    string _sAccessory_price = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_price()))
                        _sAccessory_price = "0";
                    else
                        _sAccessory_price = _oMobileRetentionOrder.GetAccessory_price();

                    string _sFirst_month_fee = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetFirst_month_fee()))
                        _sFirst_month_fee = "0";
                    else
                        _sFirst_month_fee = _oMobileRetentionOrder.GetFirst_month_fee();

                    string _sFirst_month_license_fee = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetFirst_month_license_fee()))
                        _sFirst_month_license_fee = "0";
                    else
                        _sFirst_month_license_fee = _oMobileRetentionOrder.GetFirst_month_license_fee();


                    Double _dTotal = 0.0;
                    Double _dAmount2, _dAccessory_price, _dExtra_d_charge, _dFirst_month_fee, _dFirst_month_license_fee;
                    if (Double.TryParse(_sAmount, out _dAmount2))
                        _dTotal += _dAmount2;
                    if (Double.TryParse(_sAccessory_price, out _dAccessory_price))
                        _dTotal += _dAccessory_price;
                    if (Double.TryParse(_sExtra_d_charge, out _dExtra_d_charge))
                        _dTotal += _dExtra_d_charge;
                    if (Double.TryParse(_sFirst_month_fee, out _dFirst_month_fee))
                        _dTotal += _dFirst_month_fee;
                    if (Double.TryParse(_sFirst_month_license_fee, out  _dFirst_month_license_fee))
                        _dTotal += _dFirst_month_license_fee;


                    if (double.TryParse(Func.FR(_oReader["Order_amt"]).Trim(), out _dOrder_amt))
                    {
                        if (!_dOrder_amt.Equals(_dTotal.ToString()))
                        {
                            edfField[5, 1] = "1";
                            edfField[5, 2] = _dTotal.ToString();
                            edfField[5, 3] = _dOrder_amt.ToString();
                        }
                    }

                    if (!Func.FR(_oReader["delivery_charge"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetExtra_d_charge().Trim().ToUpper()))
                    {
                        edfField[6, 1] = "1";
                        edfField[6, 2] = _oMobileRetentionOrder.GetExtra_d_charge();
                        edfField[6, 3] = Func.FR(_oReader["delivery_charge"]).Trim();
                    }

                    if (_oMobileRetentionOrder.GetD_date() != null)
                    {
                        if (!Func.FR(_oReader["E_delivery_date"]).Trim().ToUpper().Equals(((DateTime)_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy").ToUpper()))
                        {
                            edfField[7, 1] = "1";
                            edfField[7, 2] = ((DateTime)_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy").ToUpper();
                            edfField[7, 3] = Func.FR(_oReader["E_delivery_date"]).Trim();
                        }
                    }

                    if (!Func.FR(_oReader["E_delivery_period"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetD_time().Trim().ToUpper()))
                    {
                        edfField[8, 1] = "1";
                        edfField[8, 2] = _oMobileRetentionOrder.GetD_time().Trim();
                        edfField[8, 3] = Func.FR(_oReader["E_delivery_period"]).Trim();
                    }

                    if (!Func.FR(_oReader["Dummy2"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetD_address().Trim().Replace("'", "`").ToUpper()))
                    {
                        edfField[9, 1] = "1";
                        edfField[9, 2] = _oMobileRetentionOrder.GetD_address().Replace("'", "`").ToUpper();
                        edfField[9, 3] = Func.FR(_oReader["Dummy2"]).Trim();
                    }

                    if (!_oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`").Equals(string.Empty) && !_oMobileRetentionOrder.GetOrd_place_rel().Replace("'", "`").Equals("sub"))
                    {
                        string _sRemark = (_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + "," + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`"));
                        if (Func.FR(_oReader["remark"]).Trim().ToUpper() != _sRemark.Trim().ToUpper())
                        {
                            edfField[10, 1] = "1";
                            edfField[10, 2] = _sRemark.Trim().ToUpper();
                            edfField[10, 3] = Func.FR(_oReader["remark"]).Trim().ToUpper();
                        }
                    }
                    else
                    {
                        if (!Func.FR(_oReader["remark"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`").Trim().ToUpper()))
                        {
                            edfField[10, 1] = "1";
                            edfField[10, 2] = _oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`").Trim().ToUpper();
                            edfField[10, 3] = Func.FR(_oReader["remark"]).Trim().ToUpper();
                        }
                    }

                    if (!Func.FR(_oReader["ItemCode"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetSku().Trim().ToUpper()))
                    {
                        edfField[11, 1] = "1";
                        edfField[11, 2] = _oMobileRetentionOrder.GetSku().Trim().ToUpper();
                        edfField[11, 3] = Func.FR(_oReader["ItemCode"]).Trim();
                    }

                    if (!Func.FR(_oReader["ItemDesc"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetHs_model().Trim().ToUpper()))
                    {
                        edfField[12, 1] = "1";
                        edfField[12, 2] = _oMobileRetentionOrder.GetHs_model().Trim().ToUpper();
                        edfField[12, 3] = Func.FR(_oReader["ItemDesc"]).Trim().ToUpper();
                    }

                    string _sHandset_pay_type = string.Empty;
                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetPay_method().Trim()))
                        _sHandset_pay_type = string.Empty;
                    else if (_oMobileRetentionOrder.GetPay_method().Trim().ToUpper().Equals("CREDIT CARD"))
                        _sHandset_pay_type = "CREDIT CARD FULL PAY";
                    else if (_oMobileRetentionOrder.GetPay_method().Trim().ToUpper().Equals("CREDIT CARD INSTALLMENT"))
                        _sHandset_pay_type = _oMobileRetentionOrder.GetBank_code().Trim();
                    else
                        _sHandset_pay_type = "COD";

                    if (!Func.FR(_oReader["HS_payment_type"]).Trim().ToUpper().Equals(_sHandset_pay_type) ||
                        (_oReader["HS_payment_type"] == null && !_sHandset_pay_type.Equals(string.Empty)))
                    {
                        edfField[13, 1] = "1";
                        edfField[13, 2] = _sHandset_pay_type.Trim().ToUpper();
                        edfField[13, 3] = Func.FR(_oReader["HS_payment_type"]);
                    }

                    if (!Func.FR(_oReader["HS_Card_no"]).Equals(_oMobileRetentionOrder.GetCard_no().Trim()) ||
                        ((_oReader["HS_Card_no"] == null) && !_oMobileRetentionOrder.GetCard_no().Trim().Equals(string.Empty)) ||
                        (!Func.FR(_oReader["HS_Card_no"]).Equals(string.Empty) && _oMobileRetentionOrder.GetCard_no() == null))
                    {
                        edfField[14, 1] = "1";
                        edfField[14, 2] = _oMobileRetentionOrder.GetCard_no().Trim();
                        edfField[14, 3] = Func.FR(_oReader["HS_Card_no"]);
                    }

                    string _sHS_C_Holder_name = Func.FR(_oReader["HS_C_Holder_name"]);
                    string _sCard_holder = _oMobileRetentionOrder.GetCard_holder().Trim().ToUpper();

                    if (!_sHS_C_Holder_name.Equals(_sCard_holder) ||
                        ((string.IsNullOrEmpty(_sHS_C_Holder_name)) && !_sCard_holder.Equals(string.Empty)) ||
                        (!_sHS_C_Holder_name.Equals(string.Empty) && string.IsNullOrEmpty(_sCard_holder))
                        )
                    {
                        edfField[15, 1] = "1";
                        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_holder()))
                            edfField[15, 2] = _oMobileRetentionOrder.GetCard_holder().Trim().ToUpper();
                        else
                            edfField[15, 2] = string.Empty;

                        if (!string.IsNullOrEmpty(_sHS_C_Holder_name))
                            edfField[15, 3] = _sHS_C_Holder_name.Trim().ToUpper();
                        else
                            edfField[15, 3] = string.Empty;
                    }


                    if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_exp_year()) && !string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_exp_month()))
                    {
                        if (Func.FR(_oReader["HS_EXPIRYDATE"]).Trim() != (_oMobileRetentionOrder.GetCard_exp_month() + Func.Right(_oMobileRetentionOrder.GetCard_exp_year(), 2)) ||
                            (_oReader["hs_expiryDate"] == null) && (!_oMobileRetentionOrder.GetCard_exp_month().Trim().Equals(string.Empty)) ||
                            !Func.FR(_oReader["hs_expiryDate"]).Equals(string.Empty) && string.IsNullOrEmpty(_oMobileRetentionOrder.GetCard_exp_year()))
                        {
                            edfField[16, 1] = "1";
                            edfField[16, 2] = _oMobileRetentionOrder.GetCard_exp_month() + Func.Right(_oMobileRetentionOrder.GetCard_exp_year(), 2);
                            edfField[16, 3] = Func.FR(_oReader["HS_ExpiryDate"]).Trim();
                        }
                    }
                    if (!Func.FR(_oReader["HS_PAY_AMT"]).Trim().Equals(_oMobileRetentionOrder.GetAmount()))
                    {
                        edfField[17, 1] = "1";
                        edfField[17, 2] = _oMobileRetentionOrder.GetAmount().Trim();
                        edfField[17, 3] = Func.FR(_oReader["HS_Pay_Amt"]).Trim();
                    }

                    if (!Func.FR(_oReader["User_name"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetContact_person().Trim().ToUpper()))
                    {
                        edfField[18, 1] = "1";
                        edfField[18, 2] = _oMobileRetentionOrder.GetContact_person().Trim();
                        edfField[18, 3] = Func.FR(_oReader["User_Name"]).Trim();
                    }

                    if (!Func.FR(_oReader["Plan_code"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetAccessory_code().Trim().ToUpper()))
                    {
                        edfField[19, 1] = "1";
                        edfField[19, 2] = _oMobileRetentionOrder.GetAccessory_code();
                        edfField[19, 3] = Func.FR(_oReader["Plan_code"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_Code"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetAccessory_desc().Trim().ToUpper()))
                    {
                        edfField[20, 1] = "1";
                        edfField[20, 2] = _oMobileRetentionOrder.GetAccessory_desc().Trim();
                        edfField[20, 3] = Func.FR(_oReader["FG_Code"]).Trim();
                    }

                    if (!Func.FR(_oReader["program"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetProgram().Trim().ToUpper()))
                    {
                        edfField[21, 1] = "1";
                        edfField[21, 2] = _oMobileRetentionOrder.GetProgram().Trim();
                        edfField[21, 3] = Func.FR(_oReader["program"]).Trim();
                    }

                    if (!Func.FR(_oReader["PP_CUSTOMER_NAME"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetRate_plan().Trim().Substring(0, ((_oMobileRetentionOrder.GetRate_plan().Length >= 20) ? 20 : _oMobileRetentionOrder.GetRate_plan().Length)).ToUpper()))
                    {
                        edfField[22, 1] = "1";
                        edfField[22, 2] = _oMobileRetentionOrder.GetRate_plan().Trim().Substring(0, ((_oMobileRetentionOrder.GetRate_plan().Length >= 20) ? 20 : _oMobileRetentionOrder.GetRate_plan().Length));
                        edfField[22, 3] = Func.FR(_oReader["PP_CUSTOMER_NAME"]).Trim();
                    }

                    if (!Func.FR(_oReader["contract_period"]).Trim().Equals(_oMobileRetentionOrder.GetCon_per().Trim() + " MTH"))
                    {
                        edfField[23, 1] = "1";
                        edfField[23, 2] = _oMobileRetentionOrder.GetCon_per().Trim() + " MTH";
                        edfField[23, 3] = Func.FR(_oReader["contract_period"]).Trim();
                    }

                    if (!Func.FR(_oReader["FreeGift1"]).Equals(_oMobileRetentionOrder.GetGift_code().Trim()))
                    {
                        edfField[24, 1] = "1";
                        edfField[24, 2] = _oMobileRetentionOrder.GetGift_code().Trim();
                        edfField[24, 3] = Func.FR(_oReader["FreeGift1"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_Desc1"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_desc().Trim().ToUpper()))
                    {
                        edfField[25, 1] = "1";
                        edfField[25, 2] = _oMobileRetentionOrder.GetGift_desc().Trim();
                        edfField[25, 3] = Func.FR(_oReader["FG_Desc1"]).Trim();
                    }

                    if (!Func.FR(_oReader["CASH_AMT"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetAccessory_price().Trim()))
                    {
                        edfField[26, 1] = "1";
                        edfField[26, 2] = _oMobileRetentionOrder.GetAccessory_price().Trim();
                        edfField[26, 3] = Func.FR(_oReader["CASH_AMT"]).Trim();
                    }

                    if (!Func.FR(_oReader["IMEI"]).Trim().Equals(_oMobileRetentionOrder.GetImei_no().Trim()))
                    {
                        edfField[27, 1] = "1";
                        if (!_oMobileRetentionOrder.GetImei_no().Trim().ToUpper().Equals("AWAIT"))
                            edfField[27, 2] = _oMobileRetentionOrder.GetImei_no().Trim();
                        else
                            edfField[27, 2] = string.Empty;

                        edfField[27, 3] = Func.FR(_oReader["IMEI"]).Trim().ToUpper();
                    }

                    if (!Func.FR(_oReader["TRADE"]).Trim().Equals(_oMobileRetentionOrder.GetTrade_field().Trim()))
                    {
                        edfField[28, 1] = "1";
                        edfField[28, 2] = _oMobileRetentionOrder.GetTrade_field().Trim();
                        edfField[28, 3] = Func.FR(_oReader["TRADE"]).Trim();
                    }

                    if (!Func.FR(_oReader["REBATE"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetRebate_amount().Trim().ToUpper()))
                    {
                        edfField[29, 1] = "1";
                        edfField[29, 2] = _oMobileRetentionOrder.GetRebate_amount().Trim().ToUpper();
                        edfField[29, 3] = Func.FR(_oReader["REBATE"]).Trim().ToUpper();
                    }

                    if (!Func.FR(_oReader["FreeGift2"]).Trim().Equals(_oMobileRetentionOrder.GetGift_code2().Trim()))
                    {
                        edfField[30, 1] = "1";
                        edfField[30, 2] = _oMobileRetentionOrder.GetGift_code2().Trim().ToUpper();
                        edfField[30, 3] = Func.FR(_oReader["FreeGift2"]).Trim().ToUpper();
                    }

                    if (!Func.FR(_oReader["FG_Desc2"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_desc2().Trim().ToUpper()))
                    {
                        edfField[31, 1] = "1";
                        edfField[31, 2] = _oMobileRetentionOrder.GetGift_desc2().Trim().ToUpper();
                        edfField[31, 3] = Func.FR(_oReader["FG_Desc2"]).Trim().ToUpper();
                    }
                    string _sR_HKID_type = string.Empty;
                    if (Func.FR(_oMobileRetentionOrder.GetId_type()).Trim().Equals("BRNO"))
                        _sR_HKID_type = "BR";
                    else
                    {
                        _sR_HKID_type = _oMobileRetentionOrder.GetId_type().Trim().ToUpper();
                    }



                    if (!Func.FR(_oReader["customer_ID_type"]).Trim().ToUpper().Equals(_sR_HKID_type.ToUpper()))
                    {
                        edfField[32, 1] = "1";
                        edfField[32, 2] = _sR_HKID_type.Trim().ToUpper();
                        edfField[32, 3] = Func.FR(_oReader["customer_ID_type"]).Trim().ToUpper();
                    }
                    string _sR_HKID = string.Empty;



                    if (_oMobileRetentionOrder.GetId_type().Trim().ToUpper().Equals("HKID"))
                    {
                        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetHkid()))
                        {
                            if (_oMobileRetentionOrder.GetHkid().Length >= 8)
                                _sR_HKID = Func.Left(_oMobileRetentionOrder.GetHkid(), 7) + "(" + Func.Right(_oMobileRetentionOrder.GetHkid(), 1) + ")";
                            else
                                _sR_HKID = _oMobileRetentionOrder.GetHkid();
                        }
                    }
                    else
                        _sR_HKID = _oMobileRetentionOrder.GetHkid().Trim().ToUpper();

                    if (!Func.FR(_oReader["customer_ID"]).Trim().ToUpper().Equals(_sR_HKID.ToUpper()))
                    {
                        edfField[33, 1] = "1";
                        edfField[33, 2] = _sR_HKID;
                        edfField[33, 3] = Func.FR(_oReader["customer_ID"]).Trim().ToUpper();
                    }

                    if (!Func.FR(_oReader["FreeGift3"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_code3().Trim().ToUpper()))
                    {
                        edfField[34, 1] = "1";
                        edfField[34, 2] = _oMobileRetentionOrder.GetGift_code3().Trim().ToUpper();
                        edfField[34, 3] = Func.FR(_oReader["FreeGift3"]).Trim().ToUpper();
                    }

                    if (!Func.FR(_oReader["FG_Desc3"]).Trim().Equals(_oMobileRetentionOrder.GetGift_desc3().Trim()))
                    {
                        edfField[35, 1] = "1";
                        edfField[35, 2] = _oMobileRetentionOrder.GetGift_desc3().Trim();
                        edfField[35, 3] = Func.FR(_oReader["FG_Desc3"]).Trim();
                    }

                    if (!Func.FR(_oReader["FreeGift4"]).Trim().Equals(_oMobileRetentionOrder.GetGift_code4().Trim()))
                    {
                        edfField[36, 1] = "1";
                        edfField[36, 2] = _oMobileRetentionOrder.GetGift_code4().Trim();
                        edfField[36, 3] = Func.FR(_oReader["FreeGift4"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_Desc4"]).Trim().Equals(_oMobileRetentionOrder.GetGift_desc4().Trim()))
                    {
                        edfField[37, 1] = "1";
                        edfField[37, 2] = _oMobileRetentionOrder.GetGift_desc4().Trim();
                        edfField[37, 3] = Func.FR(_oReader["FG_Desc4"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_IMEI0"]).Trim().Equals(_oMobileRetentionOrder.GetAccessory_imei().Trim()))
                    {
                        edfField[38, 1] = "1";
                        edfField[38, 2] = _oMobileRetentionOrder.GetAccessory_imei().Trim();
                        edfField[38, 3] = Func.FR(_oReader["FG_IMEI0"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_IMEI1"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_imei()))
                    {
                        edfField[39, 1] = "1";
                        edfField[39, 2] = _oMobileRetentionOrder.GetGift_imei().Trim().ToUpper();
                        edfField[39, 3] = Func.FR(_oReader["FG_IMEI1"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_IMEI2"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_imei2()))
                    {
                        edfField[40, 1] = "1";
                        edfField[40, 2] = _oMobileRetentionOrder.GetGift_imei2().Trim().ToUpper();
                        edfField[40, 3] = Func.FR(_oReader["FG_IMEI2"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_IMEI3"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_imei3()))
                    {
                        edfField[41, 1] = "1";
                        edfField[41, 2] = _oMobileRetentionOrder.GetGift_imei3().Trim().ToUpper();
                        edfField[41, 3] = Func.FR(_oReader["FG_IMEI3"]).Trim();
                    }

                    if (!Func.FR(_oReader["FG_IMEI4"]).Trim().ToUpper().Equals(_oMobileRetentionOrder.GetGift_imei4()))
                    {
                        edfField[42, 1] = "1";
                        edfField[42, 2] = _oMobileRetentionOrder.GetGift_imei4().Trim().ToUpper();
                        edfField[42, 3] = Func.FR(_oReader["FG_IMEI4"]).Trim();
                    }

                    string _sDummy3 = Func.FR(_oReader["dummy3"]).Trim().ToUpper();
                    string _sVip_case = _oMobileRetentionOrder.GetVip_case().Trim().ToUpper();

                    if (!_sDummy3.ToUpper().Equals(_sVip_case.Trim().ToUpper()) ||
                       ((string.IsNullOrEmpty(_sDummy3)) && !_sVip_case.Equals(string.Empty)) ||
                        (!_sDummy3.Equals(string.Empty) && string.IsNullOrEmpty(_sVip_case)))
                    {
                        edfField[43, 1] = "1";
                        edfField[43, 2] = _oMobileRetentionOrder.GetVip_case().Trim();
                        edfField[43, 3] = Func.FR(_oReader["dummy3"]).Trim();
                    }

                    string _sConeff = string.Empty;
                    if (_oMobileRetentionOrder.GetCon_eff_date() != null)
                        _sConeff = Convert.ToDateTime(_oMobileRetentionOrder.GetCon_eff_date()).ToString("MM/dd/yyyy");
                    string _sCOMPANY_NAME = Func.FR(_oReader["COMPANY_NAME"]).Trim().ToUpper();
                    if (!_sCOMPANY_NAME.Equals(_sConeff) ||
                        (string.IsNullOrEmpty(_sCOMPANY_NAME) && !string.IsNullOrEmpty(_sConeff)) ||
                        (!string.IsNullOrEmpty(_sCOMPANY_NAME) && string.IsNullOrEmpty(_sConeff))
                        )
                    {
                        edfField[44, 1] = "1";
                        edfField[44, 2] = _sConeff;
                        edfField[44, 3] = _sCOMPANY_NAME;
                    }

                    string _sVas = Func.FR(_oReader["VAS"]).Trim().ToUpper();
                    string _sBundleName = _oMobileRetentionOrder.GetBundle_name().Trim().ToUpper();

                    if (!_sVas.Equals(_sBundleName) ||
                        (!string.IsNullOrEmpty(_sVas) && string.IsNullOrEmpty(_sBundleName)) ||
                       string.IsNullOrEmpty(_sVas) && !string.IsNullOrEmpty(_sBundleName))
                    {
                        edfField[45, 1] = "1";
                        edfField[45, 2] = _oMobileRetentionOrder.GetBundle_name().Trim();
                        edfField[45, 3] = Func.FR(_oReader["VAS"]).Trim();
                    }

                    string _sSF_sim_item_name_ = Func.FR(_oReader["sim_card_type"]).Trim().ToUpper();
                    string _sWL_sim_item_name = _oMobileRetentionOrder.GetSim_item_name().Trim().ToUpper();

                    if (!_sSF_sim_item_name_.Equals(_sWL_sim_item_name) ||
                        (!string.IsNullOrEmpty(_sSF_sim_item_name_) && string.IsNullOrEmpty(_sWL_sim_item_name)) ||
                       string.IsNullOrEmpty(_sSF_sim_item_name_) && !string.IsNullOrEmpty(_sWL_sim_item_name))
                    {
                        edfField[46, 1] = "1";
                        edfField[46, 2] = _oMobileRetentionOrder.GetSim_item_name().Trim();
                        edfField[46, 3] = Func.FR(_oReader["sim_card_type"]).Trim();
                    }


                    string _sSF_sim_item_code = Func.FR(_oReader["sim_item_code"]).Trim().ToUpper();
                    string _sWL_sim_item_code = _oMobileRetentionOrder.GetSim_item_code().Trim().ToUpper();

                    if (!_sSF_sim_item_code.Equals(_sWL_sim_item_code) ||
                        (!string.IsNullOrEmpty(_sWL_sim_item_code) && string.IsNullOrEmpty(_sWL_sim_item_code)) ||
                       string.IsNullOrEmpty(_sWL_sim_item_code) && !string.IsNullOrEmpty(_sWL_sim_item_code))
                    {
                        edfField[47, 1] = "1";
                        edfField[47, 2] = _oMobileRetentionOrder.GetSim_item_code().Trim();
                        edfField[47, 3] = Func.FR(_oReader["sim_item_code"]).Trim();
                    }

                    string _sVAS10 = Func.FR(_oReader["VAS10"]).Trim().ToUpper();
                    string _sDelivery_Exchange = _oMobileRetentionOrder.GetDelivery_exchange();
                    if (!_sVAS10.Equals(_sDelivery_Exchange) ||
                       (!string.IsNullOrEmpty(_sDelivery_Exchange) && string.IsNullOrEmpty(_sDelivery_Exchange)) ||
                      string.IsNullOrEmpty(_sDelivery_Exchange) && !string.IsNullOrEmpty(_sDelivery_Exchange))
                    {
                        edfField[48, 1] = "1";
                        edfField[48, 2] = _oMobileRetentionOrder.GetDelivery_exchange().Trim();
                        edfField[48, 3] = Func.FR(_oReader["VAS10"]).Trim();
                    }

                    string _sMRT_Serial = Func.FR(_oReader["MRT_Serial"]).Trim().ToUpper();
                    string _sDelivery_Collection_Type = _oMobileRetentionOrder.GetDelivery_collection_type();
                    if (!_sMRT_Serial.Equals(_sDelivery_Collection_Type) ||
                       (!string.IsNullOrEmpty(_sDelivery_Collection_Type) && string.IsNullOrEmpty(_sDelivery_Collection_Type)) ||
                      string.IsNullOrEmpty(_sDelivery_Collection_Type) && !string.IsNullOrEmpty(_sDelivery_Collection_Type))
                    {
                        edfField[49, 1] = "1";
                        edfField[49, 2] = _oMobileRetentionOrder.GetDelivery_collection_type().Trim();
                        edfField[49, 3] = Func.FR(_oReader["MRT_Serial"]).Trim();
                    }

                    string _sStock_Serial = Func.FR(_oReader["Stock_Serial"]).Trim().ToUpper();
                    string _sDelivery_Exchange_Location = _oMobileRetentionOrder.GetDelivery_exchange_location();
                    if (!_sStock_Serial.Equals(_sDelivery_Exchange_Location) ||
                       (!string.IsNullOrEmpty(_sDelivery_Exchange_Location) && string.IsNullOrEmpty(_sDelivery_Exchange_Location)) ||
                      string.IsNullOrEmpty(_sDelivery_Exchange_Location) && !string.IsNullOrEmpty(_sDelivery_Exchange_Location))
                    {
                        edfField[50, 1] = "1";
                        edfField[50, 2] = _oMobileRetentionOrder.GetDelivery_exchange_location().Trim();
                        edfField[50, 3] = Func.FR(_oReader["Stock_Serial"]).Trim();
                    }

                    string _sVAS9 = Func.FR(_oReader["VAS9"]).Trim().ToUpper();
                    string _sDelivery_Exchange_Option = _oMobileRetentionOrder.GetDelivery_exchange_option();
                    if (!_sVAS9.Equals(_sDelivery_Exchange_Option) ||
                       (!string.IsNullOrEmpty(_sDelivery_Exchange_Option) && string.IsNullOrEmpty(_sDelivery_Exchange_Option)) ||
                      string.IsNullOrEmpty(_sDelivery_Exchange_Option) && !string.IsNullOrEmpty(_sDelivery_Exchange_Option))
                    {
                        edfField[51, 1] = "1";
                        edfField[51, 2] = _oMobileRetentionOrder.GetDelivery_exchange_option().Trim();
                        edfField[51, 3] = Func.FR(_oReader["VAS9"]).Trim();
                    }

                    string _sServiceActivationDate =
                        ((_oReader["Activa_Date"] != null && _oReader["Activa_Date"] != System.DBNull.Value) ? ((DateTime)_oReader["Activa_Date"]).ToString("dd/MM/yyyy HH:mm:ss") : string.Empty);

                    string _sServiceActivationDate2 =
                        ((_oMobileOrderMNPDetail.GetService_activation_date() != null) ?
                        ((DateTime)_oMobileOrderMNPDetail.GetService_activation_date()).ToString("dd/MM/yyyy").Trim() :
                        string.Empty);

                    if (!_sServiceActivationDate.Equals(_sServiceActivationDate2) ||
                       (!string.IsNullOrEmpty(_sServiceActivationDate2) && string.IsNullOrEmpty(_sServiceActivationDate2)) ||
                      string.IsNullOrEmpty(_sServiceActivationDate2) && !string.IsNullOrEmpty(_sServiceActivationDate2))
                    {
                        edfField[52, 1] = "1";
                        edfField[52, 2] = _sServiceActivationDate2;
                        edfField[52, 3] = _sServiceActivationDate;
                    }

                    string _sBIRTH_DATE = Func.FR(_oReader["BIRTH_DATE"]).Trim().ToUpper();
                    string _sBIRTH_DATE2 =
                        ((_oMobileRetentionOrder.GetDate_of_birth() != null) ?
                        ((DateTime)_oMobileRetentionOrder.GetDate_of_birth()).ToString("dd/MM/yyyy") :
                        string.Empty);

                    if (!_sBIRTH_DATE.Equals(_sBIRTH_DATE2) ||
                       (!string.IsNullOrEmpty(_sBIRTH_DATE2) && string.IsNullOrEmpty(_sBIRTH_DATE2)) ||
                      string.IsNullOrEmpty(_sBIRTH_DATE2) && !string.IsNullOrEmpty(_sBIRTH_DATE2))
                    {
                        edfField[53, 1] = "1";
                        edfField[53, 2] = _sBIRTH_DATE2;
                        edfField[53, 3] = _sBIRTH_DATE;
                    }


                    string _sOrder_Confirm = Func.FR(_oReader["Order_Confirm"]).Trim().ToUpper();
                    string _slicense_waiver = FindVasValue1("license_waiver").Trim().ToUpper();
                    if (!_sOrder_Confirm.Equals(_slicense_waiver) ||
                       (!string.IsNullOrEmpty(_slicense_waiver) && string.IsNullOrEmpty(_slicense_waiver)) ||
                      string.IsNullOrEmpty(_slicense_waiver) && !string.IsNullOrEmpty(_slicense_waiver))
                    {
                        edfField[54, 1] = "1";
                        edfField[54, 2] = _slicense_waiver.Trim();
                        edfField[54, 3] = _sOrder_Confirm;
                    }

                    string _sFG_COST5 = Func.FR(_oReader["FG_COST5"]).Trim();
                    string _sTransferTo3G = ((_oMobileOrderMNPDetail.GetTransfer_to_3g() == true) ? "YES" : "NO");
                    if (!_sFG_COST5.Equals(_sTransferTo3G) ||
                       (!string.IsNullOrEmpty(_sTransferTo3G) && string.IsNullOrEmpty(_sTransferTo3G)) ||
                      string.IsNullOrEmpty(_sTransferTo3G) && !string.IsNullOrEmpty(_sTransferTo3G))
                    {
                        edfField[55, 1] = "1";
                        edfField[55, 2] = _sTransferTo3G;
                        edfField[55, 3] = _sFG_COST5;
                    }

                    string _sFG_COST0 = Func.FR(_oReader["FG_COST0"]).Trim();
                    string _sTransfer_idd_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_idd_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_idd_deposit()).ToString() : string.Empty);

                    if (!_sFG_COST0.Equals(_sTransfer_idd_deposit) ||
                       (!string.IsNullOrEmpty(_sTransfer_idd_deposit) && string.IsNullOrEmpty(_sTransfer_idd_deposit)) ||
                      string.IsNullOrEmpty(_sTransfer_idd_deposit) && !string.IsNullOrEmpty(_sTransfer_idd_deposit))
                    {
                        edfField[56, 1] = "1";
                        edfField[56, 2] = _sTransfer_idd_deposit;
                        edfField[56, 3] = _sFG_COST0;
                    }

                    string _sFG_COST1 = Func.FR(_oReader["FG_COST1"]).Trim();
                    string _sTransfer_idd_roaming_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit()).ToString() : string.Empty);

                    if (!_sFG_COST1.Equals(_sTransfer_idd_roaming_deposit) ||
                       (!string.IsNullOrEmpty(_sTransfer_idd_roaming_deposit) && string.IsNullOrEmpty(_sTransfer_idd_roaming_deposit)) ||
                      string.IsNullOrEmpty(_sTransfer_idd_roaming_deposit) && !string.IsNullOrEmpty(_sTransfer_idd_roaming_deposit))
                    {
                        edfField[57, 1] = "1";
                        edfField[57, 2] = _sTransfer_idd_roaming_deposit;
                        edfField[57, 3] = _sFG_COST1;
                    }

                    string _sFG_COST2 = Func.FR(_oReader["FG_COST2"]).Trim();
                    string _sTransfer_no_hk_id_holder_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit()).ToString() : string.Empty);

                    if (!_sFG_COST2.Equals(_sTransfer_no_hk_id_holder_deposit) ||
                       (!string.IsNullOrEmpty(_sTransfer_no_hk_id_holder_deposit) && string.IsNullOrEmpty(_sTransfer_no_hk_id_holder_deposit)) ||
                      string.IsNullOrEmpty(_sTransfer_no_hk_id_holder_deposit) && !string.IsNullOrEmpty(_sTransfer_no_hk_id_holder_deposit))
                    {
                        edfField[58, 1] = "1";
                        edfField[58, 2] = _sTransfer_no_hk_id_holder_deposit;
                        edfField[58, 3] = _sFG_COST2;
                    }

                    string _sFG_COST3 = Func.FR(_oReader["FG_COST3"]).Trim();
                    string _sTransfer_no_add_proof_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit()).ToString() : string.Empty);

                    if (!_sFG_COST3.Equals(_sTransfer_no_add_proof_deposit) ||
                       (!string.IsNullOrEmpty(_sTransfer_no_add_proof_deposit) && string.IsNullOrEmpty(_sTransfer_no_add_proof_deposit)) ||
                      string.IsNullOrEmpty(_sTransfer_no_add_proof_deposit) && !string.IsNullOrEmpty(_sTransfer_no_add_proof_deposit))
                    {
                        edfField[59, 1] = "1";
                        edfField[59, 2] = _sTransfer_no_add_proof_deposit;
                        edfField[59, 3] = _sFG_COST3;
                    }

                    string _sFG_COST4 = Func.FR(_oReader["FG_COST4"]).Trim();
                    string _sTransfer_others_deposit =
                        ((_oMobileOrderMNPDetail.GetTransfer_others_deposit() != null) ? ((long)_oMobileOrderMNPDetail.GetTransfer_others_deposit()).ToString() : string.Empty);

                    if (!_sFG_COST4.Equals(_sTransfer_others_deposit) ||
                       (!string.IsNullOrEmpty(_sTransfer_others_deposit) && string.IsNullOrEmpty(_sTransfer_others_deposit)) ||
                      string.IsNullOrEmpty(_sTransfer_others_deposit) && !string.IsNullOrEmpty(_sTransfer_others_deposit))
                    {
                        edfField[60, 1] = "1";
                        edfField[60, 2] = _sTransfer_others_deposit;
                        edfField[60, 3] = _sFG_COST4;
                    }

                    string _sMP_CARD_OWNER = _oSundayActivation.GetMP_CARD_OWNER();
                    string _sChange_payment_type = string.Empty;


                    if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetChange_payment_type()))
                    {
                        if (_oMobileRetentionOrder.GetChange_payment_type().Length >= 15)
                            _sChange_payment_type = _oMobileRetentionOrder.GetChange_payment_type().Substring(0, 15);
                        else
                            _sChange_payment_type = _oMobileRetentionOrder.GetChange_payment_type();
                    }


                    if (!_sMP_CARD_OWNER.Equals(_sChange_payment_type) ||
                       (!string.IsNullOrEmpty(_sChange_payment_type) && string.IsNullOrEmpty(_sChange_payment_type)) ||
                      string.IsNullOrEmpty(_sChange_payment_type) && !string.IsNullOrEmpty(_sChange_payment_type))
                    {
                        edfField[61, 1] = "1";
                        edfField[61, 2] = _sChange_payment_type;
                        edfField[61, 3] = _sMP_CARD_OWNER;
                    }

                    string _sMP_3_PARTY_NAME = _oSundayActivation.GetMP_3_PARTY_NAME().Trim().ToUpper();
                    string _sM_card_type = _oMobileRetentionOrder.GetM_card_type().Trim().ToUpper();

                    if (!_sMP_3_PARTY_NAME.Equals(_sM_card_type) ||
                       (!string.IsNullOrEmpty(_sM_card_type) && string.IsNullOrEmpty(_sM_card_type)) ||
                      string.IsNullOrEmpty(_sM_card_type) && !string.IsNullOrEmpty(_sM_card_type))
                    {
                        edfField[62, 1] = "1";
                        edfField[62, 2] = _sM_card_type;
                        edfField[62, 3] = _sMP_3_PARTY_NAME;
                    }

                    string _sMP_CARDNO = _oSundayActivation.GetMP_CARDNO();
                    string _sM_card_no = _oMobileRetentionOrder.GetM_card_no();
                    string _sBank_code = _oMobileRetentionOrder.GetMonthly_bank_account_bank_code() + " " +
                            _oMobileRetentionOrder.GetMonthly_bank_account_branch_code() + " " +
                            _oMobileRetentionOrder.GetMonthly_bank_account_no();

                    if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetM_card_no()))
                        _sM_card_no = _oMobileRetentionOrder.GetM_card_no();
                    else if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetMonthly_bank_account_bank_code().Trim()) &&
                    !string.IsNullOrEmpty(_oMobileRetentionOrder.GetMonthly_bank_account_branch_code().Trim()) &&
                    !string.IsNullOrEmpty(_oMobileRetentionOrder.GetMonthly_bank_account_no().Trim()))
                    {
                        _sM_card_no = _sBank_code;
                    }

                    if (!_sMP_CARDNO.Equals(_sM_card_no) ||
                       (!string.IsNullOrEmpty(_sM_card_no) && string.IsNullOrEmpty(_sM_card_no)) ||
                      string.IsNullOrEmpty(_sM_card_no) && !string.IsNullOrEmpty(_sM_card_no))
                    {
                        edfField[63, 1] = "1";
                        edfField[63, 2] = _sM_card_no;
                        edfField[63, 3] = _sMP_CARDNO;
                    }

                    string _sMP_C_HOLDER_NAME = _oSundayActivation.GetMP_C_HOLDER_NAME();
                    string _sHolder_name = string.Empty;
                    if (_oMobileRetentionOrder.GetMonthly_payment_type().ToUpper().Equals("CHANGE TO CREDIT CARD"))
                        _sHolder_name = _oMobileRetentionOrder.GetM_card_holder2();
                    else if (_oMobileRetentionOrder.GetMonthly_payment_type().ToUpper().Equals("CHANGE TO BANK ACCOUNT"))
                        _sHolder_name = _oMobileRetentionOrder.GetMonthly_bank_account_holder();


                    if (!_sMP_C_HOLDER_NAME.Equals(_sHolder_name) ||
                       (!string.IsNullOrEmpty(_sHolder_name) && string.IsNullOrEmpty(_sHolder_name)) ||
                      string.IsNullOrEmpty(_sHolder_name) && !string.IsNullOrEmpty(_sHolder_name))
                    {
                        edfField[64, 1] = "1";
                        edfField[64, 2] = _sHolder_name;
                        edfField[64, 3] = _sMP_C_HOLDER_NAME;
                    }

                    string _sMP_3_PARTY_ID = _oSundayActivation.GetMP_3_PARTY_ID();
                    string _sMonthly_bank_account_hkid = _oMobileRetentionOrder.GetMonthly_bank_account_hkid() + _oMobileRetentionOrder.GetMonthly_bank_account_hkid2();

                    if (!_sMP_3_PARTY_ID.Equals(_sMonthly_bank_account_hkid) ||
                       (!string.IsNullOrEmpty(_sMonthly_bank_account_hkid) && string.IsNullOrEmpty(_sMonthly_bank_account_hkid)) ||
                      string.IsNullOrEmpty(_sMonthly_bank_account_hkid) && !string.IsNullOrEmpty(_sMonthly_bank_account_hkid))
                    {
                        edfField[65, 1] = "1";
                        edfField[65, 2] = _sMonthly_bank_account_hkid;
                        edfField[65, 3] = _sMP_3_PARTY_ID;
                    }

                    string _sMP_EXPIRYDATE = _oSundayActivation.GetMP_EXPIRYDATE();
                    string _sM_card_exp_year = string.Empty;
                    if (_oMobileRetentionOrder.GetM_card_exp_year().Length >= 4)
                        _sM_card_exp_year = _oMobileRetentionOrder.GetM_card_exp_year().Substring(2, 2);

                    string _sM_card_exp_monthM_card_exp_year = _oMobileRetentionOrder.GetM_card_exp_month() + _sM_card_exp_year;


                    if (!_sMP_EXPIRYDATE.Equals(_sM_card_exp_monthM_card_exp_year) ||
                       (!string.IsNullOrEmpty(_sM_card_exp_monthM_card_exp_year) && string.IsNullOrEmpty(_sM_card_exp_monthM_card_exp_year)) ||
                      string.IsNullOrEmpty(_sM_card_exp_monthM_card_exp_year) && !string.IsNullOrEmpty(_sM_card_exp_monthM_card_exp_year))
                    {
                        edfField[66, 1] = "1";
                        edfField[66, 2] = _sM_card_exp_monthM_card_exp_year;
                        edfField[66, 3] = _sMP_EXPIRYDATE;
                    }

                    string _sCUSTOMER_GROUP = _oSundayActivation.GetCUSTOMER_GROUP().Trim().ToUpper();
                    string _sBill_medium = string.Empty;
                    if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetBill_medium()))
                    {
                        if (_oMobileRetentionOrder.GetBill_medium().Equals("0"))
                            _sBill_medium = "SMS bill $0".Trim().ToUpper();
                        else if (_oMobileRetentionOrder.GetBill_medium().Equals("1"))
                            _sBill_medium = "Email bill $0".Trim().ToUpper();
                        else if (_oMobileRetentionOrder.GetBill_medium().Equals("2"))
                            _sBill_medium = "Paper bill $10".Trim().ToUpper();
                        else if (_oMobileRetentionOrder.GetBill_medium().Equals("3"))
                            _sBill_medium = "SMS bill $0 + Email bill $0".Trim().ToUpper();
                    }

                    if (!_sCUSTOMER_GROUP.Equals(_sBill_medium) ||
                       (!string.IsNullOrEmpty(_sBill_medium) && string.IsNullOrEmpty(_sBill_medium)) ||
                      string.IsNullOrEmpty(_sBill_medium) && !string.IsNullOrEmpty(_sBill_medium))
                    {
                        edfField[67, 1] = "1";
                        edfField[67, 2] = _sBill_medium;
                        edfField[67, 3] = _sCUSTOMER_GROUP;
                    }

                    string _sSMS_SUPPRESS = _oSundayActivation.GetSMS_SUPPRESS();
                    string _sSms_mrt = _oMobileRetentionOrder.GetSms_mrt();

                    if (!_sSMS_SUPPRESS.Equals(_sSms_mrt) ||
                       (!string.IsNullOrEmpty(_sSms_mrt) && string.IsNullOrEmpty(_sSms_mrt)) ||
                      string.IsNullOrEmpty(_sSms_mrt) && !string.IsNullOrEmpty(_sSms_mrt))
                    {
                        edfField[68, 1] = "1";
                        edfField[68, 2] = _sSms_mrt;
                        edfField[68, 3] = _sSMS_SUPPRESS;
                    }

                    string _sEMAIL = _oSundayActivation.GetEMAIL();
                    string _sBill_medium_email = _oMobileRetentionOrder.GetBill_medium_email();

                    if (!_sEMAIL.Equals(_sBill_medium_email) ||
                       (!string.IsNullOrEmpty(_sBill_medium_email) && string.IsNullOrEmpty(_sBill_medium_email)) ||
                      string.IsNullOrEmpty(_sBill_medium_email) && !string.IsNullOrEmpty(_sBill_medium_email))
                    {
                        edfField[69, 1] = "1";
                        edfField[69, 2] = _sBill_medium_email;
                        edfField[69, 3] = _sEMAIL;
                    }


                    string _sBILL_ADDRESS_1 = _oSundayActivation.GetBILL_ADDRESS_1();
                    /*
                    string _sBilling_Address =
                        (_oBillingAddress.GetD_type() + " " + _oBillingAddress.GetD_room() + " "
                        + _oBillingAddress.GetD_floor() + " " + ((!string.IsNullOrEmpty(_oBillingAddress.GetD_floor())) ? " FLOOR " : "")
                        + ((!string.IsNullOrEmpty(_oBillingAddress.GetD_blk())) ? " BLOCK " : "") + _oBillingAddress.GetD_blk() + " "
                        + _oBillingAddress.GetD_build() + " " + _oBillingAddress.GetD_street() + " " + _oBillingAddress.GetD_district() + " " + MobileOrderAddressBal.GetRegionDesc(_oBillingAddress.GetD_region())).Trim().ToUpper();
                    */
                    string _sBilling_Address = MobileOrderAddressBal.GetAddress(_oBillingAddress).Trim().ToUpper();
                    if (!_sBILL_ADDRESS_1.Equals(_sBilling_Address) ||
                       (!string.IsNullOrEmpty(_sBilling_Address) && string.IsNullOrEmpty(_sBilling_Address)) ||
                      string.IsNullOrEmpty(_sBilling_Address) && !string.IsNullOrEmpty(_sBilling_Address))
                    {
                        edfField[70, 1] = "1";
                        edfField[70, 2] = _sBilling_Address;
                        edfField[70, 3] = _sBILL_ADDRESS_1;
                    }

                    string _sEMAIL_BILL = _oSundayActivation.GetEMAIL_BILL();
                    string _sBill_medium_waive = ((_oMobileRetentionOrder.GetBill_medium_waive() == true) ? "1" : "0");
                    if (!_sEMAIL_BILL.Equals(_sBill_medium_waive) ||
                       (!string.IsNullOrEmpty(_sBill_medium_waive) && string.IsNullOrEmpty(_sBill_medium_waive)) ||
                      string.IsNullOrEmpty(_sBill_medium_waive) && !string.IsNullOrEmpty(_sBill_medium_waive))
                    {
                        edfField[71, 1] = "1";
                        edfField[71, 2] = _sBill_medium_waive;
                        edfField[71, 3] = _sEMAIL_BILL;
                    }

                    string _sPAYMENT_TYPE = _oSundayActivation.GetPAYMENT_TYPE();
                    string _sPrepayment = ((_oMobileRetentionOrder.GetPrepayment_waive() == true) ? "1" : "0");
                    if (!_sEMAIL_BILL.Equals(_sBill_medium_waive) ||
                       (!string.IsNullOrEmpty(_sBill_medium_waive) && string.IsNullOrEmpty(_sBill_medium_waive)) ||
                      string.IsNullOrEmpty(_sBill_medium_waive) && !string.IsNullOrEmpty(_sBill_medium_waive))
                    {
                        edfField[72, 1] = "1";
                        edfField[72, 2] = _sPrepayment;
                        edfField[72, 3] = _sPAYMENT_TYPE;
                    }

                    string _sSTUDENT_BIRTH_D = _oSundayActivation.GetSTUDENT_BIRTH_D();
                    string _sExtra_rebate = _oMobileRetentionOrder.GetExtra_rebate();
                    if (!_sSTUDENT_BIRTH_D.Equals(_sExtra_rebate) ||
                       (!string.IsNullOrEmpty(_sExtra_rebate) && string.IsNullOrEmpty(_sExtra_rebate)) ||
                      string.IsNullOrEmpty(_sExtra_rebate) && !string.IsNullOrEmpty(_sExtra_rebate))
                    {
                        edfField[73, 1] = "1";
                        edfField[73, 2] = _sExtra_rebate;
                        edfField[73, 3] = _sSTUDENT_BIRTH_D;
                    }

                    string _sBILL_CU_NAME = _oSundayActivation.GetBILL_CU_NAME();
                    string _sCompany_name = _oMobileOrderMNPDetail.GetCompany_name();
                    if (!_sBILL_CU_NAME.Equals(_sCompany_name) ||
                       (!string.IsNullOrEmpty(_sCompany_name) && string.IsNullOrEmpty(_sCompany_name)) ||
                      string.IsNullOrEmpty(_sCompany_name) && !string.IsNullOrEmpty(_sCompany_name))
                    {
                        edfField[74, 1] = "1";
                        edfField[74, 2] = _sCompany_name;
                        edfField[74, 3] = _sBILL_CU_NAME;
                    }

                    string _sN2_REGISTERED_NAME = _oSundayActivation.GetN2_REGISTERED_NAME();
                    string _sRegistered_name = _oMobileOrderMNPDetail.GetRegistered_name();
                    if (!_sN2_REGISTERED_NAME.Equals(_sRegistered_name) ||
                       (!string.IsNullOrEmpty(_sRegistered_name) && string.IsNullOrEmpty(_sRegistered_name)) ||
                      string.IsNullOrEmpty(_sRegistered_name) && !string.IsNullOrEmpty(_sRegistered_name))
                    {
                        edfField[75, 1] = "1";
                        edfField[75, 2] = _sRegistered_name;
                        edfField[75, 3] = _sN2_REGISTERED_NAME;
                    }

                    string _sTICKET_NO = _oSundayActivation.GetTICKET_NO();
                    string _sTicker_number = _oMobileOrderMNPDetail.GetTicker_number();
                    if (!_sTICKET_NO.Equals(_sTicker_number) ||
                       (!string.IsNullOrEmpty(_sTicker_number) && string.IsNullOrEmpty(_sTicker_number)) ||
                      string.IsNullOrEmpty(_sTicker_number) && !string.IsNullOrEmpty(_sTicker_number))
                    {
                        edfField[76, 1] = "1";
                        edfField[76, 2] = _sTicker_number;
                        edfField[76, 3] = _sTICKET_NO;
                    }

                    string _sADDRESS_1 = _oSundayActivation.GetADDRESS_1().Trim().ToUpper();
                    string _sRegisteredAddress = MobileOrderAddressBal.GetAddress(_oRegisteredAddress).Trim().ToUpper();

                    if (!_sADDRESS_1.Equals(_sRegisteredAddress) ||
                       (!string.IsNullOrEmpty(_sRegisteredAddress) && string.IsNullOrEmpty(_sRegisteredAddress)) ||
                      string.IsNullOrEmpty(_sRegisteredAddress) && !string.IsNullOrEmpty(_sRegisteredAddress))
                    {
                        edfField[77, 1] = "1";
                        edfField[77, 2] = _sRegisteredAddress;
                        edfField[77, 3] = _sADDRESS_1;
                    }

                    string _sIDD = Func.FR(_oReader["VAS1"]).Trim();
                    string _sIDD2 = FindVasValue1("idd_normal_vas");

                    if (!_sIDD.Equals(_sIDD2) ||
                       (!string.IsNullOrEmpty(_sIDD2) && string.IsNullOrEmpty(_sIDD2)) ||
                      string.IsNullOrEmpty(_sIDD2) && !string.IsNullOrEmpty(_sIDD2))
                    {
                        edfField[78, 1] = "1";
                        edfField[78, 2] = _sIDD2;
                        edfField[78, 3] = _sIDD;
                    }

                    string _sMOB0060 = Func.FR(_oReader["VAS1"]).Trim();
                    string _sMOB00602 = FindVasValue1("idd0060_vas");

                    if (!_sMOB0060.Equals(_sMOB00602) ||
                       (!string.IsNullOrEmpty(_sMOB00602) && string.IsNullOrEmpty(_sMOB00602)) ||
                      string.IsNullOrEmpty(_sMOB00602) && !string.IsNullOrEmpty(_sMOB00602))
                    {
                        edfField[79, 1] = "1";
                        edfField[79, 2] = _sMOB00602;
                        edfField[79, 3] = _sMOB0060;
                    }

                    string _sRoaming = Func.FR(_oReader["VAS3"]).Trim();
                    string _sRoaming2 = FindVasValue1("roaming_vas");

                    if (!_sRoaming.Equals(_sRoaming2) ||
                       (!string.IsNullOrEmpty(_sRoaming2) && string.IsNullOrEmpty(_sRoaming2)) ||
                      string.IsNullOrEmpty(_sRoaming2) && !string.IsNullOrEmpty(_sRoaming2))
                    {
                        edfField[80, 1] = "1";
                        edfField[80, 2] = _sRoaming2;
                        edfField[80, 3] = _sRoaming;
                    }

                    string _sMobileInternetPackage = Func.FR(_oReader["VAS4"]).Trim();
                    string _sMobileInternetPackage2 = FindVasValue1("net_vas");

                    if (!_sMobileInternetPackage.Equals(_sMobileInternetPackage2) ||
                       (!string.IsNullOrEmpty(_sMobileInternetPackage2) && string.IsNullOrEmpty(_sMobileInternetPackage2)) ||
                      string.IsNullOrEmpty(_sMobileInternetPackage2) && !string.IsNullOrEmpty(_sMobileInternetPackage2))
                    {
                        edfField[81, 1] = "1";
                        edfField[81, 2] = _sMobileInternetPackage2;
                        edfField[81, 3] = _sMobileInternetPackage;
                    }

                    string _sSMS = Func.FR(_oReader["VAS5"]).Trim();
                    string _sSMS2 = FindVasValue1("sms_vas");

                    if (!_sSMS.Equals(_sSMS2) ||
                       (!string.IsNullOrEmpty(_sSMS2) && string.IsNullOrEmpty(_sSMS2)) ||
                      string.IsNullOrEmpty(_sSMS2) && !string.IsNullOrEmpty(_sSMS2))
                    {
                        edfField[82, 1] = "1";
                        edfField[82, 2] = _sSMS2;
                        edfField[82, 3] = _sSMS;
                    }

                    string _sSS_Language = Func.FR(_oReader["SS_LANGUAGE"]).Trim();
                    string _sLanguage = _oMobileRetentionOrder.GetLanguage();

                    if (!_sSS_Language.Equals(_sLanguage) ||
                       (!string.IsNullOrEmpty(_sLanguage) && string.IsNullOrEmpty(_sLanguage)) ||
                      string.IsNullOrEmpty(_sLanguage) && !string.IsNullOrEmpty(_sLanguage))
                    {
                        edfField[83, 1] = "1";
                        edfField[83, 2] = _sLanguage;
                        edfField[83, 3] = _sSS_Language;
                    }


                    string _sAGREEMENT_DATE = _oSundayActivation.GetAGREEMENT_DATE();
                    string _sService_Activation_DateAM = _oMobileOrderMNPDetail.GetService_activation_time();

                    if (!_sAGREEMENT_DATE.Equals(_sService_Activation_DateAM) ||
                       (!string.IsNullOrEmpty(_sService_Activation_DateAM) && string.IsNullOrEmpty(_sService_Activation_DateAM)) ||
                      string.IsNullOrEmpty(_sService_Activation_DateAM) && !string.IsNullOrEmpty(_sService_Activation_DateAM))
                    {
                        edfField[84, 1] = "1";
                        edfField[84, 2] = _sService_Activation_DateAM;
                        edfField[84, 3] = _sAGREEMENT_DATE;
                    }

                    string _sAGREEMENT_NO = _oSundayActivation.GetAGREEMENT_NO();
                    string _sMonthly_bank_account_id_type = _oMobileRetentionOrder.GetMonthly_bank_account_id_type();

                    if (!_sAGREEMENT_NO.Equals(_sMonthly_bank_account_id_type) ||
                       (!string.IsNullOrEmpty(_sMonthly_bank_account_id_type) && string.IsNullOrEmpty(_sMonthly_bank_account_id_type)) ||
                      string.IsNullOrEmpty(_sMonthly_bank_account_id_type) && !string.IsNullOrEmpty(_sMonthly_bank_account_id_type))
                    {
                        edfField[85, 1] = "1";
                        edfField[85, 2] = _sMonthly_bank_account_id_type;
                        edfField[85, 3] = _sAGREEMENT_NO;
                    }

                    string _sREGION_CITY = _oSundayActivation.GetREGION_CITY();
                    string _sRebate = _oMobileRetentionOrder.GetRebate();

                    if (!_sREGION_CITY.Equals(_sRebate) ||
                       (!string.IsNullOrEmpty(_sRebate) && string.IsNullOrEmpty(_sRebate)) ||
                      string.IsNullOrEmpty(_sRebate) && !string.IsNullOrEmpty(_sRebate))
                    {
                        edfField[86, 1] = "1";
                        edfField[86, 2] = _sRebate;
                        edfField[86, 3] = _sREGION_CITY;
                    }

                    string _sID_No_Type = _oSundayActivation.GetID_NO_TYPE();
                    string _sId_type = _oMobileOrderMNPDetail.GetId_type();

                    if (!_sID_No_Type.Equals(_sId_type) ||
                       (!string.IsNullOrEmpty(_sId_type) && string.IsNullOrEmpty(_sId_type)) ||
                      string.IsNullOrEmpty(_sId_type) && !string.IsNullOrEmpty(_sId_type))
                    {
                        edfField[87, 1] = "1";
                        edfField[87, 2] = _sId_type;
                        edfField[87, 3] = _sID_No_Type;
                    }

                    string _sID_no = _oSundayActivation.GetID_NO();
                    string _sHkid = _oMobileOrderMNPDetail.GetHkid();

                    if (!_sID_no.Equals(_sHkid) ||
                       (!string.IsNullOrEmpty(_sHkid) && string.IsNullOrEmpty(_sHkid)) ||
                      string.IsNullOrEmpty(_sHkid) && !string.IsNullOrEmpty(_sHkid))
                    {
                        edfField[88, 1] = "1";
                        edfField[88, 2] = _sHkid;
                        edfField[88, 3] = _sID_no;
                    }

                    string _sPREMIUM_GIFT2 = Func.FR(_oReader["PREMIUM_GIFT2"]).Trim();
                    string _sAction_of_rate_plan_effective = _oMobileRetentionOrder.GetAction_of_rate_plan_effective();

                    if (!_sPREMIUM_GIFT2.Equals(_sAction_of_rate_plan_effective) ||
                       (!string.IsNullOrEmpty(_sAction_of_rate_plan_effective) && string.IsNullOrEmpty(_sAction_of_rate_plan_effective)) ||
                      string.IsNullOrEmpty(_sAction_of_rate_plan_effective) && !string.IsNullOrEmpty(_sAction_of_rate_plan_effective))
                    {
                        edfField[89, 1] = "1";
                        edfField[89, 2] = _sAction_of_rate_plan_effective;
                        edfField[89, 3] = _sPREMIUM_GIFT2;
                    }

                    string _sBILL_ADDRESS_3 = _oSundayActivation.GetBILL_ADDRESS_3();
                    string _sUpgrade_handset_offer_rebate_schedule = _oMobileRetentionOrder.GetUpgrade_handset_offer_rebate_schedule();

                    if (!_sBILL_ADDRESS_3.Equals(_sUpgrade_handset_offer_rebate_schedule) ||
                       (!string.IsNullOrEmpty(_sUpgrade_handset_offer_rebate_schedule) && string.IsNullOrEmpty(_sUpgrade_handset_offer_rebate_schedule)) ||
                      string.IsNullOrEmpty(_sUpgrade_handset_offer_rebate_schedule) && !string.IsNullOrEmpty(_sUpgrade_handset_offer_rebate_schedule))
                    {
                        edfField[90, 1] = "1";
                        edfField[90, 2] = _sUpgrade_handset_offer_rebate_schedule;
                        edfField[90, 3] = _sBILL_ADDRESS_3;
                    }

                    string _sBANK_ACCOUNT = _oSundayActivation.GetBANK_ACCOUNT();
                    string _sUpgrade_existing_customer_type = _oMobileRetentionOrder.GetUpgrade_existing_customer_type();

                    if (!_sBANK_ACCOUNT.Equals(_sUpgrade_existing_customer_type) ||
                       (!string.IsNullOrEmpty(_sUpgrade_existing_customer_type) && string.IsNullOrEmpty(_sUpgrade_existing_customer_type)) ||
                      string.IsNullOrEmpty(_sUpgrade_existing_customer_type) && !string.IsNullOrEmpty(_sUpgrade_existing_customer_type))
                    {
                        edfField[91, 1] = "1";
                        edfField[91, 2] = _sUpgrade_existing_customer_type;
                        edfField[91, 3] = _sBANK_ACCOUNT;
                    }

                    string _sCREATE_DATE =
                        ((_oSundayActivation.GetCREATE_DATE() != null) ? ((DateTime)_oSundayActivation.GetCREATE_DATE()).ToString("dd/MM/yyyy") : string.Empty);

                    string _sCREATE_DATE2 =
                        ((_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate() != null) ?
                        ((DateTime)_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate()).ToString("dd/MM/yyyy").Trim() :
                        string.Empty);

                    if (!_sCREATE_DATE.Equals(_sCREATE_DATE2) ||
                       (!string.IsNullOrEmpty(_sCREATE_DATE2) && string.IsNullOrEmpty(_sCREATE_DATE2)) ||
                      string.IsNullOrEmpty(_sCREATE_DATE2) && !string.IsNullOrEmpty(_sCREATE_DATE2))
                    {
                        edfField[92, 1] = "1";
                        edfField[92, 2] = _sCREATE_DATE2;
                        edfField[92, 3] = _sCREATE_DATE;
                    }

                    string _sSMARK_EXP_DATE =
                        ((_oSundayActivation.GetSMARK_EXP_DATE() != null) ? ((DateTime)_oSundayActivation.GetSMARK_EXP_DATE()).ToString("dd/MM/yyyy") : string.Empty);

                    string _sSMARK_EXP_DATE2 =
                        ((_oMobileRetentionOrder.GetUpgrade_existing_contract_edate() != null) ?
                        ((DateTime)_oMobileRetentionOrder.GetUpgrade_existing_contract_edate()).ToString("dd/MM/yyyy").Trim() :
                        string.Empty);

                    if (!_sSMARK_EXP_DATE.Equals(_sSMARK_EXP_DATE2) ||
                       (!string.IsNullOrEmpty(_sSMARK_EXP_DATE2) && string.IsNullOrEmpty(_sSMARK_EXP_DATE2)) ||
                      string.IsNullOrEmpty(_sSMARK_EXP_DATE2) && !string.IsNullOrEmpty(_sSMARK_EXP_DATE2))
                    {
                        edfField[93, 1] = "1";
                        edfField[93, 2] = _sSMARK_EXP_DATE2;
                        edfField[93, 3] = _sSMARK_EXP_DATE;
                    }

                    string _sPREPAID_SIM_TO_POSTPAID = _oSundayActivation.GetPREPAID_SIM_TO_POSTPAID();
                    string _sUpgrade_existing_pccw_customer = _oMobileRetentionOrder.GetUpgrade_existing_pccw_customer();

                    if (!_sPREPAID_SIM_TO_POSTPAID.Equals(_sUpgrade_existing_pccw_customer) ||
                       (!string.IsNullOrEmpty(_sUpgrade_existing_pccw_customer) && string.IsNullOrEmpty(_sUpgrade_existing_pccw_customer)) ||
                      string.IsNullOrEmpty(_sUpgrade_existing_pccw_customer) && !string.IsNullOrEmpty(_sUpgrade_existing_pccw_customer))
                    {
                        edfField[94, 1] = "1";
                        edfField[94, 2] = _sUpgrade_existing_pccw_customer;
                        edfField[94, 3] = _sPREPAID_SIM_TO_POSTPAID;
                    }

                    string _sOLD_SUB_HK_ID = _oSundayActivation.GetOLD_SUB_HK_ID();
                    string _sUpgrade_service_account_no = _oMobileRetentionOrder.GetUpgrade_service_account_no();

                    if (!_sOLD_SUB_HK_ID.Equals(_sUpgrade_service_account_no) ||
                       (!string.IsNullOrEmpty(_sUpgrade_service_account_no) && string.IsNullOrEmpty(_sUpgrade_service_account_no)) ||
                      string.IsNullOrEmpty(_sUpgrade_service_account_no) && !string.IsNullOrEmpty(_sUpgrade_service_account_no))
                    {
                        edfField[95, 1] = "1";
                        edfField[95, 2] = _sUpgrade_service_account_no;
                        edfField[95, 3] = _sOLD_SUB_HK_ID;
                    }

                    string _sJOINT_PROMOTION_CODE = _oSundayActivation.GetJOINT_PROMOTION_CODE();
                    string _sUpgrade_service_tenure = _oMobileRetentionOrder.GetUpgrade_service_tenure();

                    if (!_sJOINT_PROMOTION_CODE.Equals(_sUpgrade_service_tenure) ||
                       (!string.IsNullOrEmpty(_sUpgrade_service_tenure) && string.IsNullOrEmpty(_sUpgrade_service_tenure)) ||
                      string.IsNullOrEmpty(_sUpgrade_service_tenure) && !string.IsNullOrEmpty(_sUpgrade_service_tenure))
                    {
                        edfField[96, 1] = "1";
                        edfField[96, 2] = _sUpgrade_service_tenure;
                        edfField[96, 3] = _sJOINT_PROMOTION_CODE;
                    }

                    string _sHANDSET_DESC = _oSundayActivation.GetHANDSET_DESC();
                    string _sExisting_smart_phone_model = _oMobileRetentionOrder.GetExisting_smart_phone_model();

                    if (!_sHANDSET_DESC.Equals(_sExisting_smart_phone_model) ||
                       (!string.IsNullOrEmpty(_sExisting_smart_phone_model) && string.IsNullOrEmpty(_sExisting_smart_phone_model)) ||
                      string.IsNullOrEmpty(_sExisting_smart_phone_model) && !string.IsNullOrEmpty(_sExisting_smart_phone_model))
                    {
                        edfField[97, 1] = "1";
                        edfField[97, 2] = _sExisting_smart_phone_model;
                        edfField[97, 3] = _sHANDSET_DESC;
                    }

                    string _sIMEI = _oSundayActivation.GetIMEI();
                    string _sExisting_smart_phone_imei = _oMobileRetentionOrder.GetExisting_smart_phone_imei();

                    if (!_sIMEI.Equals(_sExisting_smart_phone_imei) ||
                       (!string.IsNullOrEmpty(_sExisting_smart_phone_imei) && string.IsNullOrEmpty(_sExisting_smart_phone_imei)) ||
                      string.IsNullOrEmpty(_sExisting_smart_phone_imei) && !string.IsNullOrEmpty(_sExisting_smart_phone_imei))
                    {
                        edfField[98, 1] = "1";
                        edfField[98, 2] = _sExisting_smart_phone_imei;
                        edfField[98, 3] = _sIMEI;
                    }


                    string _sDOA_DATE =
                        ((_oReader["DOA_DATE"] != null && _oReader["DOA_DATE"] != System.DBNull.Value) ? ((DateTime)_oReader["DOA_DATE"]).ToString("dd/MM/yyyy") : string.Empty);

                    string _sDOA_DATE2 =
                        ((_oMobileRetentionOrder.GetBill_cut_date() != null) ?
                        ((DateTime)_oMobileRetentionOrder.GetBill_cut_date()).ToString("dd/MM/yyyy").Trim() :
                        string.Empty);

                    if (!_sDOA_DATE.Equals(_sDOA_DATE2) ||
                       (!string.IsNullOrEmpty(_sDOA_DATE2) && string.IsNullOrEmpty(_sDOA_DATE2)) ||
                      string.IsNullOrEmpty(_sDOA_DATE2) && !string.IsNullOrEmpty(_sDOA_DATE2))
                    {
                        edfField[99, 1] = "1";
                        edfField[99, 2] = _sDOA_DATE2;
                        edfField[99, 3] = _sDOA_DATE;
                    }

                    string _sPAYMENT_I_DATE =
                       ((_oReader["PAYMENT_I_DATE"] != null && _oReader["PAYMENT_I_DATE"] != System.DBNull.Value) ? ((DateTime)_oReader["PAYMENT_I_DATE"]).ToString("dd/MM/yyyy") : string.Empty);

                    string _sPAYMENT_I_DATE2 =
                        ((_oMobileRetentionOrder.GetPlan_eff_date() != null) ?
                        ((DateTime)_oMobileRetentionOrder.GetPlan_eff_date()).ToString("dd/MM/yyyy").Trim() :
                        string.Empty);

                    if (!_sPAYMENT_I_DATE.Equals(_sPAYMENT_I_DATE2) ||
                       (!string.IsNullOrEmpty(_sPAYMENT_I_DATE2) && string.IsNullOrEmpty(_sPAYMENT_I_DATE2)) ||
                      string.IsNullOrEmpty(_sPAYMENT_I_DATE2) && !string.IsNullOrEmpty(_sPAYMENT_I_DATE2))
                    {
                        edfField[100, 1] = "1";
                        edfField[100, 2] = _sPAYMENT_I_DATE2;
                        edfField[100, 3] = _sPAYMENT_I_DATE;
                    }

                    string _sFAX = _oSundayActivation.GetFAX();
                    string _sBill_cut_num = (_oMobileRetentionOrder.GetBill_cut_num() != null) ? ((int)_oMobileRetentionOrder.GetBill_cut_num()).ToString() : string.Empty;

                    if (!_sFAX.Equals(_sBill_cut_num) ||
                       (!string.IsNullOrEmpty(_sBill_cut_num) && string.IsNullOrEmpty(_sBill_cut_num)) ||
                      string.IsNullOrEmpty(_sBill_cut_num) && !string.IsNullOrEmpty(_sBill_cut_num))
                    {
                        edfField[101, 1] = "1";
                        edfField[101, 2] = _sBill_cut_num;
                        edfField[101, 3] = _sFAX;
                    }

                    string _sVAS_NAME15 = _oSundayActivation.GetVAS_NAME15();
                    string _sMonthly_payment_type = _oMobileRetentionOrder.GetMonthly_payment_type();

                    if (!_sVAS_NAME15.Equals(_sMonthly_payment_type) ||
                       (!string.IsNullOrEmpty(_sMonthly_payment_type) && string.IsNullOrEmpty(_sMonthly_payment_type)) ||
                      string.IsNullOrEmpty(_sMonthly_payment_type) && !string.IsNullOrEmpty(_sMonthly_payment_type))
                    {
                        edfField[102, 1] = "1";
                        edfField[102, 2] = _sMonthly_payment_type;
                        edfField[102, 3] = _sVAS_NAME15;
                    }

                    string _sCONTACT_PERSON = _oSundayActivation.GetCONTACT_PERSON();
                    string _sUpg_auto_vas = FindVasValue1("upg_auto_vas");

                    if (!_sCONTACT_PERSON.Equals(_sUpg_auto_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_auto_vas) && string.IsNullOrEmpty(_sUpg_auto_vas)) ||
                      string.IsNullOrEmpty(_sUpg_auto_vas) && !string.IsNullOrEmpty(_sUpg_auto_vas))
                    {
                        edfField[103, 1] = "1";
                        edfField[103, 2] = _sUpg_auto_vas;
                        edfField[103, 3] = _sCONTACT_PERSON;
                    }

                    string _sOWNER_NAME = _oSundayActivation.GetOWNER_NAME();
                    string _sUpg_con_vas = FindVasValue1("upg_con_vas");

                    if (!_sOWNER_NAME.Equals(_sUpg_con_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_con_vas) && string.IsNullOrEmpty(_sUpg_con_vas)) ||
                      string.IsNullOrEmpty(_sUpg_con_vas) && !string.IsNullOrEmpty(_sUpg_con_vas))
                    {
                        edfField[104, 1] = "1";
                        edfField[104, 2] = _sUpg_con_vas;
                        edfField[104, 3] = _sOWNER_NAME;
                    }

                    string _sBANK_NAME = _oSundayActivation.GetBANK_NAME();
                    string _sUpg_cou1_vas = FindVasValue1("upg_cou1_vas");

                    if (!_sBANK_NAME.Equals(_sUpg_cou1_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_cou1_vas) && string.IsNullOrEmpty(_sUpg_cou1_vas)) ||
                      string.IsNullOrEmpty(_sUpg_cou1_vas) && !string.IsNullOrEmpty(_sUpg_cou1_vas))
                    {
                        edfField[105, 1] = "1";
                        edfField[105, 2] = _sUpg_cou1_vas;
                        edfField[105, 3] = _sBANK_NAME;
                    }

                    string _sOLD_SUB_NAME_MNP = _oSundayActivation.GetOLD_SUB_NAME_MNP();
                    string _sUpg_data_vas = FindVasValue1("upg_data_vas");

                    if (!_sOLD_SUB_NAME_MNP.Equals(_sUpg_data_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_data_vas) && string.IsNullOrEmpty(_sUpg_data_vas)) ||
                      string.IsNullOrEmpty(_sUpg_data_vas) && !string.IsNullOrEmpty(_sUpg_data_vas))
                    {
                        edfField[106, 1] = "1";
                        edfField[106, 2] = _sUpg_data_vas;
                        edfField[106, 3] = _sOLD_SUB_NAME_MNP;
                    }

                    string _sREG_BUILDING = _oSundayActivation.GetREG_BUILDING().Trim().ToUpper();
                    string _sUpg_fin_vas = FindVasValue1("upg_fin_vas").Trim().ToUpper();

                    if (!_sREG_BUILDING.Equals(_sUpg_fin_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_fin_vas) && string.IsNullOrEmpty(_sUpg_fin_vas)) ||
                      string.IsNullOrEmpty(_sUpg_fin_vas) && !string.IsNullOrEmpty(_sUpg_fin_vas))
                    {
                        edfField[107, 1] = "1";
                        edfField[107, 2] = _sUpg_fin_vas;
                        edfField[107, 3] = _sREG_BUILDING;
                    }

                    string _sREG_ESTATE = _oSundayActivation.GetREG_ESTATE();
                    string _sUpg_gprs_vas = FindVasValue1("upg_gprs_vas");

                    if (!_sREG_ESTATE.Equals(_sUpg_gprs_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_gprs_vas) && string.IsNullOrEmpty(_sUpg_gprs_vas)) ||
                      string.IsNullOrEmpty(_sUpg_gprs_vas) && !string.IsNullOrEmpty(_sUpg_gprs_vas))
                    {
                        edfField[108, 1] = "1";
                        edfField[108, 2] = _sUpg_gprs_vas;
                        edfField[108, 3] = _sREG_ESTATE;
                    }

                    string _sREG_ST_NAME = _oSundayActivation.GetREG_ST_NAME();
                    string _sUpg_idd_vas = FindVasValue1("upg_idd_vas");

                    if (!_sREG_ST_NAME.Equals(_sUpg_idd_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_idd_vas) && string.IsNullOrEmpty(_sUpg_idd_vas)) ||
                      string.IsNullOrEmpty(_sUpg_idd_vas) && !string.IsNullOrEmpty(_sUpg_idd_vas))
                    {
                        edfField[109, 1] = "1";
                        edfField[109, 2] = _sUpg_idd_vas;
                        edfField[109, 3] = _sREG_ST_NAME;
                    }

                    string _sREG_DISTRICT = _oSundayActivation.GetREG_DISTRICT();
                    string _sUpg_lice_vas = FindVasValue1("upg_lice_vas");

                    if (!_sREG_DISTRICT.Equals(_sUpg_lice_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_lice_vas) && string.IsNullOrEmpty(_sUpg_lice_vas)) ||
                      string.IsNullOrEmpty(_sUpg_lice_vas) && !string.IsNullOrEmpty(_sUpg_lice_vas))
                    {
                        edfField[110, 1] = "1";
                        edfField[110, 2] = _sUpg_lice_vas;
                        edfField[110, 3] = _sREG_DISTRICT;
                    }

                    string _sBIL_BUILDING = _oSundayActivation.GetBIL_BUILDING();
                    string _sUpg_min_vas = FindVasValue1("upg_min_vas");

                    if (!_sBIL_BUILDING.Equals(_sUpg_min_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_min_vas) && string.IsNullOrEmpty(_sUpg_min_vas)) ||
                      string.IsNullOrEmpty(_sUpg_min_vas) && !string.IsNullOrEmpty(_sUpg_min_vas))
                    {
                        edfField[111, 1] = "1";
                        edfField[111, 2] = _sUpg_min_vas;
                        edfField[111, 3] = _sBIL_BUILDING;
                    }

                    string _sBIL_ESTATE = _oSundayActivation.GetBIL_ESTATE();
                    string _sUpg_moov_vas = FindVasValue1("upg_moov_vas");

                    if (!_sBIL_ESTATE.Equals(_sUpg_moov_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_moov_vas) && string.IsNullOrEmpty(_sUpg_moov_vas)) ||
                      string.IsNullOrEmpty(_sUpg_moov_vas) && !string.IsNullOrEmpty(_sUpg_moov_vas))
                    {
                        edfField[112, 1] = "1";
                        edfField[112, 2] = _sUpg_moov_vas;
                        edfField[112, 3] = _sBIL_ESTATE;
                    }

                    string _sBIL_ST_NAME = _oSundayActivation.GetBIL_ST_NAME();
                    string _sUpg_net_vas = FindVasValue1("upg_net_vas");

                    if (!_sBIL_ST_NAME.Equals(_sUpg_net_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_net_vas) && string.IsNullOrEmpty(_sUpg_net_vas)) ||
                      string.IsNullOrEmpty(_sUpg_net_vas) && !string.IsNullOrEmpty(_sUpg_net_vas))
                    {
                        edfField[113, 1] = "1";
                        edfField[113, 2] = _sUpg_net_vas;
                        edfField[113, 3] = _sBIL_ST_NAME;
                    }

                    string _sBIL_DISTRICT = _oSundayActivation.GetBIL_DISTRICT();
                    string _sUpg_now_vas = FindVasValue1("upg_now_vas");

                    if (!_sBIL_DISTRICT.Equals(_sUpg_now_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_now_vas) && string.IsNullOrEmpty(_sUpg_now_vas)) ||
                      string.IsNullOrEmpty(_sUpg_now_vas) && !string.IsNullOrEmpty(_sUpg_now_vas))
                    {
                        edfField[114, 1] = "1";
                        edfField[114, 2] = _sUpg_now_vas;
                        edfField[114, 3] = _sBIL_DISTRICT;
                    }

                    string _sVAS_NAME1 = _oSundayActivation.GetVAS_NAME1();
                    string _sUpg_oth1_vas = FindVasValue1("upg_oth1_vas");

                    if (!_sVAS_NAME1.Equals(_sUpg_oth1_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_oth1_vas) && string.IsNullOrEmpty(_sUpg_oth1_vas)) ||
                      string.IsNullOrEmpty(_sUpg_oth1_vas) && !string.IsNullOrEmpty(_sUpg_oth1_vas))
                    {
                        edfField[115, 1] = "1";
                        edfField[115, 2] = _sUpg_oth1_vas;
                        edfField[115, 3] = _sVAS_NAME1;
                    }

                    string _sVAS_NAME2 = _oSundayActivation.GetVAS_NAME2();
                    string _sUpg_oth2_vas = FindVasValue1("upg_oth2_vas");

                    if (!_sVAS_NAME2.Equals(_sUpg_oth2_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_oth2_vas) && string.IsNullOrEmpty(_sUpg_oth2_vas)) ||
                      string.IsNullOrEmpty(_sUpg_oth2_vas) && !string.IsNullOrEmpty(_sUpg_oth2_vas))
                    {
                        edfField[116, 1] = "1";
                        edfField[116, 2] = _sUpg_oth2_vas;
                        edfField[116, 3] = _sVAS_NAME2;
                    }

                    string _sVAS_NAME3 = _oSundayActivation.GetVAS_NAME3();
                    string _sUpg_oth3_vas = FindVasValue1("upg_oth3_vas");

                    if (!_sVAS_NAME3.Equals(_sUpg_oth3_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_oth3_vas) && string.IsNullOrEmpty(_sUpg_oth3_vas)) ||
                      string.IsNullOrEmpty(_sUpg_oth3_vas) && !string.IsNullOrEmpty(_sUpg_oth3_vas))
                    {
                        edfField[117, 1] = "1";
                        edfField[117, 2] = _sUpg_oth3_vas;
                        edfField[117, 3] = _sVAS_NAME3;
                    }

                    string _sVAS_NAME4 = _oSundayActivation.GetVAS_NAME4();
                    string _sUpg_oth4_vas = FindVasValue1("upg_oth4_vas");

                    if (!_sVAS_NAME4.Equals(_sUpg_oth4_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_oth4_vas) && string.IsNullOrEmpty(_sUpg_oth4_vas)) ||
                      string.IsNullOrEmpty(_sUpg_oth4_vas) && !string.IsNullOrEmpty(_sUpg_oth4_vas))
                    {
                        edfField[118, 1] = "1";
                        edfField[118, 2] = _sUpg_oth4_vas;
                        edfField[118, 3] = _sVAS_NAME4;
                    }

                    string _sVAS_NAME5 = _oSundayActivation.GetVAS_NAME5();
                    string _sUpg_oth5_vas = FindVasValue1("upg_oth5_vas");

                    if (!_sVAS_NAME5.Equals(_sUpg_oth5_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_oth5_vas) && string.IsNullOrEmpty(_sUpg_oth5_vas)) ||
                      string.IsNullOrEmpty(_sUpg_oth5_vas) && !string.IsNullOrEmpty(_sUpg_oth5_vas))
                    {
                        edfField[119, 1] = "1";
                        edfField[119, 2] = _sUpg_oth5_vas;
                        edfField[119, 3] = _sVAS_NAME5;
                    }

                    string _sVAS_NAME6 = _oSundayActivation.GetVAS_NAME6();
                    string _sUpg_oth6_vas = FindVasValue1("upg_oth6_vas");

                    if (!_sVAS_NAME6.Equals(_sUpg_oth6_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_oth6_vas) && string.IsNullOrEmpty(_sUpg_oth6_vas)) ||
                      string.IsNullOrEmpty(_sUpg_oth6_vas) && !string.IsNullOrEmpty(_sUpg_oth6_vas))
                    {
                        edfField[120, 1] = "1";
                        edfField[120, 2] = _sUpg_oth6_vas;
                        edfField[120, 3] = _sVAS_NAME6;
                    }

                    string _sVAS_NAME7 = _oSundayActivation.GetVAS_NAME7();
                    string _sUpg_sec_vas = FindVasValue1("upg_sec_vas");

                    if (!_sVAS_NAME7.Equals(_sUpg_sec_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_sec_vas) && string.IsNullOrEmpty(_sUpg_sec_vas)) ||
                      string.IsNullOrEmpty(_sUpg_sec_vas) && !string.IsNullOrEmpty(_sUpg_sec_vas))
                    {
                        edfField[121, 1] = "1";
                        edfField[121, 2] = _sUpg_sec_vas;
                        edfField[121, 3] = _sVAS_NAME7;
                    }

                    string _sVAS_NAME8 = _oSundayActivation.GetVAS_NAME8();
                    string _sUpg_sms1_vas = FindVasValue1("upg_sms1_vas");

                    if (!_sVAS_NAME8.Equals(_sUpg_sms1_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_sms1_vas) && string.IsNullOrEmpty(_sUpg_sms1_vas)) ||
                      string.IsNullOrEmpty(_sUpg_sms1_vas) && !string.IsNullOrEmpty(_sUpg_sms1_vas))
                    {
                        edfField[122, 1] = "1";
                        edfField[122, 2] = _sUpg_sms1_vas;
                        edfField[122, 3] = _sVAS_NAME8;
                    }

                    string _sVAS_NAME9 = _oSundayActivation.GetVAS_NAME9();
                    string _sUpg_sms2_vas = FindVasValue1("upg_sms2_vas");

                    if (!_sVAS_NAME9.Equals(_sUpg_sms2_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_sms2_vas) && string.IsNullOrEmpty(_sUpg_sms2_vas)) ||
                      string.IsNullOrEmpty(_sUpg_sms2_vas) && !string.IsNullOrEmpty(_sUpg_sms2_vas))
                    {
                        edfField[123, 1] = "1";
                        edfField[123, 2] = _sUpg_sms2_vas;
                        edfField[123, 3] = _sVAS_NAME9;
                    }

                    string _sVAS_NAME10 = _oSundayActivation.GetVAS_NAME10();
                    string _sUpg_sms3_vas = FindVasValue1("upg_sms3_vas");

                    if (!_sVAS_NAME10.Equals(_sUpg_sms3_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_sms3_vas) && string.IsNullOrEmpty(_sUpg_sms3_vas)) ||
                      string.IsNullOrEmpty(_sUpg_sms3_vas) && !string.IsNullOrEmpty(_sUpg_sms3_vas))
                    {
                        edfField[124, 1] = "1";
                        edfField[124, 2] = _sUpg_sms3_vas;
                        edfField[124, 3] = _sVAS_NAME10;
                    }

                    string _sVAS_NAME11 = _oSundayActivation.GetVAS_NAME11();
                    string _sUpg_smsb_vas = FindVasValue1("upg_smsb_vas");

                    if (!_sVAS_NAME11.Equals(_sUpg_smsb_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_smsb_vas) && string.IsNullOrEmpty(_sUpg_smsb_vas)) ||
                      string.IsNullOrEmpty(_sUpg_smsb_vas) && !string.IsNullOrEmpty(_sUpg_smsb_vas))
                    {
                        edfField[125, 1] = "1";
                        edfField[125, 2] = _sUpg_smsb_vas;
                        edfField[125, 3] = _sVAS_NAME11;
                    }

                    string _sVAS_NAME12 = _oSundayActivation.GetVAS_NAME12();
                    string _sUpg_spo_vas = FindVasValue1("upg_spo_vas");

                    if (!_sVAS_NAME12.Equals(_sUpg_spo_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_spo_vas) && string.IsNullOrEmpty(_sUpg_spo_vas)) ||
                      string.IsNullOrEmpty(_sUpg_spo_vas) && !string.IsNullOrEmpty(_sUpg_spo_vas))
                    {
                        edfField[126, 1] = "1";
                        edfField[126, 2] = _sUpg_spo_vas;
                        edfField[126, 3] = _sVAS_NAME12;
                    }

                    string _sVAS_NAME13 = _oSundayActivation.GetVAS_NAME13();
                    string _sUpg_sup_vas = FindVasValue1("upg_sup_vas");

                    if (!_sVAS_NAME13.Equals(_sUpg_sup_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_sup_vas) && string.IsNullOrEmpty(_sUpg_sup_vas)) ||
                      string.IsNullOrEmpty(_sUpg_sup_vas) && !string.IsNullOrEmpty(_sUpg_sup_vas))
                    {
                        edfField[127, 1] = "1";
                        edfField[127, 2] = _sUpg_sup_vas;
                        edfField[127, 3] = _sVAS_NAME13;
                    }

                    string _sVAS_NAME14 = _oSundayActivation.GetVAS_NAME14();
                    string _sUpg_wifi_vas = FindVasValue1("upg_wifi_vas");

                    if (!_sVAS_NAME14.Equals(_sUpg_wifi_vas) ||
                       (!string.IsNullOrEmpty(_sUpg_wifi_vas) && string.IsNullOrEmpty(_sUpg_wifi_vas)) ||
                      string.IsNullOrEmpty(_sUpg_wifi_vas) && !string.IsNullOrEmpty(_sUpg_wifi_vas))
                    {
                        edfField[128, 1] = "1";
                        edfField[128, 2] = _sUpg_wifi_vas;
                        edfField[128, 3] = _sVAS_NAME14;
                    }

                    string _sPAYMENT_CAT = Func.FR(_oReader["PAYMENT_CAT"]).Trim();
                    string _sCn_mrt_no = ((_oMobileRetentionOrder.GetCn_mrt_no() != null) ? ((int)_oMobileRetentionOrder.GetCn_mrt_no()).ToString() : string.Empty);

                    if (!_sPAYMENT_CAT.Equals(_sCn_mrt_no) ||
                       (!string.IsNullOrEmpty(_sCn_mrt_no) && string.IsNullOrEmpty(_sCn_mrt_no)) ||
                      string.IsNullOrEmpty(_sCn_mrt_no) && !string.IsNullOrEmpty(_sCn_mrt_no))
                    {
                        edfField[129, 1] = "1";
                        edfField[129, 2] = _sCn_mrt_no;
                        edfField[129, 3] = _sPAYMENT_CAT;
                    }


                    string _sFAMILY_REFERRAL_DN = _oSundayActivation.GetFAMILY_REFERRAL_DN();
                    string _sCard_ref_no = _oMobileRetentionOrder.GetCard_ref_no();

                    if (!_sFAMILY_REFERRAL_DN.Equals(_sCard_ref_no) ||
                       (!string.IsNullOrEmpty(_sCard_ref_no) && string.IsNullOrEmpty(_sCard_ref_no)) ||
                      string.IsNullOrEmpty(_sCard_ref_no) && !string.IsNullOrEmpty(_sCard_ref_no))
                    {
                        edfField[130, 1] = "1";
                        edfField[130, 2] = _sCard_ref_no;
                        edfField[130, 3] = _sFAMILY_REFERRAL_DN;
                    }

                    string _sStaffNo = Func.FR(_oReader["StaffNo"]).Trim();
                    string _sStaff_no = _oMobileRetentionOrder.GetStaff_no();

                    if (!_sStaffNo.Equals(_sStaff_no) ||
                       (!string.IsNullOrEmpty(_sStaff_no) && string.IsNullOrEmpty(_sStaff_no)) ||
                      string.IsNullOrEmpty(_sStaff_no) && !string.IsNullOrEmpty(_sStaff_no))
                    {
                        edfField[131, 1] = "1";
                        edfField[131, 2] = _sStaff_no;
                        edfField[131, 3] = _sStaffNo;
                    }





                    string _sVAS_NAME16 = _oSundayActivation.GetVAS_NAME16().Trim().ToUpper();
                    string _sS_premium1 = _oMobileRetentionOrder.GetS_premium1().Trim().ToUpper();

                    if (!_sVAS_NAME16.Equals(_sS_premium1) ||
                       (!string.IsNullOrEmpty(_sS_premium1) && string.IsNullOrEmpty(_sS_premium1)) ||
                      string.IsNullOrEmpty(_sS_premium1) && !string.IsNullOrEmpty(_sS_premium1))
                    {
                        edfField[132, 1] = "1";
                        edfField[132, 2] = _sM_card_type;
                        edfField[132, 3] = _sVAS_NAME16;
                    }


                    string _sVAS_NAME17 = _oSundayActivation.GetVAS_NAME17().Trim().ToUpper();
                    string _sS_premium2 = _oMobileRetentionOrder.GetS_premium2().Trim().ToUpper();

                    if (!_sVAS_NAME17.Equals(_sS_premium2) ||
                       (!string.IsNullOrEmpty(_sS_premium2) && string.IsNullOrEmpty(_sS_premium2)) ||
                      string.IsNullOrEmpty(_sS_premium2) && !string.IsNullOrEmpty(_sS_premium2))
                    {
                        edfField[133, 1] = "1";
                        edfField[133, 2] = _sS_premium2;
                        edfField[133, 3] = _sVAS_NAME17;
                    }


                    string _sVAS_NAME19 = _oSundayActivation.GetVAS_NAME19().Trim().ToUpper();
                    string _sA_COUPON_OFFER_2 = FindVasValue1("upg_cou2_vas");

                    if (!_sVAS_NAME19.Equals(_sA_COUPON_OFFER_2) ||
                       (!string.IsNullOrEmpty(_sA_COUPON_OFFER_2) && string.IsNullOrEmpty(_sA_COUPON_OFFER_2)) ||
                      string.IsNullOrEmpty(_sA_COUPON_OFFER_2) && !string.IsNullOrEmpty(_sA_COUPON_OFFER_2))
                    {
                        edfField[134, 1] = "1";
                        edfField[134, 2] = _sA_COUPON_OFFER_2;
                        edfField[134, 3] = _sVAS_NAME19;
                    }

                    string _sVAS_NAME20 = _oSundayActivation.GetVAS_NAME20().Trim().ToUpper();
                    string _sA_PREMIUM_OFFER_1  = FindVasValue1("upg_prem1_vas");

                    if (!_sVAS_NAME20.Equals(_sA_PREMIUM_OFFER_1) ||
                       (!string.IsNullOrEmpty(_sA_PREMIUM_OFFER_1) && string.IsNullOrEmpty(_sA_PREMIUM_OFFER_1)) ||
                      string.IsNullOrEmpty(_sA_PREMIUM_OFFER_1) && !string.IsNullOrEmpty(_sA_PREMIUM_OFFER_1))
                    {
                        edfField[135, 1] = "1";
                        edfField[135, 2] = _sA_PREMIUM_OFFER_1;
                        edfField[135, 3] = _sVAS_NAME20;
                    }

                    string _sDummy1= _oSundayActivation.GetDUMMY1().Trim().ToUpper();
                    string _sA_PREMIUM_OFFER_2 = FindVasValue1("upg_prem2_vas");

                    if (!_sDummy1.Equals(_sA_PREMIUM_OFFER_2) ||
                       (!string.IsNullOrEmpty(_sA_PREMIUM_OFFER_2) && string.IsNullOrEmpty(_sA_PREMIUM_OFFER_2)) ||
                      string.IsNullOrEmpty(_sA_PREMIUM_OFFER_2) && !string.IsNullOrEmpty(_sA_PREMIUM_OFFER_2))
                    {
                        edfField[136, 1] = "1";
                        edfField[136, 2] = _sA_PREMIUM_OFFER_2;
                        edfField[136, 3] = _sDummy1;
                    }

                    string _sVAS_PRICE4 = _oSundayActivation.GetVAS_PRICE4().Trim().ToUpper();
                    string _sM_3rd_hkid = _oMobileRetentionOrder.GetM_3rd_hkid() + _oMobileRetentionOrder.GetM_3rd_hkid2();

                    if (!_sVAS_PRICE4.Equals(_sM_3rd_hkid) ||
                       (!string.IsNullOrEmpty(_sM_3rd_hkid) && string.IsNullOrEmpty(_sM_3rd_hkid)) ||
                      string.IsNullOrEmpty(_sM_3rd_hkid) && !string.IsNullOrEmpty(_sM_3rd_hkid))
                    {
                        edfField[137, 1] = "1";
                        edfField[137, 2] = _sM_3rd_hkid;
                        edfField[137, 3] = _sVAS_PRICE4;
                    }

                    string _sInter_SMS = Func.FR(_oReader["Inter_SMS"]).Trim();
                    string _sUpg_act_super = FindVasValue1("upg_act_super");

                    if (!_sInter_SMS.Equals(_sUpg_act_super) ||
                      (!string.IsNullOrEmpty(_sUpg_act_super) && string.IsNullOrEmpty(_sUpg_act_super)) ||
                     string.IsNullOrEmpty(_sUpg_act_super) && !string.IsNullOrEmpty(_sUpg_act_super))
                    {
                        edfField[138, 1] = "1";
                        edfField[138, 2] = _sUpg_act_super;
                        edfField[138, 3] = _sInter_SMS;
                    }

                    string _sC_Tone_Service = Func.FR(_oReader["C_Tone_Service"]).Trim();
                    string _sUpg_1c2n_vas = FindVasValue1("upg_1c2n_vas");

                    if (!_sC_Tone_Service.Equals(_sUpg_1c2n_vas) ||
                      (!string.IsNullOrEmpty(_sUpg_1c2n_vas) && string.IsNullOrEmpty(_sUpg_1c2n_vas)) ||
                     string.IsNullOrEmpty(_sUpg_1c2n_vas) && !string.IsNullOrEmpty(_sUpg_1c2n_vas))
                    {
                        edfField[139, 1] = "1";
                        edfField[139, 2] = _sUpg_1c2n_vas;
                        edfField[139, 3] = _sC_Tone_Service;
                    }


                    string _sMobile_MSN = Func.FR(_oReader["Mobile_MSN"]).Trim();
                    string _sUpg_msn_vas = FindVasValue1("upg_msn_vas");

                    if (!_sMobile_MSN.Equals(_sUpg_msn_vas) ||
                      (!string.IsNullOrEmpty(_sUpg_msn_vas) && string.IsNullOrEmpty(_sUpg_msn_vas)) ||
                     string.IsNullOrEmpty(_sUpg_msn_vas) && !string.IsNullOrEmpty(_sUpg_msn_vas))
                    {
                        edfField[140, 1] = "1";
                        edfField[140, 2] = _sUpg_msn_vas;
                        edfField[140, 3] = _sMobile_MSN;
                    }

                    string _sEZ_SMS_Pack = Func.FR(_oReader["EZ_SMS_Pack"]).Trim();
                    string _sUpg_prem3_vas = FindVasValue1("upg_prem3_vas");

                    if (!_sEZ_SMS_Pack.Equals(_sUpg_prem3_vas) ||
                      (!string.IsNullOrEmpty(_sUpg_prem3_vas) && string.IsNullOrEmpty(_sUpg_prem3_vas)) ||
                     string.IsNullOrEmpty(_sUpg_prem3_vas) && !string.IsNullOrEmpty(_sUpg_prem3_vas))
                    {
                        edfField[141, 1] = "1";
                        edfField[141, 2] = _sUpg_prem3_vas;
                        edfField[141, 3] = _sEZ_SMS_Pack;
                    }

                    string _sGPRS_Mob_Data = Func.FR(_oReader["EZ_SMS_Pack"]).Trim();
                    string _sUpg_prem4_vas = FindVasValue1("upg_prem4_vas");

                    if (!_sGPRS_Mob_Data.Equals(_sUpg_prem4_vas) ||
                      (!string.IsNullOrEmpty(_sUpg_prem4_vas) && string.IsNullOrEmpty(_sUpg_prem4_vas)) ||
                     string.IsNullOrEmpty(_sUpg_prem4_vas) && !string.IsNullOrEmpty(_sUpg_prem4_vas))
                    {
                        edfField[142, 1] = "1";
                        edfField[142, 2] = _sUpg_prem4_vas;
                        edfField[142, 3] = _sGPRS_Mob_Data;
                    }

                    string _sMob_Online_Betting = Func.FR(_oReader["Mob_Online_Betting"]).Trim();
                    string _sMin_vas200 = FindVasValue1("min_vas200");

                    if (!_sMob_Online_Betting.Equals(_sMin_vas200) ||
                      (!string.IsNullOrEmpty(_sMin_vas200) && string.IsNullOrEmpty(_sMin_vas200)) ||
                     string.IsNullOrEmpty(_sMin_vas200) && !string.IsNullOrEmpty(_sMin_vas200))
                    {
                        edfField[143, 1] = "1";
                        edfField[143, 2] = _sMin_vas200;
                        edfField[143, 3] = _sMob_Online_Betting;
                    }

                    string _sMob_ESPN_S_Package = Func.FR(_oReader["Mob_ESPN_S_Package"]).Trim();
                    string _sMin_vas450 = FindVasValue1("min_vas450");

                    if (!_sMob_ESPN_S_Package.Equals(_sMin_vas450) ||
                      (!string.IsNullOrEmpty(_sMin_vas450) && string.IsNullOrEmpty(_sMin_vas450)) ||
                     string.IsNullOrEmpty(_sMin_vas450) && !string.IsNullOrEmpty(_sMin_vas450))
                    {
                        edfField[144, 1] = "1";
                        edfField[144, 2] = _sMin_vas450;
                        edfField[144, 3] = _sMob_ESPN_S_Package;
                    }


                    string _sOFFICE_TEL = _oSundayActivation.GetOFFICE_TEL();
                    string _sUpgrade_registered_mobile_no = _oMobileRetentionOrder.GetUpgrade_registered_mobile_no();

                    if (!_sOFFICE_TEL.Equals(_sUpgrade_registered_mobile_no) ||
                      (!string.IsNullOrEmpty(_sUpgrade_registered_mobile_no) && string.IsNullOrEmpty(_sUpgrade_registered_mobile_no)) ||
                     string.IsNullOrEmpty(_sUpgrade_registered_mobile_no) && !string.IsNullOrEmpty(_sUpgrade_registered_mobile_no))
                    {
                        edfField[144, 1] = "1";
                        edfField[144, 2] = _sUpgrade_registered_mobile_no;
                        edfField[144, 3] = _sOFFICE_TEL;
                    }


                    #endregion

                    for (int i = 0; i < _iEdfXSize; i++)
                    {
                        if (edfField[i, 1] != null && edfField[i, 0] != null)
                        {
                            if (edfField[i, 1].Equals("1"))
                            {
                                StringBuilder _oQueryAmend = new StringBuilder();
                                _oQueryAmend.Append("SELECT RECORD_ID FROM SUNDAY_AMENT WHERE ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' And Field_Name='" + edfField[i, 0].Trim() + "' And SUPPORT_PRINT is Null");
                                OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQueryAmend.ToString());
                                if (_oDr.Read())
                                {
                                    _oQueryAmend = new StringBuilder();
                                    _oQueryAmend.Append("UPDATE SUNDAY_Ament SET eOrder_Update = 'Y',eOrder_U_Date=to_date('" + _sToday1 + "','yyyy-mm-dd'), Ament_Date=to_date('" + _sToday + "','yyyy-mm-dd hh24:mi:ss'),AMENT_BY='" + x_sUid + "', Change_From='" + edfField[i, 3] + "',  Change_To='" + edfField[i, 2] + "' WHERE Record_ID='" + Func.FR(_oDr["record_id"]) + "' AND FORM_NAME='CC RET' AND ROWNUM<=1 ");
                                    bool _bUpdateSuccess = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQueryAmend.ToString());
                                    if (_bUpdateSuccess)
                                        WebFunc.SaveQuery(_oQueryAmend.ToString());
                                }
                                else
                                {
                                    string _sRefNo = string.Empty;
                                    OdbcDataReader _oRefDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT SUNDAY_RA1_Serial.NextVal AS seq, to_char(sysdate, 'yymon') AS cdate FROM dual");
                                    if (_oRefDr.Read())
                                    {
                                        _sRefNo = Func.Right(Func.IDAdd100000(Convert.ToInt32(Func.FR(_oRefDr["seq"]).Trim())), 5) + "/A/" + Func.FR(_oRefDr["cdate"]).Trim().ToUpper();
                                    }
                                    _oRefDr.Close();
                                    _oRefDr.Dispose();
                                    bool _bInsertSuccess = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID ,eOrder_Update ,eOrder_U_Date , Form_Name ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','Y',to_date('" + _sToday1 + "','yyyy-mm-dd'),'CC RET','" + _oMobileRetentionOrder.GetEdf_no() + "',to_date('" + _sToday + "', 'yyyy-mm-dd hh24:mi:ss'),'" + x_sUid + "' ,'" + edfField[i, 0] + "','" + edfField[i, 3] + "','" + edfField[i, 2] + "')");
                                    if (_bInsertSuccess)
                                        WebFunc.SaveQuery(_oQueryAmend.ToString());
                                }
                                _oDr.Close();
                                _oDr.Dispose();
                            }
                        }
                    }


                    _sRemarksEDF = Func.FR(_oReader["remark"]).Trim();

                }// if issue is equal to 'Y'
            }
            _oReader.Close();
            _oReader.Dispose();
        }



        #region CheckIMEIInDB
        protected bool CheckIMEINoInDB(string x_sIMEI)
        {
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            x_sIMEI = x_sIMEI.Trim();
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei FROM sunday_Form  WHERE imei='" + x_sIMEI + "' AND cancelled='N' AND rownum<=1");
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
        #endregion

        #region CheckEDFIMEIInDB
        protected bool CheckEDFIMEIInDB(string x_sEdfNo, string x_sIMEI)
        {
            if (string.IsNullOrEmpty(x_sEdfNo)) return false;
            if (string.IsNullOrEmpty(x_sIMEI)) return false;
            x_sEdfNo = x_sEdfNo.Trim();
            x_sIMEI = x_sIMEI.Trim();

            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo,  imei FROM sunday_Form  WHERE  referenceNo='" + x_sEdfNo + "' AND imei='" + x_sIMEI + "' AND cancelled='N' AND rownum<=1");
            if (_oDr.Read())
            {
                if (!Func.FR(_oDr["imei"]).Trim().Equals(string.Empty) &&
                    !Func.FR(_oDr["referenceNo"]).Trim().Equals(string.Empty)
                    )
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
        #endregion


        protected string n_sAssign_date = global::System.String.Empty;
        #region Assign_date
        public string Assign_date
        {
            get
            {
                return this.n_sAssign_date;
            }
            set
            {
                this.n_sAssign_date = value;
            }
        }
        #endregion Assign_date


        protected string n_sSTATUS_DATE = global::System.String.Empty;
        #region STATUS_DATE
        public string STATUS_DATE
        {
            get
            {
                return this.n_sSTATUS_DATE;
            }
            set
            {
                this.n_sSTATUS_DATE = value;
            }
        }
        #endregion STATUS_DATE


        protected string n_sPayment_status_date = global::System.String.Empty;
        #region Payment_status_date
        public string Payment_status_date
        {
            get
            {
                return this.n_sPayment_status_date;
            }
            set
            {
                this.n_sPayment_status_date = value;
            }
        }
        #endregion Payment_status_date


        protected string n_sCancelled_date = global::System.String.Empty;
        #region Cancelled_date
        public string Cancelled_date
        {
            get
            {
                return this.n_sCancelled_date;
            }
            set
            {
                this.n_sCancelled_date = value;
            }
        }
        #endregion Cancelled_date


        protected string n_sActual_del_date = global::System.String.Empty;
        #region Actual_del_date
        public string Actual_del_date
        {
            get
            {
                return this.n_sActual_del_date;
            }
            set
            {
                this.n_sActual_del_date = value;
            }
        }
        #endregion Actual_del_date


        protected string n_sActivated_date = global::System.String.Empty;
        #region Activated_date
        public string Activated_date
        {
            get
            {
                return this.n_sActivated_date;
            }
            set
            {
                this.n_sActivated_date = value;
            }
        }
        #endregion Activated_date


        protected string n_sCreate_s = global::System.String.Empty;
        #region Create_s
        public string Create_s
        {
            get
            {
                return this.n_sCreate_s;
            }
            set
            {
                this.n_sCreate_s = value;
            }
        }
        #endregion Create_s


        protected string n_sDoc_r_date = global::System.String.Empty;
        #region Doc_r_date
        public string Doc_r_date
        {
            get
            {
                return this.n_sDoc_r_date;
            }
            set
            {
                this.n_sDoc_r_date = value;
            }
        }
        #endregion Doc_r_date


        protected string n_sTo_plg = global::System.String.Empty;
        #region To_plg
        public string To_plg
        {
            get
            {
                return this.n_sTo_plg;
            }
            set
            {
                this.n_sTo_plg = value;
            }
        }
        #endregion To_plg


        protected string n_sActivated = global::System.String.Empty;
        #region Activated
        public string Activated
        {
            get
            {
                return this.n_sActivated;
            }
            set
            {
                this.n_sActivated = value;
            }
        }
        #endregion Activated


        protected string n_sMNP_rej_date = global::System.String.Empty;
        #region MNP_rej_date
        public string MNP_rej_date
        {
            get
            {
                return this.n_sMNP_rej_date;
            }
            set
            {
                this.n_sMNP_rej_date = value;
            }
        }
        #endregion MNP_rej_date


        protected string n_sCancelled = global::System.String.Empty;
        #region Cancelled
        public string Cancelled
        {
            get
            {
                return this.n_sCancelled;
            }
            set
            {
                this.n_sCancelled = value;
            }
        }
        #endregion Cancelled


        protected string n_sPending = global::System.String.Empty;
        #region Pending
        public string Pending
        {
            get
            {
                return this.n_sPending;
            }
            set
            {
                this.n_sPending = value;
            }
        }
        #endregion Pending


        protected string n_sLast_update = global::System.String.Empty;
        #region Last_update
        public string Last_update
        {
            get
            {
                return this.n_sLast_update;
            }
            set
            {
                this.n_sLast_update = value;
            }
        }
        #endregion Last_update


        protected string n_sMNP_rej_code = global::System.String.Empty;
        #region MNP_rej_code
        public string MNP_rej_code
        {
            get
            {
                return this.n_sMNP_rej_code;
            }
            set
            {
                this.n_sMNP_rej_code = value;
            }
        }
        #endregion MNP_rej_code


        protected string n_sCreate_s_date = global::System.String.Empty;
        #region Create_s_date
        public string Create_s_date
        {
            get
            {
                return this.n_sCreate_s_date;
            }
            set
            {
                this.n_sCreate_s_date = value;
            }
        }
        #endregion Create_s_date


        protected string n_sPayment_status = global::System.String.Empty;
        #region Payment_status
        public string Payment_status
        {
            get
            {
                return this.n_sPayment_status;
            }
            set
            {
                this.n_sPayment_status = value;
            }
        }
        #endregion Payment_status


        protected string n_sDoc_receive = global::System.String.Empty;
        #region Doc_receive
        public string Doc_receive
        {
            get
            {
                return this.n_sDoc_receive;
            }
            set
            {
                this.n_sDoc_receive = value;
            }
        }
        #endregion Doc_receive


        protected string n_sPend_date = global::System.String.Empty;
        #region Pend_date
        public string Pend_date
        {
            get
            {
                return this.n_sPend_date;
            }
            set
            {
                this.n_sPend_date = value;
            }
        }
        #endregion Pend_date


        protected string n_sFo_to_sales = global::System.String.Empty;
        #region Fo_to_sales
        public string Fo_to_sales
        {
            get
            {
                return this.n_sFo_to_sales;
            }
            set
            {
                this.n_sFo_to_sales = value;
            }
        }
        #endregion Fo_to_sales


        protected string n_sFo_date = global::System.String.Empty;
        #region Fo_date
        public string Fo_date
        {
            get
            {
                return this.n_sFo_date;
            }
            set
            {
                this.n_sFo_date = value;
            }
        }
        #endregion Fo_date


        protected string n_sIssue_date = global::System.String.Empty;
        #region Issue_date
        public string Issue_date
        {
            get
            {
                return this.n_sIssue_date;
            }
            set
            {
                this.n_sIssue_date = value;
            }
        }
        #endregion Issue_date


        protected string n_sMNP_Rejection = global::System.String.Empty;
        #region MNP_Rejection
        public string MNP_Rejection
        {
            get
            {
                return this.n_sMNP_Rejection;
            }
            set
            {
                this.n_sMNP_Rejection = value;
            }
        }
        #endregion MNP_Rejection


        protected bool n_bFound = false;
        #region Found
        public bool Found
        {
            get
            {
                return this.n_bFound;
            }
            set
            {
                this.n_bFound = value;
            }
        }
        #endregion Found


        protected string n_sPrint_delivery = global::System.String.Empty;
        #region Print_delivery
        public string Print_delivery
        {
            get
            {
                return this.n_sPrint_delivery;
            }
            set
            {
                this.n_sPrint_delivery = value;
            }
        }
        #endregion Print_delivery


        protected string n_sPc_reason = global::System.String.Empty;
        #region Pc_reason
        public string Pc_reason
        {
            get
            {
                return this.n_sPc_reason;
            }
            set
            {
                this.n_sPc_reason = value;
            }
        }
        #endregion Pc_reason


        protected string n_sIssue = global::System.String.Empty;
        #region Issue
        public string Issue
        {
            get
            {
                return this.n_sIssue;
            }
            set
            {
                this.n_sIssue = value;
            }
        }
        #endregion Issue


        protected string n_sSTATUS = global::System.String.Empty;
        #region STATUS
        public string STATUS
        {
            get
            {
                return this.n_sSTATUS;
            }
            set
            {
                this.n_sSTATUS = value;
            }
        }
        #endregion STATUS


        protected string n_sAssign_name = global::System.String.Empty;
        #region Assign_name
        public string Assign_name
        {
            get
            {
                return this.n_sAssign_name;
            }
            set
            {
                this.n_sAssign_name = value;
            }
        }
        #endregion Assign_name


        protected string n_sFail_reason = global::System.String.Empty;
        #region Fail_reason
        public string Fail_reason
        {
            get
            {
                return this.n_sFail_reason;
            }
            set
            {
                this.n_sFail_reason = value;
            }
        }
        #endregion Fail_reason


        protected string n_sTo_plg_date = global::System.String.Empty;
        #region To_plg_date
        public string To_plg_date
        {
            get
            {
                return this.n_sTo_plg_date;
            }
            set
            {
                this.n_sTo_plg_date = value;
            }
        }
        #endregion To_plg_date


        protected string n_sAssign_sn = global::System.String.Empty;
        #region Assign_sn
        public string Assign_sn
        {
            get
            {
                return this.n_sAssign_sn;
            }
            set
            {
                this.n_sAssign_sn = value;
            }
        }
        #endregion Assign_sn


        #region Constructor & Destructor
        public EDFStatusProfile()
        {
        }

        public EDFStatusProfile(string x_sAssign_date, string x_sSTATUS_DATE, string x_sPayment_status_date, string x_sCancelled_date, string x_sActual_del_date, string x_sActivated_date, string x_sCreate_s, string x_sDoc_r_date, string x_sTo_plg, string x_sActivated, string x_sMNP_rej_date, string x_sCancelled, string x_sPending, string x_sLast_update, string x_sMNP_rej_code, string x_sCreate_s_date, string x_sPayment_status, string x_sDoc_receive, string x_sPend_date, string x_sFo_to_sales, string x_sFo_date, string x_sIssue_date, string x_sMNP_Rejection, bool x_bFound, string x_sPrint_delivery, string x_sPc_reason, string x_sIssue, string x_sSTATUS, string x_sAssign_name, string x_sFail_reason, string x_sTo_plg_date, string x_sAssign_sn)
        {
            Assign_date = x_sAssign_date;
            STATUS_DATE = x_sSTATUS_DATE;
            Payment_status_date = x_sPayment_status_date;
            Cancelled_date = x_sCancelled_date;
            Actual_del_date = x_sActual_del_date;
            Activated_date = x_sActivated_date;
            Create_s = x_sCreate_s;
            Doc_r_date = x_sDoc_r_date;
            To_plg = x_sTo_plg;
            Activated = x_sActivated;
            MNP_rej_date = x_sMNP_rej_date;
            Cancelled = x_sCancelled;
            Pending = x_sPending;
            Last_update = x_sLast_update;
            MNP_rej_code = x_sMNP_rej_code;
            Create_s_date = x_sCreate_s_date;
            Payment_status = x_sPayment_status;
            Doc_receive = x_sDoc_receive;
            Pend_date = x_sPend_date;
            Fo_to_sales = x_sFo_to_sales;
            Fo_date = x_sFo_date;
            Issue_date = x_sIssue_date;
            MNP_Rejection = x_sMNP_Rejection;
            Found = x_bFound;
            Print_delivery = x_sPrint_delivery;
            Pc_reason = x_sPc_reason;
            Issue = x_sIssue;
            STATUS = x_sSTATUS;
            Assign_name = x_sAssign_name;
            Fail_reason = x_sFail_reason;
            To_plg_date = x_sTo_plg_date;
            Assign_sn = x_sAssign_sn;
        }

        ~EDFStatusProfile() { }

        #endregion Constructor & Destructor

        public class Para
        {
            public const string issue = "issue";
            public const string Issue_date = "Issue_date";
            public const string doc_receive = "doc_receive";
            public const string doc_r_date = "doc_r_date";
            public const string assign_sn = "assign_sn";
            public const string assign_date = "assign_date";
            public const string assign_name = "assign_name";
            public const string fo_to_sales = "fo_to_sales";
            public const string fo_date = "fo_date";
            public const string STATUS = "STATUS";
            public const string STATUS_DATE = "STATUS_DATE";
            public const string payment_status = "payment_status";
            public const string payment_status_date = "payment_status_date";
            public const string create_s = "create_s";
            public const string create_s_date = "create_s_date";
            public const string actual_del_date = "actual_del_date";
            public const string print_delivery = "print_delivery";
            public const string to_plg = "to_plg";
            public const string to_plg_date = "to_plg_date";
            public const string activated = "activated";
            public const string activated_date = "activated_date";
            public const string pending = "pending";
            public const string pend_date = "pend_date";
            public const string fail_reason = "fail_reason";
            public const string MNP_Rejection = "MNP_Rejection";
            public const string MNP_rej_date = "MNP_rej_date";
            public const string Mnp_rej_code = "Mnp_rej_code";
            public const string cancelled = "cancelled";
            public const string cancel_date = "cancel_date";
            public const string pc_reason = "pc_reason";
            public const string last_update = "last_update";
        }

        #region Load
        public void LoadData(string x_sEDF_no)
        {
            DataSet _oFTSDs = SYSConn<ODBCConnect>.Connect().GetDS("SELECT STATUS,STATUS_DATE,sm_no FROM FTS_CPE_Form ");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM SUNDAY_Form WHERE referenceNO='" + x_sEDF_no.Replace("'", "''").Trim() + "'");
            if (_oDr.HasRows)
            {
                if (_oDr.Read())
                {
                    SetFound(true);
                    string _sReferenceNO = Func.FR(_oDr["referenceNO"]).Trim();
                    IDSQuery _oFTSDr = IDSQuery.CreateDsCriteria(_oFTSDs, string.Empty)
                        .Add(DsExpression.Eq("sm_no", _sReferenceNO));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.issue) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.issue]))
                        this.Issue = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.issue));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.Issue_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.Issue_date]))
                        this.Issue_date = ((DateTime)_oDr[EDFStatusProfile.Para.Issue_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.doc_receive) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.doc_receive]))
                        this.Doc_receive = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.doc_receive));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.doc_r_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.doc_r_date]))
                        this.Doc_r_date = ((DateTime)_oDr[EDFStatusProfile.Para.doc_r_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.assign_sn) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.assign_sn]))
                        this.Assign_sn = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.assign_sn));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.assign_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.assign_date]))
                        this.Assign_date = ((DateTime)_oDr[EDFStatusProfile.Para.assign_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.assign_name) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.assign_name]))
                        this.Assign_name = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.assign_name));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.fo_to_sales) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.fo_to_sales]))
                        this.Fo_to_sales = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.fo_to_sales));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.fo_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.fo_date]))
                        this.Fo_date = ((DateTime)_oDr[EDFStatusProfile.Para.fo_date]).ToString("dd-MMM-yyyy");

                    if (_oFTSDr.Read())
                    {
                        this.STATUS = _oFTSDr[EDFStatusProfile.Para.STATUS].ToString();
                        this.STATUS_DATE = ((DateTime)_oFTSDr[EDFStatusProfile.Para.STATUS_DATE, false]).ToString("dd-MMM-yyyy");
                    }

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.payment_status) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.payment_status]))
                        this.Payment_status = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.payment_status));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.payment_status_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.payment_status_date]))
                        this.Payment_status_date = ((DateTime)_oDr[EDFStatusProfile.Para.payment_status_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.create_s) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.create_s]))
                        this.Create_s = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.create_s));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.create_s_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.create_s_date]))
                        this.Create_s_date = ((DateTime)_oDr[EDFStatusProfile.Para.create_s_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.actual_del_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.actual_del_date]))
                        this.Actual_del_date = ((DateTime)_oDr[EDFStatusProfile.Para.actual_del_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.print_delivery) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.print_delivery]))
                        this.Print_delivery = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.print_delivery));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.to_plg) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.to_plg]))
                        this.To_plg = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.to_plg));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.to_plg_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.to_plg_date]))
                        this.To_plg_date = ((DateTime)_oDr[EDFStatusProfile.Para.to_plg_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.activated) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.activated]))
                        this.Activated = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.activated));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.activated_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.activated_date]))
                        this.Activated_date = ((DateTime)_oDr[EDFStatusProfile.Para.activated_date]).ToString("dd-MMM-yyyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.pending) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.pending]))
                        this.Pending = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.pending));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.pend_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.pend_date]))
                        this.Pend_date = ((DateTime)_oDr[EDFStatusProfile.Para.pend_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.fail_reason) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.fail_reason]))
                        this.Fail_reason = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.fail_reason));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.MNP_Rejection) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.MNP_Rejection]))
                        this.MNP_Rejection = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.MNP_Rejection));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.MNP_rej_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.MNP_rej_date]))
                        this.MNP_rej_date = ((DateTime)_oDr[EDFStatusProfile.Para.MNP_rej_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.Mnp_rej_code) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.Mnp_rej_code]))
                        this.MNP_rej_code = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.Mnp_rej_code));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.cancelled) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.cancelled]))
                        this.Cancelled = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.cancelled));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.cancel_date) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.cancel_date]))
                        this.Cancelled_date = ((DateTime)_oDr[EDFStatusProfile.Para.cancel_date]).ToString("dd-MMM-yyyy");

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.pc_reason) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.pc_reason]))
                        this.Pc_reason = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.pc_reason));

                    if (_oDr.GetOrdinal(EDFStatusProfile.Para.last_update) >= 0 && !global::System.Convert.IsDBNull(_oDr[EDFStatusProfile.Para.last_update]))
                        this.Last_update = _oDr.GetString(_oDr.GetOrdinal(EDFStatusProfile.Para.last_update));
                }
                else
                {
                    SetFound(false);
                }
            }
            else
            {
                SetFound(false);
            }
            _oDr.Close();
            _oDr.Dispose();
        }

        #endregion

        #region Get & Set
        public string GetAssign_date() { return this.Assign_date; }
        public string GetSTATUS_DATE() { return this.STATUS_DATE; }
        public string GetPayment_status_date() { return this.Payment_status_date; }
        public string GetCancelled_date() { return this.Cancelled_date; }
        public string GetActual_del_date() { return this.Actual_del_date; }
        public string GetActivated_date() { return this.Activated_date; }
        public string GetCreate_s() { return this.Create_s; }
        public string GetDoc_r_date() { return this.Doc_r_date; }
        public string GetTo_plg() { return this.To_plg; }
        public string GetActivated() { return this.Activated; }
        public string GetMNP_rej_date() { return this.MNP_rej_date; }
        public string GetCancelled() { return this.Cancelled; }
        public string GetPending() { return this.Pending; }
        public string GetLast_update() { return this.Last_update; }
        public string GetMNP_rej_code() { return this.MNP_rej_code; }
        public string GetCreate_s_date() { return this.Create_s_date; }
        public string GetPayment_status() { return this.Payment_status; }
        public string GetDoc_receive() { return this.Doc_receive; }
        public string GetPend_date() { return this.Pend_date; }
        public string GetFo_to_sales() { return this.Fo_to_sales; }
        public string GetFo_date() { return this.Fo_date; }
        public string GetIssue_date() { return this.Issue_date; }
        public string GetMNP_Rejection() { return this.MNP_Rejection; }
        public bool GetFound() { return this.Found; }
        public string GetPrint_delivery() { return this.Print_delivery; }
        public string GetPc_reason() { return this.Pc_reason; }
        public string GetIssue() { return this.Issue; }
        public string GetSTATUS() { return this.STATUS; }
        public string GetAssign_name() { return this.Assign_name; }
        public string GetFail_reason() { return this.Fail_reason; }
        public string GetTo_plg_date() { return this.To_plg_date; }
        public string GetAssign_sn() { return this.Assign_sn; }

        public bool SetAssign_date(string value)
        {
            this.Assign_date = value;
            return true;
        }
        public bool SetSTATUS_DATE(string value)
        {
            this.STATUS_DATE = value;
            return true;
        }
        public bool SetPayment_status_date(string value)
        {
            this.Payment_status_date = value;
            return true;
        }
        public bool SetCancelled_date(string value)
        {
            this.Cancelled_date = value;
            return true;
        }
        public bool SetActual_del_date(string value)
        {
            this.Actual_del_date = value;
            return true;
        }
        public bool SetActivated_date(string value)
        {
            this.Activated_date = value;
            return true;
        }
        public bool SetCreate_s(string value)
        {
            this.Create_s = value;
            return true;
        }
        public bool SetDoc_r_date(string value)
        {
            this.Doc_r_date = value;
            return true;
        }
        public bool SetTo_plg(string value)
        {
            this.To_plg = value;
            return true;
        }
        public bool SetActivated(string value)
        {
            this.Activated = value;
            return true;
        }
        public bool SetMNP_rej_date(string value)
        {
            this.MNP_rej_date = value;
            return true;
        }
        public bool SetCancelled(string value)
        {
            this.Cancelled = value;
            return true;
        }
        public bool SetPending(string value)
        {
            this.Pending = value;
            return true;
        }
        public bool SetLast_update(string value)
        {
            this.Last_update = value;
            return true;
        }
        public bool SetMNP_rej_code(string value)
        {
            this.MNP_rej_code = value;
            return true;
        }
        public bool SetCreate_s_date(string value)
        {
            this.Create_s_date = value;
            return true;
        }
        public bool SetPayment_status(string value)
        {
            this.Payment_status = value;
            return true;
        }
        public bool SetDoc_receive(string value)
        {
            this.Doc_receive = value;
            return true;
        }
        public bool SetPend_date(string value)
        {
            this.Pend_date = value;
            return true;
        }
        public bool SetFo_to_sales(string value)
        {
            this.Fo_to_sales = value;
            return true;
        }
        public bool SetFo_date(string value)
        {
            this.Fo_date = value;
            return true;
        }
        public bool SetIssue_date(string value)
        {
            this.Issue_date = value;
            return true;
        }
        public bool SetMNP_Rejection(string value)
        {
            this.MNP_Rejection = value;
            return true;
        }
        public bool SetFound(bool value)
        {
            this.Found = value;
            return true;
        }
        public bool SetPrint_delivery(string value)
        {
            this.Print_delivery = value;
            return true;
        }
        public bool SetPc_reason(string value)
        {
            this.Pc_reason = value;
            return true;
        }
        public bool SetIssue(string value)
        {
            this.Issue = value;
            return true;
        }
        public bool SetSTATUS(string value)
        {
            this.STATUS = value;
            return true;
        }
        public bool SetAssign_name(string value)
        {
            this.Assign_name = value;
            return true;
        }
        public bool SetFail_reason(string value)
        {
            this.Fail_reason = value;
            return true;
        }
        public bool SetTo_plg_date(string value)
        {
            this.To_plg_date = value;
            return true;
        }
        public bool SetAssign_sn(string value)
        {
            this.Assign_sn = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(EDFStatusProfile x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Assign_date.Equals(x_oObj.Assign_date)) { return false; }
            if (!this.STATUS_DATE.Equals(x_oObj.STATUS_DATE)) { return false; }
            if (!this.Payment_status_date.Equals(x_oObj.Payment_status_date)) { return false; }
            if (!this.Cancelled_date.Equals(x_oObj.Cancelled_date)) { return false; }
            if (!this.Actual_del_date.Equals(x_oObj.Actual_del_date)) { return false; }
            if (!this.Activated_date.Equals(x_oObj.Activated_date)) { return false; }
            if (!this.Create_s.Equals(x_oObj.Create_s)) { return false; }
            if (!this.Doc_r_date.Equals(x_oObj.Doc_r_date)) { return false; }
            if (!this.To_plg.Equals(x_oObj.To_plg)) { return false; }
            if (!this.Activated.Equals(x_oObj.Activated)) { return false; }
            if (!this.MNP_rej_date.Equals(x_oObj.MNP_rej_date)) { return false; }
            if (!this.Cancelled.Equals(x_oObj.Cancelled)) { return false; }
            if (!this.Pending.Equals(x_oObj.Pending)) { return false; }
            if (!this.Last_update.Equals(x_oObj.Last_update)) { return false; }
            if (!this.MNP_rej_code.Equals(x_oObj.MNP_rej_code)) { return false; }
            if (!this.Create_s_date.Equals(x_oObj.Create_s_date)) { return false; }
            if (!this.Payment_status.Equals(x_oObj.Payment_status)) { return false; }
            if (!this.Doc_receive.Equals(x_oObj.Doc_receive)) { return false; }
            if (!this.Pend_date.Equals(x_oObj.Pend_date)) { return false; }
            if (!this.Fo_to_sales.Equals(x_oObj.Fo_to_sales)) { return false; }
            if (!this.Fo_date.Equals(x_oObj.Fo_date)) { return false; }
            if (!this.Issue_date.Equals(x_oObj.Issue_date)) { return false; }
            if (!this.MNP_Rejection.Equals(x_oObj.MNP_Rejection)) { return false; }
            if (!this.Found.Equals(x_oObj.Found)) { return false; }
            if (!this.Print_delivery.Equals(x_oObj.Print_delivery)) { return false; }
            if (!this.Pc_reason.Equals(x_oObj.Pc_reason)) { return false; }
            if (!this.Issue.Equals(x_oObj.Issue)) { return false; }
            if (!this.STATUS.Equals(x_oObj.STATUS)) { return false; }
            if (!this.Assign_name.Equals(x_oObj.Assign_name)) { return false; }
            if (!this.Fail_reason.Equals(x_oObj.Fail_reason)) { return false; }
            if (!this.To_plg_date.Equals(x_oObj.To_plg_date)) { return false; }
            if (!this.Assign_sn.Equals(x_oObj.Assign_sn)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Assign_date = global::System.String.Empty;
            this.STATUS_DATE = global::System.String.Empty;
            this.Payment_status_date = global::System.String.Empty;
            this.Cancelled_date = global::System.String.Empty;
            this.Actual_del_date = global::System.String.Empty;
            this.Activated_date = global::System.String.Empty;
            this.Create_s = global::System.String.Empty;
            this.Doc_r_date = global::System.String.Empty;
            this.To_plg = global::System.String.Empty;
            this.Activated = global::System.String.Empty;
            this.MNP_rej_date = global::System.String.Empty;
            this.Cancelled = global::System.String.Empty;
            this.Pending = global::System.String.Empty;
            this.Last_update = global::System.String.Empty;
            this.MNP_rej_code = global::System.String.Empty;
            this.Create_s_date = global::System.String.Empty;
            this.Payment_status = global::System.String.Empty;
            this.Doc_receive = global::System.String.Empty;
            this.Pend_date = global::System.String.Empty;
            this.Fo_to_sales = global::System.String.Empty;
            this.Fo_date = global::System.String.Empty;
            this.Issue_date = global::System.String.Empty;
            this.MNP_Rejection = global::System.String.Empty;
            this.Found = false;
            this.Print_delivery = global::System.String.Empty;
            this.Pc_reason = global::System.String.Empty;
            this.Issue = global::System.String.Empty;
            this.STATUS = global::System.String.Empty;
            this.Assign_name = global::System.String.Empty;
            this.Fail_reason = global::System.String.Empty;
            this.To_plg_date = global::System.String.Empty;
            this.Assign_sn = global::System.String.Empty;
        }
        #endregion Release


        #region Clone
        public EDFStatusProfile DeepClone()
        {
            EDFStatusProfile EDFStatusProfile_Clone = new EDFStatusProfile();
            EDFStatusProfile_Clone.SetAssign_date(this.Assign_date);
            EDFStatusProfile_Clone.SetSTATUS_DATE(this.STATUS_DATE);
            EDFStatusProfile_Clone.SetPayment_status_date(this.Payment_status_date);
            EDFStatusProfile_Clone.SetCancelled_date(this.Cancelled_date);
            EDFStatusProfile_Clone.SetActual_del_date(this.Actual_del_date);
            EDFStatusProfile_Clone.SetActivated_date(this.Activated_date);
            EDFStatusProfile_Clone.SetCreate_s(this.Create_s);
            EDFStatusProfile_Clone.SetDoc_r_date(this.Doc_r_date);
            EDFStatusProfile_Clone.SetTo_plg(this.To_plg);
            EDFStatusProfile_Clone.SetActivated(this.Activated);
            EDFStatusProfile_Clone.SetMNP_rej_date(this.MNP_rej_date);
            EDFStatusProfile_Clone.SetCancelled(this.Cancelled);
            EDFStatusProfile_Clone.SetPending(this.Pending);
            EDFStatusProfile_Clone.SetLast_update(this.Last_update);
            EDFStatusProfile_Clone.SetMNP_rej_code(this.MNP_rej_code);
            EDFStatusProfile_Clone.SetCreate_s_date(this.Create_s_date);
            EDFStatusProfile_Clone.SetPayment_status(this.Payment_status);
            EDFStatusProfile_Clone.SetDoc_receive(this.Doc_receive);
            EDFStatusProfile_Clone.SetPend_date(this.Pend_date);
            EDFStatusProfile_Clone.SetFo_to_sales(this.Fo_to_sales);
            EDFStatusProfile_Clone.SetFo_date(this.Fo_date);
            EDFStatusProfile_Clone.SetIssue_date(this.Issue_date);
            EDFStatusProfile_Clone.SetMNP_Rejection(this.MNP_Rejection);
            EDFStatusProfile_Clone.SetFound(this.Found);
            EDFStatusProfile_Clone.SetPrint_delivery(this.Print_delivery);
            EDFStatusProfile_Clone.SetPc_reason(this.Pc_reason);
            EDFStatusProfile_Clone.SetIssue(this.Issue);
            EDFStatusProfile_Clone.SetSTATUS(this.STATUS);
            EDFStatusProfile_Clone.SetAssign_name(this.Assign_name);
            EDFStatusProfile_Clone.SetFail_reason(this.Fail_reason);
            EDFStatusProfile_Clone.SetTo_plg_date(this.To_plg_date);
            EDFStatusProfile_Clone.SetAssign_sn(this.Assign_sn);
            return EDFStatusProfile_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
