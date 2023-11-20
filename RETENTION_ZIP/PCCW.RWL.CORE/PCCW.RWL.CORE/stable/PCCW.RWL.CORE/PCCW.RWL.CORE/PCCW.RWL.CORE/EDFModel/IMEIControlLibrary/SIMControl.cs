using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
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

///-- =============================================
///-- Author:		<Author,Ben Wong>
///-- Create date: <Create Date 2010-08-09 Mon>
///-- Description:	<Description,Class :SIMControl, Data Access Object Control>
///-- =============================================

namespace PCCW.RWL.CORE
{
    public class SIMControl : SIMControlEntity, ISIMControlEntityRepository
    {
        #region Instance
        private static SIMControl instance;
        #endregion

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        
        #region Constructor & Destructor
        public SIMControl() { }

        public SIMControl(
            string x_sSim_no, string x_sReserve, string x_sReferenceno, 
            string x_sDummy1, string x_sAssign_date
            )
        {
            m_sSim_no = x_sSim_no;
            m_sReserve = x_sReserve;
            m_sReferenceno = x_sReferenceno;
            m_sDummy1 = x_sDummy1;
            m_sAssign_date = x_sAssign_date;
        }

        
        public static SIMControl Instance()
        {
            if (instance == null)
                instance = new SIMControl();
            return instance;
        }

        public static SIMControl Instance(
            string x_sSim_no, string x_sReserve, string x_sReferenceno, 
            string x_sDummy1, string x_sAssign_date)
        {
            if (instance == null)
                instance = new SIMControl(x_sSim_no, x_sReserve, x_sReferenceno, x_sDummy1, x_sAssign_date);
            return instance;
        }

        ~SIMControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetSim_no() { return this.m_sSim_no; }
        public string GetReserve() { return this.m_sReserve; }
        public string GetReferenceno() { return this.m_sReferenceno; }
        public string GetDummy1() { return this.m_sDummy1; }
        public string GetAssign_date() { return this.m_sAssign_date; }
        public bool SetSim_no(string value)
        {
            this.m_sSim_no = value;
            return true;
        }

        public bool SetReserve(string value)
        {
            this.m_sReserve = value;
            return true;
        }
        public bool SetReferenceno(string value)
        {
            this.m_sReferenceno = value;
            return true;
        }
        public bool SetDummy1(string value)
        {
            this.m_sDummy1 = value;
            return true;
        }
        public bool SetAssign_date(string value)
        {
            this.m_sAssign_date = value;
            return true;
        }
        #endregion

        #region ReservedSimItem
        
        // check if item_no is reserved and not by ame order id
        public bool checkReserveSIM(string x_sOrder_id)
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT TOP 1 item_no FROM dbo.ReservedSimItem ");
            _oQuery.Append("WHERE (order_id='" + x_sOrder_id + "' or ");
            _oQuery.Append("item_no='" + GetSim_no() + "') and ");
            _oQuery.Append("exp_date < getDate() ");

            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());

