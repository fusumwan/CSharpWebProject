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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :GiftIMEIControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class GiftIMEIControl : GiftIMEIControlEntity, IGiftIMEIControlEntityRepository, IDisposable
    {

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public void RecordGiftIMEI(string x_sCheck_imei)
        {
            if (x_sCheck_imei.Equals(string.Empty)) throw new FormatException();

            try
            {
                Logger.Debug("In GiftIMEIControl Function");
                Logger.Debug("Going to insert the record in EDF system");
                if (x_sCheck_imei == "gift_imei")
                {
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + GetToday() + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Code 1','','" + GetSku() + "')");
                    string _sGift_desc = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("select gift_desc from dbo." + Configurator.MSSQLTablePrefix + "GiftBasket  with (nolock) where active=1 and gift_code='" + GetSku() + "'");
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET gift_desc='" + GetGift_desc() + "', gift_imei='" + GetIMEI() + "',gift_code='" + GetSku() + "' where active=1 and order_id='" + GetOrd_id() + "' ");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Description 1','','" + GetGift_desc() + "')");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift IMEI 1','','" + GetIMEI().Trim() + "')");
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET FreeGift1='" + GetSku() + "', FG_Desc1='" + GetGift_desc() + "', FG_IMEI1='" + GetIMEI().Trim() + "' where referenceno='" + GetEdf_no() + "'");
                }
                else if (x_sCheck_imei == "gift_imei2")
                {
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Code 2','','" + GetSku() + "')");
                    string _sGift_desc = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("select gift_desc from dbo." + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock) where active=1 and gift_code='" + GetSku() + "'");
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET gift_desc2='" + GetGift_desc() + "', gift_imei2='" + GetIMEI() + "',gift_code2='" + GetSku() + "' where active=1 and order_id='" + GetOrd_id() + "'");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Description 2','','" + GetGift_desc() + "')");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift IMEI 2','','" + GetIMEI().Trim() + "')");
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET FreeGift2='" + GetSku() + "', FG_Desc2='" + GetGift_desc() + "', FG_IMEI2='" + GetIMEI().Trim() + "' where referenceno='" + GetEdf_no() + "'");
                }
                else if (x_sCheck_imei == "gift_imei3")
                {

                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Code 3','','" + GetSku() + "')");
                    string _sGift_desc = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("select gift_desc from dbo." + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock)  where active=1 and gift_code='" + GetSku() + "'");
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET gift_desc3='" + GetGift_desc() + "', gift_imei3='" + GetIMEI() + "',gift_code3='" + GetSku() + "' where active=1 and order_id='" + GetOrd_id() + "'");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Description 3','','" + GetGift_desc() + "')");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift IMEI 3','','" + GetIMEI().Trim() + "')");
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET FreeGift3='" + GetSku() + "', FG_Desc3='" + GetGift_desc() + "', FG_IMEI3='" + GetIMEI().Trim() + "' where referenceno='" + GetEdf_no() + "'");
                }
                else if (x_sCheck_imei == "gift_imei4")
                {
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Code 4','','" + GetSku() + "')");
                    string _sGift_desc = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("select gift_desc from dbo." + Configurator.MSSQLTablePrefix + "GiftBasket  with (nolock) where active=1 and gift_code='" + GetSku() + "'");
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET gift_desc4='" + GetGift_desc() + "', gift_imei4='" + GetIMEI() + "',gift_code4='" + GetSku() + "' where active=1 and order_id='" + GetOrd_id() + "'");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift Description 4','','" + GetGift_desc() + "')");
                    SetRef_no(GetRdf());
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + GetRef_no() + "','CC RET','" + GetEdf_no() + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "' ,'Free Gift IMEI 4','','" + GetIMEI().Trim() + "')");
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET FreeGift4='" + GetSku() + "', FG_Desc4='" + GetGift_desc() + "', FG_IMEI4='" + GetIMEI().Trim() + "' where referenceno='" + GetEdf_no() + "'");
                }
            }
            catch
            {
            }

        }

        string GetRdf(){
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
        private static GiftIMEIControl instance;
        #endregion

        #region Constructor & Destructor
        protected GiftIMEIControl() { }

        protected GiftIMEIControl(string x_sOrd_id, string x_sUid, string x_sToday, string x_sSku, string x_sIMEI, string x_sRef_no, string x_sGift_desc, string x_sEdf_no)
        {
            m_sOrd_id = x_sOrd_id;
            m_sUid = x_sUid;
            m_sToday = x_sToday;
            m_sSku = x_sSku;
            m_sIMEI = x_sIMEI;
            m_sRef_no = x_sRef_no;
            m_sGift_desc = x_sGift_desc;
            m_sEdf_no = x_sEdf_no;
        }

        public static GiftIMEIControl Instance()
        {
            if (instance == null)
                instance = new GiftIMEIControl();
            return instance;
        }

        public static GiftIMEIControl Instance(string x_sOrd_id, string x_sUid, string x_sToday, string x_sSku, string x_sIMEI, string x_sRef_no, string x_sGift_desc, string x_sEdf_no)
        {
            if (instance == null)
                instance = new GiftIMEIControl(x_sOrd_id, x_sUid, x_sToday, x_sSku, x_sIMEI, x_sRef_no, x_sGift_desc, x_sEdf_no);
            return instance;
        }

        ~GiftIMEIControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetOrd_id() { return this.m_sOrd_id; }
        public string GetUid() { return this.m_sUid; }
        public string GetToday() { return this.m_sToday; }
        public string GetSku() { return this.m_sSku; }
        public string GetIMEI() { return this.m_sIMEI; }
        public string GetRef_no() { return this.m_sRef_no; }
        public string GetGift_desc() { return this.m_sGift_desc; }
        public string GetEdf_no() { return this.m_sEdf_no; }

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
        public bool SetIMEI(string value)
        {
            this.m_sIMEI = value;
            return true;
        }
        public bool SetRef_no(string value)
        {
            this.m_sRef_no = value;
            return true;
        }
        public bool SetGift_desc(string value)
        {
            this.m_sGift_desc = value;
            return true;
        }
        public bool SetEdf_no(string value)
        {
            this.m_sEdf_no = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(GiftIMEIControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sOrd_id.Equals(x_oObj.m_sOrd_id)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_sToday.Equals(x_oObj.m_sToday)) { return false; }
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
            if (!this.m_sIMEI.Equals(x_oObj.m_sIMEI)) { return false; }
            if (!this.m_sRef_no.Equals(x_oObj.m_sRef_no)) { return false; }
            if (!this.m_sGift_desc.Equals(x_oObj.m_sGift_desc)) { return false; }
            if (!this.m_sEdf_no.Equals(x_oObj.m_sEdf_no)) { return false; }
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
            this.m_sIMEI = string.Empty;
            this.m_sRef_no = string.Empty;
            this.m_sGift_desc = string.Empty;
            this.m_sEdf_no = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public GiftIMEIControl DeepClone()
        {
            GiftIMEIControl GiftIMEIControl_Clone = new GiftIMEIControl();
            GiftIMEIControl_Clone.SetOrd_id(this.m_sOrd_id);
            GiftIMEIControl_Clone.SetUid(this.m_sUid);
            GiftIMEIControl_Clone.SetToday(this.m_sToday);
            GiftIMEIControl_Clone.SetSku(this.m_sSku);
            GiftIMEIControl_Clone.SetIMEI(this.m_sIMEI);
            GiftIMEIControl_Clone.SetRef_no(this.m_sRef_no);
            GiftIMEIControl_Clone.SetGift_desc(this.m_sGift_desc);
            GiftIMEIControl_Clone.SetEdf_no(this.m_sEdf_no);
            return GiftIMEIControl_Clone;
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
