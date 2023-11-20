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
using System.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[BusinessRatePlanManagement],Data Relation Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class BusinessRatePlanManagement
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion     

        #region Get Rate Plan
        public global::System.Collections.Generic.List<string> Get_RatePlanList(
            string x_sProgram, string x_sNormal_rebate_type, string x_sChannel ,  string x_sIssue_type)
        {
            if (x_sProgram == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sProgram");
            //if (x_sNormal_rebate_type == null) throw new InvalidOperationException("x_sNormal_rebate_type");
            //if (x_sChannel == null) throw new InvalidOperationException("x_sChannel");
            global::System.Collections.Generic.List<string> _oRatePlanList = new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append(" SELECT DISTINCT rate_plan FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _sQuery.Append("WHERE active=1 AND rate_plan<>'' AND rate_plan is not null ");
            _sQuery.Append("AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery.Append(" AND program='" + x_sProgram.Trim() + "'");
            _sQuery.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append(" AND issue_type ='" + x_sIssue_type + "'"); }
            _sQuery.Append(" AND channel in ('ALL'");
            if (x_sChannel.Trim() != "")
                _sQuery.Append(",'" + x_sChannel.Trim() + "'");
            else
                _sQuery.Append(",'IB','OB'");
            _sQuery.Append(")");
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            if (_oReader != null)
            {
                while (_oReader.Read())
                    _oRatePlanList.Add(_oReader[BusinessTrade.Para.rate_plan].ToString());
            }
            _oReader.Close();
            _oReader.Dispose();
            return _oRatePlanList;
        }


        public global::System.Collections.Generic.List<string> Get_RatePlanList(
            string x_sProgram, string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_RatePlanList(x_sProgram, x_sNormal_rebate_type, x_sChannel, string.Empty);
        }

        #endregion

        #region Get DB
        protected static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        protected string n_sNormal_rebate_type = string.Empty;
        #region m_sNormal_rebate
        public string m_sNormal_rebate
        {
            get
            {
                return this.n_sNormal_rebate_type;
            }
            set
            {
                this.n_sNormal_rebate_type = value;
            }
        }
        #endregion m_sNormal_rebate


        protected string n_sProgram = string.Empty;
        #region m_sProgram
        public string m_sProgram
        {
            get
            {
                return this.n_sProgram;
            }
            set
            {
                this.n_sProgram = value;
            }
        }
        #endregion m_sProgram


        protected string n_sChannel = string.Empty;
        #region m_sChannel
        public string m_sChannel
        {
            get
            {
                return this.n_sChannel;
            }
            set
            {
                this.n_sChannel = value;
            }
        }
        #endregion m_sChannel

        
        #region Constructor & Destructor
        public BusinessRatePlanManagement() { }

        public BusinessRatePlanManagement(string x_sNormal_rebate_type, string x_sProgram, string x_sChannel)
        {
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sProgram = x_sProgram;
            m_sChannel = x_sChannel;
        }

        ~BusinessRatePlanManagement() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetProgram() { return this.m_sProgram; }
        public string GetChannel() { return this.m_sChannel; }

        public bool SetNormal_rebate(string value)
        {
            this.m_sNormal_rebate = value;
            return true;
        }
        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
        }
        #endregion

        

        #region Equals
        public bool Equals(BusinessRatePlanManagement x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_sNormal_rebate = string.Empty;
            this.m_sProgram = string.Empty;
            this.m_sChannel = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public BusinessRatePlanManagement DeepClone()
        {
            BusinessRatePlanManagement BusinessRatePlanManagement_Clone = new BusinessRatePlanManagement();
            BusinessRatePlanManagement_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            BusinessRatePlanManagement_Clone.SetProgram(this.m_sProgram);
            BusinessRatePlanManagement_Clone.SetChannel(this.m_sChannel);
            return BusinessRatePlanManagement_Clone;
        }
        #endregion Clone

    }
}