            while (_oDr.Read())
            {
                _oDr.Close();
                _oDr.Dispose();
                return false;
            }
            _oDr.Close();
            _oDr.Dispose();
            return true;
        }

        public void reserveSIM(string x_sOrder_id)
        {
            bool _bInsertReservedSimItem = false;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("INSERT INTO dbo.ReservedSimItem(");
            _oQuery.Append("order_id,item_no,item_code,c_date,exp_date");
            _oQuery.Append(") values (");
            _oQuery.Append("'" + x_sOrder_id + "',");
            _oQuery.Append("'" + GetSim_no() + "',");
            _oQuery.Append("'" + GetReserve() + "',");
            _oQuery.Append("getDate(),");
            _oQuery.Append("DATEADD(minute,5,getDate())");
            _oQuery.Append(")");

            _bInsertReservedSimItem = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
        }

        public void releaseReservedSIM(string x_sOrder_id)
        {
            bool _bDeleteReservedSimItem = false;
            string _sOrder_id = (string.IsNullOrEmpty(x_sOrder_id)) ? "" : x_sOrder_id;

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("DELETE FROM dbo.ReservedSimItem ");
            _oQuery.Append("WHERE order_id='" + x_sOrder_id + "'");

            _bDeleteReservedSimItem = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());

        }

        public void releaseExpiredReservedSIM()
        {
            bool _bDeleteExpiredReservedSimItem = false;

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("DELETE FROM dbo.ReservedSimItem ");
            _oQuery.Append("WHERE exp_date<'" + DateTime.Now + "'");

            _bDeleteExpiredReservedSimItem = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());

        }
        
        #endregion

        #region Sunday_sim_no

        public string getAnotherAvaliableSIM()
        {
            StringBuilder _oQuery = new StringBuilder();
            string returnValue = string.Empty;
            /*
            _oQuery.Append("SELECT sim_no FROM sunday_sim_no WHERE ");
            _oQuery.Append("reserve='" + GetReserve() + "' and ");
            _oQuery.Append("dummy1='" + GetDummy1() + "' and ");
            _oQuery.Append("(referenceno='' or referenceno is null) and ");
            _oQuery.Append("(assign_date='' or assign_date is null) ");

            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr.Read())
            {
                returnValue = Func.FR(_oDr["sim_no"]).Trim();
            }
            _oDr.Close();
            _oDr.Dispose();
            */
            return returnValue;

        }

        public bool isSIMAvaliable()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT sim_no FROM sunday_sim_no ");
            _oQuery.Append("WHERE sim_no='" + GetSim_no() + "' and ");
            _oQuery.Append("reserve='" + GetReserve() + "' and ");
            _oQuery.Append("dummy1='" + GetDummy1() + "' and ");
            _oQuery.Append("(referenceno='' or referenceno is null) and ");
            _oQuery.Append("(assign_date='' or assign_date is null) ");

            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());

            while (_oDr.Read())
            {
                _oDr.Close();
                _oDr.Dispose();
                return true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return false;
        }

        public void orderSIM()
        {
            // get sim_item_number by sim_item_code @ sunday_sim_no


            // checkReserveSIM()


            // reserveSIM()


        }

        public void releaseSIM()
        {

        }

        public void UpdateEDFNoToSIM()
        {
            bool _bUpdateSundaySimNo = false;
            StringBuilder _oQuery = new StringBuilder();
            SetAssign_date(string.Format("{0:yyyyMMdd}", DateTime.Now));

            _oQuery.Append("UPDATE SUNDAY_SIM_NO SET ");
            _oQuery.Append("reserve='" + GetReserve() + "', ");
            _oQuery.Append("referenceno='" + GetReferenceno() + "', ");
            _oQuery.Append("dummy1='" + GetDummy1() + "', ");
            //_oQuery.Append("assign_date='" + GetAssign_date() + "' ");
            _oQuery.Append("assign_date='" + GetAssign_date() + "' ");
            _oQuery.Append("WHERE sim_no='" + GetSim_no() + "'");

            _bUpdateSundaySimNo = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
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


        #region Equals
        public bool Equals(SIMControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sSim_no.Equals(x_oObj.m_sSim_no)) { return false; }
            if (!this.m_sReserve.Equals(x_oObj.m_sReserve)) { return false; }
            if (!this.m_sReferenceno.Equals(x_oObj.m_sReferenceno)) { return false; }
            if (!this.m_sDummy1.Equals(x_oObj.m_sDummy1)) { return false; }
            if (!this.m_sAssign_date.Equals(x_oObj.m_sAssign_date)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sSim_no = string.Empty;
            this.m_sReserve = string.Empty;
            this.m_sReferenceno = string.Empty;
            this.m_sDummy1 = string.Empty;
            this.m_sAssign_date = string.Empty;
        }
        #endregion Release


        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}

