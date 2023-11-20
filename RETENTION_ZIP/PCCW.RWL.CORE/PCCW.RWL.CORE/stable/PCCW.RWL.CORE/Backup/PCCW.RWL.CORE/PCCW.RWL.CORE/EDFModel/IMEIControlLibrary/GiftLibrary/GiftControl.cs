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
using System.Xml.Linq;

using System.Data.Odbc;

using System.Data.SqlTypes;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :GiftControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class GiftControl : GiftControlEntity, IGiftControlEntityRepository, IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public global::System.Data.Odbc.OdbcDataReader IMEINormalWithSku(string x_sSku){
            if (x_sSku == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sSku");
            string _sQuery1 = "SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND Status='NORMAL' AND Kit_Code='" + x_sSku + "' AND IMEI<>' '";
            return GetORDB().GetSearch(_sQuery1);
        }

        public void RecordGift(){
            InitAmentDateEdf();
            GetORDB().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) VALUES ('" + GetKit_Code() + "','" + GetModel() + "','" + GetStatus() + "','" + GetReferenceNo() + "','" + GetDummy4() + "',to_date('" + GetToday() + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "','" + GetDummy1() + "','" + GetDummy2() + "','" + GetStock_In_Date() + "','" + GetIMEI() + "',to_date('" + GetAment_Date() + "' , 'yyyymmdd')) ");
            GetORDB().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='SOLD', ReferenceNo='" + GetEdf_no() + "', DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.RQ(GetOrd_id()))) + "', Dummy1='" + GetToday1() + "', StaffNo='" + GetUid() + "',Completed_Date='" + GetToday() + "' WHERE IMEI='" + GetIMEI() + "' AND Dummy2='CC RET' AND Kit_Code='" + GetSku() + "'");
        }

        private void InitAmentDateEdf(){
            SetEdf_no(SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT edf_no FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE active=1 AND order_id='" + GetOrd_id() + "'"));
            string _sAment_Date = string.Empty;
            //=== get EDF# ===
            string[] _sFormat = { "yyyyMMdd", "yyyyMMdd HH:mm:ss", "yyyyMMdd H:mm:ss", "MM/dd/yyyy", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy H:mm:ss" };
            if (string.IsNullOrEmpty(GetDummy1()) || "".Equals(GetDummy1()))
            {
                DateTime _dCreateDate;
                if (DateTime.TryParseExact(GetCreate_Date(), _sFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCreateDate))
                    SetAment_Date(_dCreateDate.ToString("yyyyMMdd"));
                else
                    SetAment_Date(GetDummy1());
            }
            else
                SetAment_Date(GetDummy1());
        }

        public string GetRdf(){
            global::System.Data.Odbc.OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT FTS_CPE5_Serial.NextVal AS seq, to_char(sysdate, 'yymon') AS cdate FROM dual");
            string _sRefNo = string.Empty;
            if (_oDr2 != null){
                if (_oDr2.Read())
                    _sRefNo = _oDr2["seq"].ToString() + "/A/" + _oDr2["cdate"].ToString();
            }
            _oDr2.Close();
            _oDr2.Dispose();
            return _sRefNo;
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

        #region Instance
        private static GiftControl instance;
        #endregion

        #region Constructor & Destructor
        protected GiftControl() { }

        protected GiftControl(
            string x_sCreate_Date, string x_sToday1, string x_sDummy4, 
            string x_sReferenceNo, string x_sToday, string x_sKit_Code, string x_sAment_Date,
            string x_sOrd_id, string x_sEdf_no, string x_sIMEI, string x_sModel, 
            string x_sSku, string x_sUid, string x_sStock_In_Date, string x_sDummy1, 
            string x_sDummy2, string x_sStatus)
        {
            m_sCreate_Date = x_sCreate_Date;
            m_sToday1 = x_sToday1;
            m_sDummy4= x_sDummy4;
            m_sReferenceNo = x_sReferenceNo;
            m_sToday = x_sToday;
            m_sKit_Code = x_sKit_Code;
            m_sAment_Date = x_sAment_Date;
            m_sOrd_id = x_sOrd_id;
            m_sEdf_no = x_sEdf_no;
            m_sIMEI = x_sIMEI;
            m_sModel = x_sModel;
            m_sSku = x_sSku;
            m_sUid = x_sUid;
            m_sStock_In_Date = x_sStock_In_Date;
            m_sDummy1 = x_sDummy1;
            m_sDummy2 = x_sDummy2;
            m_sStatus = x_sStatus;
        }

        public static GiftControl Instance()
        {
            if (instance == null)
                instance = new GiftControl();
            return instance;
        }

        public static GiftControl Instance(
            string x_sCreate_Date, string x_sToday1, string x_sDummy4, 
            string x_sReferenceNo, string x_sToday, string x_sKit_Code, 
            string x_sAment_Date, string x_sOrd_id, string x_sEdf_no, 
            string x_sIMEI, string x_sModel, string x_sSku, string x_sUid,
            string x_sStock_In_Date, string x_sDummy1, string x_sDummy2, 
            string x_sStatus)
        {
            if (instance == null)
                instance = new GiftControl(
                    x_sCreate_Date, x_sToday1, x_sDummy4, x_sReferenceNo, 
                    x_sToday, x_sKit_Code, x_sAment_Date, x_sOrd_id, x_sEdf_no,
                    x_sIMEI, x_sModel, x_sSku, x_sUid, x_sStock_In_Date, x_sDummy1, 
                    x_sDummy2, x_sStatus);
            return instance;
        }

        ~GiftControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetCreate_Date() { return this.m_sCreate_Date; }
        public string GetToday1() { return this.m_sToday1; }
        public string GetDummy4() { return this.m_sDummy4; }
        public string GetReferenceNo() { return this.m_sReferenceNo; }
        public string GetToday() { return this.m_sToday; }
        public string GetKit_Code() { return this.m_sKit_Code; }
        public string GetAment_Date() { return this.m_sAment_Date; }
        public string GetOrd_id() { return this.m_sOrd_id; }
        public string GetEdf_no() { return this.m_sEdf_no; }
        public string GetIMEI() { return this.m_sIMEI; }
        public string GetModel() { return this.m_sModel; }
        public string GetSku() { return this.m_sSku; }
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
        public bool SetDummy4(string value)
        {
            this.m_sDummy4= value;
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
        public bool SetOrd_id(string value)
        {
            this.m_sOrd_id = value;
            return true;
        }
        public bool SetEdf_no(string value)
        {
            this.m_sEdf_no = value;
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
        public bool Equals(GiftControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sCreate_Date.Equals(x_oObj.m_sCreate_Date)) { return false; }
            if (!this.m_sToday1.Equals(x_oObj.m_sToday1)) { return false; }
            if (!this.m_sDummy4.Equals(x_oObj.m_sDummy4)) { return false; }
            if (!this.m_sReferenceNo.Equals(x_oObj.m_sReferenceNo)) { return false; }
            if (!this.m_sToday.Equals(x_oObj.m_sToday)) { return false; }
            if (!this.m_sKit_Code.Equals(x_oObj.m_sKit_Code)) { return false; }
            if (!this.m_sAment_Date.Equals(x_oObj.m_sAment_Date)) { return false; }
            if (!this.m_sOrd_id.Equals(x_oObj.m_sOrd_id)) { return false; }
            if (!this.m_sEdf_no.Equals(x_oObj.m_sEdf_no)) { return false; }
            if (!this.m_sIMEI.Equals(x_oObj.m_sIMEI)) { return false; }
            if (!this.m_sModel.Equals(x_oObj.m_sModel)) { return false; }
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
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
            this.m_sDummy4= string.Empty;
            this.m_sReferenceNo = string.Empty;
            this.m_sToday = string.Empty;
            this.m_sKit_Code = string.Empty;
            this.m_sAment_Date = string.Empty;
            this.m_sOrd_id = string.Empty;
            this.m_sEdf_no = string.Empty;
            this.m_sIMEI = string.Empty;
            this.m_sModel = string.Empty;
            this.m_sSku = string.Empty;
            this.m_sUid = string.Empty;
            this.m_sStock_In_Date = string.Empty;
            this.m_sDummy1 = string.Empty;
            this.m_sDummy2 = string.Empty;
            this.m_sStatus = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public GiftControl DeepClone()
        {
            GiftControl GiftControl_Clone = new GiftControl();
            GiftControl_Clone.SetCreate_Date(this.m_sCreate_Date);
            GiftControl_Clone.SetToday1(this.m_sToday1);
            GiftControl_Clone.SetDummy4(this.m_sDummy4);
            GiftControl_Clone.SetReferenceNo(this.m_sReferenceNo);
            GiftControl_Clone.SetToday(this.m_sToday);
            GiftControl_Clone.SetKit_Code(this.m_sKit_Code);
            GiftControl_Clone.SetAment_Date(this.m_sAment_Date);
            GiftControl_Clone.SetOrd_id(this.m_sOrd_id);
            GiftControl_Clone.SetEdf_no(this.m_sEdf_no);
            GiftControl_Clone.SetIMEI(this.m_sIMEI);
            GiftControl_Clone.SetModel(this.m_sModel);
            GiftControl_Clone.SetSku(this.m_sSku);
            GiftControl_Clone.SetUid(this.m_sUid);
            GiftControl_Clone.SetStock_In_Date(this.m_sStock_In_Date);
            GiftControl_Clone.SetDummy1(this.m_sDummy1);
            GiftControl_Clone.SetDummy2(this.m_sDummy2);
            GiftControl_Clone.SetStatus(this.m_sStatus);
            return GiftControl_Clone;
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
