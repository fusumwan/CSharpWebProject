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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadProfile],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CallListUploadProfile] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"CallListUploadProfile")]
    public class CallListUploadProfileRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static CallListUploadProfileRepositoryBase instance;
        public static CallListUploadProfileRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new CallListUploadProfileRepositoryBase(_oDB);
            }
            return instance;
        }
        public static CallListUploadProfileRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new CallListUploadProfileRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<CallListUploadProfileEntity> CallListUploadProfiles;
        #endregion
        
        #region Constructor
        public CallListUploadProfileRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~CallListUploadProfileRepositoryBase() { 
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
        public static CallListUploadProfile CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new CallListUploadProfile(_oDB);
        }
        
        public static CallListUploadProfile CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new CallListUploadProfile(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [CallListUploadProfile]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
        
        
        public CallListUploadProfileEntity GetObj(global::System.Nullable<long> x_lId)
        {
            return GetObj(n_oDB, x_lId);
        }
        
        
        public static CallListUploadProfileEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            if (x_oDB==null) { return null; }
            CallListUploadProfile _CallListUploadProfile = (CallListUploadProfile)CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_CallListUploadProfile.Load(x_lId)) { return null; }
            return _CallListUploadProfile;
        }
        
        
        
        public static CallListUploadProfileEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<CallListUploadProfileEntity> _oCallListUploadProfileList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oCallListUploadProfileList==null){ return null;}
            return _oCallListUploadProfileList.Count == 0 ? null : _oCallListUploadProfileList.ToArray();
        }
        
        public static List<CallListUploadProfileEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static CallListUploadProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<CallListUploadProfileEntity> _oCallListUploadProfileList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oCallListUploadProfileList==null){ return null;}
            return _oCallListUploadProfileList.Count == 0 ? null : _oCallListUploadProfileList.ToArray();
        }
        
        
        public static CallListUploadProfileEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<CallListUploadProfileEntity> _oCallListUploadProfileList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oCallListUploadProfileList==null){ return null;}
            return _oCallListUploadProfileList.Count == 0 ? null : _oCallListUploadProfileList.ToArray();
        }
        
        public static List<CallListUploadProfileEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<CallListUploadProfileEntity> _oRow = new List<CallListUploadProfileEntity>();
            string _sQuery = "SELECT  "+_sTop+" [CallListUploadProfile].[sdate] AS CALLLISTUPLOADPROFILE_SDATE,[CallListUploadProfile].[active] AS CALLLISTUPLOADPROFILE_ACTIVE,[CallListUploadProfile].[issue_type] AS CALLLISTUPLOADPROFILE_ISSUE_TYPE,[CallListUploadProfile].[call_list_program_id] AS CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID,[CallListUploadProfile].[id] AS CALLLISTUPLOADPROFILE_ID,[CallListUploadProfile].[edate] AS CALLLISTUPLOADPROFILE_EDATE  FROM  [CallListUploadProfile]";
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
                _sQuery += " WHERE [CallListUploadProfile].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        CallListUploadProfile _oCallListUploadProfile = CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_SDATE"])) {_oCallListUploadProfile.sdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_SDATE"]; }else{_oCallListUploadProfile.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ID"])) {_oCallListUploadProfile.id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_ID"]; }else{_oCallListUploadProfile.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"])) {_oCallListUploadProfile.call_list_program_id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"]; }else{_oCallListUploadProfile.call_list_program_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"])) {_oCallListUploadProfile.issue_type = (string)_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"]; }else{_oCallListUploadProfile.issue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ACTIVE"])) {_oCallListUploadProfile.active = (global::System.Nullable<bool>)_oData["CALLLISTUPLOADPROFILE_ACTIVE"]; }else{_oCallListUploadProfile.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_EDATE"])) {_oCallListUploadProfile.edate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_EDATE"]; }else{_oCallListUploadProfile.edate=null;}
                        _oCallListUploadProfile.SetDB(x_oDB);
                        _oCallListUploadProfile.GetFound();
                        _oRow.Add(_oCallListUploadProfile);
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
        
        
        public static CallListUploadProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<CallListUploadProfileEntity> _oCallListUploadProfileList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oCallListUploadProfileList==null){ return null;}
            return _oCallListUploadProfileList.Count == 0 ? null : _oCallListUploadProfileList.ToArray();
        }
        
        
        public static CallListUploadProfileEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<CallListUploadProfileEntity> _oCallListUploadProfileList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oCallListUploadProfileList==null){ return null;}
            return _oCallListUploadProfileList.Count == 0 ? null : _oCallListUploadProfileList.ToArray();
        }
        
        public static List<CallListUploadProfileEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<CallListUploadProfileEntity> _oRow = new List<CallListUploadProfileEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[CallListUploadProfile].[sdate] AS CALLLISTUPLOADPROFILE_SDATE,[CallListUploadProfile].[active] AS CALLLISTUPLOADPROFILE_ACTIVE,[CallListUploadProfile].[issue_type] AS CALLLISTUPLOADPROFILE_ISSUE_TYPE,[CallListUploadProfile].[call_list_program_id] AS CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID,[CallListUploadProfile].[id] AS CALLLISTUPLOADPROFILE_ID,[CallListUploadProfile].[edate] AS CALLLISTUPLOADPROFILE_EDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = CallListUploadProfileRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                CallListUploadProfileEntity _oCallListUploadProfile = CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_SDATE"])) {_oCallListUploadProfile.sdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_SDATE"]; } else {_oCallListUploadProfile.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ID"])) {_oCallListUploadProfile.id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_ID"]; } else {_oCallListUploadProfile.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"])) {_oCallListUploadProfile.call_list_program_id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"]; } else {_oCallListUploadProfile.call_list_program_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"])) {_oCallListUploadProfile.issue_type = (string)_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"]; } else {_oCallListUploadProfile.issue_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ACTIVE"])) {_oCallListUploadProfile.active = (global::System.Nullable<bool>)_oData["CALLLISTUPLOADPROFILE_ACTIVE"]; } else {_oCallListUploadProfile.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_EDATE"])) {_oCallListUploadProfile.edate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_EDATE"]; } else {_oCallListUploadProfile.edate=null; }
                _oCallListUploadProfile.SetDB(x_oDB);
                _oCallListUploadProfile.GetFound();
                _oRow.Add(_oCallListUploadProfile);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( CallListUploadProfile.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,CallListUploadProfile.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(CallListUploadProfile.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(CallListUploadProfile.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [CallListUploadProfile].[sdate] AS CALLLISTUPLOADPROFILE_SDATE,[CallListUploadProfile].[active] AS CALLLISTUPLOADPROFILE_ACTIVE,[CallListUploadProfile].[issue_type] AS CALLLISTUPLOADPROFILE_ISSUE_TYPE,[CallListUploadProfile].[call_list_program_id] AS CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID,[CallListUploadProfile].[id] AS CALLLISTUPLOADPROFILE_ID,[CallListUploadProfile].[edate] AS CALLLISTUPLOADPROFILE_EDATE  FROM  [CallListUploadProfile]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"CallListUploadProfile");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dSdate,global::System.Nullable<long> x_lCall_list_program_id,string x_sIssue_type,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            CallListUploadProfile _oCallListUploadProfile=CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oCallListUploadProfile.sdate=x_dSdate;
            _oCallListUploadProfile.call_list_program_id=x_lCall_list_program_id;
            _oCallListUploadProfile.issue_type=x_sIssue_type;
            _oCallListUploadProfile.active=x_bActive;
            _oCallListUploadProfile.edate=x_dEdate;
            return InsertWithOutLastID(n_oDB, _oCallListUploadProfile);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dSdate,global::System.Nullable<long> x_lCall_list_program_id,string x_sIssue_type,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            CallListUploadProfile _oCallListUploadProfile=CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCallListUploadProfile.sdate=x_dSdate;
            _oCallListUploadProfile.call_list_program_id=x_lCall_list_program_id;
            _oCallListUploadProfile.issue_type=x_sIssue_type;
            _oCallListUploadProfile.active=x_bActive;
            _oCallListUploadProfile.edate=x_dEdate;
            return InsertWithOutLastID(x_oDB, _oCallListUploadProfile);
        }
        
        
        public bool Insert(CallListUploadProfile x_oCallListUploadProfile)
        {
            return InsertWithOutLastID(n_oDB, x_oCallListUploadProfile);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is CallListUploadProfile)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (CallListUploadProfile)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,CallListUploadProfile x_oCallListUploadProfile)
        {
            return InsertWithOutLastID(x_oDB, x_oCallListUploadProfile);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,CallListUploadProfile x_oCallListUploadProfile)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [CallListUploadProfile]   ([sdate],[active],[issue_type],[call_list_program_id],[edate])  VALUES  (@sdate,@active,@issue_type,@call_list_program_id,@edate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oCallListUploadProfile);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,CallListUploadProfile x_oCallListUploadProfile)
        {
            bool _bResult = false;
            if (!x_oCallListUploadProfile.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oCallListUploadProfile.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oCallListUploadProfile.sdate; }
                if(x_oCallListUploadProfile.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oCallListUploadProfile.active; }
                if(x_oCallListUploadProfile.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oCallListUploadProfile.issue_type; }
                if(x_oCallListUploadProfile.call_list_program_id==null){  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=x_oCallListUploadProfile.call_list_program_id; }
                if(x_oCallListUploadProfile.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oCallListUploadProfile.edate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dSdate,global::System.Nullable<long> x_lCall_list_program_id,string x_sIssue_type,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            int _oLastID;
            CallListUploadProfile _oCallListUploadProfile=CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCallListUploadProfile.sdate=x_dSdate;
            _oCallListUploadProfile.call_list_program_id=x_lCall_list_program_id;
            _oCallListUploadProfile.issue_type=x_sIssue_type;
            _oCallListUploadProfile.active=x_bActive;
            _oCallListUploadProfile.edate=x_dEdate;
            if(InsertWithLastID(x_oDB, _oCallListUploadProfile,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(CallListUploadProfile x_oCallListUploadProfile)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oCallListUploadProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, CallListUploadProfile x_oCallListUploadProfile)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oCallListUploadProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is CallListUploadProfile)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (CallListUploadProfile)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,CallListUploadProfile x_oCallListUploadProfile, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [CallListUploadProfile]   ([sdate],[active],[issue_type],[call_list_program_id],[edate])  VALUES  (@sdate,@active,@issue_type,@call_list_program_id,@edate)"+" SELECT  @@IDENTITY AS CallListUploadProfile_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oCallListUploadProfile,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,CallListUploadProfile x_oCallListUploadProfile, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oCallListUploadProfile.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oCallListUploadProfile.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oCallListUploadProfile.sdate; }
                if(x_oCallListUploadProfile.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oCallListUploadProfile.active; }
                if(x_oCallListUploadProfile.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oCallListUploadProfile.issue_type; }
                if(x_oCallListUploadProfile.call_list_program_id==null){  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=x_oCallListUploadProfile.call_list_program_id; }
                if(x_oCallListUploadProfile.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oCallListUploadProfile.edate; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["CallListUploadProfile_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["CallListUploadProfile_LASTID"].ToString()) && int.TryParse(_oData["CallListUploadProfile_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dSdate,global::System.Nullable<long> x_lCall_list_program_id,string x_sIssue_type,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            int _oLastID;
            CallListUploadProfile _oCallListUploadProfile=CallListUploadProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCallListUploadProfile.sdate=x_dSdate;
            _oCallListUploadProfile.call_list_program_id=x_lCall_list_program_id;
            _oCallListUploadProfile.issue_type=x_sIssue_type;
            _oCallListUploadProfile.active=x_bActive;
            _oCallListUploadProfile.edate=x_dEdate;
            if(InsertWithLastID_SP(x_oDB, _oCallListUploadProfile,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(CallListUploadProfile x_oCallListUploadProfile)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oCallListUploadProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, CallListUploadProfile x_oCallListUploadProfile)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oCallListUploadProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is CallListUploadProfile)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (CallListUploadProfile)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,CallListUploadProfile x_oCallListUploadProfile, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "CALLLISTUPLOADPROFILE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oCallListUploadProfile,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,CallListUploadProfile x_oCallListUploadProfile, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadProfile.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCallListUploadProfile.sdate; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadProfile.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCallListUploadProfile.active; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadProfile.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCallListUploadProfile.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadProfile.call_list_program_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCallListUploadProfile.call_list_program_id; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadProfile.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCallListUploadProfile.edate; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.BigInt);
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
        
        #region INSERT_CALLLISTUPLOADPROFILE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-09-15>
        ///-- Description:	<Description,CALLLISTUPLOADPROFILE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_CALLLISTUPLOADPROFILE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_CALLLISTUPLOADPROFILE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_CALLLISTUPLOADPROFILE;
        GO
        CREATE PROCEDURE INSERT_CALLLISTUPLOADPROFILE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID bigint output,
        @sdate datetime,
        @call_list_program_id bigint,
        @issue_type nvarchar(50),
        @active bit,
        @edate datetime
        AS
        
        INSERT INTO  [CallListUploadProfile]   ([sdate],[active],[issue_type],[call_list_program_id],[edate])  VALUES  (@sdate,@active,@issue_type,@call_list_program_id,@edate)
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
        
        public bool Delete(global::System.Nullable<long> x_lId)
        {
            return DeleteProc(n_oDB, x_lId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            return DeleteProc(x_oDB, x_lId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lId)
        {
            if (x_lId==null) { return false; }
            string _sQuery = "DELETE FROM  [CallListUploadProfile]  WHERE [CallListUploadProfile].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value = x_lId;
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
            return CallListUploadProfileRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [CallListUploadProfile]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
            string _sQuery = "DELETE FROM [CallListUploadProfile]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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


