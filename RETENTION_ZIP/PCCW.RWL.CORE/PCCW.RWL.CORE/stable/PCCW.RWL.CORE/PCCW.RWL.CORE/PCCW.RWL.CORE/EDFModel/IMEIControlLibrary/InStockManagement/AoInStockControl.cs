using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE.SERIAL;
using log4net;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Thu>
///-- Description:	<Description,Class :AoInStockControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class AoInStockControl : AoInStockControlEntity, IAoInStockControlEntityRepository, IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
        #region
        public void UpdateSoldStatus(ref MobileRetentionOrder x_sMobileRetentionOrder)
        {
            if (x_sMobileRetentionOrder == null) throw new ArgumentNullException("x_sMobileRetentionOrder");
            _oOrderSerialNumberControl.SetOrder_id((int)x_sMobileRetentionOrder.GetOrder_id());
            global::System.Data.Odbc.OdbcDataReader _oDr4 = GetORDB().GetSearch("SELECT referenceNo FROM sunday_Form WHERE CREATED_BY='CC RET' and Agree_no='" + Func.IDAdd100000(Convert.ToInt32(GetOrder_id())) + "' and cancelled='N' ");
            if (!_oDr4.Read()){
                string _sAment_Date = string.Empty;
                if (string.IsNullOrEmpty(x_sMobileRetentionOrder.GetEdf_no())) {
                    if (string.IsNullOrEmpty(GetRefNo())){

                            //=== get EDF# ===
                        SetRefNo(_oOrderSerialNumberControl.ReferenceNumber);

                    }
                }
                InitAmertDate();
                bool _bInsert = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) values ('" + GetKit_Code() + "','" + GetModel() + "','" + GetStatus() + "','" + GetReferenceNo() + "','" + GetDummy4() + "',to_date('" + GetToday() + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "','" + GetDummy1() + "','" + GetDummy2() + "','" + GetStock_In_Date() + "','" + GetIMEI() + "',to_date('" + GetAment_Date() + "' , 'yyyymmdd')) ");
                bool _bUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='SOLD', Dummy1='" + GetToday1() + "'  , DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(GetOrder_id())) + "', ReferenceNo='" + GetRefNo() + "', StaffNo='" + GetStaff_no() + "',Mobile_no='" + GetMrt_no() + "' ,Completed_Date='" + GetToday1() + "'  WHERE IMEI='" + GetImei_no() + "' AND Status='NORMAL'");
            }
            _oDr4.Close();
            _oDr4.Dispose();
        }
        #endregion

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

        #region InitAmertDate
        private void InitAmertDate(){

            string[] _sFormat = { "yyyyMMdd", "yyyyMMdd HH:mm:ss", "yyyyMMdd H:mm:ss", "MM/dd/yyyy", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy H:mm:ss" };
            if (string.IsNullOrEmpty(GetDummy1()) || "".Equals(GetDummy1()))
            {
                DateTime _dCreateDate;
                if (DateTime.TryParseExact(GetCreateDate(), _sFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCreateDate))
                    SetAment_Date(_dCreateDate.ToString("yyyyMMdd"));
                else
                    SetAment_Date(GetDummy1());
                //SetAment_Date(DateTime.ParseExact(GetCreateDate(), _sFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToString("yyyyMMdd"));
            }
            else
                SetAment_Date(GetDummy1());
        }

        #endregion

        #region Constructor & Destructor
        public AoInStockControl() { }

        public AoInStockControl(
            string x_sCreateDate,string x_sMrt_no,string x_sSku, string x_sStaff_no,
            string x_sToday, string x_sToday1, string x_sDummy1, string x_sDummy4, 
            string x_sUid, string x_sReferenceNo, string x_sModel, string x_sOrder_id, 
            string x_sIMEI, string x_sDummy2, string x_sStatus, string x_sStock_In_Date, 
            string x_sKit_Code, string x_sImei_no, string x_sAment_Date, string x_sRefNo)
        {
            m_sCreateDate = x_sCreateDate;
            m_sMrt_no = x_sMrt_no;
            m_sStaff_no = x_sStaff_no;
            m_sSku = x_sSku;
            m_sToday = x_sToday;
            m_sToday1 = x_sToday1;
            m_sDummy1 = x_sDummy1;
            m_sDummy4= x_sDummy4;
            m_sUid = x_sUid;
            m_sReferenceNo = x_sReferenceNo;
            m_sModel = x_sModel;
            m_sOrder_id = x_sOrder_id;
            m_sIMEI = x_sIMEI;
            m_sDummy2 = x_sDummy2;
            m_sStatus = x_sStatus;
            m_sStock_In_Date = x_sStock_In_Date;
            m_sKit_Code = x_sKit_Code;
            m_sImei_no = x_sImei_no;
            m_sAment_Date = x_sAment_Date;
            m_sRefNo = x_sRefNo;
        }

        ~AoInStockControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetCreateDate() { return this.m_sCreateDate; }
        public string GetMrt_no() { return this.m_sMrt_no; }
        public string GetSku() { return this.m_sSku; }
        public string GetStaff_no() { return this.m_sStaff_no; }
        public string GetToday() { return this.m_sToday; }
        public string GetToday1() { return this.m_sToday1; }
        public string GetDummy1() { return this.m_sDummy1; }
        public string GetDummy4() { return this.m_sDummy4; }
        public string GetUid() { return this.m_sUid; }
        public string GetReferenceNo() { return this.m_sReferenceNo; }
        public string GetModel() { return this.m_sModel; }
        public string GetOrder_id() { return this.m_sOrder_id; }
        public string GetIMEI() { return this.m_sIMEI; }
        public string GetDummy2() { return this.m_sDummy2; }
        public string GetStatus() { return this.m_sStatus; }
        public string GetStock_In_Date() { return this.m_sStock_In_Date; }
        public string GetKit_Code() { return this.m_sKit_Code; }
        public string GetImei_no() { return this.m_sImei_no; }
        public string GetAment_Date() { return this.m_sAment_Date; }
        public string GetRefNo() { return this.m_sRefNo; }

        public bool SetCreateDate(string value)
        {
            this.m_sCreateDate = value;
            return true;
        }
        public bool SetMrt_no(string value)
        {
            this.m_sMrt_no = value;
            return true;
        }
        public bool SetStaff_no(string value)
        {
            this.m_sStaff_no = value;
            return true;
        }
        public bool SetSku(string value)
        {
            this.m_sSku = value;
            return true;
        }
        public bool SetToday(string value)
        {
            this.m_sToday = value;
            return true;
        }
        public bool SetToday1(string value)
        {
            this.m_sToday1 = value;
            return true;
        }
        public bool SetDummy1(string value)
        {
            this.m_sDummy1 = value;
            return true;
        }
        public bool SetDummy4(string value)
        {
            this.m_sDummy4= value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetReferenceNo(string value)
        {
            this.m_sReferenceNo = value;
            return true;
        }
        public bool SetModel(string value)
        {
            this.m_sModel = value;
            return true;
        }
        public bool SetOrder_id(string value)
        {
            this.m_sOrder_id = value;
            return true;
        }
        public bool SetIMEI(string value)
        {
            this.m_sIMEI = value;
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
        public bool SetStock_In_Date(string value)
        {
            this.m_sStock_In_Date = value;
            return true;
        }
        public bool SetKit_Code(string value)
        {
            this.m_sKit_Code = value;
            return true;
        }
        public bool SetImei_no(string value)
        {
            this.m_sImei_no = value;
            return true;
        }
        public bool SetAment_Date(string value)
        {
            this.m_sAment_Date = value;
            return true;
        }
        public bool SetRefNo(string value)
        {
            this.m_sRefNo = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(AoInStockControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sMrt_no.Equals(x_oObj.m_sMrt_no)) { return false; }
            if (!this.m_sStaff_no.Equals(x_oObj.m_sStaff_no)) { return false;}
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
            if (!this.m_sToday.Equals(x_oObj.m_sToday)) { return false; }
            if (!this.m_sToday1.Equals(x_oObj.m_sToday1)) { return false; }
            if (!this.m_sDummy1.Equals(x_oObj.m_sDummy1)) { return false; }
            if (!this.m_sDummy4.Equals(x_oObj.m_sDummy4)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_sReferenceNo.Equals(x_oObj.m_sReferenceNo)) { return false; }
            if (!this.m_sModel.Equals(x_oObj.m_sModel)) { return false; }
            if (!this.m_sOrder_id.Equals(x_oObj.m_sOrder_id)) { return false; }
            if (!this.m_sIMEI.Equals(x_oObj.m_sIMEI)) { return false; }
            if (!this.m_sDummy2.Equals(x_oObj.m_sDummy2)) { return false; }
            if (!this.m_sStatus.Equals(x_oObj.m_sStatus)) { return false; }
            if (!this.m_sStock_In_Date.Equals(x_oObj.m_sStock_In_Date)) { return false; }
            if (!this.m_sKit_Code.Equals(x_oObj.m_sKit_Code)) { return false; }
            if (!this.m_sImei_no.Equals(x_oObj.m_sImei_no)) { return false; }
            if (!this.m_sAment_Date.Equals(x_oObj.m_sAment_Date)) { return false; }
            if (!this.m_sRefNo.Equals(x_oObj.m_sRefNo)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sStaff_no = string.Empty;
            this.m_sSku = string.Empty;
            this.m_sToday = string.Empty;
            this.m_sToday1 = string.Empty;
            this.m_sDummy1 = string.Empty;
            this.m_sDummy4 = string.Empty;
            this.m_sUid = string.Empty;
            this.m_sReferenceNo = string.Empty;
            this.m_sModel = string.Empty;
            this.m_sOrder_id = string.Empty;
            this.m_sIMEI = string.Empty;
            this.m_sDummy2 = string.Empty;
            this.m_sStatus = string.Empty;
            this.m_sStock_In_Date = string.Empty;
            this.m_sKit_Code = string.Empty;
            this.m_sImei_no = string.Empty;
            this.m_sAment_Date = string.Empty;
            this.m_sRefNo = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public AoInStockControl DeepClone()
        {
            AoInStockControl AoInStockControl_Clone = new AoInStockControl();
            AoInStockControl_Clone.SetStaff_no(this.m_sStaff_no);
            AoInStockControl_Clone.SetSku(this.m_sSku);
            AoInStockControl_Clone.SetToday(this.m_sToday);
            AoInStockControl_Clone.SetToday(this.m_sToday1);
            AoInStockControl_Clone.SetDummy1(this.m_sDummy1);
            AoInStockControl_Clone.SetDummy4(this.m_sDummy4);
            AoInStockControl_Clone.SetUid(this.m_sUid);
            AoInStockControl_Clone.SetReferenceNo(this.m_sReferenceNo);
            AoInStockControl_Clone.SetModel(this.m_sModel);
            AoInStockControl_Clone.SetOrder_id(this.m_sOrder_id);
            AoInStockControl_Clone.SetIMEI(this.m_sIMEI);
            AoInStockControl_Clone.SetDummy2(this.m_sDummy2);
            AoInStockControl_Clone.SetStatus(this.m_sStatus);
            AoInStockControl_Clone.SetStock_In_Date(this.m_sStock_In_Date);
            AoInStockControl_Clone.SetKit_Code(this.m_sKit_Code);
            AoInStockControl_Clone.SetImei_no(this.m_sImei_no);
            AoInStockControl_Clone.SetAment_Date(this.m_sAment_Date);
            AoInStockControl_Clone.SetRefNo(this.m_sRefNo);
            return AoInStockControl_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose(){
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
