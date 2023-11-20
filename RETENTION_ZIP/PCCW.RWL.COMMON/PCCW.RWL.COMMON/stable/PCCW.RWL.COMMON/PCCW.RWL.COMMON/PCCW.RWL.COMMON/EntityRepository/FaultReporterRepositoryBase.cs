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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[FaultReporter],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [FaultReporter] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"FaultReporter")]
    public class FaultReporterRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static FaultReporterRepositoryBase instance;
        public static FaultReporterRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new FaultReporterRepositoryBase(_oDB);
            }
            return instance;
        }
        public static FaultReporterRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new FaultReporterRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<FaultReporterEntity> FaultReporters;
        #endregion
        
        #region Constructor
        public FaultReporterRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~FaultReporterRepositoryBase() { 
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
        public static FaultReporter CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new FaultReporter(_oDB);
        }
        
        public static FaultReporter CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new FaultReporter(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [FaultReporter]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
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
        
        
        public FaultReporterEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static FaultReporterEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            FaultReporter _FaultReporter = (FaultReporter)FaultReporterRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_FaultReporter.Load(x_iId)) { return null; }
            return _FaultReporter;
        }
        
        
        
        public static FaultReporterEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<FaultReporterEntity> _oFaultReporterList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oFaultReporterList.Count == 0 ? null : _oFaultReporterList.ToArray();
        }
        
        public static List<FaultReporterEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static FaultReporterEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<FaultReporterEntity> _oFaultReporterList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oFaultReporterList.Count == 0 ? null : _oFaultReporterList.ToArray();
        }
        
        
        public static FaultReporterEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<FaultReporterEntity> _oFaultReporterList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oFaultReporterList.Count == 0 ? null : _oFaultReporterList.ToArray();
        }
        
        public static List<FaultReporterEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<FaultReporterEntity> _oRow = new List<FaultReporterEntity>();
            string _sQuery = "SELECT  "+_sTop+" [FaultReporter].[active] AS FAULTREPORTER_ACTIVE,[FaultReporter].[name] AS FAULTREPORTER_NAME,[FaultReporter].[cdate] AS FAULTREPORTER_CDATE,[FaultReporter].[cid] AS FAULTREPORTER_CID,[FaultReporter].[email] AS FAULTREPORTER_EMAIL,[FaultReporter].[id] AS FAULTREPORTER_ID,[FaultReporter].[edate] AS FAULTREPORTER_EDATE  FROM  [FaultReporter]";
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
                _sQuery += " WHERE [FaultReporter].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        FaultReporter _oFaultReporter = FaultReporterRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ID"])) {_oFaultReporter.id = (global::System.Nullable<int>)_oData["FAULTREPORTER_ID"]; }else{_oFaultReporter.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_NAME"])) {_oFaultReporter.name = (string)_oData["FAULTREPORTER_NAME"]; }else{_oFaultReporter.name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CDATE"])) {_oFaultReporter.cdate = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_CDATE"]; }else{_oFaultReporter.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CID"])) {_oFaultReporter.cid = (string)_oData["FAULTREPORTER_CID"]; }else{_oFaultReporter.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EMAIL"])) {_oFaultReporter.email = (string)_oData["FAULTREPORTER_EMAIL"]; }else{_oFaultReporter.email=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ACTIVE"])) {_oFaultReporter.active = (global::System.Nullable<bool>)_oData["FAULTREPORTER_ACTIVE"]; }else{_oFaultReporter.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EDATE"])) {_oFaultReporter.edate = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_EDATE"]; }else{_oFaultReporter.edate=null;}
                        _oFaultReporter.SetDB(x_oDB);
                        _oFaultReporter.GetFound();
                        _oRow.Add(_oFaultReporter);
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
        
        
        public static FaultReporterEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<FaultReporterEntity> _oFaultReporterList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oFaultReporterList.Count == 0 ? null : _oFaultReporterList.ToArray();
        }
        
        
        public static FaultReporterEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<FaultReporterEntity> _oFaultReporterList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oFaultReporterList.Count == 0 ? null : _oFaultReporterList.ToArray();
        }
        
        public static List<FaultReporterEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<FaultReporterEntity> _oRow = new List<FaultReporterEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[FaultReporter].[active] AS FAULTREPORTER_ACTIVE,[FaultReporter].[name] AS FAULTREPORTER_NAME,[FaultReporter].[cdate] AS FAULTREPORTER_CDATE,[FaultReporter].[cid] AS FAULTREPORTER_CID,[FaultReporter].[email] AS FAULTREPORTER_EMAIL,[FaultReporter].[id] AS FAULTREPORTER_ID,[FaultReporter].[edate] AS FAULTREPORTER_EDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = FaultReporterRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                FaultReporterEntity _oFaultReporter = FaultReporterRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ID"])) {_oFaultReporter.id = (global::System.Nullable<int>)_oData["FAULTREPORTER_ID"]; } else {_oFaultReporter.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_NAME"])) {_oFaultReporter.name = (string)_oData["FAULTREPORTER_NAME"]; } else {_oFaultReporter.name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CDATE"])) {_oFaultReporter.cdate = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_CDATE"]; } else {_oFaultReporter.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CID"])) {_oFaultReporter.cid = (string)_oData["FAULTREPORTER_CID"]; } else {_oFaultReporter.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EMAIL"])) {_oFaultReporter.email = (string)_oData["FAULTREPORTER_EMAIL"]; } else {_oFaultReporter.email=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ACTIVE"])) {_oFaultReporter.active = (global::System.Nullable<bool>)_oData["FAULTREPORTER_ACTIVE"]; } else {_oFaultReporter.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EDATE"])) {_oFaultReporter.edate = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_EDATE"]; } else {_oFaultReporter.edate=null; }
                _oFaultReporter.SetDB(x_oDB);
                _oFaultReporter.GetFound();
                _oRow.Add(_oFaultReporter);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( FaultReporter.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,FaultReporter.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(FaultReporter.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(FaultReporter.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [FaultReporter].[active] AS FAULTREPORTER_ACTIVE,[FaultReporter].[name] AS FAULTREPORTER_NAME,[FaultReporter].[cdate] AS FAULTREPORTER_CDATE,[FaultReporter].[cid] AS FAULTREPORTER_CID,[FaultReporter].[email] AS FAULTREPORTER_EMAIL,[FaultReporter].[id] AS FAULTREPORTER_ID,[FaultReporter].[edate] AS FAULTREPORTER_EDATE  FROM  [FaultReporter]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"FaultReporter");
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
        
        public bool Insert(global::System.Nullable<int> x_iId,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sEmail,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            FaultReporter _oFaultReporter=FaultReporterRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oFaultReporter.id=x_iId;
            _oFaultReporter.name=x_sName;
            _oFaultReporter.cdate=x_dCdate;
            _oFaultReporter.cid=x_sCid;
            _oFaultReporter.email=x_sEmail;
            _oFaultReporter.active=x_bActive;
            _oFaultReporter.edate=x_dEdate;
            return InsertWithOutLastID(n_oDB, _oFaultReporter);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sEmail,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            FaultReporter _oFaultReporter=FaultReporterRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oFaultReporter.id=x_iId;
            _oFaultReporter.name=x_sName;
            _oFaultReporter.cdate=x_dCdate;
            _oFaultReporter.cid=x_sCid;
            _oFaultReporter.email=x_sEmail;
            _oFaultReporter.active=x_bActive;
            _oFaultReporter.edate=x_dEdate;
            return InsertWithOutLastID(x_oDB, _oFaultReporter);
        }
        
        
        public bool Insert(FaultReporter x_oFaultReporter)
        {
            return InsertWithOutLastID(n_oDB, x_oFaultReporter);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is FaultReporter)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (FaultReporter)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,FaultReporter x_oFaultReporter)
        {
            return InsertWithOutLastID(x_oDB, x_oFaultReporter);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,FaultReporter x_oFaultReporter)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [FaultReporter]   ([active],[name],[cdate],[cid],[email],[id],[edate])  VALUES  (@active,@name,@cdate,@cid,@email,@id,@edate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oFaultReporter);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,FaultReporter x_oFaultReporter)
        {
            bool _bResult = false;
            if (!x_oFaultReporter.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oFaultReporter.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oFaultReporter.active; }
                if(x_oFaultReporter.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oFaultReporter.name; }
                if(x_oFaultReporter.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oFaultReporter.cdate; }
                if(x_oFaultReporter.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oFaultReporter.cid; }
                if(x_oFaultReporter.email==null){  x_oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250).Value=x_oFaultReporter.email; }
                if(x_oFaultReporter.id==null){  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=x_oFaultReporter.id; }
                if(x_oFaultReporter.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oFaultReporter.edate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sEmail,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            int _oLastID;
            FaultReporter _oFaultReporter=FaultReporterRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oFaultReporter.id=x_iId;
            _oFaultReporter.name=x_sName;
            _oFaultReporter.cdate=x_dCdate;
            _oFaultReporter.cid=x_sCid;
            _oFaultReporter.email=x_sEmail;
            _oFaultReporter.active=x_bActive;
            _oFaultReporter.edate=x_dEdate;
            if(InsertWithLastID(x_oDB, _oFaultReporter,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(FaultReporter x_oFaultReporter)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oFaultReporter, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, FaultReporter x_oFaultReporter)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oFaultReporter, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is FaultReporter)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (FaultReporter)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,FaultReporter x_oFaultReporter, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [FaultReporter]   ([active],[name],[cdate],[cid],[email],[id],[edate])  VALUES  (@active,@name,@cdate,@cid,@email,@id,@edate)"+" SELECT  @@IDENTITY AS FaultReporter_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oFaultReporter,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,FaultReporter x_oFaultReporter, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oFaultReporter.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oFaultReporter.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oFaultReporter.active; }
                if(x_oFaultReporter.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oFaultReporter.name; }
                if(x_oFaultReporter.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oFaultReporter.cdate; }
                if(x_oFaultReporter.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oFaultReporter.cid; }
                if(x_oFaultReporter.email==null){  x_oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250).Value=x_oFaultReporter.email; }
                if(x_oFaultReporter.id==null){  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=x_oFaultReporter.id; }
                if(x_oFaultReporter.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oFaultReporter.edate; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["FaultReporter_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["FaultReporter_LASTID"].ToString()) && int.TryParse(_oData["FaultReporter_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sEmail,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            int _oLastID;
            FaultReporter _oFaultReporter=FaultReporterRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oFaultReporter.name=x_sName;
            _oFaultReporter.cdate=x_dCdate;
            _oFaultReporter.cid=x_sCid;
            _oFaultReporter.email=x_sEmail;
            _oFaultReporter.active=x_bActive;
            _oFaultReporter.edate=x_dEdate;
            if(InsertWithLastID_SP(x_oDB, _oFaultReporter,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(FaultReporter x_oFaultReporter)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oFaultReporter, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, FaultReporter x_oFaultReporter)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oFaultReporter, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is FaultReporter)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (FaultReporter)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,FaultReporter x_oFaultReporter, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "FAULTREPORTER";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oFaultReporter,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,FaultReporter x_oFaultReporter, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oFaultReporter.active; }
                _oPar=x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oFaultReporter.name; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oFaultReporter.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oFaultReporter.cid; }
                _oPar=x_oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.email==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oFaultReporter.email; }
                _oPar=x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oFaultReporter.id; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oFaultReporter.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oFaultReporter.edate; }
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
        
        #region INSERT_FAULTREPORTER Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-07-29>
        ///-- Description:	<Description,FAULTREPORTER, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_FAULTREPORTER Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_FAULTREPORTER', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_FAULTREPORTER;
        GO
        CREATE PROCEDURE INSERT_FAULTREPORTER
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @id int,
        @name nvarchar(250),
        @cdate datetime,
        @cid nvarchar(50),
        @email nvarchar(250),
        @active bit,
        @edate datetime
        AS
        
        INSERT INTO  [FaultReporter]   ([active],[name],[cdate],[cid],[email],[id],[edate])  VALUES  (@active,@name,@cdate,@cid,@email,@id,@edate)
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
            string _sQuery = "DELETE FROM  [FaultReporter]  WHERE [FaultReporter].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return FaultReporterRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [FaultReporter]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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
            string _sQuery = "DELETE FROM [FaultReporter]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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


