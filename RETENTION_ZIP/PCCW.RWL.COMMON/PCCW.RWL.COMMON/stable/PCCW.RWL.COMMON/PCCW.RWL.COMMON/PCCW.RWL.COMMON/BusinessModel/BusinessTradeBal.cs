using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-14>
///-- Description:	<Description,Table :[BusinessTrade],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessTrade] Business layer
    /// </summary>
    
    
    public class BusinessTradeBals:Collection<BusinessTrade>{}
    public class BusinessTradeBal: BusinessTradeBalBase{

        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public BusinessTradeBal() : base(){
        }
        ~BusinessTradeBal(){
            base.Release();
        }
        #endregion

        #region Update Issue Type
        public static ObjectArr GetIssueTypeList(bool x_bIncludeAll)
        {
            ObjectArr _oIssueTypeList = new ObjectArr();
            if (x_bIncludeAll)
                _oIssueTypeList.Add("ALL", "ALL");
            _oIssueTypeList.Add("3G_RETENTION", "3G_RETENTION");
            _oIssueTypeList.Add("2G_RETENTION", "2G_RETENTION");
            _oIssueTypeList.Add("WIN", "WIN");
            _oIssueTypeList.Add("MOBILE_LITE", "MOBILE_LITE");
            _oIssueTypeList.Add("GO WIRELESS", "GO WIRELESS");
            _oIssueTypeList.Add("UPGRADE", "UPGRADE");

            return _oIssueTypeList;
        }

        public static Hashtable DrpIssueTypeList(bool x_bIncludeAll)
        {
            Hashtable _oIssueTypeList = new Hashtable();
            if (x_bIncludeAll)
                _oIssueTypeList.Add("ALL", string.Empty);
            _oIssueTypeList.Add("3G_RETENTION", "3G_RETENTION");
            _oIssueTypeList.Add("2G_RETENTION", "2G_RETENTION");
            _oIssueTypeList.Add("WIN", "WIN");
            _oIssueTypeList.Add("MOBILE_LITE", "MOBILE_LITE");
            _oIssueTypeList.Add("GO_WIRELESS", "GO_WIRELESS");
            _oIssueTypeList.Add("UPGRADE", "UPGRADE");

            return _oIssueTypeList;
        }
        #endregion

        #region Update Active
        public static bool SaveActive(MSSQLConnect x_oDB, bool x_bActive, string x_sUid, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE  [BusinessTrade]  SET  ");
            _oQuery.Append("[cdate]=@cdate,[active]=@active,[cid]=@cid ");
            _oQuery.Append(" WHERE " + x_sFilter);
            if (!string.IsNullOrEmpty(Configurator.MSSQLTablePrefix)) { 
                _oQuery = _oQuery.Replace("[BusinessTrade]", "[" + Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_oQuery.ToString(), _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = DateTime.Now;
            _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_bActive;
            if (string.IsNullOrEmpty(x_sUid)) { 
                _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = 
                    global::System.DBNull.Value; 
            } else {
                _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = x_sUid; 
            }
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch { }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        #endregion

        #region Update EndDate
        public static bool SaveEndDate(MSSQLConnect x_oDB, Nullable<DateTime> x_dEdate, string x_sUid, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE  [BusinessTrade]  SET  ");
            _oQuery.Append(" [cdate]=@cdate,[edate]=@edate,[cid]=@cid ");
            _oQuery.Append(" WHERE " + x_sFilter);
            if (!string.IsNullOrEmpty(Configurator.MSSQLTablePrefix)) { 
                _oQuery = _oQuery.Replace("[BusinessTrade]", "[" + Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = 
                new global::System.Data.SqlClient.SqlCommand(_oQuery.ToString(), _oConn);
            bool _bResult=false;
            _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = DateTime.Now;
            if(x_dEdate==null){  
                _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; 
            }else{  
                _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_dEdate; 
            }
            if (string.IsNullOrEmpty(x_sUid)) { 
                _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = 
                    global::System.DBNull.Value; 
            } else { 
                _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = x_sUid; 
            }
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        #endregion

        #region Program
        public static global::System.Collections.Generic.List<string> DrpProgramList()
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT DISTINCT program FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _oQuery.Append(" WHERE active=1 AND program<>'' ORDER BY program");
            global::System.Collections.Generic.List<string> _oProgramList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader =
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
            {
                _oProgramList.Add(_oReader[BusinessTrade.Para.program].ToString());
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oProgramList;
        }

        public static DataSet DsProgramList()
        {
            return BusinessTradeBal.DsProgramList(false);
        }


        public static global::System.Data.DataSet DsProgramList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsProgramList(x_bEmptyFirstValue,string.Empty, string.Empty);
        }

        public static global::System.Data.DataSet DsProgramList(bool x_bEmptyFirstValue,string x_sSelectedValue)
        {
            return BusinessTradeBal.DsProgramList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsProgramList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            StringBuilder _oQuery = new StringBuilder();
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            if (x_bEmptyFirstValue) { _oQuery.Append("SELECT 'program'='' UNION  "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'program'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT program FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _oQuery.Append(" WHERE active=1 and program<>'' " + x_sFilter + " order by program");
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }
        #endregion

        #region RatePlan
        public static global::System.Collections.Generic.List<string> DrpRatePlanList()
        {
			StringBuilder _oQuery = new StringBuilder();
            global::System.Collections.Generic.List<string> _oRatePlanList = 
                new global::System.Collections.Generic.List<string>();
			_oQuery.Append("SELECT DISTINCT rate_plan FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
			_oQuery.Append(" WHERE active=1 and rate_plan<>'' order by rate_plan");
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oRatePlanList.Add(_oReader[BusinessTrade.Para.rate_plan].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oRatePlanList;
        }

        public static global::System.Data.DataSet DsRatePlanList()
        {
            return BusinessTradeBal.DsRatePlanList(false);
        }

        public static global::System.Data.DataSet DsRatePlanList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsRatePlanList(x_bEmptyFirstValue, string.Empty);
        }

        public static global::System.Data.DataSet DsRatePlanList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            
            return BusinessTradeBal.DsRatePlanList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsRatePlanList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append("SELECT 'rate_plan'='' UNION  "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'rate_plan'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT rate_plan FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _oQuery.Append("WHERE active=1 and rate_plan<>'' " + x_sFilter + " order by rate_plan");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        #endregion

        #region ConPer
        public static global::System.Collections.Generic.List<string> DrpCon_perList()
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT con_per FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
			_oQuery.Append(" WHERE active=1 and con_per<>'' order by con_per");
            global::System.Collections.Generic.List<string> _oCon_perList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oCon_perList.Add(_oReader[BusinessTrade.Para.con_per].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oCon_perList;
        }

        public static global::System.Data.DataSet DsCon_perList()
        {
            return BusinessTradeBal.DsCon_perList(false);
        }

        public static global::System.Data.DataSet DsCon_perList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsCon_perList(x_bEmptyFirstValue, string.Empty);
        }

        public static global::System.Data.DataSet DsCon_perList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsCon_perList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsCon_perList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append("SELECT 'con_per'='' UNION  "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'con_per'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT con_per FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _oQuery.Append(" WHERE active=1 AND con_per<>'' " + x_sFilter + " order by con_per");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        #endregion

        #region PlanFee
        public static global::System.Collections.Generic.List<string> DrpPlanFeeList()
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT plan_fee FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
			_oQuery.Append(" WHERE active=1 and plan_fee<>'' order by plan_fee");
            global::System.Collections.Generic.List<string> _oPlanFeeList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oPlanFeeList.Add(_oReader[BusinessTrade.Para.plan_fee].ToString());
            if(_oReader!=null) _oReader.Close();
            return _oPlanFeeList;
        }

        public static global::System.Data.DataSet DsPlanFeeList()
        {

            return BusinessTradeBal.DsPlanFeeList(false);
        }

        public static global::System.Data.DataSet DsPlanFeeList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsPlanFeeList(x_bEmptyFirstValue, string.Empty,string.Empty);
        }
        
        public static global::System.Data.DataSet DsPlanFeeList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsPlanFeeList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsPlanFeeList(bool x_bEmptyFirstValue, string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append("SELECT 'plan_fee'='' UNION  "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'plan_fee'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT plan_fee FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _oQuery.Append(" WHERE active=1 AND plan_fee<>'' " + x_sFilter + " order by plan_fee");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        #endregion

        #region Rebate
        public static global::System.Collections.Generic.List<string> DrpRebateList()
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT rebate FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)");
			_oQuery.Append(" WHERE active=1 and rebate<>'' order by rebate");
            global::System.Collections.Generic.List<string> _oRebateList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oRebateList.Add(_oReader[BusinessTrade.Para.rebate].ToString());
            if(_oReader!=null) _oReader.Close(); _oReader.Dispose();
            return _oRebateList;
        }

        public static global::System.Data.DataSet DsRebateList()
        {
            return BusinessTradeBal.DsRebateList(false);
        }

        public static global::System.Data.DataSet DsRebateList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsRebateList(x_bEmptyFirstValue, string.Empty);
        }
        public static global::System.Data.DataSet DsRebateList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsRebateList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsRebateList(bool x_bEmptyFirstValue, string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append("SELECT 'rebate'='' UNION  "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'rebate'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT rebate FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
            _oQuery.Append(" WHERE active=1 AND rebate<>'' " + x_sFilter + " order by rebate");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }
        #endregion

        #region FreeMon
        public static global::System.Collections.Generic.List<string> DrpFreeMonList()
        {
		    global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT free_mon FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
			_oQuery.Append("WHERE active=1 AND free_mon<>'' order by free_mon");
            global::System.Collections.Generic.List<string> _oFreeMonList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oFreeMonList.Add(_oReader[BusinessTrade.Para.free_mon].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oFreeMonList;
        }

        public static global::System.Data.DataSet DsFreeMonList()
        {
            return BusinessTradeBal.DsFreeMonList(false);
        }

        public static global::System.Data.DataSet DsFreeMonList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsFreeMonList(x_bEmptyFirstValue, string.Empty, string.Empty);
        }

        public static global::System.Data.DataSet DsFreeMonList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsFreeMonList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsFreeMonList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append("SELECT 'free_mon'='' UNION  "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'free_mon'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT free_mon FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
            _oQuery.Append(" WHERE active=1 and free_mon<>'' " + x_sFilter + " order by free_mon");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }
        #endregion

        #region Hsmodel
        public static global::System.Collections.Generic.List<string> DrpHsModelList()
        {
		    global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT hs_model FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "ProductItemCode  with (nolock) ");
            _oQuery.Append("WHERE active=1 AND hs_model<>'' AND item_code<>''  AND type='HS' order by hs_model");
            global::System.Collections.Generic.List<string> _oHsModelList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oHsModelList.Add(_oReader[ProductItemCode.Para.hs_model].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oHsModelList;
        }

        public static global::System.Data.DataSet DsHsModeList()
        {
            return BusinessTradeBal.DsHsModeList(false);
        }

        public static global::System.Data.DataSet DsHsModeList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsHsModeList(x_bEmptyFirstValue, string.Empty, string.Empty);
        }

        public static global::System.Data.DataSet DsHsModeList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsHsModeList(x_bEmptyFirstValue, string.Empty,x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsHsModeList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append(" SELECT 'hs_model' ='' UNION ALL "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'hs_model'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append(" SELECT DISTINCT hs_model FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "ProductItemCode WITH (NOLOCK) ");
            _oQuery.Append(" WHERE active=1 AND hs_model<>'' AND item_code<>'' AND type='HS' " + x_sFilter + " ORDER BY hs_model");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        #endregion

        #region PremiumHsmodel
        public static global::System.Collections.Generic.List<string> DrpPremiumHsList()
        {
		    global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT hs_model FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock)  ");
            _oQuery.Append(" WHERE active=1 AND hs_model<>'' AND  type!='HS' order by hs_model");
            global::System.Collections.Generic.List<string> _oPremiumList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oPremiumList.Add(_oReader[ProductItemCode.Para.hs_model].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oPremiumList;
        }

        public static global::System.Data.DataSet DsPremiumHsList()
        {
            return BusinessTradeBal.DsPremiumHsList(false);
        }

        public static global::System.Data.DataSet DsPremiumHsList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsPremiumHsList(x_bEmptyFirstValue, string.Empty);
        }

        public static global::System.Data.DataSet DsPremiumHsList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsPremiumHsList(x_bEmptyFirstValue, string.Empty, x_sSelectedValue);
        }

        public static global::System.Data.DataSet DsPremiumHsList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append(" SELECT 'hs_model' ='' UNION ALL "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'hs_model'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT hs_model FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock)  ");
            _oQuery.Append("WHERE active=1 AND hs_model<>'' AND type!='HS' " + x_sFilter + " order by hs_model");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        #endregion

        #region Trade Field
        public static global::System.Collections.Generic.List<string> DrpTradeFieldList()
        {
		    global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT trade_field FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)   ");
			_oQuery.Append(" WHERE active=1 AND trade_field<>'' ORDER BY trade_field");
            global::System.Collections.Generic.List<string> _oTradeFieldList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oTradeFieldList.Add(_oReader[BusinessTrade.Para.trade_field].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oTradeFieldList;
        }

        public static global::System.Data.DataSet DsTradeFieldList()
        {
            return BusinessTradeBal.DsTradeFieldList(false);
        }

        public static global::System.Data.DataSet DsTradeFieldList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsTradeFieldList(x_bEmptyFirstValue, string.Empty);
        }

        public static global::System.Data.DataSet DsTradeFieldList(bool x_bEmptyFirstValue, string x_sSelectedValue)
        {
            return BusinessTradeBal.DsTradeFieldList(x_bEmptyFirstValue,string.Empty, string.Empty);
        }

        public static global::System.Data.DataSet DsTradeFieldList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append(" SELECT 'trade_field' ='' UNION ALL "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'trade_field'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT trade_field FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
            _oQuery.Append(" WHERE active=1 and trade_field<>'' " + x_sFilter + " order by trade_field");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }
        #endregion

        #region bundle name
        public static global::System.Collections.Generic.List<string> DrpBundleNameList()
        {
		    global::System.Text.StringBuilder _oQuery = new StringBuilder();
			_oQuery.Append("SELECT DISTINCT bundle_name FROM ");
			_oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
			_oQuery.Append(" WHERE active=1 and bundle_name<>'' order by bundle_name");
            global::System.Collections.Generic.List<string> _oBundleNameList = 
                new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = 
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read())
                _oBundleNameList.Add(_oReader[BusinessTrade.Para.bundle_name].ToString());
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oBundleNameList;
        }

        public static global::System.Data.DataSet DsBundleNameList()
        {
            return BusinessTradeBal.DsBundleNameList(false);
        }

        public static global::System.Data.DataSet DsBundleNameList(bool x_bEmptyFirstValue)
        {
            return BusinessTradeBal.DsBundleNameList(x_bEmptyFirstValue, string.Empty, string.Empty);
        }

        public static global::System.Data.DataSet DsBundleNameList(bool x_bEmptyFirstValue,string x_sFilter, string x_sSelectedValue)
        {
            global::System.Text.StringBuilder _oQuery = new StringBuilder();
            if (x_bEmptyFirstValue) { _oQuery.Append(" SELECT 'bundle_name' ='' UNION ALL "); }
            if (!string.IsNullOrEmpty(x_sSelectedValue)) { _oQuery.Append("SELECT 'bundle_name'='" + x_sSelectedValue + "' UNION  "); }
            _oQuery.Append("SELECT DISTINCT bundle_name FROM ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock)  ");
            _oQuery.Append(" WHERE active=1 and bundle_name<>'' " + x_sFilter + " order by bundle_name");
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        #endregion 

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
    }
}


