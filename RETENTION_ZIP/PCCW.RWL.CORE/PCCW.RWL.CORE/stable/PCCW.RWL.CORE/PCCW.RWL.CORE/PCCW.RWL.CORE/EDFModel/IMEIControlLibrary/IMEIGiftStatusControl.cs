﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;






using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using PCCW.RWL.CORE;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using log4net;
using PCCW.RWL.CORE.WEBFUNC;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IMEIGiftStatusControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class IMEIGiftStatusControl : IMEIGiftStatusControlEntity, IIMEIGiftStatusControlEntityRepository
    {

        #region Instance
        private static IMEIGiftStatusControl instance;
        #endregion

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        
        #region ManagementGiftIMEIStatus
        public void ManagementGiftIMEIStatus(string x_sItemLocation)
        {
            
            
            SetAment_Date(string.Empty);
            string[] _sFormat = { "yyyyMMdd", "yyyyMMdd HH:mm:ss", "yyyyMMdd H:mm:ss", "MM/dd/yyyy", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy H:mm:ss" };
            if (string.IsNullOrEmpty(GetDummy1()))
            {
                DateTime _dCreateDate;
                if (DateTime.TryParseExact(GetCreate_Date(), _sFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCreateDate))
                    SetAment_Date(_dCreateDate.ToString("yyyyMMdd"));
                else
                    SetAment_Date(GetDummy1());
            }
            else
                SetAment_Date(GetDummy1());
            string _sInsert1 = "INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) values ('" + GetKit_Code() + "','" + GetModel() + "','" + GetStatus() + "','" + GetReferenceNo() + "','" + GetDummy4() + "',to_date('" + GetToday() + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "','" + GetDummy1() + "','" + GetDummy2() + "','" + GetStock_In_Date() + "','" + GetIMEI() + "',to_date('" + GetAment_Date() + "' , 'yyyymmdd')) ";
            GetORDB().ExplicitNonQuery(_sInsert1);
            WebFunc.SaveQuery(_sInsert1);
            if ((GetStatus().Trim().Equals("SOLD") || GetStatus().Trim().Equals("STOCK")))
            {
                global::System.Data.Odbc.OdbcDataReader _oDr4 = GetORDB().GetSearch("SELECT * from IMEI_Stock where Kit_Code='" + GetSku() + "' AND DUMMY3='" + GetDummy3() + "' AND Dummy2='CC RET' AND Status in ('AWAIT','AO')  order by Create_Date");
                if (_oDr4.Read())
                {
                    //'===== assign to waiting list (AO / AWAIT) -> release old & assign new =====
                    string _sUpdate1 = " UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + GetToday1() + "',IMEI='A" + GetImei_no() + "' WHERE Dummy2='CC RET' AND (IMEI not like 'FG%' OR IMEI=' ' OR IMEI is null) AND DUMMY4='" + GetOrder_id() + "' and imei='" + GetIMEI() + "'";
                    string _sInsert2 = "INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,Create_Date,Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,DUMMY4,IMEI,Ament_Date) values ('" + _oDr4["Kit_Code"].ToString() + "','" + _oDr4["Model"].ToString() + "','" + _oDr4["Status"].ToString() + "','" + _oDr4["ReferenceNo"].ToString() + "',to_date('" + GetToday1() + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "','" + _oDr4["Dummy1"].ToString() + "','" + _oDr4["Dummy2"].ToString() + "','" + _oDr4["DUMMY3"].ToString() + "','" + _oDr4["Stock_In_Date"].ToString() + "','" + _oDr4["DUMMY4"].ToString() + "','" + _oDr4["IMEI"].ToString() + "',to_date('" + GetAment_Date() + "' , 'yyyymmdd')) ";
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sUpdate1);
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sInsert2);
                    WebFunc.SaveQuery(_sUpdate1);
                    WebFunc.SaveQuery(_sInsert2);

                    string _sQueryUp = " UPDATE IMEI_Stock set Status='STOCK', IMEI='" + GetIMEI() + "', Completed_Date='" + GetToday1() + "' where Dummy2='CC RET' and (IMEI not like 'FG%' or IMEI=' ' or IMEI is null) and DUMMY4='" + _oDr4["DUMMY4"].ToString().Trim() + "' and Kit_Code='" + GetSku() + "' and Status in ('AWAIT','AO')";
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQueryUp);
                    WebFunc.SaveQuery(_sQueryUp);
                }
                else
                {
                    //'===== if no waiting list (AO / AWAIT) -> release to normal =====
                    string _sUpdate2 = " UPDATE IMEI_Stock SET Status='NORMAL', Dummy1='" + GetToday1() + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND (IMEI not like 'FG%' OR IMEI=' ' OR IMEI is null) AND DUMMY4='" + GetOrder_id() + "' AND imei='" + GetImei_no() + "'  ";
                    string _sUpdate3 = " UPDATE IMEI_Stock SET Status='NORMAL', Dummy1='" + GetToday1() + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where Dummy2='CC RET' AND (IMEI not like 'FG%' OR IMEI is not null) AND DUMMY4='" + GetOrder_id() + "' AND Status='SOLD' ";
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sUpdate2);
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sUpdate3);
                    WebFunc.SaveQuery(_sUpdate2);
                    WebFunc.SaveQuery(_sUpdate3);
                    
                    int _iRecord_id;
                    if (GetOrder_id() != string.Empty && int.TryParse(GetOrder_id(), out _iRecord_id))
                    {
                        //_oEDFStatusProfile.UsedDOAIMEI(GetImei_no().Trim(), _iRecord_id, IMEISTATUS.NORMAL, false, true);
                    }
                }
                _oDr4.Close();
                _oDr4.Dispose();
            }
            else
            {
                //'===== if not IMEI# -> update status to cancel =====
                string _sUpdate4= "UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='" + GetToday1() + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null WHERE Dummy2='CC RET' AND (IMEI not like 'FG%' OR IMEI=' ' OR IMEI is null) AND DUMMY4='" + GetOrder_id() + "' AND Status in ('AO','AWAIT')";
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sUpdate4);
                WebFunc.SaveQuery(_sUpdate4);
            }
        }
        #endregion

        #region Get Sql DB
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

        #region Constructor & Destructor
        public IMEIGiftStatusControl() { }

        protected IMEIGiftStatusControl(
            string x_sCreate_Date, string x_sToday1, string x_sOrder_id, string x_sReferenceNo,
            string x_sToday, string x_sKit_Code, string x_sAment_Date, string x_sImei_no,
            string x_sDummy4, string x_sIMEI, string x_sModel, string x_sSku, 
            string x_sGetDummy1, string x_sDummy3, string x_sUid, string x_sStock_In_Date, 
            string x_sDummy1, string x_sDummy2, string x_sStatus)
        {
            m_sCreate_Date = x_sCreate_Date;
            m_sToday1 = x_sToday1;
            m_sOrder_id = x_sOrder_id;
            m_sReferenceNo = x_sReferenceNo;
            m_sToday = x_sToday;
            m_sKit_Code = x_sKit_Code;
            m_sAment_Date = x_sAment_Date;
            m_sImei_no = x_sImei_no;
            m_sDummy4 = x_sDummy4;
            m_sIMEI = x_sIMEI;
            m_sModel = x_sModel;
            m_sSku = x_sSku;
            m_sGetDummy1 = x_sGetDummy1;
            m_sDummy3 = x_sDummy3;
            m_sUid = x_sUid;
            m_sStock_In_Date = x_sStock_In_Date;
            m_sDummy1 = x_sDummy1;
            m_sDummy2 = x_sDummy2;
            m_sStatus = x_sStatus;
        }

        public static IMEIGiftStatusControl Instance()
        {
            if (instance == null)
                instance = new IMEIGiftStatusControl();
            return instance;
        }

        public static IMEIGiftStatusControl Instance(
            string x_sCreate_Date, string x_sToday1, string x_sOrder_id, 
            string x_sReferenceNo, string x_sToday, string x_sKit_Code, 
            string x_sAment_Date, string x_sImei_no, string x_sDummy4,
            string x_sIMEI, string x_sModel, string x_sSku, string x_sGetDummy1,
            string x_sDummy3, string x_sUid, string x_sStock_In_Date, string x_sDummy1, 
            string x_sDummy2, string x_sStatus)
        {
            if (instance == null)
                instance = new IMEIGiftStatusControl(
                    x_sCreate_Date, x_sToday1, x_sOrder_id, x_sReferenceNo,
                    x_sToday, x_sKit_Code, x_sAment_Date, x_sImei_no, 
                    x_sDummy4, x_sIMEI, x_sModel, x_sSku, 
                    x_sGetDummy1, x_sDummy3, x_sUid, x_sStock_In_Date, 
                    x_sDummy1, x_sDummy2, x_sStatus);
            return instance;
        }

        ~IMEIGiftStatusControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetCreate_Date() { return this.m_sCreate_Date; }
        public string GetToday1() { return this.m_sToday1; }
        public string GetOrder_id() { return this.m_sOrder_id; }
        public string GetReferenceNo() { return this.m_sReferenceNo; }
        public string GetToday() { return this.m_sToday; }
        public string GetKit_Code() { return this.m_sKit_Code; }
        public string GetAment_Date() { return this.m_sAment_Date; }
        public string GetImei_no() { return this.m_sImei_no; }
        public string GetDummy4() { return this.m_sDummy4; }
        public string GetIMEI() {
            if (string.IsNullOrEmpty(this.m_sIMEI)) { return string.Empty; }
            return this.m_sIMEI.Trim(); 
        }
        public string GetModel() { return this.m_sModel; }
        public string GetSku() { return this.m_sSku; }
        public string GetGetDummy1() { return this.m_sGetDummy1; }
        public string GetDummy3() { return this.m_sDummy3; }
        public string GetUid() { return this.m_sUid; }
        public string GetStock_In_Date() { return this.m_sStock_In_Date; }
        public string GetDummy1() { return this.m_sDummy1; }
        public string GetDummy2() { return this.m_sDummy2; }
        public string GetStatus() { return this.m_sStatus; }

        public bool SetCreate_Date(string value)
        {
            this.m_sCreate_Date = value;
            return true;
        }
        public bool SetToday1(string value)
        {
            this.m_sToday1 = value;
            return true;
        }
        public bool SetOrder_id(string value)
        {
            this.m_sOrder_id = value;
            return true;
        }
        public bool SetReferenceNo(string value)
        {
            this.m_sReferenceNo = value;
            return true;
        }
        public bool SetToday(string value)
        {
            this.m_sToday = value;
            return true;
        }
        public bool SetKit_Code(string value)
        {
            this.m_sKit_Code = value;
            return true;
        }
        public bool SetAment_Date(string value)
        {
            this.m_sAment_Date = value;
            return true;
        }
        public bool SetImei_no(string value)
        {
            this.m_sImei_no = value;
            return true;
        }
        public bool SetDummy4(string value)
        {
            this.m_sDummy4 = value;
            return true;
        }
        public bool SetIMEI(string value)
        {
            this.m_sIMEI = value;
            return true;
        }
        public bool SetModel(string value)
        {
            this.m_sModel = value;
            return true;
        }
        public bool SetSku(string value)
        {
            this.m_sSku = value;
            return true;
        }
        public bool SetGetDummy1(string value)
        {
            this.m_sGetDummy1 = value;
            return true;
        }
        public bool SetDummy3(string value)
        {
            this.m_sDummy3 = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetStock_In_Date(string value)
        {
            this.m_sStock_In_Date = value;
            return true;
        }
        public bool SetDummy1(string value)
        {
            this.m_sDummy1 = value;
            return true;
        }
        public bool SetDummy2(string value)
        {
            this.m_sDummy2 = value;
            return true;
        }
        public bool SetStatus(string value)
        {
            this.m_sStatus = value;
            return true;
        }
        #endregion

       

        #region Equals
        public bool Equals(IMEIGiftStatusControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sCreate_Date.Equals(x_oObj.m_sCreate_Date)) { return false; }
            if (!this.m_sToday1.Equals(x_oObj.m_sToday1)) { return false; }
            if (!this.m_sOrder_id.Equals(x_oObj.m_sOrder_id)) { return false; }
            if (!this.m_sReferenceNo.Equals(x_oObj.m_sReferenceNo)) { return false; }
            if (!this.m_sToday.Equals(x_oObj.m_sToday)) { return false; }
            if (!this.m_sKit_Code.Equals(x_oObj.m_sKit_Code)) { return false; }
            if (!this.m_sAment_Date.Equals(x_oObj.m_sAment_Date)) { return false; }
            if (!this.m_sImei_no.Equals(x_oObj.m_sImei_no)) { return false; }
            if (!this.m_sDummy4.Equals(x_oObj.m_sDummy4)) { return false; }
            if (!this.m_sIMEI.Equals(x_oObj.m_sIMEI)) { return false; }
            if (!this.m_sModel.Equals(x_oObj.m_sModel)) { return false; }
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
            if (!this.m_sGetDummy1.Equals(x_oObj.m_sGetDummy1)) { return false; }
            if (!this.m_sDummy3.Equals(x_oObj.m_sDummy3)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_sStock_In_Date.Equals(x_oObj.m_sStock_In_Date)) { return false; }
            if (!this.m_sDummy1.Equals(x_oObj.m_sDummy1)) { return false; }
            if (!this.m_sDummy2.Equals(x_oObj.m_sDummy2)) { return false; }
            if (!this.m_sStatus.Equals(x_oObj.m_sStatus)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sCreate_Date = string.Empty;
            this.m_sToday1 = string.Empty;
            this.m_sOrder_id = string.Empty;
            this.m_sReferenceNo = string.Empty;
            this.m_sToday = string.Empty;
            this.m_sKit_Code = string.Empty;
            this.m_sAment_Date = string.Empty;
            this.m_sImei_no = string.Empty;
            this.m_sDummy4= string.Empty;
            this.m_sIMEI = string.Empty;
            this.m_sModel = string.Empty;
            this.m_sSku = string.Empty;
            this.m_sGetDummy1 = string.Empty;
            this.m_sDummy3 = string.Empty;
            this.m_sUid = string.Empty;
            this.m_sStock_In_Date = string.Empty;
            this.m_sDummy1 = string.Empty;
            this.m_sDummy2 = string.Empty;
            this.m_sStatus = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public IMEIGiftStatusControl DeepClone()
        {
            IMEIGiftStatusControl IMEIGiftStatusControl_Clone = new IMEIGiftStatusControl();
            IMEIGiftStatusControl_Clone.SetCreate_Date(this.m_sCreate_Date);
            IMEIGiftStatusControl_Clone.SetToday1(this.m_sToday1);
            IMEIGiftStatusControl_Clone.SetOrder_id(this.m_sOrder_id);
            IMEIGiftStatusControl_Clone.SetReferenceNo(this.m_sReferenceNo);
            IMEIGiftStatusControl_Clone.SetToday(this.m_sToday);
            IMEIGiftStatusControl_Clone.SetKit_Code(this.m_sKit_Code);
            IMEIGiftStatusControl_Clone.SetAment_Date(this.m_sAment_Date);
            IMEIGiftStatusControl_Clone.SetImei_no(this.m_sImei_no);
            IMEIGiftStatusControl_Clone.SetDummy4(this.m_sDummy4);
            IMEIGiftStatusControl_Clone.SetIMEI(this.m_sIMEI);
            IMEIGiftStatusControl_Clone.SetModel(this.m_sModel);
            IMEIGiftStatusControl_Clone.SetSku(this.m_sSku);
            IMEIGiftStatusControl_Clone.SetGetDummy1(this.m_sGetDummy1);
            IMEIGiftStatusControl_Clone.SetDummy3(this.m_sDummy3);
            IMEIGiftStatusControl_Clone.SetUid(this.m_sUid);
            IMEIGiftStatusControl_Clone.SetStock_In_Date(this.m_sStock_In_Date);
            IMEIGiftStatusControl_Clone.SetDummy1(this.m_sDummy1);
            IMEIGiftStatusControl_Clone.SetDummy2(this.m_sDummy2);
            IMEIGiftStatusControl_Clone.SetStatus(this.m_sStatus);
            return IMEIGiftStatusControl_Clone;
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
