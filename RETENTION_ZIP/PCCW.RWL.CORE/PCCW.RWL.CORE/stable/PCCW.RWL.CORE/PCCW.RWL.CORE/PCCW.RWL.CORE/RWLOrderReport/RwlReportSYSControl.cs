using System;
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
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :RwlReportSYSControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class RwlReportSYSControl : RwlReportSYSControlEntity, IRwlReportSYSControlEntityRepository, IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public void HistoryRecordCreate(string x_sIssue_Type)
        {
            string _sReportType = string.Empty;
            if (x_sIssue_Type == "3G_RETENTION")
            {
                _sReportType = "rwl_mod";
            }
            if (x_sIssue_Type == "2G_RETENTION")
            {
                _sReportType = "rwl_2g_mod";
            }

            string _sQuery3 = "SELECT * FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport with (nolock) where email_date='" + DateTime.Now.ToString("dd/MM/yyyy") + "' and order_id='" + GetOrder_id() + "'";
            global::System.Data.SqlClient.SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery3);
            if (_oDr.Read())
            {
                string _sQuery4 = "INSERT into " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,sent_again ) ";
                _sQuery4 += " SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + GetUid() + "',getdate(),sent_again  from " + Configurator.MSSQLTablePrefix + "MobileOrderReport  with (nolock) ";
                _sQuery4 += " WHERE order_id='" + GetOrder_id().ToString() + "' and order_status='FALLOUT' and active=1";
                SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery4);
                string _sQuery5 = "INSERT into " + Configurator.MSSQLTablePrefix + "MobileOrderReport(order_id, email_date,report_type,active) values ('" + GetOrder_id().ToString() + "','" + DateTime.Now.ToString("dd/MM/yyyy") + "','" + _sReportType + "',1 )";
                SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery4);
            }
            _oDr.Close();
            _oDr.Dispose();
        }

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

        #region Instance
        private static RwlReportSYSControl instance;
        #endregion
      
        #region Constructor & Destructor
        protected RwlReportSYSControl() { }

        protected RwlReportSYSControl(string x_sUid, DateTime x_dNow, string x_sOrder_id)
        {
            m_sUid = x_sUid;
            m_dNow = x_dNow;
            m_sOrder_id = x_sOrder_id;
        }

        public static RwlReportSYSControl Instance()
        {
            if (instance == null)
                instance = new RwlReportSYSControl();
            return instance;
        }

        public static RwlReportSYSControl Instance(string x_sUid, DateTime x_dNow, string x_sOrder_id)
        {
            if (instance == null)
                instance = new RwlReportSYSControl(x_sUid, x_dNow, x_sOrder_id);
            return instance;
        }

        ~RwlReportSYSControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetUid() { return this.m_sUid; }
        public DateTime GetNow() { return this.m_dNow; }
        public string GetOrder_id() { return this.m_sOrder_id; }

        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetNow(DateTime value)
        {
            this.m_dNow = value;
            return true;
        }
        public bool SetOrder_id(string value)
        {
            this.m_sOrder_id = value;
            return true;
        }
        #endregion        

        #region Equals
        public bool Equals(RwlReportSYSControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_dNow.Equals(x_oObj.m_dNow)) { return false; }
            if (!this.m_sOrder_id.Equals(x_oObj.m_sOrder_id)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sUid = string.Empty;
            this.m_dNow = ((DateTime)SqlDateTime.Null);
            this.m_sOrder_id = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public RwlReportSYSControl DeepClone()
        {
            RwlReportSYSControl RwlReportSYSControl_Clone = new RwlReportSYSControl();
            RwlReportSYSControl_Clone.SetUid(this.m_sUid);
            RwlReportSYSControl_Clone.SetNow(this.m_dNow);
            RwlReportSYSControl_Clone.SetOrder_id(this.m_sOrder_id);
            return RwlReportSYSControl_Clone;
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
