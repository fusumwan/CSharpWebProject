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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-01-14>
///-- Description:	<Description,Table :[ProfileTeamRecordHistory],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProfileTeamRecordHistory] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"ProfileTeamRecordHistory")]
    public class ProfileTeamRecordHistoryRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static ProfileTeamRecordHistoryRepositoryBase instance;
        public static ProfileTeamRecordHistoryRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new ProfileTeamRecordHistoryRepositoryBase(_oDB);
            }
            return instance;
        }
        public static ProfileTeamRecordHistoryRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new ProfileTeamRecordHistoryRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<ProfileTeamRecordHistoryEntity> ProfileTeamRecordHistorys;
        #endregion
        
        #region Constructor
        public ProfileTeamRecordHistoryRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~ProfileTeamRecordHistoryRepositoryBase() { 
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
        public static ProfileTeamRecordHistory CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new ProfileTeamRecordHistory(_oDB);
        }
        
        public static ProfileTeamRecordHistory CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new ProfileTeamRecordHistory(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [ProfileTeamRecordHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
        
        
        public ProfileTeamRecordHistoryEntity GetObj(global::System.Nullable<long> x_lHis_id)
        {
            return GetObj(n_oDB, x_lHis_id);
        }
        
        
        public static ProfileTeamRecordHistoryEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id)
        {
            if (x_oDB==null) { return null; }
            ProfileTeamRecordHistory _ProfileTeamRecordHistory = (ProfileTeamRecordHistory)ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_ProfileTeamRecordHistory.Load(x_lHis_id)) { return null; }
            return _ProfileTeamRecordHistory;
        }
        
        
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistoryList = GetListObj(x_oDB,0, "his_id", x_oArrayItemId);
            if(_oProfileTeamRecordHistoryList==null){ return null;}
            return _oProfileTeamRecordHistoryList.Count == 0 ? null : _oProfileTeamRecordHistoryList.ToArray();
        }
        
        public static List<ProfileTeamRecordHistoryEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "his_id", x_oArrayItemId);
        }
        
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistoryList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oProfileTeamRecordHistoryList==null){ return null;}
            return _oProfileTeamRecordHistoryList.Count == 0 ? null : _oProfileTeamRecordHistoryList.ToArray();
        }
        
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistoryList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oProfileTeamRecordHistoryList==null){ return null;}
            return _oProfileTeamRecordHistoryList.Count == 0 ? null : _oProfileTeamRecordHistoryList.ToArray();
        }
        
        public static List<ProfileTeamRecordHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<ProfileTeamRecordHistoryEntity> _oRow = new List<ProfileTeamRecordHistoryEntity>();
            string _sQuery = "SELECT  "+_sTop+" [ProfileTeamRecordHistory].[active] AS PROFILETEAMRECORDHISTORY_ACTIVE,[ProfileTeamRecordHistory].[cdate] AS PROFILETEAMRECORDHISTORY_CDATE,[ProfileTeamRecordHistory].[cid] AS PROFILETEAMRECORDHISTORY_CID,[ProfileTeamRecordHistory].[did] AS PROFILETEAMRECORDHISTORY_DID,[ProfileTeamRecordHistory].[sdate] AS PROFILETEAMRECORDHISTORY_SDATE,[ProfileTeamRecordHistory].[action_type] AS PROFILETEAMRECORDHISTORY_ACTION_TYPE,[ProfileTeamRecordHistory].[edate] AS PROFILETEAMRECORDHISTORY_EDATE,[ProfileTeamRecordHistory].[salesman_code] AS PROFILETEAMRECORDHISTORY_SALESMAN_CODE,[ProfileTeamRecordHistory].[his_id] AS PROFILETEAMRECORDHISTORY_HIS_ID,[ProfileTeamRecordHistory].[staff_no] AS PROFILETEAMRECORDHISTORY_STAFF_NO,[ProfileTeamRecordHistory].[ddate] AS PROFILETEAMRECORDHISTORY_DDATE,[ProfileTeamRecordHistory].[rec_no] AS PROFILETEAMRECORDHISTORY_REC_NO,[ProfileTeamRecordHistory].[remark] AS PROFILETEAMRECORDHISTORY_REMARK  FROM  [ProfileTeamRecordHistory]";
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
                _sQuery += " WHERE [ProfileTeamRecordHistory].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        ProfileTeamRecordHistory _oProfileTeamRecordHistory = ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTIVE"])) {_oProfileTeamRecordHistory.active = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORDHISTORY_ACTIVE"]; }else{_oProfileTeamRecordHistory.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CDATE"])) {_oProfileTeamRecordHistory.cdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_CDATE"]; }else{_oProfileTeamRecordHistory.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CID"])) {_oProfileTeamRecordHistory.cid = (string)_oData["PROFILETEAMRECORDHISTORY_CID"]; }else{_oProfileTeamRecordHistory.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DID"])) {_oProfileTeamRecordHistory.did = (string)_oData["PROFILETEAMRECORDHISTORY_DID"]; }else{_oProfileTeamRecordHistory.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"])) {_oProfileTeamRecordHistory.action_type = (string)_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"]; }else{_oProfileTeamRecordHistory.action_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_EDATE"])) {_oProfileTeamRecordHistory.edate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_EDATE"]; }else{_oProfileTeamRecordHistory.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REC_NO"])) {_oProfileTeamRecordHistory.rec_no = (global::System.Nullable<int>)_oData["PROFILETEAMRECORDHISTORY_REC_NO"]; }else{_oProfileTeamRecordHistory.rec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"])) {_oProfileTeamRecordHistory.salesman_code = (string)_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"]; }else{_oProfileTeamRecordHistory.salesman_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_HIS_ID"])) {_oProfileTeamRecordHistory.his_id = (global::System.Nullable<long>)_oData["PROFILETEAMRECORDHISTORY_HIS_ID"]; }else{_oProfileTeamRecordHistory.his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"])) {_oProfileTeamRecordHistory.staff_no = (string)_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"]; }else{_oProfileTeamRecordHistory.staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DDATE"])) {_oProfileTeamRecordHistory.ddate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_DDATE"]; }else{_oProfileTeamRecordHistory.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SDATE"])) {_oProfileTeamRecordHistory.sdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_SDATE"]; }else{_oProfileTeamRecordHistory.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REMARK"])) {_oProfileTeamRecordHistory.remark = (string)_oData["PROFILETEAMRECORDHISTORY_REMARK"]; }else{_oProfileTeamRecordHistory.remark=global::System.String.Empty;}
                        _oProfileTeamRecordHistory.SetDB(x_oDB);
                        _oProfileTeamRecordHistory.GetFound();
                        _oRow.Add(_oProfileTeamRecordHistory);
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
        
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistoryList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oProfileTeamRecordHistoryList==null){ return null;}
            return _oProfileTeamRecordHistoryList.Count == 0 ? null : _oProfileTeamRecordHistoryList.ToArray();
        }
        
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistoryList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oProfileTeamRecordHistoryList==null){ return null;}
            return _oProfileTeamRecordHistoryList.Count == 0 ? null : _oProfileTeamRecordHistoryList.ToArray();
        }
        
        public static List<ProfileTeamRecordHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<ProfileTeamRecordHistoryEntity> _oRow = new List<ProfileTeamRecordHistoryEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[ProfileTeamRecordHistory].[active] AS PROFILETEAMRECORDHISTORY_ACTIVE,[ProfileTeamRecordHistory].[cdate] AS PROFILETEAMRECORDHISTORY_CDATE,[ProfileTeamRecordHistory].[cid] AS PROFILETEAMRECORDHISTORY_CID,[ProfileTeamRecordHistory].[did] AS PROFILETEAMRECORDHISTORY_DID,[ProfileTeamRecordHistory].[sdate] AS PROFILETEAMRECORDHISTORY_SDATE,[ProfileTeamRecordHistory].[action_type] AS PROFILETEAMRECORDHISTORY_ACTION_TYPE,[ProfileTeamRecordHistory].[edate] AS PROFILETEAMRECORDHISTORY_EDATE,[ProfileTeamRecordHistory].[salesman_code] AS PROFILETEAMRECORDHISTORY_SALESMAN_CODE,[ProfileTeamRecordHistory].[his_id] AS PROFILETEAMRECORDHISTORY_HIS_ID,[ProfileTeamRecordHistory].[staff_no] AS PROFILETEAMRECORDHISTORY_STAFF_NO,[ProfileTeamRecordHistory].[ddate] AS PROFILETEAMRECORDHISTORY_DDATE,[ProfileTeamRecordHistory].[rec_no] AS PROFILETEAMRECORDHISTORY_REC_NO,[ProfileTeamRecordHistory].[remark] AS PROFILETEAMRECORDHISTORY_REMARK";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = ProfileTeamRecordHistoryRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                ProfileTeamRecordHistoryEntity _oProfileTeamRecordHistory = ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTIVE"])) {_oProfileTeamRecordHistory.active = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORDHISTORY_ACTIVE"]; } else {_oProfileTeamRecordHistory.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CDATE"])) {_oProfileTeamRecordHistory.cdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_CDATE"]; } else {_oProfileTeamRecordHistory.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CID"])) {_oProfileTeamRecordHistory.cid = (string)_oData["PROFILETEAMRECORDHISTORY_CID"]; } else {_oProfileTeamRecordHistory.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DID"])) {_oProfileTeamRecordHistory.did = (string)_oData["PROFILETEAMRECORDHISTORY_DID"]; } else {_oProfileTeamRecordHistory.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"])) {_oProfileTeamRecordHistory.action_type = (string)_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"]; } else {_oProfileTeamRecordHistory.action_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_EDATE"])) {_oProfileTeamRecordHistory.edate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_EDATE"]; } else {_oProfileTeamRecordHistory.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REC_NO"])) {_oProfileTeamRecordHistory.rec_no = (global::System.Nullable<int>)_oData["PROFILETEAMRECORDHISTORY_REC_NO"]; } else {_oProfileTeamRecordHistory.rec_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"])) {_oProfileTeamRecordHistory.salesman_code = (string)_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"]; } else {_oProfileTeamRecordHistory.salesman_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_HIS_ID"])) {_oProfileTeamRecordHistory.his_id = (global::System.Nullable<long>)_oData["PROFILETEAMRECORDHISTORY_HIS_ID"]; } else {_oProfileTeamRecordHistory.his_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"])) {_oProfileTeamRecordHistory.staff_no = (string)_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"]; } else {_oProfileTeamRecordHistory.staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DDATE"])) {_oProfileTeamRecordHistory.ddate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_DDATE"]; } else {_oProfileTeamRecordHistory.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SDATE"])) {_oProfileTeamRecordHistory.sdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_SDATE"]; } else {_oProfileTeamRecordHistory.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REMARK"])) {_oProfileTeamRecordHistory.remark = (string)_oData["PROFILETEAMRECORDHISTORY_REMARK"]; } else {_oProfileTeamRecordHistory.remark=global::System.String.Empty; }
                _oProfileTeamRecordHistory.SetDB(x_oDB);
                _oProfileTeamRecordHistory.GetFound();
                _oRow.Add(_oProfileTeamRecordHistory);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( ProfileTeamRecordHistory.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,ProfileTeamRecordHistory.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(ProfileTeamRecordHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(ProfileTeamRecordHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [ProfileTeamRecordHistory].[active] AS PROFILETEAMRECORDHISTORY_ACTIVE,[ProfileTeamRecordHistory].[cdate] AS PROFILETEAMRECORDHISTORY_CDATE,[ProfileTeamRecordHistory].[cid] AS PROFILETEAMRECORDHISTORY_CID,[ProfileTeamRecordHistory].[did] AS PROFILETEAMRECORDHISTORY_DID,[ProfileTeamRecordHistory].[sdate] AS PROFILETEAMRECORDHISTORY_SDATE,[ProfileTeamRecordHistory].[action_type] AS PROFILETEAMRECORDHISTORY_ACTION_TYPE,[ProfileTeamRecordHistory].[edate] AS PROFILETEAMRECORDHISTORY_EDATE,[ProfileTeamRecordHistory].[salesman_code] AS PROFILETEAMRECORDHISTORY_SALESMAN_CODE,[ProfileTeamRecordHistory].[his_id] AS PROFILETEAMRECORDHISTORY_HIS_ID,[ProfileTeamRecordHistory].[staff_no] AS PROFILETEAMRECORDHISTORY_STAFF_NO,[ProfileTeamRecordHistory].[ddate] AS PROFILETEAMRECORDHISTORY_DDATE,[ProfileTeamRecordHistory].[rec_no] AS PROFILETEAMRECORDHISTORY_REC_NO,[ProfileTeamRecordHistory].[remark] AS PROFILETEAMRECORDHISTORY_REMARK  FROM  [ProfileTeamRecordHistory]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"ProfileTeamRecordHistory");
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
        
        public bool Insert(global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sAction_type,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<int> x_iRec_no,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate,string x_sRemark)
        {
            ProfileTeamRecordHistory _oProfileTeamRecordHistory=ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oProfileTeamRecordHistory.active=x_bActive;
            _oProfileTeamRecordHistory.cdate=x_dCdate;
            _oProfileTeamRecordHistory.cid=x_sCid;
            _oProfileTeamRecordHistory.did=x_sDid;
            _oProfileTeamRecordHistory.action_type=x_sAction_type;
            _oProfileTeamRecordHistory.edate=x_dEdate;
            _oProfileTeamRecordHistory.rec_no=x_iRec_no;
            _oProfileTeamRecordHistory.salesman_code=x_sSalesman_code;
            _oProfileTeamRecordHistory.staff_no=x_sStaff_no;
            _oProfileTeamRecordHistory.ddate=x_dDdate;
            _oProfileTeamRecordHistory.sdate=x_dSdate;
            _oProfileTeamRecordHistory.remark=x_sRemark;
            return InsertWithOutLastID(n_oDB, _oProfileTeamRecordHistory);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sAction_type,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<int> x_iRec_no,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate,string x_sRemark)
        {
            ProfileTeamRecordHistory _oProfileTeamRecordHistory=ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamRecordHistory.active=x_bActive;
            _oProfileTeamRecordHistory.cdate=x_dCdate;
            _oProfileTeamRecordHistory.cid=x_sCid;
            _oProfileTeamRecordHistory.did=x_sDid;
            _oProfileTeamRecordHistory.action_type=x_sAction_type;
            _oProfileTeamRecordHistory.edate=x_dEdate;
            _oProfileTeamRecordHistory.rec_no=x_iRec_no;
            _oProfileTeamRecordHistory.salesman_code=x_sSalesman_code;
            _oProfileTeamRecordHistory.staff_no=x_sStaff_no;
            _oProfileTeamRecordHistory.ddate=x_dDdate;
            _oProfileTeamRecordHistory.sdate=x_dSdate;
            _oProfileTeamRecordHistory.remark=x_sRemark;
            return InsertWithOutLastID(x_oDB, _oProfileTeamRecordHistory);
        }
        
        
        public bool Insert(ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            return InsertWithOutLastID(n_oDB, x_oProfileTeamRecordHistory);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is ProfileTeamRecordHistory)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (ProfileTeamRecordHistory)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            return InsertWithOutLastID(x_oDB, x_oProfileTeamRecordHistory);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ProfileTeamRecordHistory]   ([active],[cdate],[cid],[did],[sdate],[action_type],[edate],[salesman_code],[staff_no],[ddate],[rec_no],[remark])  VALUES  (@active,@cdate,@cid,@did,@sdate,@action_type,@edate,@salesman_code,@staff_no,@ddate,@rec_no,@remark)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oProfileTeamRecordHistory);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            bool _bResult = false;
            if (!x_oProfileTeamRecordHistory.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oProfileTeamRecordHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oProfileTeamRecordHistory.active; }
                if(x_oProfileTeamRecordHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.cdate; }
                if(x_oProfileTeamRecordHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.cid; }
                if(x_oProfileTeamRecordHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.did; }
                if(x_oProfileTeamRecordHistory.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.sdate; }
                if(x_oProfileTeamRecordHistory.action_type==null){  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.action_type; }
                if(x_oProfileTeamRecordHistory.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.edate; }
                if(x_oProfileTeamRecordHistory.salesman_code==null){  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value=x_oProfileTeamRecordHistory.salesman_code; }
                if(x_oProfileTeamRecordHistory.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.staff_no; }
                if(x_oProfileTeamRecordHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.ddate; }
                if(x_oProfileTeamRecordHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oProfileTeamRecordHistory.rec_no; }
                if(x_oProfileTeamRecordHistory.remark==null){  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value=x_oProfileTeamRecordHistory.remark; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sAction_type,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<int> x_iRec_no,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate,string x_sRemark)
        {
            int _oLastID;
            ProfileTeamRecordHistory _oProfileTeamRecordHistory=ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamRecordHistory.active=x_bActive;
            _oProfileTeamRecordHistory.cdate=x_dCdate;
            _oProfileTeamRecordHistory.cid=x_sCid;
            _oProfileTeamRecordHistory.did=x_sDid;
            _oProfileTeamRecordHistory.action_type=x_sAction_type;
            _oProfileTeamRecordHistory.edate=x_dEdate;
            _oProfileTeamRecordHistory.rec_no=x_iRec_no;
            _oProfileTeamRecordHistory.salesman_code=x_sSalesman_code;
            _oProfileTeamRecordHistory.staff_no=x_sStaff_no;
            _oProfileTeamRecordHistory.ddate=x_dDdate;
            _oProfileTeamRecordHistory.sdate=x_dSdate;
            _oProfileTeamRecordHistory.remark=x_sRemark;
            if(InsertWithLastID(x_oDB, _oProfileTeamRecordHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oProfileTeamRecordHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oProfileTeamRecordHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProfileTeamRecordHistory)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (ProfileTeamRecordHistory)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,ProfileTeamRecordHistory x_oProfileTeamRecordHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ProfileTeamRecordHistory]   ([active],[cdate],[cid],[did],[sdate],[action_type],[edate],[salesman_code],[staff_no],[ddate],[rec_no],[remark])  VALUES  (@active,@cdate,@cid,@did,@sdate,@action_type,@edate,@salesman_code,@staff_no,@ddate,@rec_no,@remark)"+" SELECT  @@IDENTITY AS ProfileTeamRecordHistory_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oProfileTeamRecordHistory,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProfileTeamRecordHistory x_oProfileTeamRecordHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oProfileTeamRecordHistory.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oProfileTeamRecordHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oProfileTeamRecordHistory.active; }
                if(x_oProfileTeamRecordHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.cdate; }
                if(x_oProfileTeamRecordHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.cid; }
                if(x_oProfileTeamRecordHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.did; }
                if(x_oProfileTeamRecordHistory.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.sdate; }
                if(x_oProfileTeamRecordHistory.action_type==null){  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.action_type; }
                if(x_oProfileTeamRecordHistory.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.edate; }
                if(x_oProfileTeamRecordHistory.salesman_code==null){  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value=x_oProfileTeamRecordHistory.salesman_code; }
                if(x_oProfileTeamRecordHistory.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecordHistory.staff_no; }
                if(x_oProfileTeamRecordHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecordHistory.ddate; }
                if(x_oProfileTeamRecordHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oProfileTeamRecordHistory.rec_no; }
                if(x_oProfileTeamRecordHistory.remark==null){  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value=x_oProfileTeamRecordHistory.remark; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["ProfileTeamRecordHistory_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["ProfileTeamRecordHistory_LASTID"].ToString()) && int.TryParse(_oData["ProfileTeamRecordHistory_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sAction_type,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<int> x_iRec_no,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate,string x_sRemark)
        {
            int _oLastID;
            ProfileTeamRecordHistory _oProfileTeamRecordHistory=ProfileTeamRecordHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamRecordHistory.active=x_bActive;
            _oProfileTeamRecordHistory.cdate=x_dCdate;
            _oProfileTeamRecordHistory.cid=x_sCid;
            _oProfileTeamRecordHistory.did=x_sDid;
            _oProfileTeamRecordHistory.action_type=x_sAction_type;
            _oProfileTeamRecordHistory.edate=x_dEdate;
            _oProfileTeamRecordHistory.rec_no=x_iRec_no;
            _oProfileTeamRecordHistory.salesman_code=x_sSalesman_code;
            _oProfileTeamRecordHistory.staff_no=x_sStaff_no;
            _oProfileTeamRecordHistory.ddate=x_dDdate;
            _oProfileTeamRecordHistory.sdate=x_dSdate;
            _oProfileTeamRecordHistory.remark=x_sRemark;
            if(InsertWithLastID_SP(x_oDB, _oProfileTeamRecordHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oProfileTeamRecordHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oProfileTeamRecordHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProfileTeamRecordHistory)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (ProfileTeamRecordHistory)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,ProfileTeamRecordHistory x_oProfileTeamRecordHistory, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "PROFILETEAMRECORDHISTORY";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oProfileTeamRecordHistory,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProfileTeamRecordHistory x_oProfileTeamRecordHistory, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.active; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecordHistory.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.did; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecordHistory.sdate; }
                _oPar=x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.action_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.action_type; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecordHistory.edate; }
                _oPar=x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.salesman_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.salesman_code; }
                _oPar=x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.staff_no; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecordHistory.ddate; }
                _oPar=x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.rec_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.rec_no; }
                _oPar=x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecordHistory.remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecordHistory.remark; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_HIS_ID", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_HIS_ID"].Value.ToString());
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
        
        #region INSERT_PROFILETEAMRECORDHISTORY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-01-14>
        ///-- Description:	<Description,PROFILETEAMRECORDHISTORY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_PROFILETEAMRECORDHISTORY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_PROFILETEAMRECORDHISTORY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_PROFILETEAMRECORDHISTORY;
        GO
        CREATE PROCEDURE INSERT_PROFILETEAMRECORDHISTORY
        	-- Add the parameters for the stored procedure here
        @RETURN_HIS_ID bigint output,
        @active bit,
        @cdate datetime,
        @cid nvarchar(50),
        @did nvarchar(50),
        @action_type nvarchar(50),
        @edate datetime,
        @rec_no int,
        @salesman_code nvarchar(4),
        @staff_no nvarchar(50),
        @ddate datetime,
        @sdate datetime,
        @remark text
        AS
        
        INSERT INTO  [ProfileTeamRecordHistory]   ([active],[cdate],[cid],[did],[sdate],[action_type],[edate],[salesman_code],[staff_no],[ddate],[rec_no],[remark])  VALUES  (@active,@cdate,@cid,@did,@sdate,@action_type,@edate,@salesman_code,@staff_no,@ddate,@rec_no,@remark)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_HIS_ID=@@IDENTITY
        RETURN @RETURN_HIS_ID
        END
        ELSE
        BEGIN
        SET @RETURN_HIS_ID=-1
        RETURN @RETURN_HIS_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<long> x_lHis_id)
        {
            return DeleteProc(n_oDB, x_lHis_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id)
        {
            return DeleteProc(x_oDB, x_lHis_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lHis_id)
        {
            if (x_lHis_id==null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamRecordHistory]  WHERE [ProfileTeamRecordHistory].[his_id]=@his_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@his_id", global::System.Data.SqlDbType.BigInt).Value = x_lHis_id;
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
            return ProfileTeamRecordHistoryRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamRecordHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
            string _sQuery = "DELETE FROM [ProfileTeamRecordHistory]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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


