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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferType],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [HandSetOfferType] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"HandSetOfferType")]
    public class HandSetOfferTypeRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static HandSetOfferTypeRepositoryBase instance;
        public static HandSetOfferTypeRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new HandSetOfferTypeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static HandSetOfferTypeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new HandSetOfferTypeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<HandSetOfferTypeEntity> HandSetOfferTypes;
        #endregion
        
        #region Constructor
        public HandSetOfferTypeRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~HandSetOfferTypeRepositoryBase() { 
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
        public static HandSetOfferType CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new HandSetOfferType(_oDB);
        }
        
        public static HandSetOfferType CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new HandSetOfferType(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [HandSetOfferType]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
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
        
        
        public HandSetOfferTypeEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static HandSetOfferTypeEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            HandSetOfferType _HandSetOfferType = (HandSetOfferType)HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_HandSetOfferType.Load(x_iId)) { return null; }
            return _HandSetOfferType;
        }
        
        
        
        public static HandSetOfferTypeEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<HandSetOfferTypeEntity> _oHandSetOfferTypeList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oHandSetOfferTypeList==null){ return null;}
            return _oHandSetOfferTypeList.Count == 0 ? null : _oHandSetOfferTypeList.ToArray();
        }
        
        public static List<HandSetOfferTypeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static HandSetOfferTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<HandSetOfferTypeEntity> _oHandSetOfferTypeList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oHandSetOfferTypeList==null){ return null;}
            return _oHandSetOfferTypeList.Count == 0 ? null : _oHandSetOfferTypeList.ToArray();
        }
        
        
        public static HandSetOfferTypeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<HandSetOfferTypeEntity> _oHandSetOfferTypeList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oHandSetOfferTypeList==null){ return null;}
            return _oHandSetOfferTypeList.Count == 0 ? null : _oHandSetOfferTypeList.ToArray();
        }
        
        public static List<HandSetOfferTypeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<HandSetOfferTypeEntity> _oRow = new List<HandSetOfferTypeEntity>();
            string _sQuery = "SELECT  "+_sTop+" [HandSetOfferType].[id] AS HANDSETOFFERTYPE_ID,[HandSetOfferType].[cdate] AS HANDSETOFFERTYPE_CDATE,[HandSetOfferType].[cid] AS HANDSETOFFERTYPE_CID,[HandSetOfferType].[did] AS HANDSETOFFERTYPE_DID,[HandSetOfferType].[expiry_chk] AS HANDSETOFFERTYPE_EXPIRY_CHK,[HandSetOfferType].[active] AS HANDSETOFFERTYPE_ACTIVE,[HandSetOfferType].[name] AS HANDSETOFFERTYPE_NAME,[HandSetOfferType].[edate] AS HANDSETOFFERTYPE_EDATE,[HandSetOfferType].[ddate] AS HANDSETOFFERTYPE_DDATE,[HandSetOfferType].[sdate] AS HANDSETOFFERTYPE_SDATE  FROM  [HandSetOfferType]";
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
                _sQuery += " WHERE [HandSetOfferType].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        HandSetOfferType _oHandSetOfferType = HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_ID"])) {_oHandSetOfferType.id = (global::System.Nullable<int>)_oData["HANDSETOFFERTYPE_ID"]; }else{_oHandSetOfferType.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_CDATE"])) {_oHandSetOfferType.cdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_CDATE"]; }else{_oHandSetOfferType.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_CID"])) {_oHandSetOfferType.cid = (string)_oData["HANDSETOFFERTYPE_CID"]; }else{_oHandSetOfferType.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_DID"])) {_oHandSetOfferType.did = (string)_oData["HANDSETOFFERTYPE_DID"]; }else{_oHandSetOfferType.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_EXPIRY_CHK"])) {_oHandSetOfferType.expiry_chk = (global::System.Nullable<bool>)_oData["HANDSETOFFERTYPE_EXPIRY_CHK"]; }else{_oHandSetOfferType.expiry_chk=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_ACTIVE"])) {_oHandSetOfferType.active = (global::System.Nullable<bool>)_oData["HANDSETOFFERTYPE_ACTIVE"]; }else{_oHandSetOfferType.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_NAME"])) {_oHandSetOfferType.name = (string)_oData["HANDSETOFFERTYPE_NAME"]; }else{_oHandSetOfferType.name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_EDATE"])) {_oHandSetOfferType.edate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_EDATE"]; }else{_oHandSetOfferType.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_DDATE"])) {_oHandSetOfferType.ddate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_DDATE"]; }else{_oHandSetOfferType.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_SDATE"])) {_oHandSetOfferType.sdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_SDATE"]; }else{_oHandSetOfferType.sdate=null;}
                        _oHandSetOfferType.SetDB(x_oDB);
                        _oHandSetOfferType.GetFound();
                        _oRow.Add(_oHandSetOfferType);
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
        
        
        public static HandSetOfferTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<HandSetOfferTypeEntity> _oHandSetOfferTypeList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oHandSetOfferTypeList==null){ return null;}
            return _oHandSetOfferTypeList.Count == 0 ? null : _oHandSetOfferTypeList.ToArray();
        }
        
        
        public static HandSetOfferTypeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<HandSetOfferTypeEntity> _oHandSetOfferTypeList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oHandSetOfferTypeList==null){ return null;}
            return _oHandSetOfferTypeList.Count == 0 ? null : _oHandSetOfferTypeList.ToArray();
        }
        
        public static List<HandSetOfferTypeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<HandSetOfferTypeEntity> _oRow = new List<HandSetOfferTypeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[HandSetOfferType].[id] AS HANDSETOFFERTYPE_ID,[HandSetOfferType].[cdate] AS HANDSETOFFERTYPE_CDATE,[HandSetOfferType].[cid] AS HANDSETOFFERTYPE_CID,[HandSetOfferType].[did] AS HANDSETOFFERTYPE_DID,[HandSetOfferType].[expiry_chk] AS HANDSETOFFERTYPE_EXPIRY_CHK,[HandSetOfferType].[active] AS HANDSETOFFERTYPE_ACTIVE,[HandSetOfferType].[name] AS HANDSETOFFERTYPE_NAME,[HandSetOfferType].[edate] AS HANDSETOFFERTYPE_EDATE,[HandSetOfferType].[ddate] AS HANDSETOFFERTYPE_DDATE,[HandSetOfferType].[sdate] AS HANDSETOFFERTYPE_SDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = HandSetOfferTypeRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                HandSetOfferTypeEntity _oHandSetOfferType = HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_ID"])) {_oHandSetOfferType.id = (global::System.Nullable<int>)_oData["HANDSETOFFERTYPE_ID"]; } else {_oHandSetOfferType.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_CDATE"])) {_oHandSetOfferType.cdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_CDATE"]; } else {_oHandSetOfferType.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_CID"])) {_oHandSetOfferType.cid = (string)_oData["HANDSETOFFERTYPE_CID"]; } else {_oHandSetOfferType.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_DID"])) {_oHandSetOfferType.did = (string)_oData["HANDSETOFFERTYPE_DID"]; } else {_oHandSetOfferType.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_EXPIRY_CHK"])) {_oHandSetOfferType.expiry_chk = (global::System.Nullable<bool>)_oData["HANDSETOFFERTYPE_EXPIRY_CHK"]; } else {_oHandSetOfferType.expiry_chk=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_ACTIVE"])) {_oHandSetOfferType.active = (global::System.Nullable<bool>)_oData["HANDSETOFFERTYPE_ACTIVE"]; } else {_oHandSetOfferType.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_NAME"])) {_oHandSetOfferType.name = (string)_oData["HANDSETOFFERTYPE_NAME"]; } else {_oHandSetOfferType.name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_EDATE"])) {_oHandSetOfferType.edate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_EDATE"]; } else {_oHandSetOfferType.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_DDATE"])) {_oHandSetOfferType.ddate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_DDATE"]; } else {_oHandSetOfferType.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_SDATE"])) {_oHandSetOfferType.sdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_SDATE"]; } else {_oHandSetOfferType.sdate=null; }
                _oHandSetOfferType.SetDB(x_oDB);
                _oHandSetOfferType.GetFound();
                _oRow.Add(_oHandSetOfferType);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( HandSetOfferType.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,HandSetOfferType.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(HandSetOfferType.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(HandSetOfferType.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [HandSetOfferType].[id] AS HANDSETOFFERTYPE_ID,[HandSetOfferType].[cdate] AS HANDSETOFFERTYPE_CDATE,[HandSetOfferType].[cid] AS HANDSETOFFERTYPE_CID,[HandSetOfferType].[did] AS HANDSETOFFERTYPE_DID,[HandSetOfferType].[expiry_chk] AS HANDSETOFFERTYPE_EXPIRY_CHK,[HandSetOfferType].[active] AS HANDSETOFFERTYPE_ACTIVE,[HandSetOfferType].[name] AS HANDSETOFFERTYPE_NAME,[HandSetOfferType].[edate] AS HANDSETOFFERTYPE_EDATE,[HandSetOfferType].[ddate] AS HANDSETOFFERTYPE_DDATE,[HandSetOfferType].[sdate] AS HANDSETOFFERTYPE_SDATE  FROM  [HandSetOfferType]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"HandSetOfferType");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bExpiry_chk,global::System.Nullable<bool> x_bActive,string x_sName,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            HandSetOfferType _oHandSetOfferType=HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oHandSetOfferType.cdate=x_dCdate;
            _oHandSetOfferType.cid=x_sCid;
            _oHandSetOfferType.did=x_sDid;
            _oHandSetOfferType.expiry_chk=x_bExpiry_chk;
            _oHandSetOfferType.active=x_bActive;
            _oHandSetOfferType.name=x_sName;
            _oHandSetOfferType.edate=x_dEdate;
            _oHandSetOfferType.ddate=x_dDdate;
            _oHandSetOfferType.sdate=x_dSdate;
            return InsertWithOutLastID(n_oDB, _oHandSetOfferType);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bExpiry_chk,global::System.Nullable<bool> x_bActive,string x_sName,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            HandSetOfferType _oHandSetOfferType=HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferType.cdate=x_dCdate;
            _oHandSetOfferType.cid=x_sCid;
            _oHandSetOfferType.did=x_sDid;
            _oHandSetOfferType.expiry_chk=x_bExpiry_chk;
            _oHandSetOfferType.active=x_bActive;
            _oHandSetOfferType.name=x_sName;
            _oHandSetOfferType.edate=x_dEdate;
            _oHandSetOfferType.ddate=x_dDdate;
            _oHandSetOfferType.sdate=x_dSdate;
            return InsertWithOutLastID(x_oDB, _oHandSetOfferType);
        }
        
        
        public bool Insert(HandSetOfferType x_oHandSetOfferType)
        {
            return InsertWithOutLastID(n_oDB, x_oHandSetOfferType);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is HandSetOfferType)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (HandSetOfferType)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,HandSetOfferType x_oHandSetOfferType)
        {
            return InsertWithOutLastID(x_oDB, x_oHandSetOfferType);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,HandSetOfferType x_oHandSetOfferType)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [HandSetOfferType]   ([cdate],[cid],[did],[expiry_chk],[active],[name],[edate],[ddate],[sdate])  VALUES  (@cdate,@cid,@did,@expiry_chk,@active,@name,@edate,@ddate,@sdate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oHandSetOfferType);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferType x_oHandSetOfferType)
        {
            bool _bResult = false;
            if (!x_oHandSetOfferType.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oHandSetOfferType.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.cdate; }
                if(x_oHandSetOfferType.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferType.cid; }
                if(x_oHandSetOfferType.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferType.did; }
                if(x_oHandSetOfferType.expiry_chk==null){  x_oCmd.Parameters.Add("@expiry_chk", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@expiry_chk", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferType.expiry_chk; }
                if(x_oHandSetOfferType.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferType.active; }
                if(x_oHandSetOfferType.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oHandSetOfferType.name; }
                if(x_oHandSetOfferType.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.edate; }
                if(x_oHandSetOfferType.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.ddate; }
                if(x_oHandSetOfferType.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.sdate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bExpiry_chk,global::System.Nullable<bool> x_bActive,string x_sName,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            HandSetOfferType _oHandSetOfferType=HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferType.cdate=x_dCdate;
            _oHandSetOfferType.cid=x_sCid;
            _oHandSetOfferType.did=x_sDid;
            _oHandSetOfferType.expiry_chk=x_bExpiry_chk;
            _oHandSetOfferType.active=x_bActive;
            _oHandSetOfferType.name=x_sName;
            _oHandSetOfferType.edate=x_dEdate;
            _oHandSetOfferType.ddate=x_dDdate;
            _oHandSetOfferType.sdate=x_dSdate;
            if(InsertWithLastID(x_oDB, _oHandSetOfferType,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(HandSetOfferType x_oHandSetOfferType)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oHandSetOfferType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, HandSetOfferType x_oHandSetOfferType)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oHandSetOfferType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is HandSetOfferType)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (HandSetOfferType)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,HandSetOfferType x_oHandSetOfferType, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [HandSetOfferType]   ([cdate],[cid],[did],[expiry_chk],[active],[name],[edate],[ddate],[sdate])  VALUES  (@cdate,@cid,@did,@expiry_chk,@active,@name,@edate,@ddate,@sdate)"+" SELECT  @@IDENTITY AS HandSetOfferType_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oHandSetOfferType,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferType x_oHandSetOfferType, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oHandSetOfferType.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oHandSetOfferType.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.cdate; }
                if(x_oHandSetOfferType.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferType.cid; }
                if(x_oHandSetOfferType.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferType.did; }
                if(x_oHandSetOfferType.expiry_chk==null){  x_oCmd.Parameters.Add("@expiry_chk", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@expiry_chk", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferType.expiry_chk; }
                if(x_oHandSetOfferType.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferType.active; }
                if(x_oHandSetOfferType.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oHandSetOfferType.name; }
                if(x_oHandSetOfferType.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.edate; }
                if(x_oHandSetOfferType.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.ddate; }
                if(x_oHandSetOfferType.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferType.sdate; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["HandSetOfferType_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["HandSetOfferType_LASTID"].ToString()) && int.TryParse(_oData["HandSetOfferType_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bExpiry_chk,global::System.Nullable<bool> x_bActive,string x_sName,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            HandSetOfferType _oHandSetOfferType=HandSetOfferTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferType.cdate=x_dCdate;
            _oHandSetOfferType.cid=x_sCid;
            _oHandSetOfferType.did=x_sDid;
            _oHandSetOfferType.expiry_chk=x_bExpiry_chk;
            _oHandSetOfferType.active=x_bActive;
            _oHandSetOfferType.name=x_sName;
            _oHandSetOfferType.edate=x_dEdate;
            _oHandSetOfferType.ddate=x_dDdate;
            _oHandSetOfferType.sdate=x_dSdate;
            if(InsertWithLastID_SP(x_oDB, _oHandSetOfferType,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(HandSetOfferType x_oHandSetOfferType)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oHandSetOfferType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, HandSetOfferType x_oHandSetOfferType)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oHandSetOfferType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is HandSetOfferType)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (HandSetOfferType)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,HandSetOfferType x_oHandSetOfferType, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "HANDSETOFFERTYPE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oHandSetOfferType,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferType x_oHandSetOfferType, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferType.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferType.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferType.did; }
                _oPar=x_oCmd.Parameters.Add("@expiry_chk", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.expiry_chk==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferType.expiry_chk; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferType.active; }
                _oPar=x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferType.name; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferType.edate; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferType.ddate; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferType.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferType.sdate; }
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
        
        #region INSERT_HANDSETOFFERTYPE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-07-13>
        ///-- Description:	<Description,HANDSETOFFERTYPE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_HANDSETOFFERTYPE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_HANDSETOFFERTYPE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_HANDSETOFFERTYPE;
        GO
        CREATE PROCEDURE INSERT_HANDSETOFFERTYPE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @did nvarchar(50),
        @expiry_chk bit,
        @active bit,
        @name nvarchar(250),
        @edate datetime,
        @ddate datetime,
        @sdate datetime
        AS
        
        INSERT INTO  [HandSetOfferType]   ([cdate],[cid],[did],[expiry_chk],[active],[name],[edate],[ddate],[sdate])  VALUES  (@cdate,@cid,@did,@expiry_chk,@active,@name,@edate,@ddate,@sdate)
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
            string _sQuery = "DELETE FROM  [HandSetOfferType]  WHERE [HandSetOfferType].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
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
            return HandSetOfferTypeRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [HandSetOfferType]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
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
            string _sQuery = "DELETE FROM [HandSetOfferType]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
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


