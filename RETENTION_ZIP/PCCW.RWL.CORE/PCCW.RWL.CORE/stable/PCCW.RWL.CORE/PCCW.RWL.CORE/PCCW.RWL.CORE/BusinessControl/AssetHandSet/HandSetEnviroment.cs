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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[HandSetEnvironment],Data Relation Access Object Control>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public class HandSetEnvironment
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Get RatePlan By PlanCode

        public IQueryable<RetentionPlanEntity> Get_RatePlan_By_PlanCode(string x_sPlanCode)
        {
            if (x_sPlanCode == null) throw new ArgumentNullException("x_sPlanCode");
            RetentionPlanRepositoryBase _oRetentionPlanRepositoryBase =
                new RetentionPlanRepositoryBase(SYSConn<MSSQLConnect>.Connect());
            IQueryable<RetentionPlanEntity> _oRwlPlanQA =
                from sRwlPlan in _oRetentionPlanRepositoryBase.RetentionPlans
                where
                sRwlPlan.active == true && sRwlPlan.plan_code == x_sPlanCode.Trim()
                select sRwlPlan;
            return _oRwlPlanQA;
        }
        #endregion

        #region Get HandSet In Rebate Group DataReader
        public global::System.Data.SqlClient.SqlDataReader Get_HsInRebateGp_DataReader(
            string x_sCon_per, string x_sPlan_fee, string x_sNormal_rebate_type, string x_sProgram, string x_sIssue_type)
        {
            //if (x_sCon_per == null) throw new InvalidOperationException("x_sCon_per");
            //if (x_sPlan_fee == null) throw new InvalidOperationException("x_sPlan_fee");
            if (x_sProgram == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sProgram");
            //if (x_sNormal_rebate_type == null) throw new InvalidOperationException("x_sNormal_rebate_type");
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT DISTINCT a.hs_model hs_model FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "RebateGroup b with (nolock), ");
            _sQuery.Append(" (SELECT plan_fee, con_per, hs_model,rebate_gp,normal_rebate FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "HandSetOfferedBasket with (nolock) ");
            _sQuery.Append(" WHERE active=1 AND (hs_model is not null and hs_model <>'') ");
            _sQuery.Append(" AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery.Append(" AND plan_fee='" + x_sPlan_fee.Trim() + "'");
            _sQuery.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            //if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append(" AND issue_type='" + x_sIssue_type.Trim() + "' OR issue_type='ALL' "); }
            _sQuery.Append(" ) a WHERE b.active=1 AND a.rebate_gp=b.gp ");
            _sQuery.Append(" AND b.program='" + x_sProgram.Trim() + "'");
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        }
        #endregion

        #region Get StartDay of HandSet
        public string Get_StartDay_Of_HS(string x_sHsmodel, string x_sType)
        {
            if (x_sHsmodel == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sHsmodel");
            //if (x_sType == null) throw new InvalidOperationException("x_sType");
            string _sFilter = string.Empty;
            _sFilter = "active=1 AND hs_model='" + x_sHsmodel.Trim() + "' ";
            if (!string.IsNullOrEmpty(x_sType) && x_sType != null) { _sFilter += " AND type='" + x_sType.Trim() + "'"; }
            global::System.Data.SqlClient.SqlDataReader _oReader =
                ProductItemCodeBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "quota,sdate,last_stock", _sFilter, null, null);
            if (_oReader != null)
            {
                if (_oReader.Read())
                {
                    if (!global::System.Convert.IsDBNull(_oReader[ProductItemCode.Para.last_stock]))
                    {
                        if (!global::System.Convert.IsDBNull(_oReader[ProductItemCode.Para.last_stock]) &&
                            global::System.Convert.ToBoolean(_oReader[ProductItemCode.Para.last_stock].ToString()))
                        {
                            this.n_iLast_stock_flag = 1;
                            //this.n_iQ_count = Convert.ToInt32(_oReader[ProductItemCode.Para.quota].ToString());

                            if (int.TryParse(_oReader[ProductItemCode.Para.quota].ToString(), out this.n_iQ_count))
                            {
                                if (!global::System.Convert.IsDBNull(_oReader[ProductItemCode.Para.sdate]) &&
                                    !Func.FR(_oReader[ProductItemCode.Para.sdate]).Trim().Equals(string.Empty))
                                {
                                    if (Func.IsParseDateTime(Func.FR(_oReader[ProductItemCode.Para.sdate]).Trim()))
                                    {
                                        DateTime _dSdate = Func.ConvertDatetime(_oReader[ProductItemCode.Para.sdate].ToString());
                                        _oReader.Close(); _oReader.Dispose();
                                        return _dSdate.ToString("dd/MM/yyyy");
                                    }
                                    else
                                    {
                                        n_iQ_count = 0;
                                        n_iP_count = 0;
                                        n_iLast_stock_flag = 0;
                                    }
                                }
                                else
                                {
                                    n_iQ_count = 0;
                                    n_iP_count = 0;
                                    n_iLast_stock_flag = 0;
                                }
                            }
                        }
                    }
                }
                _oReader.Close(); _oReader.Dispose();
            }
            if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
            return string.Empty;
        }
        #endregion

        #region Get Count order by Handset AND Start date
        public int Get_CountOfOrder_byHsSdate(string x_sHsmodel, string x_sSdate)
        {
            if (x_sHsmodel == null) throw new ArgumentNullException("x_sHsmodel");
            if (x_sSdate == null) throw new ArgumentNullException("x_sSdate");
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT top 1 count(1) as count FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) ");
            _oQuery.Append(" WHERE active=1 ");
            _oQuery.Append(" AND hs_model='" + x_sHsmodel.Trim() + "' ");
            _oQuery.Append(" AND log_date>='" + x_sSdate.Trim() + "' ");
            string _sResult = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString()).ToString();
            int _iResult;
            if (int.TryParse(_sResult, out _iResult))
            {
                if (_iResult < 0) return -1;
                return _iResult;
            }
            return -1;
        }
        #endregion

        #region Get Count order by Premium AND Start date
        public int Get_CountOfOrder_byPreSdate(string x_sPremium, string x_sSdate)
        {
            if (x_sPremium == null) throw new InvalidOperationException("x_sSku");
            if (x_sSdate == null) throw new InvalidOperationException("x_sSdate");
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT count(1) AS count FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) ");
            _oQuery.Append("WHERE active=1 AND premium='" + x_sPremium.Trim() + "' AND log_date>='" + x_sSdate.Trim() + "' ");

            string _sResult = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString()).ToString();
            int _iResult;
            if (int.TryParse(_sResult, out _iResult))
            {
                if (_iResult < 0) return -1;
                return _iResult;
            }
            return -1;
        }
        #endregion





        #region Get Rebate List
        public global::System.Collections.Generic.List<string> Get_DrpRebateList()
        {
            return this.Get_RebateList(n_sProgram, n_sCon_per, n_sRate_plan, n_sPlan_fee, n_sNormal_rebate_type, n_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpRebateList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel)
        {
            return this.Get_RebateList(x_sProgam, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpRebateList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel, string x_sIssue_type)
        {
            return this.Get_RebateList(x_sProgam, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel, x_sIssue_type);
        }

        public global::System.Collections.Generic.List<string> Get_RebateList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel, string x_sIssue_type)
        {
            //if (x_sProgam == null) throw new ArgumentNullException("x_sProgram");
            //if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sPlan_fee == null) throw new ArgumentNullException("x_sPlan_fee");
            //if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");

            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            global::System.Collections.Generic.List<string> _oRebatelist =
                new global::System.Collections.Generic.List<string>();
            _sQuery.Append("  SELECT DISTINCT rebate FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)   ");
            _sQuery.Append("  WHERE active=1 AND rebate<>'' ");
            _sQuery.Append(" AND rebate is not null ");
            _sQuery.Append(" AND (edate is null or edate >getdate()-1) AND sdate<=getdate()   ");
            _sQuery.Append("  AND program='" + x_sProgam.Trim() + "'");
            _sQuery.Append("  AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery.Append("  AND program='" + x_sProgam.Trim() + "'");
            _sQuery.Append("  AND rate_plan='" + x_sRate_plan.Trim() + "'");
            _sQuery.Append("  AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append("  AND issue_type='" + x_sIssue_type.Trim() + "'"); }
            _sQuery.Append("  AND channel in ('ALL'");
            if (x_sChannel.Trim() != string.Empty)
                _sQuery.Append(",'" + x_sChannel.Trim() + "'");
            else
                _sQuery.Append(",'IB','OB'");
            _sQuery.Append(") AND rebate is not null");
            global::System.Data.SqlClient.SqlDataReader _oReader =
                SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            if (_oReader != null)
            {
                while (_oReader.Read())
                    _oRebatelist.Add(_oReader[BusinessTrade.Para.rebate].ToString());
                if (_oReader != null) { _oReader.Close(); }
            }
            _oReader.Dispose();
            return _oRebatelist;
        }
        #endregion

        #region Get Fee Mon
        public global::System.Collections.Generic.List<string> Get_FeeMonList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            //if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sPlan_fee == null) throw new ArgumentNullException("x_sPlan_fee");
            //if (x_sProgam == null) throw new ArgumentNullException("x_sProgram");
            //if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");

            global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();
            global::System.Collections.Generic.List<string> _oFeeMonlist =
                new global::System.Collections.Generic.List<string>();
            _oQuery.Append("  SELECT DISTINCT free_mon FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _oQuery.Append("  WHERE active=1 AND free_mon<>'' ");
            _oQuery.Append(" AND free_mon is not null ");
            _oQuery.Append(" AND (edate is null or edate >getdate()-1) ");
            _oQuery.Append(" AND sdate<=getdate()");
            _oQuery.Append("  AND program='" + x_sProgam.Trim() + "'");
            _oQuery.Append("   AND con_per='" + x_sCon_per.Trim() + "'");
            _oQuery.Append("  AND rate_plan='" + x_sRate_plan.Trim() + "'");
            _oQuery.Append("  AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _oQuery.Append("  AND issue_type='" + x_sIssue_type.Trim() + "'"); }
            _oQuery.Append("  AND channel in ('ALL'");
            if (x_sChannel.Trim() != string.Empty)
                _oQuery.Append(",'" + x_sChannel.Trim() + "'");
            else
                _oQuery.Append(",'IB','OB'");
            _oQuery.Append(") AND free_mon is not null");
            global::System.Data.SqlClient.SqlDataReader _oReader =
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oReader != null)
            {
                while (_oReader.Read())
                    _oFeeMonlist.Add(_oReader[BusinessTrade.Para.free_mon].ToString());
                if (_oReader != null) _oReader.Close();
            }
            _oReader.Dispose();
            return _oFeeMonlist;
        }
        #endregion

        #region Get SPremiumList
        public global::System.Collections.Generic.List<string> Get_SPremiumList(string x_sCon_per, string x_sRate_plan)
        {
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");
            global::System.Collections.Generic.List<string> _oSPremiumList =
                new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();
            _oQuery.Append(" SELECT DISTINCT s_premium FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "SpecialPremium with (nolock) ");
            _oQuery.Append("WHERE active=1 AND s_premium<>'' AND s_premium is not null");
            _oQuery.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _oQuery.Append(" AND rate_plan='" + x_sRate_plan.Trim() + "' AND s_premium is not null");
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oReader != null)
            {
                while (_oReader.Read())
                    _oSPremiumList.Add(_oReader[SpecialPremium.Para.s_premium].ToString());
                if (_oReader != null) { _oReader.Close(); }
            }
            _oReader.Dispose();
            return _oSPremiumList;
        }
        #endregion

        #region Get SPremiumList Type 2

        public global::System.Data.SqlClient.SqlDataReader Get_HsmodelbyType(string x_sType)
        {
            if (x_sType == null) throw new ArgumentNullException("x_sType");
            return SYSConn<MSSQLConnect>.Connect()
            .GetSearch("SELECT DISTINCT hs_model FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock) WHERE active=1 AND hs_model<>'' AND type='" + x_sType + "'");
        }

        public global::System.Collections.Generic.List<string> Get_SPremiumTypeHs()
        {
            global::System.Collections.Generic.List<string> _oHandSetList =
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = Get_HsmodelbyType("SPMU");
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = Get_StartDay_Of_HS(_oReader[ProductItemCode.Para.hs_model].ToString(), "SPMU");
                    if (this.n_iLast_stock_flag == 1)
                    {
                        int _iP = this.Get_CountOfOrder_byHsSdate(_oReader[ProductItemCode.Para.hs_model].ToString(), _sStartDate);
                        if (_iP != -1)
                            n_iP_count = _iP;
                    }
                    if (bCheckStock())
                        _oHandSetList.Add(_oReader[ProductItemCode.Para.hs_model].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
                _oReader = null;
            }
            return _oHandSetList;
        }


        public global::System.Collections.Generic.List<string> Get_SPremiumType1Hs()
        {
            global::System.Collections.Generic.List<string> _oHandSetList =
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = Get_HsmodelbyType("SPMU1");
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = Get_StartDay_Of_HS(_oReader[ProductItemCode.Para.hs_model].ToString(), "SPMU1");
                    if (this.n_iLast_stock_flag == 1)
                    {
                        int _iP = this.Get_CountOfOrder_byHsSdate(_oReader[ProductItemCode.Para.hs_model].ToString(), _sStartDate);
                        if (_iP != -1)
                            n_iP_count = _iP;
                    }
                    if (bCheckStock())
                        _oHandSetList.Add(_oReader[ProductItemCode.Para.hs_model].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
                _oReader = null;
            }
            return _oHandSetList;
        }

        public global::System.Collections.Generic.List<string> Get_SPremiumType2Hs()
        {
            global::System.Collections.Generic.List<string> _oHandSetList =
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = Get_HsmodelbyType("SPMU2");
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = Get_StartDay_Of_HS(_oReader[ProductItemCode.Para.hs_model].ToString(), "SPMU2");
                    if (this.n_iLast_stock_flag == 1)
                    {
                        int _iP = this.Get_CountOfOrder_byHsSdate(_oReader[ProductItemCode.Para.hs_model].ToString(), _sStartDate);
                        if (_iP != -1)
                            n_iP_count = _iP;
                    }
                    if (bCheckStock())
                        _oHandSetList.Add(_oReader[ProductItemCode.Para.hs_model].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
                _oReader = null;
            }
            return _oHandSetList;
        }
        #endregion

        #region CheckStock
        private bool bCheckStock()
        {
            if (n_iLast_stock_flag == 0 || (n_iLast_stock_flag == 1 && (n_iP_count < n_iQ_count))) return true;
            return false;
        }
        #endregion

        #region Get Premium by con_per,plan_fee,normal_rebate,program


        public global::System.Data.SqlClient.SqlDataReader Get_Premium_DataReader(
            string x_sCon_per, string x_sPlan_fee, string x_sNormal_rebate_type, string x_sProgram,string x_sIssue_type)
        {
            if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            if (x_sPlan_fee == null) throw new ArgumentNullException("x_sPlan_fee");
            if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            global::System.Collections.Generic.List<string> _sPremium = new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT DISTINCT a.premium premium FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "RebateGroup b with (nolock), ");
            _sQuery.Append(" (SELECT plan_fee, con_per, premium,rebate_gp,normal_rebate FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "HandSetOfferedBasket with (nolock) ");
            _sQuery.Append(" WHERE active=1 AND (premium is not null and premium <>'') ");
            _sQuery.Append("AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery.Append(" AND plan_fee='" + x_sPlan_fee.Trim() + "'");
            _sQuery.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            //if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append(" AND issue_type='" + x_sIssue_type.Trim() + "' OR issue_type='ALL' "); }
            _sQuery.Append(" ) a WHERE b.active=1 AND a.rebate_gp=b.gp ");
            _sQuery.Append(" AND b.program='" + x_sProgram.Trim() + "'");
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        }

        public global::System.Data.SqlClient.SqlDataReader Get_Premium_DataReader(
            string x_sCon_per, string x_sRatePlan, bool x_bNormal_rebate_type, string x_sProgram,string x_sIssue_type)
        {
            if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            if (x_sRatePlan == null) throw new ArgumentNullException("x_sRatePlan");
            if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");

            global::System.Collections.Generic.List<string> _sPremium =
                new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT DISTINCT a.premium FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "RebateGroup b with (nolock), ");
            _sQuery.Append(" (SELECT DISTINCT premium,rebate_gp FROM ");
            _sQuery.Append(Configurator.MSSQLTablePrefix + "HandSetOfferedBasket with (nolock) ");
            _sQuery.Append(" WHERE active=1 AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery.Append(" AND issue_type='" + x_sIssue_type.Trim() + "' OR issue_type='ALL' "); }
            if (x_bNormal_rebate_type)
                _sQuery.Append(" AND normal_rebate_type!='' ");
            else
                _sQuery.Append(" AND (normal_rebate_type='' OR normal_rebate_type IS NULL) ");

            _sQuery.Append(" AND (premium is not null or premium <>'') AND con_per='" + x_sCon_per.Trim() + "' AND plan_fee in (select plan_fee from " + Configurator.MSSQLTablePrefix + "RetentionPlan with (nolock) WHERE active=1 AND plan_code='" + x_sRatePlan.Trim() + "')) a WHERE a.rebate_gp=b.gp AND b.active=1 AND b.program='" + x_sProgram.Trim() + "'");
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        }

        #endregion

        #region Get HsRelation

        public global::System.Collections.Generic.List<string> Get_DrpHandSetList()
        {
            return Get_DrpHandSetList(n_sProgram, n_sCon_per, n_sRate_plan, n_sPlan_fee, n_sNormal_rebate_type, n_sChannel);
        }
        public global::System.Collections.Generic.List<string> Get_DrpHandSetList(
            string x_sProgram, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee, string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_DrpHandSetList(x_sProgram, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel, string.Empty);

        }

        public global::System.Collections.Generic.List<string> Get_DrpHandSetList(
            string x_sProgram, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee, string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            if (x_sPlan_fee == null) throw new ArgumentNullException("x_sPlan_fee");
            if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");

            global::System.Collections.Generic.List<string> _oHandSetList =
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader =
                this.Get_HsInRebateGp_DataReader(x_sCon_per, x_sPlan_fee, x_sNormal_rebate_type, x_sProgram, x_sIssue_type);
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = Get_StartDay_Of_HS(_oReader[HandSetOfferedBasket.Para.hs_model].ToString(), null);
                    if (this.n_iLast_stock_flag == 1)
                    {
                        int _iP = this.Get_CountOfOrder_byHsSdate(_oReader[HandSetOfferedBasket.Para.hs_model].ToString(), _sStartDate);
                        if (_iP != -1)
                            n_iP_count = _iP;
                    }
                    if (bCheckStock())
                        _oHandSetList.Add(_oReader[HandSetOfferedBasket.Para.hs_model].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
            }
            return _oHandSetList;
        }
        public global::System.Collections.Generic.List<string> Get_DrpPremiumList(
            string x_sCon_per, string x_sRate_pan, bool x_bNormal_rebate_type, string x_sProgram)
        {
            return Get_DrpPremiumList(x_sCon_per, x_sRate_pan, x_bNormal_rebate_type, x_sProgram, string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpPremiumList(
            string x_sCon_per, string x_sRate_pan, bool x_bNormal_rebate_type, string x_sProgram,string x_sIssue_type)
        {
            if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_bNormal_rebate == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            if (x_sRate_pan == null) throw new ArgumentNullException("x_sRate_plan");
            global::System.Collections.Generic.List<string> _oPremiumList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader =
                this.Get_Premium_DataReader(x_sCon_per, x_sRate_pan, x_bNormal_rebate_type, x_sProgram, x_sIssue_type);
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = this.Get_StartDay_Of_HS(_oReader[HandSetOfferedBasket.Para.premium].ToString(), null);
                    if (n_iLast_stock_flag == 1)
                    {
                        int _iPc = this.Get_CountOfOrder_byPreSdate(_oReader[HandSetOfferedBasket.Para.premium].ToString(), _sStartDate);
                        if (_iPc != -1)
                            n_iP_count = _iPc;
                    }
                    if (bCheckStock())
                        _oPremiumList.Add(_oReader[HandSetOfferedBasket.Para.premium].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
            }
            return _oPremiumList;
        }

        public global::System.Collections.Generic.List<string> Get_DrpPremiumList(
            string x_sProgram, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            bool x_bNormal_rebate, string x_sChannel,string x_sIssue_type)
        {
            if (x_sProgram == null) throw new InvalidOperationException("x_sProgram");
            if (x_bNormal_rebate == null) throw new InvalidOperationException("x_sNormal_rebate_type");
            if (x_sChannel == null) throw new InvalidOperationException("x_sChannel");
            if (x_sCon_per == null) throw new InvalidOperationException("x_sCon_per");
            if (x_sPlan_fee == null) throw new InvalidOperationException("x_sPlan_fee");
            if (x_sRate_plan == null) throw new InvalidOperationException("x_sRate_plan");

            global::System.Collections.Generic.List<string> _oPremiumList =
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader =
                this.Get_Premium_DataReader(x_sCon_per, x_sPlan_fee, x_bNormal_rebate, x_sProgram, x_sIssue_type);
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = this.Get_StartDay_Of_HS(_oReader[HandSetOfferedBasket.Para.premium].ToString(), null);
                    if (n_iLast_stock_flag == 1)
                    {
                        int _iPc = this.Get_CountOfOrder_byPreSdate(_oReader[HandSetOfferedBasket.Para.premium].ToString(), _sStartDate);
                        if (_iPc != -1)
                            n_iP_count = _iPc;
                    }
                    if (bCheckStock())
                        _oPremiumList.Add(_oReader[HandSetOfferedBasket.Para.premium].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
            }
            return _oPremiumList;
        }
        public global::System.Collections.Generic.List<string> Get_DrpPremiumList
            (string x_sProgram, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_DrpPremiumList(x_sProgram, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel, string.Empty);
        }
        
        public global::System.Collections.Generic.List<string> Get_DrpPremiumList
            (string x_sProgram, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            if (x_sPlan_fee == null) throw new ArgumentNullException("x_sPlan_fee");
            if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");
            global::System.Collections.Generic.List<string> _oPremiumList =
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader =
                this.Get_Premium_DataReader(x_sCon_per, x_sPlan_fee, x_sNormal_rebate_type, x_sProgram, x_sIssue_type);
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_iP_count = 0;
                    n_iQ_count = 0;
                    n_iLast_stock_flag = 0;
                    string _sStartDate = this.Get_StartDay_Of_HS(_oReader[HandSetOfferedBasket.Para.premium].ToString(), null);
                    if (n_iLast_stock_flag == 1)
                    {
                        int _iPc = this.Get_CountOfOrder_byPreSdate(_oReader[HandSetOfferedBasket.Para.premium].ToString(), _sStartDate);
                        if (_iPc != -1)
                            n_iP_count = _iPc;
                    }
                    if (bCheckStock())
                        _oPremiumList.Add(_oReader[HandSetOfferedBasket.Para.premium].ToString());
                }
                if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
            }
            return _oPremiumList;
        }
        //Philip Note
        public global::System.Collections.Generic.List<string> Get_DrpTradeFieldList()
        {
            return Get_DrpTradeFieldList(n_sProgram, n_sCon_per, n_sRate_plan, n_sPlan_fee, n_sNormal_rebate_type, n_sChannel);
        }

        public global::System.Collections.Generic.List<string> Get_DrpTradeFieldList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel)
        {
            bool _bDisabledHandSet = false;
            bool _bDisabledPremium = false;
            return FromRegisterControler.Get_TradeFieldList(x_sProgam, x_sCon_per, x_sPlan_fee, x_sRate_plan, string.Empty, x_sNormal_rebate_type, x_sChannel, string.Empty, string.Empty, string.Empty, ref _bDisabledHandSet, ref _bDisabledPremium);
        }
        //Philip Note
        public global::System.Collections.Generic.List<string> Get_DrpBundleNameList()
        {
            return Get_DrpBundleNameList(n_sProgram, n_sCon_per, n_sRate_plan, n_sPlan_fee, n_sNormal_rebate_type, n_sChannel);
        }

        public global::System.Collections.Generic.List<string> Get_DrpBundleNameList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel)
        {
            bool _bDisabledHandSet = false;
            bool _bDisabledPremium = false;
            return FromRegisterControler.Get_BundleNameList(x_sProgam, x_sCon_per, x_sPlan_fee, x_sRate_plan, string.Empty, x_sNormal_rebate_type, x_sChannel, string.Empty, string.Empty, string.Empty, ref _bDisabledHandSet, ref _bDisabledPremium);
        }

        public global::System.Collections.Generic.List<string> GetRebateList()
        {
            return GetRebateList(n_sProgram, n_sCon_per, n_sRate_plan, n_sPlan_fee, n_sNormal_rebate_type, n_sChannel);
        }

        public global::System.Collections.Generic.List<string> GetRebateList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_RebateList(x_sProgam, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> GetRebateList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel, string x_sIssue_type)
        {
            return Get_RebateList(x_sProgam, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel, x_sIssue_type);
        }

        public global::System.Collections.Generic.List<string> Get_DrpFeeMonList()
        {
            return Get_DrpFeeMonList(n_sProgram, n_sCon_per, n_sRate_plan, n_sPlan_fee, n_sNormal_rebate_type, n_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpFeeMonList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel)
        {
            return Get_FeeMonList(x_sProgam, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel,string.Empty);
        }

        public global::System.Collections.Generic.List<string> Get_DrpFeeMonList(
            string x_sProgam, string x_sCon_per, string x_sRate_plan, string x_sPlan_fee,
            string x_sNormal_rebate_type, string x_sChannel,string x_sIssue_type)
        {
            return Get_FeeMonList(x_sProgam, x_sCon_per, x_sRate_plan, x_sPlan_fee, x_sNormal_rebate_type, x_sChannel, x_sIssue_type);
        }

        public global::System.Collections.Generic.List<string> GetSPremiumList()
        {
            return GetSPremiumList(n_sCon_per, n_sRate_plan);
        }

        public global::System.Collections.Generic.List<string> GetSPremiumList(string x_sCon_per, string x_sRate_plan)
        {
            return Get_SPremiumList(x_sCon_per, x_sRate_plan);
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

        protected int n_iP_count = -1;
        #region m_iP_count
        protected int m_iP_count
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


        protected int n_iQ_count = -1;
        #region m_iQ_count
        protected int m_iQ_count
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


        protected string n_sPlan_fee = string.Empty;
        #region m_sPlan_fee
        protected string m_sPlan_fee
        {
            get
            {
                return this.n_sPlan_fee;
            }
            set
            {
                this.n_sPlan_fee = value;
            }
        }
        #endregion m_sPlan_fee


        protected int n_iLast_stock_flag = -1;
        #region m_iLast_stock_flag
        protected int m_iLast_stock_flag
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


        protected global::System.Collections.Generic.List<string> n_oHs_model = null;
        #region m_oHs_model
        protected global::System.Collections.Generic.List<string> m_oHs_model
        {
            get
            {
                return this.n_oHs_model;
            }
            set
            {
                this.n_oHs_model = value;
            }
        }
        #endregion m_oHs_model


        protected string n_sRate_plan = string.Empty;
        #region m_sRate_plan
        protected string m_sRate_plan
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


        protected global::System.Collections.Generic.List<string> n_oFree_mon = null;
        #region m_oFree_mon
        protected global::System.Collections.Generic.List<string> m_oFree_mon
        {
            get
            {
                return this.n_oFree_mon;
            }
            set
            {
                this.n_oFree_mon = value;
            }
        }
        #endregion m_oFree_mon


        protected string n_sChannel = string.Empty;
        #region m_sChannel
        protected string m_sChannel
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


        protected global::System.Collections.Generic.List<string> n_oRebate = null;
        #region m_oRebate
        protected global::System.Collections.Generic.List<string> m_oRebate
        {
            get
            {
                return this.n_oRebate;
            }
            set
            {
                this.n_oRebate = value;
            }
        }
        #endregion m_oRebate


        protected string n_sProgram = string.Empty;
        #region m_sProgram
        protected string m_sProgram
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


        protected global::System.Collections.Generic.List<string> n_oS_premium = null;
        #region m_oS_premium
        protected global::System.Collections.Generic.List<string> m_oS_premium
        {
            get
            {
                return this.n_oS_premium;
            }
            set
            {
                this.n_oS_premium = value;
            }
        }
        #endregion m_oS_premium


        protected global::System.Collections.Generic.List<string> n_oPermium = null;
        #region m_oPermium
        protected global::System.Collections.Generic.List<string> m_oPermium
        {
            get
            {
                return this.n_oPermium;
            }
            set
            {
                this.n_oPermium = value;
            }
        }
        #endregion m_oPermium


        protected global::System.Collections.Generic.List<string> n_oBundle_name = null;
        #region m_oBundle_name
        protected global::System.Collections.Generic.List<string> m_oBundle_name
        {
            get
            {
                return this.n_oBundle_name;
            }
            set
            {
                this.n_oBundle_name = value;
            }
        }
        #endregion m_oBundle_name


        protected global::System.Collections.Generic.List<string> n_oTrade_field = null;
        #region m_oTrade_field
        protected global::System.Collections.Generic.List<string> m_oTrade_field
        {
            get
            {
                return this.n_oTrade_field;
            }
            set
            {
                this.n_oTrade_field = value;
            }
        }
        #endregion m_oTrade_field


        protected string n_sNormal_rebate_type = string.Empty;
        #region m_sNormal_rebate
        protected string m_sNormal_rebate
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


        protected string n_sSdate = string.Empty;
        #region m_sSdate
        protected string m_sSdate
        {
            get
            {
                return this.n_sSdate;
            }
            set
            {
                this.n_sSdate = value;
            }
        }
        #endregion m_sSdate


        protected string n_sCon_per = string.Empty;
        #region m_sCon_per
        protected string m_sCon_per
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


        #region Constructor + Destructor
        public HandSetEnvironment() { }

        public HandSetEnvironment(int x_iP_count, int x_iQ_count, string x_sPlan_fee, int x_iLast_stock_flag, global::System.Collections.Generic.List<string> x_oHs_model, string x_sRate_plan, global::System.Collections.Generic.List<string> x_oFree_mon, string x_sChannel, global::System.Collections.Generic.List<string> x_oRebate, string x_sProgram, global::System.Collections.Generic.List<string> x_oS_premium, global::System.Collections.Generic.List<string> x_oPermium, global::System.Collections.Generic.List<string> x_oBundle_name, global::System.Collections.Generic.List<string> x_oTrade_field, string x_sNormal_rebate_type, string x_sSdate, string x_sCon_per)
        {
            m_iP_count = x_iP_count;
            m_iQ_count = x_iQ_count;
            m_sPlan_fee = x_sPlan_fee;
            m_iLast_stock_flag = x_iLast_stock_flag;
            m_oHs_model = x_oHs_model;
            m_sRate_plan = x_sRate_plan;
            m_oFree_mon = x_oFree_mon;
            m_sChannel = x_sChannel;
            m_oRebate = x_oRebate;
            m_sProgram = x_sProgram;
            m_oS_premium = x_oS_premium;
            m_oPermium = x_oPermium;
            m_oBundle_name = x_oBundle_name;
            m_oTrade_field = x_oTrade_field;
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sSdate = x_sSdate;
            m_sCon_per = x_sCon_per;
        }

        ~HandSetEnvironment() { }

        #endregion Constructor + Destructor

        #region Get + Set
        public int GetP_count() { return this.m_iP_count; }
        public int GetQ_count() { return this.m_iQ_count; }
        public string GetPlan_fee() { return this.m_sPlan_fee; }
        public int GetLast_stock_flag() { return this.m_iLast_stock_flag; }
        public global::System.Collections.Generic.List<string> GetHs_model() { return this.m_oHs_model; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public global::System.Collections.Generic.List<string> GetFree_mon() { return this.m_oFree_mon; }
        public string GetChannel() { return this.m_sChannel; }
        public global::System.Collections.Generic.List<string> GetRebate() { return this.m_oRebate; }
        public string GetProgram() { return this.m_sProgram; }
        public global::System.Collections.Generic.List<string> GetS_premium() { return this.m_oS_premium; }
        public global::System.Collections.Generic.List<string> GetPermium() { return this.m_oPermium; }
        public global::System.Collections.Generic.List<string> GetBundle_name() { return this.m_oBundle_name; }
        public global::System.Collections.Generic.List<string> GetTrade_field() { return this.m_oTrade_field; }
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetSdate() { return this.m_sSdate; }
        public string GetCon_per() { return this.m_sCon_per; }

        public bool SetP_count(int value)
        {
            this.m_iP_count = value;
            return true;
        }
        public bool SetQ_count(int value)
        {
            this.m_iQ_count = value;
            return true;
        }
        public bool SetPlan_fee(string value)
        {
            this.m_sPlan_fee = value;
            return true;
        }
        public bool SetLast_stock_flag(int value)
        {
            this.m_iLast_stock_flag = value;
            return true;
        }
        public bool SetHs_model(List<string> value)
        {
            this.m_oHs_model = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetFree_mon(List<string> value)
        {
            this.m_oFree_mon = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
        }
        public bool SetRebate(List<string> value)
        {
            this.m_oRebate = value;
            return true;
        }
        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
        }
        public bool SetS_premium(List<string> value)
        {
            this.m_oS_premium = value;
            return true;
        }
        public bool SetPermium(List<string> value)
        {
            this.m_oPermium = value;
            return true;
        }
        public bool SetBundle_name(List<string> value)
        {
            this.m_oBundle_name = value;
            return true;
        }
        public bool SetTrade_field(List<string> value)
        {
            this.m_oTrade_field = value;
            return true;
        }
        public bool SetNormal_rebate(string value)
        {
            this.m_sNormal_rebate = value;
            return true;
        }
        public bool SetSdate(string value)
        {
            this.m_sSdate = value;
            return true;
        }
        public bool SetCon_per(string value)
        {
            this.m_sCon_per = value;
            return true;
        }
        #endregion




        #region Equals
        public bool Equals(HandSetEnvironment x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_iP_count.Equals(x_oObj.m_iP_count)) { return false; }
            if (!this.m_iQ_count.Equals(x_oObj.m_iQ_count)) { return false; }
            if (!this.m_sPlan_fee.Equals(x_oObj.m_sPlan_fee)) { return false; }
            if (!this.m_iLast_stock_flag.Equals(x_oObj.m_iLast_stock_flag)) { return false; }
            if (!this.m_oHs_model.Equals(x_oObj.m_oHs_model)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_oFree_mon.Equals(x_oObj.m_oFree_mon)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            if (!this.m_oRebate.Equals(x_oObj.m_oRebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_oS_premium.Equals(x_oObj.m_oS_premium)) { return false; }
            if (!this.m_oPermium.Equals(x_oObj.m_oPermium)) { return false; }
            if (!this.m_oBundle_name.Equals(x_oObj.m_oBundle_name)) { return false; }
            if (!this.m_oTrade_field.Equals(x_oObj.m_oTrade_field)) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sSdate.Equals(x_oObj.m_sSdate)) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_iP_count = -1;
            this.m_iQ_count = -1;
            this.m_sPlan_fee = string.Empty;
            this.m_iLast_stock_flag = -1;
            this.m_oHs_model = null;
            this.m_sRate_plan = string.Empty;
            this.m_oFree_mon = null;
            this.m_sChannel = string.Empty;
            this.m_oRebate = null;
            this.m_sProgram = string.Empty;
            this.m_oS_premium = null;
            this.m_oPermium = null;
            this.m_oBundle_name = null;
            this.m_oTrade_field = null;
            this.m_sNormal_rebate = string.Empty;
            this.m_sSdate = string.Empty;
            this.m_sCon_per = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public HandSetEnvironment DeepClone()
        {
            HandSetEnvironment HandSetEnvironment_Clone = new HandSetEnvironment();
            HandSetEnvironment_Clone.SetP_count(this.m_iP_count);
            HandSetEnvironment_Clone.SetQ_count(this.m_iQ_count);
            HandSetEnvironment_Clone.SetPlan_fee(this.m_sPlan_fee);
            HandSetEnvironment_Clone.SetLast_stock_flag(this.m_iLast_stock_flag);
            HandSetEnvironment_Clone.SetHs_model(this.m_oHs_model);
            HandSetEnvironment_Clone.SetRate_plan(this.m_sRate_plan);
            HandSetEnvironment_Clone.SetFree_mon(this.m_oFree_mon);
            HandSetEnvironment_Clone.SetChannel(this.m_sChannel);
            HandSetEnvironment_Clone.SetRebate(this.m_oRebate);
            HandSetEnvironment_Clone.SetProgram(this.m_sProgram);
            HandSetEnvironment_Clone.SetS_premium(this.m_oS_premium);
            HandSetEnvironment_Clone.SetPermium(this.m_oPermium);
            HandSetEnvironment_Clone.SetBundle_name(this.m_oBundle_name);
            HandSetEnvironment_Clone.SetTrade_field(this.m_oTrade_field);
            HandSetEnvironment_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            HandSetEnvironment_Clone.SetSdate(this.m_sSdate);
            HandSetEnvironment_Clone.SetCon_per(this.m_sCon_per);
            return HandSetEnvironment_Clone;
        }
        #endregion Clone

    }
}
