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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[RebateProfileControler],Data Relation Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class RebateProfileControler
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Get Plan Fee
        public string Get_PlanFee(string x_sRate_Plan){
            if (x_sRate_Plan == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sRate_Plan");
            string _sPlan_fee_rs = string.Empty;
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT plan_fee FROM " + Configurator.MSSQLTablePrefix + "RetentionPlan with (nolock) WHERE active=1 AND plan_code='" + x_sRate_Plan.Trim() + "'");
            _sPlan_fee_rs = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery.ToString());
            if (_sPlan_fee_rs == string.Empty)
                return "0";
            return _sPlan_fee_rs;
        }
        #endregion

        #region Get Premium
        public global::System.Data.SqlClient.SqlDataReader Get_Premium_DataReader(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs,
            string x_sRebate, string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_Premium_DataReader(
             x_sProgram, x_sCon_per, x_sPlan_fee_rs,
             x_sRebate, x_sNormal_rebate_type, x_sChannel, string.Empty);

        }

        public global::System.Data.SqlClient.SqlDataReader Get_Premium_DataReader(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs,
            string x_sRebate, string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            //if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            //if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sRebate == null) throw new ArgumentNullException("x_sRebate");
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append(" SELECT DISTINCT premium_1 FROM " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _sQuery.Append(" WHERE active=1 AND hs_model='P' ");
            _sQuery.Append(" AND premium_1 is not null AND premium_1 <>'' ");
            _sQuery.Append(" AND (edate is null OR edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery.Append(" AND program='" + x_sProgram.Trim() + "'");
            _sQuery.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery.Append(" AND plan_fee='" + x_sPlan_fee_rs.Trim() + "'");
            _sQuery.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            _sQuery.Append(" AND (free_mon='' OR free_mon is null)");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append(" AND issue_type='" + x_sIssue_type.Trim() + "' OR issue_type='ALL' "); }
            if (x_sRebate.Trim() != string.Empty)
                _sQuery.Append(" AND rebate='" + x_sRebate.Trim() + "'");
            else
                _sQuery.Append(" AND (rebate='' OR rebate is null)");
            _sQuery.Append(" AND channel IN ('ALL'");
            if (x_sChannel.Trim() != string.Empty)
                _sQuery.Append(",'" + x_sChannel.Trim() + "'");
            else
                _sQuery.Append(",'IB','OB'");
            _sQuery.Append(")");
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        }
        #endregion

        #region Get StartDate by Hsmodel
        private ProductItemCodeEntity[] Get_StartData_List(string x_sPremium_rs)
        {
            if (x_sPremium_rs == null) throw new InvalidOperationException("x_sPremium_rs");
            ProductItemCodeEntity[] _oProductItemCode = ProductItemCodeBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1 AND hs_model='" + x_sPremium_rs.Trim() + "' ", null, null);
            if (_oProductItemCode == null) return new ProductItemCode[0];
            return _oProductItemCode;
        }

        private global::System.Data.SqlClient.SqlDataReader Get_StartDate_DataReader(string x_sPremium_rs)
        {
            if (x_sPremium_rs == null) throw new InvalidOperationException("x_sPremium_rs");
            string _sQuery = "SELECT quota,sdate,last_stock FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock) WHERE active=1 AND hs_model='" + x_sPremium_rs.Trim() + "' ";
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        }
        #endregion

        #region Get Count of active Premium
        private int Get_Count(string x_sPremium_rs, string x_sStartDate_rs)
        {
            if (x_sPremium_rs == null) throw new ArgumentNullException("x_sPremium_rs");
            if (x_sStartDate_rs == null) throw new ArgumentNullException("x_sStartDate_rs");
            string _sQuery = "SELECT count(1) AS count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE active=1 AND premium='" + x_sPremium_rs.Trim() + "' AND log_date>='" + x_sStartDate_rs.Trim() + "'";
            return Convert.ToInt32(SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery));
        }
        #endregion

        #region Get DropDown Premium List
        public global::System.Collections.Generic.List<string> Get_DrpPremiumList(string x_sPlan_fee_rs)
        {
            if (x_sPlan_fee_rs == null) throw new InvalidOperationException("x_sPlan_fee_rs");
            return Get_DrpPremiumList(n_sProgram, n_sCon_per, x_sPlan_fee_rs, n_sRebate, n_sNormal_rebate_type, n_sChannel);
        }
        #endregion

        #region Get DropDown Premium List
        public global::System.Collections.Generic.List<string> Get_DrpPremiumList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs,
            string x_sRebate, string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_DrpPremiumList(x_sProgram, x_sCon_per, x_sPlan_fee_rs, x_sRebate, x_sNormal_rebate_type, x_sChannel, string.Empty);

        }

        public global::System.Collections.Generic.List<string> Get_DrpPremiumList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs, 
            string x_sRebate, string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            //if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            //if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sRebate == null) throw new ArgumentNullException("x_sRebate");
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sPlan_fee_rs == null) throw new ArgumentNullException("x_sPlan_fee_rs");
            global::System.Collections.Generic.List<string> _oPremiumList = new global::System.Collections.Generic.List<string>();
            string _sStartDate = string.Empty;
            global::System.Data.SqlClient.SqlDataReader _oPremiumReader = this.Get_Premium_DataReader(x_sProgram, x_sCon_per, x_sPlan_fee_rs, x_sRebate, x_sNormal_rebate_type, x_sChannel,x_sIssue_type);
            if (_oPremiumReader != null){
                while (_oPremiumReader.Read()){
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    global::System.Data.SqlClient.SqlDataReader _oStartDateReader = this.Get_StartDate_DataReader(_oPremiumReader[BusinessTrade.Para.premium_1].ToString());
                    if (_oStartDateReader != null){
                        if (_oStartDateReader.Read()){
                            if (!global::System.Convert.IsDBNull(_oStartDateReader[ProductItemCode.Para.last_stock]) && global::System.Convert.ToBoolean(_oStartDateReader[ProductItemCode.Para.last_stock].ToString())){
                                n_iLast_stock_flag = 1;
                                n_iQ_count = Convert.ToInt32(_oStartDateReader[ProductItemCode.Para.quota]);
                                if (!global::System.Convert.IsDBNull(_oStartDateReader[ProductItemCode.Para.sdate]))
                                {
                                    DateTime _dSdate = Func.ConvertDatetime(_oStartDateReader[ProductItemCode.Para.sdate].ToString());
                                    _sStartDate = _dSdate.ToString("dd/MM/yyyy");
                                }
                                else{
                                    n_iQ_count = 0;
                                    n_iP_count = 0;
                                    n_iLast_stock_flag = 0;
                                }
                            }
                        }
                        _oStartDateReader.Close(); _oStartDateReader.Dispose();
                    }
                    if (n_iLast_stock_flag == 1) { n_iP_count = this.Get_Count(_oPremiumReader[BusinessTrade.Para.premium_1].ToString(), _sStartDate); }
                    if (bCheckStock())
                        _oPremiumList.Add(_oPremiumReader[BusinessTrade.Para.premium_1].ToString());
                }
                _oPremiumReader.Close(); _oPremiumReader.Dispose();
            }
            return _oPremiumList;
        }
        #endregion

        #region CheckStock
        private bool bCheckStock()
        {
            if (n_iLast_stock_flag == 0 || (n_iLast_stock_flag == 1 && (n_iP_count < n_iQ_count))) return true;
            return false;
        }
        #endregion
		
		#region RebateGpUpdate
		protected bool RebateGpUpdate(string x_sGp,System.Nullable<int> x_iMid)
		{
		    if (Convert.IsDBNull(x_iMid) || x_iMid==null ) return false;
		    string _sQuery = "UPDATE  [RebateGroup]  SET [gp]=@gp WHERE [RebateGroup].[mid]=@mid";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@gp", SqlDbType.NVarChar).Value =x_sGp;
		        _oCmd.Parameters.Add("@mid", SqlDbType.Int).Value =x_iMid;
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
		protected bool RebateGpUpdate(string x_sCid,string x_sGp,string x_sProgram,System.Nullable<int> x_iMid)
		{
		    if (Convert.IsDBNull(x_iMid) || x_iMid==null ) return false;
		    string _sQuery = "UPDATE  [RebateGroup]  SET [cid]=@cid,[gp]=@gp,[program]=@program WHERE [RebateGroup].[mid]=@mid";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@cid", SqlDbType.Char).Value =x_sCid;
		        _oCmd.Parameters.Add("@gp", SqlDbType.NVarChar).Value =x_sGp;
		        _oCmd.Parameters.Add("@program", SqlDbType.NVarChar).Value =x_sProgram;
		        _oCmd.Parameters.Add("@mid", SqlDbType.Int).Value =x_iMid;
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
		
		protected bool RebateGpUpdate(
            System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sGp,
            string x_sProgram,System.Nullable<int> x_iMid)
		{
		    if (Convert.IsDBNull(x_iMid) || x_iMid==null ) return false;
		    string _sQuery = "UPDATE  [RebateGroup]  SET [active]=@active,[cdate]=@cdate,[cid]=@cid,[gp]=@gp,[program]=@program WHERE [RebateGroup].[mid]=@mid";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value =x_bActive;
		        _oCmd.Parameters.Add("@cdate", SqlDbType.DateTime).Value =x_dCdate;
		        _oCmd.Parameters.Add("@cid", SqlDbType.Char).Value =x_sCid;
		        _oCmd.Parameters.Add("@gp", SqlDbType.NVarChar).Value =x_sGp;
		        _oCmd.Parameters.Add("@program", SqlDbType.NVarChar).Value =x_sProgram;
		        _oCmd.Parameters.Add("@mid", SqlDbType.Int).Value =x_iMid;
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

        protected int n_iLast_stock_flag = -1;
        #region m_iLast_stock_flag
        public int m_iLast_stock_flag
        {
            get
            {
                return this.n_iLast_stock_flag;
            }
            set
            {
                this.n_iLast_stock_flag = value;
            }
        }
        #endregion m_iLast_stock_flag

        protected int n_iQ_count = -1;
        #region m_iQ_count
        public int m_iQ_count
        {
            get
            {
                return this.n_iQ_count;
            }
            set
            {
                this.n_iQ_count = value;
            }
        }
        #endregion m_iQ_count

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

        protected int n_iP_count = -1;
        #region m_iP_count
        public int m_iP_count
        {
            get
            {
                return this.n_iP_count;
            }
            set
            {
                this.n_iP_count = value;
            }
        }
        #endregion m_iP_count

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

        protected string n_sRebate = string.Empty;
        #region m_sRebate
        public string m_sRebate
        {
            get
            {
                return this.n_sRebate;
            }
            set
            {
                this.n_sRebate = value;
            }
        }
        #endregion m_sRebate

        protected string n_sFree_mon = string.Empty;
        #region m_sFree_mon
        public string m_sFree_mon
        {
            get
            {
                return this.n_sFree_mon;
            }
            set
            {
                this.n_sFree_mon = value;
            }
        }
        #endregion m_sFree_mon

        protected int n_iPlan_fee = -1;
        #region m_iPlan_fee
        public int m_iPlan_fee
        {
            get
            {
                return this.n_iPlan_fee;
            }
            set
            {
                this.n_iPlan_fee = value;
            }
        }
        #endregion m_iPlan_fee

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
        public RebateProfileControler() { }

        public RebateProfileControler(
            string x_sCon_per, int x_iLast_stock_flag, int x_iQ_count, string x_sNormal_rebate_type,
            string x_sProgram, int x_iP_count, string x_sRate_plan, string x_sRebate, string x_sFree_mon, 
            int x_iPlan_fee, string x_sChannel)
        {
            m_sCon_per = x_sCon_per;
            m_iLast_stock_flag = x_iLast_stock_flag;
            m_iQ_count = x_iQ_count;
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sProgram = x_sProgram;
            m_iP_count = x_iP_count;
            m_sRate_plan = x_sRate_plan;
            m_sRebate = x_sRebate;
            m_sFree_mon = x_sFree_mon;
            m_iPlan_fee = x_iPlan_fee;
            m_sChannel = x_sChannel;
        }

        ~RebateProfileControler() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetCon_per() { return this.m_sCon_per; }
        public int GetLast_stock_flag() { return this.m_iLast_stock_flag; }
        public int GetQ_count() { return this.m_iQ_count; }
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetProgram() { return this.m_sProgram; }
        public int GetP_count() { return this.m_iP_count; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetRebate() { return this.m_sRebate; }
        public string GetFree_mon() { return this.m_sFree_mon; }
        public int GetPlan_fee() { return this.m_iPlan_fee; }
        public string GetChannel() { return this.m_sChannel; }

        public bool SetCon_per(string value)
        {
            this.m_sCon_per = value;
            return true;
        }
        public bool SetLast_stock_flag(int value)
        {
            this.m_iLast_stock_flag = value;
            return true;
        }
        public bool SetQ_count(int value)
        {
            this.m_iQ_count = value;
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
        public bool SetP_count(int value)
        {
            this.m_iP_count = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetRebate(string value)
        {
            this.m_sRebate = value;
            return true;
        }
        public bool SetFree_mon(string value)
        {
            this.m_sFree_mon = value;
            return true;
        }
        public bool SetPlan_fee(int value)
        {
            this.m_iPlan_fee = value;
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

        #region Equals
        public bool Equals(RebateProfileControler x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            if (!this.m_iLast_stock_flag.Equals(x_oObj.m_iLast_stock_flag)) { return false; }
            if (!this.m_iQ_count.Equals(x_oObj.m_iQ_count)) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_iP_count.Equals(x_oObj.m_iP_count)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sRebate.Equals(x_oObj.m_sRebate)) { return false; }
            if (!this.m_sFree_mon.Equals(x_oObj.m_sFree_mon)) { return false; }
            if (!this.m_iPlan_fee.Equals(x_oObj.m_iPlan_fee)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sCon_per = string.Empty;
            this.m_iLast_stock_flag = -1;
            this.m_iQ_count = -1;
            this.m_sNormal_rebate = string.Empty;
            this.m_sProgram = string.Empty;
            this.m_iP_count = -1;
            this.m_sRate_plan = string.Empty;
            this.m_sRebate = string.Empty;
            this.m_sFree_mon = string.Empty;
            this.m_iPlan_fee = -1;
            this.m_sChannel = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public RebateProfileControler DeepClone()
        {
            RebateProfileControler RebateProfileControler_Clone = new RebateProfileControler();
            RebateProfileControler_Clone.SetCon_per(this.m_sCon_per);
            RebateProfileControler_Clone.SetLast_stock_flag(this.m_iLast_stock_flag);
            RebateProfileControler_Clone.SetQ_count(this.m_iQ_count);
            RebateProfileControler_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            RebateProfileControler_Clone.SetProgram(this.m_sProgram);
            RebateProfileControler_Clone.SetP_count(this.m_iP_count);
            RebateProfileControler_Clone.SetRate_plan(this.m_sRate_plan);
            RebateProfileControler_Clone.SetRebate(this.m_sRebate);
            RebateProfileControler_Clone.SetFree_mon(this.m_sFree_mon);
            RebateProfileControler_Clone.SetPlan_fee(this.m_iPlan_fee);
            RebateProfileControler_Clone.SetChannel(this.m_sChannel);
            return RebateProfileControler_Clone;
        }
        #endregion Clone

    }
}
