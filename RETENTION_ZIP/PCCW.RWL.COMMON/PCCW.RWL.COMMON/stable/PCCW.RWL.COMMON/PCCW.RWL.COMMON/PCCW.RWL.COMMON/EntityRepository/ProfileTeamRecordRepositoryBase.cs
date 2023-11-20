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
///-- Create date: <Create Date 2011-01-11>
///-- Description:	<Description,Table :[ProfileTeamRecord],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProfileTeamRecord] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"ProfileTeamRecord")]
    public class ProfileTeamRecordRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static ProfileTeamRecordRepositoryBase instance;
        public static ProfileTeamRecordRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new ProfileTeamRecordRepositoryBase(_oDB);
            }
            return instance;
        }
        public static ProfileTeamRecordRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new ProfileTeamRecordRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<ProfileTeamRecordEntity> ProfileTeamRecords;
        #endregion
        
        #region Constructor
        public ProfileTeamRecordRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~ProfileTeamRecordRepositoryBase() { 
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
        public static ProfileTeamRecord CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new ProfileTeamRecord(_oDB);
        }
        
        public static ProfileTeamRecord CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new ProfileTeamRecord(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [ProfileTeamRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
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
        
        
        public ProfileTeamRecordEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static ProfileTeamRecordEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            ProfileTeamRecord _ProfileTeamRecord = (ProfileTeamRecord)ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_ProfileTeamRecord.Load(x_iId)) { return null; }
            return _ProfileTeamRecord;
        }
        
        
        
        public static ProfileTeamRecordEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<ProfileTeamRecordEntity> _oProfileTeamRecordList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oProfileTeamRecordList==null){ return null;}
            return _oProfileTeamRecordList.Count == 0 ? null : _oProfileTeamRecordList.ToArray();
        }
        
        public static List<ProfileTeamRecordEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static ProfileTeamRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProfileTeamRecordEntity> _oProfileTeamRecordList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oProfileTeamRecordList==null){ return null;}
            return _oProfileTeamRecordList.Count == 0 ? null : _oProfileTeamRecordList.ToArray();
        }
        
        
        public static ProfileTeamRecordEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProfileTeamRecordEntity> _oProfileTeamRecordList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oProfileTeamRecordList==null){ return null;}
            return _oProfileTeamRecordList.Count == 0 ? null : _oProfileTeamRecordList.ToArray();
        }
        
        public static List<ProfileTeamRecordEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<ProfileTeamRecordEntity> _oRow = new List<ProfileTeamRecordEntity>();
            string _sQuery = "SELECT  "+_sTop+" [ProfileTeamRecord].[id] AS PROFILETEAMRECORD_ID,[ProfileTeamRecord].[cdate] AS PROFILETEAMRECORD_CDATE,[ProfileTeamRecord].[cid] AS PROFILETEAMRECORD_CID,[ProfileTeamRecord].[did] AS PROFILETEAMRECORD_DID,[ProfileTeamRecord].[active] AS PROFILETEAMRECORD_ACTIVE,[ProfileTeamRecord].[remark] AS PROFILETEAMRECORD_REMARK,[ProfileTeamRecord].[edate] AS PROFILETEAMRECORD_EDATE,[ProfileTeamRecord].[salesman_code] AS PROFILETEAMRECORD_SALESMAN_CODE,[ProfileTeamRecord].[staff_no] AS PROFILETEAMRECORD_STAFF_NO,[ProfileTeamRecord].[ddate] AS PROFILETEAMRECORD_DDATE,[ProfileTeamRecord].[sdate] AS PROFILETEAMRECORD_SDATE  FROM  [ProfileTeamRecord]";
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
                _sQuery += " WHERE [ProfileTeamRecord].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        ProfileTeamRecord _oProfileTeamRecord = ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_ID"])) {_oProfileTeamRecord.id = (global::System.Nullable<int>)_oData["PROFILETEAMRECORD_ID"]; }else{_oProfileTeamRecord.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_CDATE"])) {_oProfileTeamRecord.cdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_CDATE"]; }else{_oProfileTeamRecord.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_CID"])) {_oProfileTeamRecord.cid = (string)_oData["PROFILETEAMRECORD_CID"]; }else{_oProfileTeamRecord.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_DID"])) {_oProfileTeamRecord.did = (string)_oData["PROFILETEAMRECORD_DID"]; }else{_oProfileTeamRecord.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_ACTIVE"])) {_oProfileTeamRecord.active = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORD_ACTIVE"]; }else{_oProfileTeamRecord.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_REMARK"])) {_oProfileTeamRecord.remark = (string)_oData["PROFILETEAMRECORD_REMARK"]; }else{_oProfileTeamRecord.remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_EDATE"])) {_oProfileTeamRecord.edate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_EDATE"]; }else{_oProfileTeamRecord.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_SALESMAN_CODE"])) {_oProfileTeamRecord.salesman_code = (string)_oData["PROFILETEAMRECORD_SALESMAN_CODE"]; }else{_oProfileTeamRecord.salesman_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_STAFF_NO"])) {_oProfileTeamRecord.staff_no = (string)_oData["PROFILETEAMRECORD_STAFF_NO"]; }else{_oProfileTeamRecord.staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_DDATE"])) {_oProfileTeamRecord.ddate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_DDATE"]; }else{_oProfileTeamRecord.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_SDATE"])) {_oProfileTeamRecord.sdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_SDATE"]; }else{_oProfileTeamRecord.sdate=null;}
                        _oProfileTeamRecord.SetDB(x_oDB);
                        _oProfileTeamRecord.GetFound();
                        _oRow.Add(_oProfileTeamRecord);
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
        
        
        public static ProfileTeamRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProfileTeamRecordEntity> _oProfileTeamRecordList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oProfileTeamRecordList==null){ return null;}
            return _oProfileTeamRecordList.Count == 0 ? null : _oProfileTeamRecordList.ToArray();
        }
        
        
        public static ProfileTeamRecordEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProfileTeamRecordEntity> _oProfileTeamRecordList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oProfileTeamRecordList==null){ return null;}
            return _oProfileTeamRecordList.Count == 0 ? null : _oProfileTeamRecordList.ToArray();
        }
        
        public static List<ProfileTeamRecordEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<ProfileTeamRecordEntity> _oRow = new List<ProfileTeamRecordEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[ProfileTeamRecord].[id] AS PROFILETEAMRECORD_ID,[ProfileTeamRecord].[cdate] AS PROFILETEAMRECORD_CDATE,[ProfileTeamRecord].[cid] AS PROFILETEAMRECORD_CID,[ProfileTeamRecord].[did] AS PROFILETEAMRECORD_DID,[ProfileTeamRecord].[active] AS PROFILETEAMRECORD_ACTIVE,[ProfileTeamRecord].[remark] AS PROFILETEAMRECORD_REMARK,[ProfileTeamRecord].[edate] AS PROFILETEAMRECORD_EDATE,[ProfileTeamRecord].[salesman_code] AS PROFILETEAMRECORD_SALESMAN_CODE,[ProfileTeamRecord].[staff_no] AS PROFILETEAMRECORD_STAFF_NO,[ProfileTeamRecord].[ddate] AS PROFILETEAMRECORD_DDATE,[ProfileTeamRecord].[sdate] AS PROFILETEAMRECORD_SDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = ProfileTeamRecordRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                ProfileTeamRecordEntity _oProfileTeamRecord = ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_ID"])) {_oProfileTeamRecord.id = (global::System.Nullable<int>)_oData["PROFILETEAMRECORD_ID"]; } else {_oProfileTeamRecord.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_CDATE"])) {_oProfileTeamRecord.cdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_CDATE"]; } else {_oProfileTeamRecord.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_CID"])) {_oProfileTeamRecord.cid = (string)_oData["PROFILETEAMRECORD_CID"]; } else {_oProfileTeamRecord.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_DID"])) {_oProfileTeamRecord.did = (string)_oData["PROFILETEAMRECORD_DID"]; } else {_oProfileTeamRecord.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_ACTIVE"])) {_oProfileTeamRecord.active = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORD_ACTIVE"]; } else {_oProfileTeamRecord.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_REMARK"])) {_oProfileTeamRecord.remark = (string)_oData["PROFILETEAMRECORD_REMARK"]; } else {_oProfileTeamRecord.remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_EDATE"])) {_oProfileTeamRecord.edate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_EDATE"]; } else {_oProfileTeamRecord.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_SALESMAN_CODE"])) {_oProfileTeamRecord.salesman_code = (string)_oData["PROFILETEAMRECORD_SALESMAN_CODE"]; } else {_oProfileTeamRecord.salesman_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_STAFF_NO"])) {_oProfileTeamRecord.staff_no = (string)_oData["PROFILETEAMRECORD_STAFF_NO"]; } else {_oProfileTeamRecord.staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_DDATE"])) {_oProfileTeamRecord.ddate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_DDATE"]; } else {_oProfileTeamRecord.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_SDATE"])) {_oProfileTeamRecord.sdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_SDATE"]; } else {_oProfileTeamRecord.sdate=null; }
                _oProfileTeamRecord.SetDB(x_oDB);
                _oProfileTeamRecord.GetFound();
                _oRow.Add(_oProfileTeamRecord);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( ProfileTeamRecord.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,ProfileTeamRecord.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(ProfileTeamRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(ProfileTeamRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [ProfileTeamRecord].[id] AS PROFILETEAMRECORD_ID,[ProfileTeamRecord].[cdate] AS PROFILETEAMRECORD_CDATE,[ProfileTeamRecord].[cid] AS PROFILETEAMRECORD_CID,[ProfileTeamRecord].[did] AS PROFILETEAMRECORD_DID,[ProfileTeamRecord].[active] AS PROFILETEAMRECORD_ACTIVE,[ProfileTeamRecord].[remark] AS PROFILETEAMRECORD_REMARK,[ProfileTeamRecord].[edate] AS PROFILETEAMRECORD_EDATE,[ProfileTeamRecord].[salesman_code] AS PROFILETEAMRECORD_SALESMAN_CODE,[ProfileTeamRecord].[staff_no] AS PROFILETEAMRECORD_STAFF_NO,[ProfileTeamRecord].[ddate] AS PROFILETEAMRECORD_DDATE,[ProfileTeamRecord].[sdate] AS PROFILETEAMRECORD_SDATE  FROM  [ProfileTeamRecord]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"ProfileTeamRecord");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bActive,string x_sRemark,global::System.Nullable<DateTime> x_dEdate,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            ProfileTeamRecord _oProfileTeamRecord=ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oProfileTeamRecord.cdate=x_dCdate;
            _oProfileTeamRecord.cid=x_sCid;
            _oProfileTeamRecord.did=x_sDid;
            _oProfileTeamRecord.active=x_bActive;
            _oProfileTeamRecord.remark=x_sRemark;
            _oProfileTeamRecord.edate=x_dEdate;
            _oProfileTeamRecord.salesman_code=x_sSalesman_code;
            _oProfileTeamRecord.staff_no=x_sStaff_no;
            _oProfileTeamRecord.ddate=x_dDdate;
            _oProfileTeamRecord.sdate=x_dSdate;
            return InsertWithOutLastID(n_oDB, _oProfileTeamRecord);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bActive,string x_sRemark,global::System.Nullable<DateTime> x_dEdate,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            ProfileTeamRecord _oProfileTeamRecord=ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamRecord.cdate=x_dCdate;
            _oProfileTeamRecord.cid=x_sCid;
            _oProfileTeamRecord.did=x_sDid;
            _oProfileTeamRecord.active=x_bActive;
            _oProfileTeamRecord.remark=x_sRemark;
            _oProfileTeamRecord.edate=x_dEdate;
            _oProfileTeamRecord.salesman_code=x_sSalesman_code;
            _oProfileTeamRecord.staff_no=x_sStaff_no;
            _oProfileTeamRecord.ddate=x_dDdate;
            _oProfileTeamRecord.sdate=x_dSdate;
            return InsertWithOutLastID(x_oDB, _oProfileTeamRecord);
        }
        
        
        public bool Insert(ProfileTeamRecord x_oProfileTeamRecord)
        {
            return InsertWithOutLastID(n_oDB, x_oProfileTeamRecord);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is ProfileTeamRecord)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (ProfileTeamRecord)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,ProfileTeamRecord x_oProfileTeamRecord)
        {
            return InsertWithOutLastID(x_oDB, x_oProfileTeamRecord);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProfileTeamRecord x_oProfileTeamRecord)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ProfileTeamRecord]   ([cdate],[cid],[did],[active],[remark],[edate],[salesman_code],[staff_no],[ddate],[sdate])  VALUES  (@cdate,@cid,@did,@active,@remark,@edate,@salesman_code,@staff_no,@ddate,@sdate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oProfileTeamRecord);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProfileTeamRecord x_oProfileTeamRecord)
        {
            bool _bResult = false;
            if (!x_oProfileTeamRecord.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oProfileTeamRecord.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.cdate; }
                if(x_oProfileTeamRecord.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oProfileTeamRecord.cid; }
                if(x_oProfileTeamRecord.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecord.did; }
                if(x_oProfileTeamRecord.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oProfileTeamRecord.active; }
                if(x_oProfileTeamRecord.remark==null){  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value=x_oProfileTeamRecord.remark; }
                if(x_oProfileTeamRecord.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.edate; }
                if(x_oProfileTeamRecord.salesman_code==null){  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value=x_oProfileTeamRecord.salesman_code; }
                if(x_oProfileTeamRecord.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecord.staff_no; }
                if(x_oProfileTeamRecord.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.ddate; }
                if(x_oProfileTeamRecord.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.sdate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bActive,string x_sRemark,global::System.Nullable<DateTime> x_dEdate,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            ProfileTeamRecord _oProfileTeamRecord=ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamRecord.cdate=x_dCdate;
            _oProfileTeamRecord.cid=x_sCid;
            _oProfileTeamRecord.did=x_sDid;
            _oProfileTeamRecord.active=x_bActive;
            _oProfileTeamRecord.remark=x_sRemark;
            _oProfileTeamRecord.edate=x_dEdate;
            _oProfileTeamRecord.salesman_code=x_sSalesman_code;
            _oProfileTeamRecord.staff_no=x_sStaff_no;
            _oProfileTeamRecord.ddate=x_dDdate;
            _oProfileTeamRecord.sdate=x_dSdate;
            if(InsertWithLastID(x_oDB, _oProfileTeamRecord,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(ProfileTeamRecord x_oProfileTeamRecord)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oProfileTeamRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, ProfileTeamRecord x_oProfileTeamRecord)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oProfileTeamRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProfileTeamRecord)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (ProfileTeamRecord)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,ProfileTeamRecord x_oProfileTeamRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ProfileTeamRecord]   ([cdate],[cid],[did],[active],[remark],[edate],[salesman_code],[staff_no],[ddate],[sdate])  VALUES  (@cdate,@cid,@did,@active,@remark,@edate,@salesman_code,@staff_no,@ddate,@sdate)"+" SELECT  @@IDENTITY AS ProfileTeamRecord_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oProfileTeamRecord,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProfileTeamRecord x_oProfileTeamRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oProfileTeamRecord.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oProfileTeamRecord.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.cdate; }
                if(x_oProfileTeamRecord.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oProfileTeamRecord.cid; }
                if(x_oProfileTeamRecord.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecord.did; }
                if(x_oProfileTeamRecord.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oProfileTeamRecord.active; }
                if(x_oProfileTeamRecord.remark==null){  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value=x_oProfileTeamRecord.remark; }
                if(x_oProfileTeamRecord.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.edate; }
                if(x_oProfileTeamRecord.salesman_code==null){  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value=x_oProfileTeamRecord.salesman_code; }
                if(x_oProfileTeamRecord.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProfileTeamRecord.staff_no; }
                if(x_oProfileTeamRecord.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.ddate; }
                if(x_oProfileTeamRecord.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oProfileTeamRecord.sdate; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["ProfileTeamRecord_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["ProfileTeamRecord_LASTID"].ToString()) && int.TryParse(_oData["ProfileTeamRecord_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bActive,string x_sRemark,global::System.Nullable<DateTime> x_dEdate,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            ProfileTeamRecord _oProfileTeamRecord=ProfileTeamRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamRecord.cdate=x_dCdate;
            _oProfileTeamRecord.cid=x_sCid;
            _oProfileTeamRecord.did=x_sDid;
            _oProfileTeamRecord.active=x_bActive;
            _oProfileTeamRecord.remark=x_sRemark;
            _oProfileTeamRecord.edate=x_dEdate;
            _oProfileTeamRecord.salesman_code=x_sSalesman_code;
            _oProfileTeamRecord.staff_no=x_sStaff_no;
            _oProfileTeamRecord.ddate=x_dDdate;
            _oProfileTeamRecord.sdate=x_dSdate;
            if(InsertWithLastID_SP(x_oDB, _oProfileTeamRecord,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(ProfileTeamRecord x_oProfileTeamRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oProfileTeamRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProfileTeamRecord x_oProfileTeamRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oProfileTeamRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProfileTeamRecord)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (ProfileTeamRecord)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,ProfileTeamRecord x_oProfileTeamRecord, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "PROFILETEAMRECORD";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oProfileTeamRecord,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProfileTeamRecord x_oProfileTeamRecord, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecord.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecord.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecord.did; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecord.active; }
                _oPar=x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecord.remark; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecord.edate; }
                _oPar=x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.salesman_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecord.salesman_code; }
                _oPar=x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProfileTeamRecord.staff_no; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecord.ddate; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProfileTeamRecord.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProfileTeamRecord.sdate; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
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
        
        #region INSERT_PROFILETEAMRECORD Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-01-11>
        ///-- Description:	<Description,PROFILETEAMRECORD, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_PROFILETEAMRECORD Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_PROFILETEAMRECORD', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_PROFILETEAMRECORD;
        GO
        CREATE PROCEDURE INSERT_PROFILETEAMRECORD
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(10),
        @did nvarchar(50),
        @active bit,
        @remark text,
        @edate datetime,
        @salesman_code nvarchar(4),
        @staff_no nvarchar(50),
        @ddate datetime,
        @sdate datetime
        AS
        
        INSERT INTO  [ProfileTeamRecord]   ([cdate],[cid],[did],[active],[remark],[edate],[salesman_code],[staff_no],[ddate],[sdate])  VALUES  (@cdate,@cid,@did,@active,@remark,@edate,@salesman_code,@staff_no,@ddate,@sdate)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ID=@@IDENTITY
        RETURN @RETURN_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ID=-1
        RETURN @RETURN_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamRecord]  WHERE [ProfileTeamRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return ProfileTeamRecordRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
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
            string _sQuery = "DELETE FROM [ProfileTeamRecord]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
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


