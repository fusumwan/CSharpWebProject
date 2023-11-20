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
using System.Linq;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[BusinessContractPeriodControleration],Data Releation Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class BusinessContractPeriodControler
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Get Con_Per
        public global::System.Collections.Generic.List<string> Get_DrpConPerList()
        {
            return this.Get_ConPerList(n_sProgram, n_sRate_plan, n_sNormal_rebate_type, n_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpConPerList(
            string x_sProgram, string x_sRatePlan, string x_sNormal_rebate_type, string x_sChannel)
        {
            return this.Get_ConPerList(x_sProgram, x_sRatePlan, x_sNormal_rebate_type, x_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpConPerList(
            string x_sProgram, string x_sRatePlan, string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            return this.Get_ConPerList(x_sProgram, x_sRatePlan, x_sNormal_rebate_type, x_sChannel, x_sIssue_type);
        }

        public global::System.Collections.Generic.List<string> Get_ConPerList(
            string x_sProgram, string x_sRatePlan, string x_sNormal_rebate_type, string x_sChannel, string x_sIssue_type)
        {
            if (x_sProgram == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sProgram");
            if (x_sRatePlan == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sRatePlan");
            if (x_sNormal_rebate_type == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sNormal_rebate_type");
            if (x_sChannel == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sChannel");

            global::System.Collections.Generic.List<string> _oConPerList = new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT DISTINCT con_per FROM " + Configurator.MSSQLTablePrefix + "BusinessTrade WITH (NOLOCK) WHERE active=1  AND (edate is null or edate >getdate()-1) AND sdate<=getdate() AND con_per<>'' AND con_per is not null ");
            _sQuery.Append(" AND program='" + x_sProgram.Trim() + "'");
            _sQuery.Append(" AND rate_plan='" + x_sRatePlan.Trim() + "'");
            _sQuery.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append(" AND issue_type='" + x_sIssue_type.Trim() + "' OR issue_type='ALL' "); }
            _sQuery.Append(" AND channel in ('ALL'");
            if (x_sChannel.Trim() != "")
                _sQuery.Append(",'" + x_sChannel.Trim() + "'");
            else
                _sQuery.Append(",'IB','OB'");
            _sQuery.Append(")");

            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            if (_oReader != null){
                while (_oReader.Read())
                    _oConPerList.Add(_oReader[BusinessTrade.Para.con_per].ToString());
            }
            _oReader.Close(); _oReader.Dispose();
            return _oConPerList;
        }
        #endregion
		
		#region
		protected bool HsmodelUpdate(string x_sHs_model_name,Nullable<int> x_iMid)
		{
            if (Convert.IsDBNull(x_iMid) || x_iMid == null) return false;
            string _sQuery = "UPDATE  [BusinessTrade]  SET [hs_model_name]=@hs_model_name WHERE [BusinessTrade].[x_iMid]=@x_iMid";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@hs_model_name", SqlDbType.NVarChar).Value =x_sHs_model_name;
                _oCmd.Parameters.Add("@mid", SqlDbType.NVarChar).Value = x_iMid;
		        try
		        {
		            _oConn.Open();
		            _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
		        }
		        catch (Exception error)
		        {
		        }
		        finally
		        {
		            _oConn.Close();
		            _oCmd.Dispose();
		            _oConn.Dispose();
		        }
		        return _bResult;
		    }
		}
		
		protected bool TradeFieldUpdateByHs(string x_sTrade_field,string x_sHs_model_name, Nullable<int> x_iMid)
		{
		    if (Convert.IsDBNull(x_iMid) || x_iMid==null ) return false;
            string _sQuery = "UPDATE  [BusinessTrade]  SET [trade_field]=@trade_field WHERE [BusinessTrade].[hs_model_name]=@hs_model_name AND [BusinessTrade].[mid]=@mid";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@trade_field", SqlDbType.NVarChar).Value =x_sTrade_field;
		        _oCmd.Parameters.Add("@hs_model_name", SqlDbType.NVarChar).Value =x_sHs_model_name;
                _oCmd.Parameters.Add("@mid", SqlDbType.NVarChar).Value = x_iMid;
		        try
		        {
		            _oConn.Open();
		            _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
		        }
		        catch (Exception error)
		        {
		        }
		        finally
		        {
		            _oConn.Close();
		            _oCmd.Dispose();
		            _oConn.Dispose();
		        }
		        return _bResult;
		    }
		}
		
		protected bool PremiumUpdateBy(
            string x_sPremium_1,string x_sHs_model_name,System.Nullable<int> x_iMid,System.Nullable<bool> x_bActive)
		{
		    if (Convert.IsDBNull(x_iMid) || x_iMid==null ) return false;
		    string _sQuery = "UPDATE  [BusinessTrade]  SET [premium_1]=@premium_1 WHERE [BusinessTrade].[hs_model_name]=@hs_model_name AND [BusinessTrade].[mid]=@mid AND [BusinessTrade].[active]=@active";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@premium_1", SqlDbType.NVarChar).Value =x_sPremium_1;
		        _oCmd.Parameters.Add("@hs_model_name", SqlDbType.NVarChar).Value =x_sHs_model_name;
		        _oCmd.Parameters.Add("@mid", SqlDbType.Int).Value =x_iMid;
		        _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value =x_bActive;
		        try
		        {
		            _oConn.Open();
		            _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
		        }
		        catch (Exception error)
		        {
		        }
		        finally
		        {
		            _oConn.Close();
		            _oCmd.Dispose();
		            _oConn.Dispose();
		        }
		        return _bResult;
		    }
		}
		#endregion
		
        protected string n_sCon_per = string.Empty;
        #region m_sCon_per
        public string m_sCon_per
        {
            get
            {
                return this.n_sCon_per;
            }
            set
            {
                this.n_sCon_per = value;
            }
        }
        #endregion m_sCon_per


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


        protected string n_sRate_plan = string.Empty;
        #region m_sRate_plan
        public string m_sRate_plan
        {
            get
            {
                return this.n_sRate_plan;
            }
            set
            {
                this.n_sRate_plan = value;
            }
        }
        #endregion m_sRate_plan


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
        public BusinessContractPeriodControler() { }

        public BusinessContractPeriodControler(string x_sCon_per, string x_sNormal_rebate_type, string x_sProgram, string x_sRate_plan, string x_sChannel)
        {
            m_sCon_per = x_sCon_per;
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sProgram = x_sProgram;
            m_sRate_plan = x_sRate_plan;
            m_sChannel = x_sChannel;
        }

        ~BusinessContractPeriodControler() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetCon_per() { return this.m_sCon_per; }
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetProgram() { return this.m_sProgram; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetChannel() { return this.m_sChannel; }

        public bool SetCon_per(string value)
        {
            this.m_sCon_per = value;
            return true;
        }
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
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
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

        #region Get Plan Fee
        public IQueryable<BusinessTradeEntity> Get_DrpTradePlanFeeList(string x_sRatePlan)
        {
            return this.Get_TradePlanFeeList(x_sRatePlan);
        }

        public IQueryable<BusinessTradeEntity> Get_DrpTradePlanFeeList(string x_sRatePlan,string x_sIssue_type)
        {
            return this.Get_TradePlanFeeList(x_sRatePlan, x_sIssue_type);
        }

        public IQueryable<BusinessTradeEntity> Get_DrpTradePlanFeeList()
        {
            return this.Get_TradePlanFeeList(n_sRate_plan);
        }

        public IQueryable<BusinessTradeEntity> Get_TradePlanFeeList(string x_sRatePlan,string x_sIssue_type)
        {
            if (x_sRatePlan == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sRatePlan");
            IQueryable<BusinessTradeEntity> _oBusinessTradeQA = null;
            if (!string.IsNullOrEmpty(x_sIssue_type))
            {
                BusinessTradeRepositoryBase _oBusinessTradeRepositoryBase = new BusinessTradeRepositoryBase(SYSConn<MSSQLConnect>.Connect());
                _oBusinessTradeQA = from sRwlTrade in _oBusinessTradeRepositoryBase.BusinessTrades
                                                                    where
                                                                        sRwlTrade.active == true &&
                                                                        sRwlTrade.rate_plan == x_sRatePlan
                                                                    select sRwlTrade;
            }
            else if (string.IsNullOrEmpty(x_sIssue_type))
            {
                BusinessTradeRepositoryBase _oBusinessTradeRepositoryBase = new BusinessTradeRepositoryBase(SYSConn<MSSQLConnect>.Connect());
                _oBusinessTradeQA = from sRwlTrade in _oBusinessTradeRepositoryBase.BusinessTrades
                                                                    where
                                                                        sRwlTrade.active == true &&
                                                                        sRwlTrade.rate_plan == x_sRatePlan &&
                                                                        sRwlTrade.issue_type == x_sIssue_type
                                                                    select sRwlTrade;
            }
            return _oBusinessTradeQA;
        }

        public int CheckIssueType(string x_sSysIssueType, string x_sIssue_type)
        {
            if (string.IsNullOrEmpty(x_sIssue_type)) return 1;
            if (x_sSysIssueType.Equals(x_sIssue_type))
                return 1;
            else
                return 0;
        }

        public IQueryable<BusinessTradeEntity> Get_TradePlanFeeList(string x_sRatePlan)
        {
            return Get_TradePlanFeeList(x_sRatePlan, string.Empty);
        }
        #endregion

        #region Equals
        public bool Equals(BusinessContractPeriodControler x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sCon_per = string.Empty;
            this.m_sNormal_rebate = string.Empty;
            this.m_sProgram = string.Empty;
            this.m_sRate_plan = string.Empty;
            this.m_sChannel = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public BusinessContractPeriodControler DeepClone()
        {
            BusinessContractPeriodControler BusinessContractPeriodControler_Clone = new BusinessContractPeriodControler();
            BusinessContractPeriodControler_Clone.SetCon_per(this.m_sCon_per);
            BusinessContractPeriodControler_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            BusinessContractPeriodControler_Clone.SetProgram(this.m_sProgram);
            BusinessContractPeriodControler_Clone.SetRate_plan(this.m_sRate_plan);
            BusinessContractPeriodControler_Clone.SetChannel(this.m_sChannel);
            return BusinessContractPeriodControler_Clone;
        }
        #endregion Clone

    }
}
