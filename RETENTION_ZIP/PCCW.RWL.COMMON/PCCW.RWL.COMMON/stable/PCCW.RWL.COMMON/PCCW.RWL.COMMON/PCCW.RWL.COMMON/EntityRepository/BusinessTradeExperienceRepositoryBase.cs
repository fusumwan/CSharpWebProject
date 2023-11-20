using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTradeExperience],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessTradeExperience] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"BusinessTradeExperience")]
    public class BusinessTradeExperienceRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static BusinessTradeExperienceRepositoryBase instance;
        public static BusinessTradeExperienceRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessTradeExperienceRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessTradeExperienceRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new BusinessTradeExperienceRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessTradeExperienceEntity> BusinessTradeExperiences;
        #endregion
        
        #region Constructor
        public BusinessTradeExperienceRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~BusinessTradeExperienceRepositoryBase() { 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
        }
        #endregion
        #region Create Instance Object
        /// <summary>
        /// Summary description for Create Instance Object
        /// </summary>
        public static BusinessTradeExperience CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessTradeExperience(_oDB);
        }
        
        public static BusinessTradeExperience CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessTradeExperience(x_oDB);
        }
        #endregion
        
        #region Count
        
        /// <summary>
        /// Summary description for Counting
        /// </summary>
        
        public int GetCount()
        {
            return GetCount(n_oDB);
        }
        public static int GetCount(MSSQLConnect x_oDB)
        {
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessTradeExperience]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                int _iTotalCount = 0;
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        _iTotalCount = (int)_oData["TotalCount"];
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch{}
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _iTotalCount;
            }
        }
        #endregion
        
        #region Get Array & List
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        public BusinessTradeExperienceEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static BusinessTradeExperienceEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            BusinessTradeExperience _BusinessTradeExperience = (BusinessTradeExperience)BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessTradeExperience.Load(x_iMid)) { return null; }
            return _BusinessTradeExperience;
        }
        
        
        
        public static BusinessTradeExperienceEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<BusinessTradeExperienceEntity> _oBusinessTradeExperienceList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oBusinessTradeExperienceList==null){ return null;}
            return _oBusinessTradeExperienceList.Count == 0 ? null : _oBusinessTradeExperienceList.ToArray();
        }
        
        public static List<BusinessTradeExperienceEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static BusinessTradeExperienceEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessTradeExperienceEntity> _oBusinessTradeExperienceList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oBusinessTradeExperienceList==null){ return null;}
            return _oBusinessTradeExperienceList.Count == 0 ? null : _oBusinessTradeExperienceList.ToArray();
        }
        
        
        public static BusinessTradeExperienceEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessTradeExperienceEntity> _oBusinessTradeExperienceList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oBusinessTradeExperienceList==null){ return null;}
            return _oBusinessTradeExperienceList.Count == 0 ? null : _oBusinessTradeExperienceList.ToArray();
        }
        
        public static List<BusinessTradeExperienceEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<BusinessTradeExperienceEntity> _oRow = new List<BusinessTradeExperienceEntity>();
            string _sQuery = "SELECT  "+_sTop+" [BusinessTradeExperience].[rec_no] AS BUSINESSTRADEEXPERIENCE_REC_NO,[BusinessTradeExperience].[mid] AS BUSINESSTRADEEXPERIENCE_MID,[BusinessTradeExperience].[channel] AS BUSINESSTRADEEXPERIENCE_CHANNEL,[BusinessTradeExperience].[cdate] AS BUSINESSTRADEEXPERIENCE_CDATE,[BusinessTradeExperience].[bundle_name] AS BUSINESSTRADEEXPERIENCE_BUNDLE_NAME,[BusinessTradeExperience].[hs_model_name] AS BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME,[BusinessTradeExperience].[trade_field] AS BUSINESSTRADEEXPERIENCE_TRADE_FIELD,[BusinessTradeExperience].[did] AS BUSINESSTRADEEXPERIENCE_DID,[BusinessTradeExperience].[premium_1] AS BUSINESSTRADEEXPERIENCE_PREMIUM_1,[BusinessTradeExperience].[sdate] AS BUSINESSTRADEEXPERIENCE_SDATE,[BusinessTradeExperience].[rebate] AS BUSINESSTRADEEXPERIENCE_REBATE,[BusinessTradeExperience].[premium_2] AS BUSINESSTRADEEXPERIENCE_PREMIUM_2,[BusinessTradeExperience].[po_date] AS BUSINESSTRADEEXPERIENCE_PO_DATE,[BusinessTradeExperience].[retention_type] AS BUSINESSTRADEEXPERIENCE_RETENTION_TYPE,[BusinessTradeExperience].[extra_offer] AS BUSINESSTRADEEXPERIENCE_EXTRA_OFFER,[BusinessTradeExperience].[edate] AS BUSINESSTRADEEXPERIENCE_EDATE,[BusinessTradeExperience].[program] AS BUSINESSTRADEEXPERIENCE_PROGRAM,[BusinessTradeExperience].[ob_early] AS BUSINESSTRADEEXPERIENCE_OB_EARLY,[BusinessTradeExperience].[con_per] AS BUSINESSTRADEEXPERIENCE_CON_PER,[BusinessTradeExperience].[ddate] AS BUSINESSTRADEEXPERIENCE_DDATE,[BusinessTradeExperience].[normal_rebate_type] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE,[BusinessTradeExperience].[active] AS BUSINESSTRADEEXPERIENCE_ACTIVE,[BusinessTradeExperience].[free_mon] AS BUSINESSTRADEEXPERIENCE_FREE_MON,[BusinessTradeExperience].[cid] AS BUSINESSTRADEEXPERIENCE_CID,[BusinessTradeExperience].[cancel_renew] AS BUSINESSTRADEEXPERIENCE_CANCEL_RENEW,[BusinessTradeExperience].[rate_plan] AS BUSINESSTRADEEXPERIENCE_RATE_PLAN,[BusinessTradeExperience].[normal_rebate] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE,[BusinessTradeExperience].[hs_model] AS BUSINESSTRADEEXPERIENCE_HS_MODEL,[BusinessTradeExperience].[plan_fee] AS BUSINESSTRADEEXPERIENCE_PLAN_FEE,[BusinessTradeExperience].[remarks] AS BUSINESSTRADEEXPERIENCE_REMARKS,[BusinessTradeExperience].[issue_type] AS BUSINESSTRADEEXPERIENCE_ISSUE_TYPE  FROM  [BusinessTradeExperience]";
            if (x_oArrayItemId==null)
            {
                string _oList = "(";
                for (int i = 0; i < x_oArrayItemId.Count; i++)
                {
                    if (i < (x_oArrayItemId.Count - 1))
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "',";
                    }
                    else
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "'";
                    }
                }
                _oList += ")";
                _sQuery += " WHERE [BusinessTradeExperience].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessTradeExperience _oBusinessTradeExperience = BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REC_NO"])) {_oBusinessTradeExperience.rec_no = (global::System.Nullable<int>)_oData["BUSINESSTRADEEXPERIENCE_REC_NO"]; }else{_oBusinessTradeExperience.rec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_MID"])) {_oBusinessTradeExperience.mid = (global::System.Nullable<int>)_oData["BUSINESSTRADEEXPERIENCE_MID"]; }else{_oBusinessTradeExperience.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CHANNEL"])) {_oBusinessTradeExperience.channel = (string)_oData["BUSINESSTRADEEXPERIENCE_CHANNEL"]; }else{_oBusinessTradeExperience.channel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CDATE"])) {_oBusinessTradeExperience.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_CDATE"]; }else{_oBusinessTradeExperience.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_BUNDLE_NAME"])) {_oBusinessTradeExperience.bundle_name = (string)_oData["BUSINESSTRADEEXPERIENCE_BUNDLE_NAME"]; }else{_oBusinessTradeExperience.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME"])) {_oBusinessTradeExperience.hs_model_name = (string)_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME"]; }else{_oBusinessTradeExperience.hs_model_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_TRADE_FIELD"])) {_oBusinessTradeExperience.trade_field = (string)_oData["BUSINESSTRADEEXPERIENCE_TRADE_FIELD"]; }else{_oBusinessTradeExperience.trade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_DID"])) {_oBusinessTradeExperience.did = (string)_oData["BUSINESSTRADEEXPERIENCE_DID"]; }else{_oBusinessTradeExperience.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_1"])) {_oBusinessTradeExperience.premium_1 = (string)_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_1"]; }else{_oBusinessTradeExperience.premium_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_SDATE"])) {_oBusinessTradeExperience.sdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_SDATE"]; }else{_oBusinessTradeExperience.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REBATE"])) {_oBusinessTradeExperience.rebate = (string)_oData["BUSINESSTRADEEXPERIENCE_REBATE"]; }else{_oBusinessTradeExperience.rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_2"])) {_oBusinessTradeExperience.premium_2 = (string)_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_2"]; }else{_oBusinessTradeExperience.premium_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_RETENTION_TYPE"])) {_oBusinessTradeExperience.retention_type = (string)_oData["BUSINESSTRADEEXPERIENCE_RETENTION_TYPE"]; }else{_oBusinessTradeExperience.retention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_EXTRA_OFFER"])) {_oBusinessTradeExperience.extra_offer = (string)_oData["BUSINESSTRADEEXPERIENCE_EXTRA_OFFER"]; }else{_oBusinessTradeExperience.extra_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_EDATE"])) {_oBusinessTradeExperience.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_EDATE"]; }else{_oBusinessTradeExperience.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PROGRAM"])) {_oBusinessTradeExperience.program = (string)_oData["BUSINESSTRADEEXPERIENCE_PROGRAM"]; }else{_oBusinessTradeExperience.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CON_PER"])) {_oBusinessTradeExperience.con_per = (string)_oData["BUSINESSTRADEEXPERIENCE_CON_PER"]; }else{_oBusinessTradeExperience.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_RATE_PLAN"])) {_oBusinessTradeExperience.rate_plan = (string)_oData["BUSINESSTRADEEXPERIENCE_RATE_PLAN"]; }else{_oBusinessTradeExperience.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_DDATE"])) {_oBusinessTradeExperience.ddate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_DDATE"]; }else{_oBusinessTradeExperience.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE"])) {_oBusinessTradeExperience.normal_rebate_type = (string)_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE"]; }else{_oBusinessTradeExperience.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_ACTIVE"])) {_oBusinessTradeExperience.active = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_ACTIVE"]; }else{_oBusinessTradeExperience.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_FREE_MON"])) {_oBusinessTradeExperience.free_mon = (string)_oData["BUSINESSTRADEEXPERIENCE_FREE_MON"]; }else{_oBusinessTradeExperience.free_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CID"])) {_oBusinessTradeExperience.cid = (string)_oData["BUSINESSTRADEEXPERIENCE_CID"]; }else{_oBusinessTradeExperience.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CANCEL_RENEW"])) {_oBusinessTradeExperience.cancel_renew = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_CANCEL_RENEW"]; }else{_oBusinessTradeExperience.cancel_renew=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_OB_EARLY"])) {_oBusinessTradeExperience.ob_early = (string)_oData["BUSINESSTRADEEXPERIENCE_OB_EARLY"]; }else{_oBusinessTradeExperience.ob_early=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE"])) {_oBusinessTradeExperience.normal_rebate = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE"]; }else{_oBusinessTradeExperience.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL"])) {_oBusinessTradeExperience.hs_model = (string)_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL"]; }else{_oBusinessTradeExperience.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PLAN_FEE"])) {_oBusinessTradeExperience.plan_fee = (string)_oData["BUSINESSTRADEEXPERIENCE_PLAN_FEE"]; }else{_oBusinessTradeExperience.plan_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PO_DATE"])) {_oBusinessTradeExperience.po_date = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_PO_DATE"]; }else{_oBusinessTradeExperience.po_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REMARKS"])) {_oBusinessTradeExperience.remarks = (string)_oData["BUSINESSTRADEEXPERIENCE_REMARKS"]; }else{_oBusinessTradeExperience.remarks=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_ISSUE_TYPE"])) {_oBusinessTradeExperience.issue_type = (string)_oData["BUSINESSTRADEEXPERIENCE_ISSUE_TYPE"]; }else{_oBusinessTradeExperience.issue_type=global::System.String.Empty;}
                        _oBusinessTradeExperience.SetDB(x_oDB);
                        _oBusinessTradeExperience.GetFound();
                        _oRow.Add(_oBusinessTradeExperience);
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch { }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRow;
            }
        }
        
        
        public static BusinessTradeExperienceEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessTradeExperienceEntity> _oBusinessTradeExperienceList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessTradeExperienceList==null){ return null;}
            return _oBusinessTradeExperienceList.Count == 0 ? null : _oBusinessTradeExperienceList.ToArray();
        }
        
        
        public static BusinessTradeExperienceEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessTradeExperienceEntity> _oBusinessTradeExperienceList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessTradeExperienceList==null){ return null;}
            return _oBusinessTradeExperienceList.Count == 0 ? null : _oBusinessTradeExperienceList.ToArray();
        }
        
        public static List<BusinessTradeExperienceEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<BusinessTradeExperienceEntity> _oRow = new List<BusinessTradeExperienceEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[BusinessTradeExperience].[rec_no] AS BUSINESSTRADEEXPERIENCE_REC_NO,[BusinessTradeExperience].[mid] AS BUSINESSTRADEEXPERIENCE_MID,[BusinessTradeExperience].[channel] AS BUSINESSTRADEEXPERIENCE_CHANNEL,[BusinessTradeExperience].[cdate] AS BUSINESSTRADEEXPERIENCE_CDATE,[BusinessTradeExperience].[bundle_name] AS BUSINESSTRADEEXPERIENCE_BUNDLE_NAME,[BusinessTradeExperience].[hs_model_name] AS BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME,[BusinessTradeExperience].[trade_field] AS BUSINESSTRADEEXPERIENCE_TRADE_FIELD,[BusinessTradeExperience].[did] AS BUSINESSTRADEEXPERIENCE_DID,[BusinessTradeExperience].[premium_1] AS BUSINESSTRADEEXPERIENCE_PREMIUM_1,[BusinessTradeExperience].[sdate] AS BUSINESSTRADEEXPERIENCE_SDATE,[BusinessTradeExperience].[rebate] AS BUSINESSTRADEEXPERIENCE_REBATE,[BusinessTradeExperience].[premium_2] AS BUSINESSTRADEEXPERIENCE_PREMIUM_2,[BusinessTradeExperience].[po_date] AS BUSINESSTRADEEXPERIENCE_PO_DATE,[BusinessTradeExperience].[retention_type] AS BUSINESSTRADEEXPERIENCE_RETENTION_TYPE,[BusinessTradeExperience].[extra_offer] AS BUSINESSTRADEEXPERIENCE_EXTRA_OFFER,[BusinessTradeExperience].[edate] AS BUSINESSTRADEEXPERIENCE_EDATE,[BusinessTradeExperience].[program] AS BUSINESSTRADEEXPERIENCE_PROGRAM,[BusinessTradeExperience].[ob_early] AS BUSINESSTRADEEXPERIENCE_OB_EARLY,[BusinessTradeExperience].[con_per] AS BUSINESSTRADEEXPERIENCE_CON_PER,[BusinessTradeExperience].[ddate] AS BUSINESSTRADEEXPERIENCE_DDATE,[BusinessTradeExperience].[normal_rebate_type] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE,[BusinessTradeExperience].[active] AS BUSINESSTRADEEXPERIENCE_ACTIVE,[BusinessTradeExperience].[free_mon] AS BUSINESSTRADEEXPERIENCE_FREE_MON,[BusinessTradeExperience].[cid] AS BUSINESSTRADEEXPERIENCE_CID,[BusinessTradeExperience].[cancel_renew] AS BUSINESSTRADEEXPERIENCE_CANCEL_RENEW,[BusinessTradeExperience].[rate_plan] AS BUSINESSTRADEEXPERIENCE_RATE_PLAN,[BusinessTradeExperience].[normal_rebate] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE,[BusinessTradeExperience].[hs_model] AS BUSINESSTRADEEXPERIENCE_HS_MODEL,[BusinessTradeExperience].[plan_fee] AS BUSINESSTRADEEXPERIENCE_PLAN_FEE,[BusinessTradeExperience].[remarks] AS BUSINESSTRADEEXPERIENCE_REMARKS,[BusinessTradeExperience].[issue_type] AS BUSINESSTRADEEXPERIENCE_ISSUE_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessTradeExperienceRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessTradeExperienceEntity _oBusinessTradeExperience = BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REC_NO"])) {_oBusinessTradeExperience.rec_no = (global::System.Nullable<int>)_oData["BUSINESSTRADEEXPERIENCE_REC_NO"]; } else {_oBusinessTradeExperience.rec_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_MID"])) {_oBusinessTradeExperience.mid = (global::System.Nullable<int>)_oData["BUSINESSTRADEEXPERIENCE_MID"]; } else {_oBusinessTradeExperience.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CHANNEL"])) {_oBusinessTradeExperience.channel = (string)_oData["BUSINESSTRADEEXPERIENCE_CHANNEL"]; } else {_oBusinessTradeExperience.channel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CDATE"])) {_oBusinessTradeExperience.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_CDATE"]; } else {_oBusinessTradeExperience.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_BUNDLE_NAME"])) {_oBusinessTradeExperience.bundle_name = (string)_oData["BUSINESSTRADEEXPERIENCE_BUNDLE_NAME"]; } else {_oBusinessTradeExperience.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME"])) {_oBusinessTradeExperience.hs_model_name = (string)_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME"]; } else {_oBusinessTradeExperience.hs_model_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_TRADE_FIELD"])) {_oBusinessTradeExperience.trade_field = (string)_oData["BUSINESSTRADEEXPERIENCE_TRADE_FIELD"]; } else {_oBusinessTradeExperience.trade_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_DID"])) {_oBusinessTradeExperience.did = (string)_oData["BUSINESSTRADEEXPERIENCE_DID"]; } else {_oBusinessTradeExperience.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_1"])) {_oBusinessTradeExperience.premium_1 = (string)_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_1"]; } else {_oBusinessTradeExperience.premium_1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_SDATE"])) {_oBusinessTradeExperience.sdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_SDATE"]; } else {_oBusinessTradeExperience.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REBATE"])) {_oBusinessTradeExperience.rebate = (string)_oData["BUSINESSTRADEEXPERIENCE_REBATE"]; } else {_oBusinessTradeExperience.rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_2"])) {_oBusinessTradeExperience.premium_2 = (string)_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_2"]; } else {_oBusinessTradeExperience.premium_2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_RETENTION_TYPE"])) {_oBusinessTradeExperience.retention_type = (string)_oData["BUSINESSTRADEEXPERIENCE_RETENTION_TYPE"]; } else {_oBusinessTradeExperience.retention_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_EXTRA_OFFER"])) {_oBusinessTradeExperience.extra_offer = (string)_oData["BUSINESSTRADEEXPERIENCE_EXTRA_OFFER"]; } else {_oBusinessTradeExperience.extra_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_EDATE"])) {_oBusinessTradeExperience.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_EDATE"]; } else {_oBusinessTradeExperience.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PROGRAM"])) {_oBusinessTradeExperience.program = (string)_oData["BUSINESSTRADEEXPERIENCE_PROGRAM"]; } else {_oBusinessTradeExperience.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CON_PER"])) {_oBusinessTradeExperience.con_per = (string)_oData["BUSINESSTRADEEXPERIENCE_CON_PER"]; } else {_oBusinessTradeExperience.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_RATE_PLAN"])) {_oBusinessTradeExperience.rate_plan = (string)_oData["BUSINESSTRADEEXPERIENCE_RATE_PLAN"]; } else {_oBusinessTradeExperience.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_DDATE"])) {_oBusinessTradeExperience.ddate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_DDATE"]; } else {_oBusinessTradeExperience.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE"])) {_oBusinessTradeExperience.normal_rebate_type = (string)_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE"]; } else {_oBusinessTradeExperience.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_ACTIVE"])) {_oBusinessTradeExperience.active = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_ACTIVE"]; } else {_oBusinessTradeExperience.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_FREE_MON"])) {_oBusinessTradeExperience.free_mon = (string)_oData["BUSINESSTRADEEXPERIENCE_FREE_MON"]; } else {_oBusinessTradeExperience.free_mon=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CID"])) {_oBusinessTradeExperience.cid = (string)_oData["BUSINESSTRADEEXPERIENCE_CID"]; } else {_oBusinessTradeExperience.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CANCEL_RENEW"])) {_oBusinessTradeExperience.cancel_renew = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_CANCEL_RENEW"]; } else {_oBusinessTradeExperience.cancel_renew=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_OB_EARLY"])) {_oBusinessTradeExperience.ob_early = (string)_oData["BUSINESSTRADEEXPERIENCE_OB_EARLY"]; } else {_oBusinessTradeExperience.ob_early=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE"])) {_oBusinessTradeExperience.normal_rebate = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE"]; } else {_oBusinessTradeExperience.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL"])) {_oBusinessTradeExperience.hs_model = (string)_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL"]; } else {_oBusinessTradeExperience.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PLAN_FEE"])) {_oBusinessTradeExperience.plan_fee = (string)_oData["BUSINESSTRADEEXPERIENCE_PLAN_FEE"]; } else {_oBusinessTradeExperience.plan_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PO_DATE"])) {_oBusinessTradeExperience.po_date = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_PO_DATE"]; } else {_oBusinessTradeExperience.po_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REMARKS"])) {_oBusinessTradeExperience.remarks = (string)_oData["BUSINESSTRADEEXPERIENCE_REMARKS"]; } else {_oBusinessTradeExperience.remarks=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_ISSUE_TYPE"])) {_oBusinessTradeExperience.issue_type = (string)_oData["BUSINESSTRADEEXPERIENCE_ISSUE_TYPE"]; } else {_oBusinessTradeExperience.issue_type=global::System.String.Empty; }
                _oBusinessTradeExperience.SetDB(x_oDB);
                _oBusinessTradeExperience.GetFound();
                _oRow.Add(_oBusinessTradeExperience);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow;
        }
        #endregion
        
        #region DataSet
        /// <summary>
        /// Summary description for get table from records with DataSet
        /// </summary>
        
        public global::System.Data.DataSet GetDataSet()
        {
            return GetDataSet(n_oDB,"");
        }
        
        
        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB,x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( BusinessTradeExperience.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,BusinessTradeExperience.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(BusinessTradeExperience.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessTradeExperience.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [BusinessTradeExperience].[rec_no] AS BUSINESSTRADEEXPERIENCE_REC_NO,[BusinessTradeExperience].[mid] AS BUSINESSTRADEEXPERIENCE_MID,[BusinessTradeExperience].[channel] AS BUSINESSTRADEEXPERIENCE_CHANNEL,[BusinessTradeExperience].[cdate] AS BUSINESSTRADEEXPERIENCE_CDATE,[BusinessTradeExperience].[bundle_name] AS BUSINESSTRADEEXPERIENCE_BUNDLE_NAME,[BusinessTradeExperience].[hs_model_name] AS BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME,[BusinessTradeExperience].[trade_field] AS BUSINESSTRADEEXPERIENCE_TRADE_FIELD,[BusinessTradeExperience].[did] AS BUSINESSTRADEEXPERIENCE_DID,[BusinessTradeExperience].[premium_1] AS BUSINESSTRADEEXPERIENCE_PREMIUM_1,[BusinessTradeExperience].[sdate] AS BUSINESSTRADEEXPERIENCE_SDATE,[BusinessTradeExperience].[rebate] AS BUSINESSTRADEEXPERIENCE_REBATE,[BusinessTradeExperience].[premium_2] AS BUSINESSTRADEEXPERIENCE_PREMIUM_2,[BusinessTradeExperience].[po_date] AS BUSINESSTRADEEXPERIENCE_PO_DATE,[BusinessTradeExperience].[retention_type] AS BUSINESSTRADEEXPERIENCE_RETENTION_TYPE,[BusinessTradeExperience].[extra_offer] AS BUSINESSTRADEEXPERIENCE_EXTRA_OFFER,[BusinessTradeExperience].[edate] AS BUSINESSTRADEEXPERIENCE_EDATE,[BusinessTradeExperience].[program] AS BUSINESSTRADEEXPERIENCE_PROGRAM,[BusinessTradeExperience].[ob_early] AS BUSINESSTRADEEXPERIENCE_OB_EARLY,[BusinessTradeExperience].[con_per] AS BUSINESSTRADEEXPERIENCE_CON_PER,[BusinessTradeExperience].[ddate] AS BUSINESSTRADEEXPERIENCE_DDATE,[BusinessTradeExperience].[normal_rebate_type] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE,[BusinessTradeExperience].[active] AS BUSINESSTRADEEXPERIENCE_ACTIVE,[BusinessTradeExperience].[free_mon] AS BUSINESSTRADEEXPERIENCE_FREE_MON,[BusinessTradeExperience].[cid] AS BUSINESSTRADEEXPERIENCE_CID,[BusinessTradeExperience].[cancel_renew] AS BUSINESSTRADEEXPERIENCE_CANCEL_RENEW,[BusinessTradeExperience].[rate_plan] AS BUSINESSTRADEEXPERIENCE_RATE_PLAN,[BusinessTradeExperience].[normal_rebate] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE,[BusinessTradeExperience].[hs_model] AS BUSINESSTRADEEXPERIENCE_HS_MODEL,[BusinessTradeExperience].[plan_fee] AS BUSINESSTRADEEXPERIENCE_PLAN_FEE,[BusinessTradeExperience].[remarks] AS BUSINESSTRADEEXPERIENCE_REMARKS,[BusinessTradeExperience].[issue_type] AS BUSINESSTRADEEXPERIENCE_ISSUE_TYPE  FROM  [BusinessTradeExperience]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"BusinessTradeExperience");
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oAdp.Dispose();
                    _oConn.Dispose();
                }
                return _oDset;
            }
        }
        #endregion
        #region Insert
        
        
        /// <summary>
        /// Summary description for management Insert
        /// </summary>
        
        public bool Insert(global::System.Nullable<int> x_iRec_no,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            BusinessTradeExperience _oBusinessTradeExperience=BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessTradeExperience.rec_no=x_iRec_no;
            _oBusinessTradeExperience.channel=x_sChannel;
            _oBusinessTradeExperience.cdate=x_dCdate;
            _oBusinessTradeExperience.bundle_name=x_sBundle_name;
            _oBusinessTradeExperience.hs_model_name=x_sHs_model_name;
            _oBusinessTradeExperience.trade_field=x_sTrade_field;
            _oBusinessTradeExperience.did=x_sDid;
            _oBusinessTradeExperience.premium_1=x_sPremium_1;
            _oBusinessTradeExperience.sdate=x_dSdate;
            _oBusinessTradeExperience.rebate=x_sRebate;
            _oBusinessTradeExperience.premium_2=x_sPremium_2;
            _oBusinessTradeExperience.retention_type=x_sRetention_type;
            _oBusinessTradeExperience.extra_offer=x_sExtra_offer;
            _oBusinessTradeExperience.edate=x_dEdate;
            _oBusinessTradeExperience.program=x_sProgram;
            _oBusinessTradeExperience.con_per=x_sCon_per;
            _oBusinessTradeExperience.rate_plan=x_sRate_plan;
            _oBusinessTradeExperience.ddate=x_dDdate;
            _oBusinessTradeExperience.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTradeExperience.active=x_bActive;
            _oBusinessTradeExperience.free_mon=x_sFree_mon;
            _oBusinessTradeExperience.cid=x_sCid;
            _oBusinessTradeExperience.cancel_renew=x_bCancel_renew;
            _oBusinessTradeExperience.ob_early=x_sOb_early;
            _oBusinessTradeExperience.normal_rebate=x_bNormal_rebate;
            _oBusinessTradeExperience.hs_model=x_sHs_model;
            _oBusinessTradeExperience.plan_fee=x_sPlan_fee;
            _oBusinessTradeExperience.po_date=x_dPo_date;
            _oBusinessTradeExperience.remarks=x_sRemarks;
            _oBusinessTradeExperience.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oBusinessTradeExperience);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iRec_no,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            BusinessTradeExperience _oBusinessTradeExperience=BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessTradeExperience.rec_no=x_iRec_no;
            _oBusinessTradeExperience.channel=x_sChannel;
            _oBusinessTradeExperience.cdate=x_dCdate;
            _oBusinessTradeExperience.bundle_name=x_sBundle_name;
            _oBusinessTradeExperience.hs_model_name=x_sHs_model_name;
            _oBusinessTradeExperience.trade_field=x_sTrade_field;
            _oBusinessTradeExperience.did=x_sDid;
            _oBusinessTradeExperience.premium_1=x_sPremium_1;
            _oBusinessTradeExperience.sdate=x_dSdate;
            _oBusinessTradeExperience.rebate=x_sRebate;
            _oBusinessTradeExperience.premium_2=x_sPremium_2;
            _oBusinessTradeExperience.retention_type=x_sRetention_type;
            _oBusinessTradeExperience.extra_offer=x_sExtra_offer;
            _oBusinessTradeExperience.edate=x_dEdate;
            _oBusinessTradeExperience.program=x_sProgram;
            _oBusinessTradeExperience.con_per=x_sCon_per;
            _oBusinessTradeExperience.rate_plan=x_sRate_plan;
            _oBusinessTradeExperience.ddate=x_dDdate;
            _oBusinessTradeExperience.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTradeExperience.active=x_bActive;
            _oBusinessTradeExperience.free_mon=x_sFree_mon;
            _oBusinessTradeExperience.cid=x_sCid;
            _oBusinessTradeExperience.cancel_renew=x_bCancel_renew;
            _oBusinessTradeExperience.ob_early=x_sOb_early;
            _oBusinessTradeExperience.normal_rebate=x_bNormal_rebate;
            _oBusinessTradeExperience.hs_model=x_sHs_model;
            _oBusinessTradeExperience.plan_fee=x_sPlan_fee;
            _oBusinessTradeExperience.po_date=x_dPo_date;
            _oBusinessTradeExperience.remarks=x_sRemarks;
            _oBusinessTradeExperience.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oBusinessTradeExperience);
        }
        
        
        public bool Insert(BusinessTradeExperience x_oBusinessTradeExperience)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessTradeExperience);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessTradeExperience)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessTradeExperience)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,BusinessTradeExperience x_oBusinessTradeExperience)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessTradeExperience);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessTradeExperience x_oBusinessTradeExperience)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessTradeExperience]   ([rec_no],[channel],[cdate],[bundle_name],[hs_model_name],[trade_field],[did],[premium_1],[sdate],[rebate],[premium_2],[po_date],[retention_type],[extra_offer],[edate],[program],[ob_early],[con_per],[ddate],[normal_rebate_type],[active],[free_mon],[cid],[cancel_renew],[rate_plan],[normal_rebate],[hs_model],[plan_fee],[remarks],[issue_type])  VALUES  (@rec_no,@channel,@cdate,@bundle_name,@hs_model_name,@trade_field,@did,@premium_1,@sdate,@rebate,@premium_2,@po_date,@retention_type,@extra_offer,@edate,@program,@ob_early,@con_per,@ddate,@normal_rebate_type,@active,@free_mon,@cid,@cancel_renew,@rate_plan,@normal_rebate,@hs_model,@plan_fee,@remarks,@issue_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn =x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oBusinessTradeExperience);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessTradeExperience x_oBusinessTradeExperience)
        {
            bool _bResult = false;
            if (!x_oBusinessTradeExperience.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessTradeExperience.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oBusinessTradeExperience.rec_no; }
                if(x_oBusinessTradeExperience.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTradeExperience.channel; }
                if(x_oBusinessTradeExperience.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.cdate; }
                if(x_oBusinessTradeExperience.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.bundle_name; }
                if(x_oBusinessTradeExperience.hs_model_name==null){  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTradeExperience.hs_model_name; }
                if(x_oBusinessTradeExperience.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.trade_field; }
                if(x_oBusinessTradeExperience.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.did; }
                if(x_oBusinessTradeExperience.premium_1==null){  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.VarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.VarChar,250).Value=x_oBusinessTradeExperience.premium_1; }
                if(x_oBusinessTradeExperience.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.sdate; }
                if(x_oBusinessTradeExperience.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.rebate; }
                if(x_oBusinessTradeExperience.premium_2==null){  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.VarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.VarChar,250).Value=x_oBusinessTradeExperience.premium_2; }
                if(x_oBusinessTradeExperience.po_date==null){  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.po_date; }
                if(x_oBusinessTradeExperience.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.retention_type; }
                if(x_oBusinessTradeExperience.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTradeExperience.extra_offer; }
                if(x_oBusinessTradeExperience.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.edate; }
                if(x_oBusinessTradeExperience.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.program; }
                if(x_oBusinessTradeExperience.ob_early==null){  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTradeExperience.ob_early; }
                if(x_oBusinessTradeExperience.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.con_per; }
                if(x_oBusinessTradeExperience.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.ddate; }
                if(x_oBusinessTradeExperience.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessTradeExperience.normal_rebate_type; }
                if(x_oBusinessTradeExperience.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTradeExperience.active; }
                if(x_oBusinessTradeExperience.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.free_mon; }
                if(x_oBusinessTradeExperience.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.cid; }
                if(x_oBusinessTradeExperience.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTradeExperience.cancel_renew; }
                if(x_oBusinessTradeExperience.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.rate_plan; }
                if(x_oBusinessTradeExperience.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTradeExperience.normal_rebate; }
                if(x_oBusinessTradeExperience.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTradeExperience.hs_model; }
                if(x_oBusinessTradeExperience.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.plan_fee; }
                if(x_oBusinessTradeExperience.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oBusinessTradeExperience.remarks; }
                if(x_oBusinessTradeExperience.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRec_no,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            int _oLastID;
            BusinessTradeExperience _oBusinessTradeExperience=BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessTradeExperience.rec_no=x_iRec_no;
            _oBusinessTradeExperience.channel=x_sChannel;
            _oBusinessTradeExperience.cdate=x_dCdate;
            _oBusinessTradeExperience.bundle_name=x_sBundle_name;
            _oBusinessTradeExperience.hs_model_name=x_sHs_model_name;
            _oBusinessTradeExperience.trade_field=x_sTrade_field;
            _oBusinessTradeExperience.did=x_sDid;
            _oBusinessTradeExperience.premium_1=x_sPremium_1;
            _oBusinessTradeExperience.sdate=x_dSdate;
            _oBusinessTradeExperience.rebate=x_sRebate;
            _oBusinessTradeExperience.premium_2=x_sPremium_2;
            _oBusinessTradeExperience.retention_type=x_sRetention_type;
            _oBusinessTradeExperience.extra_offer=x_sExtra_offer;
            _oBusinessTradeExperience.edate=x_dEdate;
            _oBusinessTradeExperience.program=x_sProgram;
            _oBusinessTradeExperience.con_per=x_sCon_per;
            _oBusinessTradeExperience.rate_plan=x_sRate_plan;
            _oBusinessTradeExperience.ddate=x_dDdate;
            _oBusinessTradeExperience.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTradeExperience.active=x_bActive;
            _oBusinessTradeExperience.free_mon=x_sFree_mon;
            _oBusinessTradeExperience.cid=x_sCid;
            _oBusinessTradeExperience.cancel_renew=x_bCancel_renew;
            _oBusinessTradeExperience.ob_early=x_sOb_early;
            _oBusinessTradeExperience.normal_rebate=x_bNormal_rebate;
            _oBusinessTradeExperience.hs_model=x_sHs_model;
            _oBusinessTradeExperience.plan_fee=x_sPlan_fee;
            _oBusinessTradeExperience.po_date=x_dPo_date;
            _oBusinessTradeExperience.remarks=x_sRemarks;
            _oBusinessTradeExperience.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oBusinessTradeExperience,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(BusinessTradeExperience x_oBusinessTradeExperience)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBusinessTradeExperience, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, BusinessTradeExperience x_oBusinessTradeExperience)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBusinessTradeExperience, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessTradeExperience)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BusinessTradeExperience)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,BusinessTradeExperience x_oBusinessTradeExperience, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessTradeExperience]   ([rec_no],[channel],[cdate],[bundle_name],[hs_model_name],[trade_field],[did],[premium_1],[sdate],[rebate],[premium_2],[po_date],[retention_type],[extra_offer],[edate],[program],[ob_early],[con_per],[ddate],[normal_rebate_type],[active],[free_mon],[cid],[cancel_renew],[rate_plan],[normal_rebate],[hs_model],[plan_fee],[remarks],[issue_type])  VALUES  (@rec_no,@channel,@cdate,@bundle_name,@hs_model_name,@trade_field,@did,@premium_1,@sdate,@rebate,@premium_2,@po_date,@retention_type,@extra_offer,@edate,@program,@ob_early,@con_per,@ddate,@normal_rebate_type,@active,@free_mon,@cid,@cancel_renew,@rate_plan,@normal_rebate,@hs_model,@plan_fee,@remarks,@issue_type)"+" SELECT  @@IDENTITY AS BusinessTradeExperience_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oBusinessTradeExperience,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessTradeExperience x_oBusinessTradeExperience, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBusinessTradeExperience.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessTradeExperience.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oBusinessTradeExperience.rec_no; }
                if(x_oBusinessTradeExperience.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTradeExperience.channel; }
                if(x_oBusinessTradeExperience.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.cdate; }
                if(x_oBusinessTradeExperience.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.bundle_name; }
                if(x_oBusinessTradeExperience.hs_model_name==null){  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTradeExperience.hs_model_name; }
                if(x_oBusinessTradeExperience.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.trade_field; }
                if(x_oBusinessTradeExperience.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.did; }
                if(x_oBusinessTradeExperience.premium_1==null){  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.VarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.VarChar,250).Value=x_oBusinessTradeExperience.premium_1; }
                if(x_oBusinessTradeExperience.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.sdate; }
                if(x_oBusinessTradeExperience.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.rebate; }
                if(x_oBusinessTradeExperience.premium_2==null){  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.VarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.VarChar,250).Value=x_oBusinessTradeExperience.premium_2; }
                if(x_oBusinessTradeExperience.po_date==null){  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.po_date; }
                if(x_oBusinessTradeExperience.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.retention_type; }
                if(x_oBusinessTradeExperience.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTradeExperience.extra_offer; }
                if(x_oBusinessTradeExperience.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.edate; }
                if(x_oBusinessTradeExperience.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.program; }
                if(x_oBusinessTradeExperience.ob_early==null){  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTradeExperience.ob_early; }
                if(x_oBusinessTradeExperience.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.con_per; }
                if(x_oBusinessTradeExperience.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTradeExperience.ddate; }
                if(x_oBusinessTradeExperience.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessTradeExperience.normal_rebate_type; }
                if(x_oBusinessTradeExperience.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTradeExperience.active; }
                if(x_oBusinessTradeExperience.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.free_mon; }
                if(x_oBusinessTradeExperience.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.cid; }
                if(x_oBusinessTradeExperience.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTradeExperience.cancel_renew; }
                if(x_oBusinessTradeExperience.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.rate_plan; }
                if(x_oBusinessTradeExperience.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTradeExperience.normal_rebate; }
                if(x_oBusinessTradeExperience.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTradeExperience.hs_model; }
                if(x_oBusinessTradeExperience.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTradeExperience.plan_fee; }
                if(x_oBusinessTradeExperience.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oBusinessTradeExperience.remarks; }
                if(x_oBusinessTradeExperience.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTradeExperience.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BusinessTradeExperience_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["BusinessTradeExperience_LASTID"].ToString()) && int.TryParse(_oData["BusinessTradeExperience_LASTID"].ToString(),out x_iLAST_ID)){
                            _bResult=true;
                        }
                        else
                        {
                            x_iLAST_ID = -1;
                        }
                    }
                }
                _oData.Close();
                _oData.Dispose();
            }
            catch {  }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRec_no,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            int _oLastID;
            BusinessTradeExperience _oBusinessTradeExperience=BusinessTradeExperienceRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessTradeExperience.rec_no=x_iRec_no;
            _oBusinessTradeExperience.channel=x_sChannel;
            _oBusinessTradeExperience.cdate=x_dCdate;
            _oBusinessTradeExperience.bundle_name=x_sBundle_name;
            _oBusinessTradeExperience.hs_model_name=x_sHs_model_name;
            _oBusinessTradeExperience.trade_field=x_sTrade_field;
            _oBusinessTradeExperience.did=x_sDid;
            _oBusinessTradeExperience.premium_1=x_sPremium_1;
            _oBusinessTradeExperience.sdate=x_dSdate;
            _oBusinessTradeExperience.rebate=x_sRebate;
            _oBusinessTradeExperience.premium_2=x_sPremium_2;
            _oBusinessTradeExperience.retention_type=x_sRetention_type;
            _oBusinessTradeExperience.extra_offer=x_sExtra_offer;
            _oBusinessTradeExperience.edate=x_dEdate;
            _oBusinessTradeExperience.program=x_sProgram;
            _oBusinessTradeExperience.con_per=x_sCon_per;
            _oBusinessTradeExperience.rate_plan=x_sRate_plan;
            _oBusinessTradeExperience.ddate=x_dDdate;
            _oBusinessTradeExperience.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTradeExperience.active=x_bActive;
            _oBusinessTradeExperience.free_mon=x_sFree_mon;
            _oBusinessTradeExperience.cid=x_sCid;
            _oBusinessTradeExperience.cancel_renew=x_bCancel_renew;
            _oBusinessTradeExperience.ob_early=x_sOb_early;
            _oBusinessTradeExperience.normal_rebate=x_bNormal_rebate;
            _oBusinessTradeExperience.hs_model=x_sHs_model;
            _oBusinessTradeExperience.plan_fee=x_sPlan_fee;
            _oBusinessTradeExperience.po_date=x_dPo_date;
            _oBusinessTradeExperience.remarks=x_sRemarks;
            _oBusinessTradeExperience.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oBusinessTradeExperience,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(BusinessTradeExperience x_oBusinessTradeExperience)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessTradeExperience, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessTradeExperience x_oBusinessTradeExperience)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessTradeExperience, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessTradeExperience)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessTradeExperience)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,BusinessTradeExperience x_oBusinessTradeExperience, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSTRADEEXPERIENCE";
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oBusinessTradeExperience,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessTradeExperience x_oBusinessTradeExperience, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.rec_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.rec_no; }
                _oPar=x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.channel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.channel; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTradeExperience.cdate; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.hs_model_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.hs_model_name; }
                _oPar=x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.trade_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.trade_field; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.did; }
                _oPar=x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.VarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.premium_1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.premium_1; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTradeExperience.sdate; }
                _oPar=x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.rebate; }
                _oPar=x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.VarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.premium_2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.premium_2; }
                _oPar=x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.po_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTradeExperience.po_date; }
                _oPar=x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.retention_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.retention_type; }
                _oPar=x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.extra_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.extra_offer; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTradeExperience.edate; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.program; }
                _oPar=x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.ob_early==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.ob_early; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.con_per; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTradeExperience.ddate; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.active; }
                _oPar=x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.free_mon==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.free_mon; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.cid; }
                _oPar=x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.cancel_renew==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.cancel_renew; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.plan_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.plan_fee; }
                _oPar=x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.remarks==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.remarks; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTradeExperience.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTradeExperience.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
            }
            catch { }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        #region INSERT_BUSINESSTRADEEXPERIENCE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-07-13>
        ///-- Description:	<Description,BUSINESSTRADEEXPERIENCE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSTRADEEXPERIENCE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSTRADEEXPERIENCE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSTRADEEXPERIENCE;
        GO
        CREATE PROCEDURE INSERT_BUSINESSTRADEEXPERIENCE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @rec_no int,
        @channel char(10),
        @cdate datetime,
        @bundle_name nvarchar(50),
        @hs_model_name nvarchar(250),
        @trade_field nvarchar(50),
        @did nvarchar(10),
        @premium_1 varchar(250),
        @sdate datetime,
        @rebate nvarchar(10),
        @premium_2 varchar(250),
        @retention_type nvarchar(50),
        @extra_offer nvarchar(250),
        @edate datetime,
        @program nvarchar(50),
        @con_per nvarchar(10),
        @rate_plan nvarchar(50),
        @ddate datetime,
        @normal_rebate_type nvarchar(100),
        @active bit,
        @free_mon nvarchar(50),
        @cid nvarchar(10),
        @cancel_renew bit,
        @ob_early char(10),
        @normal_rebate bit,
        @hs_model nvarchar(250),
        @plan_fee nvarchar(10),
        @po_date datetime,
        @remarks text,
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [BusinessTradeExperience]   ([rec_no],[channel],[cdate],[bundle_name],[hs_model_name],[trade_field],[did],[premium_1],[sdate],[rebate],[premium_2],[po_date],[retention_type],[extra_offer],[edate],[program],[ob_early],[con_per],[ddate],[normal_rebate_type],[active],[free_mon],[cid],[cancel_renew],[rate_plan],[normal_rebate],[hs_model],[plan_fee],[remarks],[issue_type])  VALUES  (@rec_no,@channel,@cdate,@bundle_name,@hs_model_name,@trade_field,@did,@premium_1,@sdate,@rebate,@premium_2,@po_date,@retention_type,@extra_offer,@edate,@program,@ob_early,@con_per,@ddate,@normal_rebate_type,@active,@free_mon,@cid,@cancel_renew,@rate_plan,@normal_rebate,@hs_model,@plan_fee,@remarks,@issue_type)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_MID=@@IDENTITY
        RETURN @RETURN_MID
        END
        ELSE
        BEGIN
        SET @RETURN_MID=-1
        RETURN @RETURN_MID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(n_oDB, x_iMid);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessTradeExperience]  WHERE [BusinessTradeExperience].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return BusinessTradeExperienceRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessTradeExperience]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oCmd.CommandType = CommandType.Text;
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        
        
        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [BusinessTradeExperience]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        #endregion
        
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
        
    }
}


