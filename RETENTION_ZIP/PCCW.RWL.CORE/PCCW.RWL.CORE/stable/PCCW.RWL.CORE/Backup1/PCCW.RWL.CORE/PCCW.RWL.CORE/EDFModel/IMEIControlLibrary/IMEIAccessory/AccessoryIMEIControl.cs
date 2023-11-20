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

using System.Data.SqlTypes;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :AccessoryIMEIControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class AccessoryIMEIControl : AccessoryIMEIControlEntity, IAccessoryIMEIControlEntityRepository, IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public void RecordAccessoryIMEI(){
            try
            {
                SetRef_no(GetRdf());
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + GetToday() + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Code','','" + GetSku() + "')");
                SetGift_desc(string.Empty);
                SetAccessory_price(string.Empty);
                AccessoryEntity[] _oAccessorys = AccessoryBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1 and accessory_code='" + GetSku() + "'", null, null);
                if (_oAccessorys != null){
                    foreach (AccessoryEntity _oAccessory in _oAccessorys){
                        SetGift_desc(_oAccessory.accessory_desc);
                        SetAccessory_price(_oAccessory.accessory_price);
                    }
                }
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder set accessory_desc='" + GetGift_desc() + "',accessory_code='" + GetSku() + "', accessory_imei='" + GetIMEI() + "',accessory_price='" + GetAccessory_price() + "'  where active=1 and order_id='" + GetOrd_id() + "'");
                SetRef_no(GetRdf());
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + GetToday() + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Description','','" + GetGift_desc() + "')");
                SetRef_no(GetRdf());
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + GetToday() + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift IMEI','','" + GetIMEI() + "')");
                SetRef_no(GetRdf());
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + GetToday() + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Accessory Cost','0','" + GetAccessory_price() + "')");
                SetGift_desc(string.Empty);
                int _iAmount = 0;
                int _iAccessory_price = 0;
                int _iNew_amount = 0;
                global::System.Data.SqlClient.SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch("select amount from dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and order_id='" + GetOrd_id() + "' ");
                if (_oDr3.Read()){
                    SetGift_desc(Func.FR(_oDr3[MobileRetentionOrder.Para.accessory_desc]));
                    if (string.IsNullOrEmpty(Func.FR(_oDr3[MobileRetentionOrder.Para.amount]).Trim()))
                        _iAmount = 0;
                    else
                        _iAmount = Convert.ToInt32(Func.FR(_oDr3[MobileRetentionOrder.Para.amount]).Trim());
                    if (string.IsNullOrEmpty(Func.FR(_oDr3[MobileRetentionOrder.Para.accessory_price]).Trim()))
                        _iAccessory_price = 0;
                    else
                        _iAccessory_price = Convert.ToInt32(Func.FR(_oDr3[MobileRetentionOrder.Para.accessory_price]).Trim());
                    _iNew_amount = _iAmount + _iAccessory_price;
                }
                _oDr3.Close();
                _oDr3.Dispose();
                SetRef_no(GetRdf());
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + GetToday() + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Order Amount','" + _iAmount.ToString() + "','" + _iNew_amount.ToString() + "')");
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form set CASH_AMT='" + GetAccessory_price() + "', Order_Amt=Order_Amt+" + GetAccessory_price() + ", Plan_code='" + GetSku() + "', FG_Code='" + GetGift_desc() + "', FG_IMEI0='" + GetIMEI() + "' where referenceno='" + GetEdf_no() + "'");
            }
            catch { Logger.DebugFormat("Accessory (uid={0} , ref_no= {1}) has cannot update success the current IMEI Control in edf system.", GetUid().ToString(), GetRef_no()); }
        }

        public string GetRdf()
        {
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
        private static AccessoryIMEIControl instance;
        #endregion

        #region Constructor & Destructor
        protected AccessoryIMEIControl() { }

        protected AccessoryIMEIControl(
            string x_sOrd_id, string x_sUid, string x_sToday, string x_sSku, 
            string x_sEdf_no, string x_sRef_no, string x_sIMEI, string x_sAccessory_price, 
            string x_sGift_desc)
        {
            m_sOrd_id = x_sOrd_id;
            m_sUid = x_sUid;
            m_sToday = x_sToday;
            m_sSku = x_sSku;
            m_sEdf_no = x_sEdf_no;
            m_sRef_no = x_sRef_no;
            m_sIMEI = x_sIMEI;
            m_sAccessory_price = x_sAccessory_price;
            m_sGift_desc = x_sGift_desc;
        }

        public static AccessoryIMEIControl Instance()
        {
            if (instance == null)
                instance = new AccessoryIMEIControl();
            return instance;
        }

        public AccessoryIMEIControl CreateInstance()
        {
            return new AccessoryIMEIControl();
        }

        public static AccessoryIMEIControl Instance(
            string x_sOrd_id, string x_sUid, string x_sToday, string x_sSku, 
            string x_sEdf_no, string x_sRef_no, string x_sIMEI, 
            string x_sAccessory_price, string x_sGift_desc)
        {
            if (instance == null)
                instance = new AccessoryIMEIControl(
                    x_sOrd_id, x_sUid, x_sToday, x_sSku, x_sEdf_no, 
                    x_sRef_no, x_sIMEI, x_sAccessory_price,
                    x_sGift_desc);
            return instance;
        }

        ~AccessoryIMEIControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetOrd_id() { return this.m_sOrd_id; }
        public string GetUid() { return this.m_sUid; }
        public string GetToday() { return this.m_sToday; }
        public string GetSku() { return this.m_sSku; }
        public string GetEdf_no() { return this.m_sEdf_no; }
        public string GetRef_no() { return this.m_sRef_no; }
        public string GetIMEI() { return this.m_sIMEI; }
        public string GetAccessory_price() { return this.m_sAccessory_price; }
        public string GetGift_desc() { return this.m_sGift_desc; }

        public bool SetOrd_id(string value)
        {
            this.m_sOrd_id = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetToday(string value)
        {
            this.m_sToday = value;
            return true;
        }
        public bool SetSku(string value)
        {
            this.m_sSku = value;
            return true;
        }
        public bool SetEdf_no(string value)
        {
            this.m_sEdf_no = value;
            return true;
        }
        public bool SetRef_no(string value)
        {
            this.m_sRef_no = value;
            return true;
        }
        public bool SetIMEI(string value)
        {
            this.m_sIMEI = value;
            return true;
        }
        public bool SetAccessory_price(string value)
        {
            this.m_sAccessory_price = value;
            return true;
        }
        public bool SetGift_desc(string value)
        {
            this.m_sGift_desc = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(AccessoryIMEIControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sOrd_id.Equals(x_oObj.m_sOrd_id)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_sToday.Equals(x_oObj.m_sToday)) { return false; }
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
            if (!this.m_sEdf_no.Equals(x_oObj.m_sEdf_no)) { return false; }
            if (!this.m_sRef_no.Equals(x_oObj.m_sRef_no)) { return false; }
            if (!this.m_sIMEI.Equals(x_oObj.m_sIMEI)) { return false; }
            if (!this.m_sAccessory_price.Equals(x_oObj.m_sAccessory_price)) { return false; }
            if (!this.m_sGift_desc.Equals(x_oObj.m_sGift_desc)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sOrd_id = string.Empty;
            this.m_sUid = string.Empty;
            this.m_sToday = string.Empty;
            this.m_sSku = string.Empty;
            this.m_sEdf_no = string.Empty;
            this.m_sRef_no = string.Empty;
            this.m_sIMEI = string.Empty;
            this.m_sAccessory_price = string.Empty;
            this.m_sGift_desc = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public AccessoryIMEIControl DeepClone()
        {
            AccessoryIMEIControl AccessoryIMEIControl_Clone = new AccessoryIMEIControl();
            AccessoryIMEIControl_Clone.SetOrd_id(this.m_sOrd_id);
            AccessoryIMEIControl_Clone.SetUid(this.m_sUid);
            AccessoryIMEIControl_Clone.SetToday(this.m_sToday);
            AccessoryIMEIControl_Clone.SetSku(this.m_sSku);
            AccessoryIMEIControl_Clone.SetEdf_no(this.m_sEdf_no);
            AccessoryIMEIControl_Clone.SetRef_no(this.m_sRef_no);
            AccessoryIMEIControl_Clone.SetIMEI(this.m_sIMEI);
            AccessoryIMEIControl_Clone.SetAccessory_price(this.m_sAccessory_price);
            AccessoryIMEIControl_Clone.SetGift_desc(this.m_sGift_desc);
            return AccessoryIMEIControl_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose() {

            this.Dispose();
        }
        public void Dispose()
        {
        }

    }
}
