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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportType],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportType] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportType")]
    public class MobileOrderReportTypeRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportTypeRepositoryBase instance;
        public static MobileOrderReportTypeRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportTypeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportTypeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportTypeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportTypeEntity> MobileOrderReportTypes;
        #endregion
        
        #region Constructor
        public MobileOrderReportTypeRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportTypeRepositoryBase() { 
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
        public static MobileOrderReportType CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportType(_oDB);
        }
        
        public static MobileOrderReportType CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportType(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportType]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
        
        
        public MobileOrderReportTypeEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static MobileOrderReportTypeEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportType _MobileOrderReportType = (MobileOrderReportType)MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportType.Load(x_iMid)) { return null; }
            return _MobileOrderReportType;
        }
        
        
        
        public static MobileOrderReportTypeEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportTypeEntity> _oMobileOrderReportTypeList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderReportTypeList==null){ return null;}
            return _oMobileOrderReportTypeList.Count == 0 ? null : _oMobileOrderReportTypeList.ToArray();
        }
        
        public static List<MobileOrderReportTypeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportTypeEntity> _oMobileOrderReportTypeList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportTypeList==null){ return null;}
            return _oMobileOrderReportTypeList.Count == 0 ? null : _oMobileOrderReportTypeList.ToArray();
        }
        
        
        public static MobileOrderReportTypeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportTypeEntity> _oMobileOrderReportTypeList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportTypeList==null){ return null;}
            return _oMobileOrderReportTypeList.Count == 0 ? null : _oMobileOrderReportTypeList.ToArray();
        }
        
        public static List<MobileOrderReportTypeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportTypeEntity> _oRow = new List<MobileOrderReportTypeEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportType].[active] AS MOBILEORDERREPORTTYPE_ACTIVE,[MobileOrderReportType].[cdate] AS MOBILEORDERREPORTTYPE_CDATE,[MobileOrderReportType].[cid] AS MOBILEORDERREPORTTYPE_CID,[MobileOrderReportType].[did] AS MOBILEORDERREPORTTYPE_DID,[MobileOrderReportType].[report_name] AS MOBILEORDERREPORTTYPE_REPORT_NAME,[MobileOrderReportType].[id] AS MOBILEORDERREPORTTYPE_ID,[MobileOrderReportType].[ddate] AS MOBILEORDERREPORTTYPE_DDATE,[MobileOrderReportType].[mid] AS MOBILEORDERREPORTTYPE_MID,[MobileOrderReportType].[report_type] AS MOBILEORDERREPORTTYPE_REPORT_TYPE  FROM  [MobileOrderReportType]";
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
                _sQuery += " WHERE [MobileOrderReportType].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportType _oMobileOrderReportType = MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ACTIVE"])) {_oMobileOrderReportType.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTTYPE_ACTIVE"]; }else{_oMobileOrderReportType.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CDATE"])) {_oMobileOrderReportType.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_CDATE"]; }else{_oMobileOrderReportType.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CID"])) {_oMobileOrderReportType.cid = (string)_oData["MOBILEORDERREPORTTYPE_CID"]; }else{_oMobileOrderReportType.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DID"])) {_oMobileOrderReportType.did = (string)_oData["MOBILEORDERREPORTTYPE_DID"]; }else{_oMobileOrderReportType.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"])) {_oMobileOrderReportType.report_name = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"]; }else{_oMobileOrderReportType.report_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ID"])) {_oMobileOrderReportType.id = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTTYPE_ID"]; }else{_oMobileOrderReportType.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DDATE"])) {_oMobileOrderReportType.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_DDATE"]; }else{_oMobileOrderReportType.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_MID"])) {_oMobileOrderReportType.mid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTTYPE_MID"]; }else{_oMobileOrderReportType.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"])) {_oMobileOrderReportType.report_type = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"]; }else{_oMobileOrderReportType.report_type=global::System.String.Empty;}
                        _oMobileOrderReportType.SetDB(x_oDB);
                        _oMobileOrderReportType.GetFound();
                        _oRow.Add(_oMobileOrderReportType);
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
        
        
        public static MobileOrderReportTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportTypeEntity> _oMobileOrderReportTypeList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportTypeList==null){ return null;}
            return _oMobileOrderReportTypeList.Count == 0 ? null : _oMobileOrderReportTypeList.ToArray();
        }
        
        
        public static MobileOrderReportTypeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportTypeEntity> _oMobileOrderReportTypeList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportTypeList==null){ return null;}
            return _oMobileOrderReportTypeList.Count == 0 ? null : _oMobileOrderReportTypeList.ToArray();
        }
        
        public static List<MobileOrderReportTypeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportTypeEntity> _oRow = new List<MobileOrderReportTypeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportType].[active] AS MOBILEORDERREPORTTYPE_ACTIVE,[MobileOrderReportType].[cdate] AS MOBILEORDERREPORTTYPE_CDATE,[MobileOrderReportType].[cid] AS MOBILEORDERREPORTTYPE_CID,[MobileOrderReportType].[did] AS MOBILEORDERREPORTTYPE_DID,[MobileOrderReportType].[report_name] AS MOBILEORDERREPORTTYPE_REPORT_NAME,[MobileOrderReportType].[id] AS MOBILEORDERREPORTTYPE_ID,[MobileOrderReportType].[ddate] AS MOBILEORDERREPORTTYPE_DDATE,[MobileOrderReportType].[mid] AS MOBILEORDERREPORTTYPE_MID,[MobileOrderReportType].[report_type] AS MOBILEORDERREPORTTYPE_REPORT_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportTypeRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportTypeEntity _oMobileOrderReportType = MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ACTIVE"])) {_oMobileOrderReportType.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTTYPE_ACTIVE"]; } else {_oMobileOrderReportType.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CDATE"])) {_oMobileOrderReportType.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_CDATE"]; } else {_oMobileOrderReportType.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CID"])) {_oMobileOrderReportType.cid = (string)_oData["MOBILEORDERREPORTTYPE_CID"]; } else {_oMobileOrderReportType.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DID"])) {_oMobileOrderReportType.did = (string)_oData["MOBILEORDERREPORTTYPE_DID"]; } else {_oMobileOrderReportType.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"])) {_oMobileOrderReportType.report_name = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"]; } else {_oMobileOrderReportType.report_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ID"])) {_oMobileOrderReportType.id = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTTYPE_ID"]; } else {_oMobileOrderReportType.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DDATE"])) {_oMobileOrderReportType.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_DDATE"]; } else {_oMobileOrderReportType.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_MID"])) {_oMobileOrderReportType.mid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTTYPE_MID"]; } else {_oMobileOrderReportType.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"])) {_oMobileOrderReportType.report_type = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"]; } else {_oMobileOrderReportType.report_type=global::System.String.Empty; }
                _oMobileOrderReportType.SetDB(x_oDB);
                _oMobileOrderReportType.GetFound();
                _oRow.Add(_oMobileOrderReportType);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportType.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportType.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportType.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportType.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportType].[active] AS MOBILEORDERREPORTTYPE_ACTIVE,[MobileOrderReportType].[cdate] AS MOBILEORDERREPORTTYPE_CDATE,[MobileOrderReportType].[cid] AS MOBILEORDERREPORTTYPE_CID,[MobileOrderReportType].[did] AS MOBILEORDERREPORTTYPE_DID,[MobileOrderReportType].[report_name] AS MOBILEORDERREPORTTYPE_REPORT_NAME,[MobileOrderReportType].[id] AS MOBILEORDERREPORTTYPE_ID,[MobileOrderReportType].[ddate] AS MOBILEORDERREPORTTYPE_DDATE,[MobileOrderReportType].[mid] AS MOBILEORDERREPORTTYPE_MID,[MobileOrderReportType].[report_type] AS MOBILEORDERREPORTTYPE_REPORT_TYPE  FROM  [MobileOrderReportType]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportType");
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
        
        public bool Insert(global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sReport_name,global::System.Nullable<Guid> x_gId,global::System.Nullable<DateTime> x_dDdate,string x_sReport_type)
        {
            MobileOrderReportType _oMobileOrderReportType=MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportType.active=x_bActive;
            _oMobileOrderReportType.cdate=x_dCdate;
            _oMobileOrderReportType.cid=x_sCid;
            _oMobileOrderReportType.did=x_sDid;
            _oMobileOrderReportType.report_name=x_sReport_name;
            _oMobileOrderReportType.id=x_gId;
            _oMobileOrderReportType.ddate=x_dDdate;
            _oMobileOrderReportType.report_type=x_sReport_type;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportType);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sReport_name,global::System.Nullable<Guid> x_gId,global::System.Nullable<DateTime> x_dDdate,string x_sReport_type)
        {
            MobileOrderReportType _oMobileOrderReportType=MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportType.active=x_bActive;
            _oMobileOrderReportType.cdate=x_dCdate;
            _oMobileOrderReportType.cid=x_sCid;
            _oMobileOrderReportType.did=x_sDid;
            _oMobileOrderReportType.report_name=x_sReport_name;
            _oMobileOrderReportType.id=x_gId;
            _oMobileOrderReportType.ddate=x_dDdate;
            _oMobileOrderReportType.report_type=x_sReport_type;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportType);
        }
        
        
        public bool Insert(MobileOrderReportType x_oMobileOrderReportType)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportType);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportType)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportType)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportType x_oMobileOrderReportType)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportType);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportType x_oMobileOrderReportType)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportType]   ([active],[cdate],[cid],[did],[report_name],[id],[ddate],[report_type])  VALUES  (@active,@cdate,@cid,@did,@report_name,@id,@ddate,@report_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportType);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportType x_oMobileOrderReportType)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportType.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportType.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportType.active; }
                if(x_oMobileOrderReportType.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportType.cdate; }
                if(x_oMobileOrderReportType.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderReportType.cid; }
                if(x_oMobileOrderReportType.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderReportType.did; }
                if(x_oMobileOrderReportType.report_name==null){  x_oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportType.report_name; }
                if(x_oMobileOrderReportType.id==null){  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier).Value=x_oMobileOrderReportType.id; }
                if(x_oMobileOrderReportType.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportType.ddate; }
                if(x_oMobileOrderReportType.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportType.report_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sReport_name,global::System.Nullable<Guid> x_gId,global::System.Nullable<DateTime> x_dDdate,string x_sReport_type)
        {
            int _oLastID;
            MobileOrderReportType _oMobileOrderReportType=MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportType.active=x_bActive;
            _oMobileOrderReportType.cdate=x_dCdate;
            _oMobileOrderReportType.cid=x_sCid;
            _oMobileOrderReportType.did=x_sDid;
            _oMobileOrderReportType.report_name=x_sReport_name;
            _oMobileOrderReportType.id=x_gId;
            _oMobileOrderReportType.ddate=x_dDdate;
            _oMobileOrderReportType.report_type=x_sReport_type;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportType,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportType x_oMobileOrderReportType)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportType x_oMobileOrderReportType)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportType)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportType)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportType x_oMobileOrderReportType, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportType]   ([active],[cdate],[cid],[did],[report_name],[id],[ddate],[report_type])  VALUES  (@active,@cdate,@cid,@did,@report_name,@id,@ddate,@report_type)"+" SELECT  @@IDENTITY AS MobileOrderReportType_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportType,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportType x_oMobileOrderReportType, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportType.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportType.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportType.active; }
                if(x_oMobileOrderReportType.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportType.cdate; }
                if(x_oMobileOrderReportType.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderReportType.cid; }
                if(x_oMobileOrderReportType.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderReportType.did; }
                if(x_oMobileOrderReportType.report_name==null){  x_oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportType.report_name; }
                if(x_oMobileOrderReportType.id==null){  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier).Value=x_oMobileOrderReportType.id; }
                if(x_oMobileOrderReportType.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportType.ddate; }
                if(x_oMobileOrderReportType.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportType.report_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportType_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportType_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportType_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sReport_name,global::System.Nullable<Guid> x_gId,global::System.Nullable<DateTime> x_dDdate,string x_sReport_type)
        {
            int _oLastID;
            MobileOrderReportType _oMobileOrderReportType=MobileOrderReportTypeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportType.active=x_bActive;
            _oMobileOrderReportType.cdate=x_dCdate;
            _oMobileOrderReportType.cid=x_sCid;
            _oMobileOrderReportType.did=x_sDid;
            _oMobileOrderReportType.report_name=x_sReport_name;
            _oMobileOrderReportType.id=x_gId;
            _oMobileOrderReportType.ddate=x_dDdate;
            _oMobileOrderReportType.report_type=x_sReport_type;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportType,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportType x_oMobileOrderReportType)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportType x_oMobileOrderReportType)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportType, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportType)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportType)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportType x_oMobileOrderReportType, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTTYPE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportType,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportType x_oMobileOrderReportType, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportType.active; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportType.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportType.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportType.did; }
                _oPar=x_oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.report_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportType.report_name; }
                _oPar=x_oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportType.id; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportType.ddate; }
                _oPar=x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportType.report_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportType.report_type; }
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
        
        #region INSERT_MOBILEORDERREPORTTYPE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,MOBILEORDERREPORTTYPE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTTYPE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTTYPE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTTYPE;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTTYPE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid nvarchar(10),
        @did nvarchar(10),
        @report_name nvarchar(50),
        @id uniqueidentifier,
        @ddate datetime,
        @report_type nvarchar(20)
        AS
        
        INSERT INTO  [MobileOrderReportType]   ([active],[cdate],[cid],[did],[report_name],[id],[ddate],[report_type])  VALUES  (@active,@cdate,@cid,@did,@report_name,@id,@ddate,@report_type)
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
            string _sQuery = "DELETE FROM  [MobileOrderReportType]  WHERE [MobileOrderReportType].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
            return MobileOrderReportTypeRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportType]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportType]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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


