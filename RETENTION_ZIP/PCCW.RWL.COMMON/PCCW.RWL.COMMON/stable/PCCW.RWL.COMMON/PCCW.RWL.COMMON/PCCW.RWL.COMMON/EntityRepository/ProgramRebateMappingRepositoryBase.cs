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
///-- Create date: <Create Date 2011-09-22>
///-- Description:	<Description,Table :[ProgramRebateMapping],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProgramRebateMapping] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"ProgramRebateMapping")]
    public class ProgramRebateMappingRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static ProgramRebateMappingRepositoryBase instance;
        public static ProgramRebateMappingRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new ProgramRebateMappingRepositoryBase(_oDB);
            }
            return instance;
        }
        public static ProgramRebateMappingRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new ProgramRebateMappingRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<ProgramRebateMappingEntity> ProgramRebateMappings;
        #endregion
        
        #region Constructor
        public ProgramRebateMappingRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~ProgramRebateMappingRepositoryBase() { 
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
        public static ProgramRebateMapping CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new ProgramRebateMapping(_oDB);
        }
        
        public static ProgramRebateMapping CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new ProgramRebateMapping(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [ProgramRebateMapping]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
        
        
        public ProgramRebateMappingEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static ProgramRebateMappingEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            ProgramRebateMapping _ProgramRebateMapping = (ProgramRebateMapping)ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_ProgramRebateMapping.Load(x_iId)) { return null; }
            return _ProgramRebateMapping;
        }
        
        
        
        public static ProgramRebateMappingEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<ProgramRebateMappingEntity> _oProgramRebateMappingList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oProgramRebateMappingList==null){ return null;}
            return _oProgramRebateMappingList.Count == 0 ? null : _oProgramRebateMappingList.ToArray();
        }
        
        public static List<ProgramRebateMappingEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static ProgramRebateMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProgramRebateMappingEntity> _oProgramRebateMappingList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oProgramRebateMappingList==null){ return null;}
            return _oProgramRebateMappingList.Count == 0 ? null : _oProgramRebateMappingList.ToArray();
        }
        
        
        public static ProgramRebateMappingEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProgramRebateMappingEntity> _oProgramRebateMappingList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oProgramRebateMappingList==null){ return null;}
            return _oProgramRebateMappingList.Count == 0 ? null : _oProgramRebateMappingList.ToArray();
        }
        
        public static List<ProgramRebateMappingEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<ProgramRebateMappingEntity> _oRow = new List<ProgramRebateMappingEntity>();
            string _sQuery = "SELECT  "+_sTop+" [ProgramRebateMapping].[id] AS PROGRAMREBATEMAPPING_ID,[ProgramRebateMapping].[cdate] AS PROGRAMREBATEMAPPING_CDATE,[ProgramRebateMapping].[active] AS PROGRAMREBATEMAPPING_ACTIVE,[ProgramRebateMapping].[edate] AS PROGRAMREBATEMAPPING_EDATE,[ProgramRebateMapping].[program] AS PROGRAMREBATEMAPPING_PROGRAM,[ProgramRebateMapping].[issue_type] AS PROGRAMREBATEMAPPING_ISSUE_TYPE,[ProgramRebateMapping].[use_rebate_mapping] AS PROGRAMREBATEMAPPING_USE_REBATE_MAPPING,[ProgramRebateMapping].[sdate] AS PROGRAMREBATEMAPPING_SDATE  FROM  [ProgramRebateMapping]";
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
                _sQuery += " WHERE [ProgramRebateMapping].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        ProgramRebateMapping _oProgramRebateMapping = ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ID"])) {_oProgramRebateMapping.id = (global::System.Nullable<int>)_oData["PROGRAMREBATEMAPPING_ID"]; }else{_oProgramRebateMapping.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_CDATE"])) {_oProgramRebateMapping.cdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_CDATE"]; }else{_oProgramRebateMapping.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ACTIVE"])) {_oProgramRebateMapping.active = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_ACTIVE"]; }else{_oProgramRebateMapping.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_EDATE"])) {_oProgramRebateMapping.edate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_EDATE"]; }else{_oProgramRebateMapping.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_PROGRAM"])) {_oProgramRebateMapping.program = (string)_oData["PROGRAMREBATEMAPPING_PROGRAM"]; }else{_oProgramRebateMapping.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"])) {_oProgramRebateMapping.issue_type = (string)_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"]; }else{_oProgramRebateMapping.issue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"])) {_oProgramRebateMapping.use_rebate_mapping = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"]; }else{_oProgramRebateMapping.use_rebate_mapping=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_SDATE"])) {_oProgramRebateMapping.sdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_SDATE"]; }else{_oProgramRebateMapping.sdate=null;}
                        _oProgramRebateMapping.SetDB(x_oDB);
                        _oProgramRebateMapping.GetFound();
                        _oRow.Add(_oProgramRebateMapping);
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
        
        
        public static ProgramRebateMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProgramRebateMappingEntity> _oProgramRebateMappingList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oProgramRebateMappingList==null){ return null;}
            return _oProgramRebateMappingList.Count == 0 ? null : _oProgramRebateMappingList.ToArray();
        }
        
        
        public static ProgramRebateMappingEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProgramRebateMappingEntity> _oProgramRebateMappingList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oProgramRebateMappingList==null){ return null;}
            return _oProgramRebateMappingList.Count == 0 ? null : _oProgramRebateMappingList.ToArray();
        }
        
        public static List<ProgramRebateMappingEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<ProgramRebateMappingEntity> _oRow = new List<ProgramRebateMappingEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[ProgramRebateMapping].[id] AS PROGRAMREBATEMAPPING_ID,[ProgramRebateMapping].[cdate] AS PROGRAMREBATEMAPPING_CDATE,[ProgramRebateMapping].[active] AS PROGRAMREBATEMAPPING_ACTIVE,[ProgramRebateMapping].[edate] AS PROGRAMREBATEMAPPING_EDATE,[ProgramRebateMapping].[program] AS PROGRAMREBATEMAPPING_PROGRAM,[ProgramRebateMapping].[issue_type] AS PROGRAMREBATEMAPPING_ISSUE_TYPE,[ProgramRebateMapping].[use_rebate_mapping] AS PROGRAMREBATEMAPPING_USE_REBATE_MAPPING,[ProgramRebateMapping].[sdate] AS PROGRAMREBATEMAPPING_SDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = ProgramRebateMappingRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                ProgramRebateMappingEntity _oProgramRebateMapping = ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ID"])) {_oProgramRebateMapping.id = (global::System.Nullable<int>)_oData["PROGRAMREBATEMAPPING_ID"]; } else {_oProgramRebateMapping.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_CDATE"])) {_oProgramRebateMapping.cdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_CDATE"]; } else {_oProgramRebateMapping.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ACTIVE"])) {_oProgramRebateMapping.active = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_ACTIVE"]; } else {_oProgramRebateMapping.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_EDATE"])) {_oProgramRebateMapping.edate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_EDATE"]; } else {_oProgramRebateMapping.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_PROGRAM"])) {_oProgramRebateMapping.program = (string)_oData["PROGRAMREBATEMAPPING_PROGRAM"]; } else {_oProgramRebateMapping.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"])) {_oProgramRebateMapping.issue_type = (string)_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"]; } else {_oProgramRebateMapping.issue_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"])) {_oProgramRebateMapping.use_rebate_mapping = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"]; } else {_oProgramRebateMapping.use_rebate_mapping=null; }
                if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_SDATE"])) {_oProgramRebateMapping.sdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_SDATE"]; } else {_oProgramRebateMapping.sdate=null; }
                _oProgramRebateMapping.SetDB(x_oDB);
                _oProgramRebateMapping.GetFound();
                _oRow.Add(_oProgramRebateMapping);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( ProgramRebateMapping.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,ProgramRebateMapping.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(ProgramRebateMapping.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(ProgramRebateMapping.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [ProgramRebateMapping].[id] AS PROGRAMREBATEMAPPING_ID,[ProgramRebateMapping].[cdate] AS PROGRAMREBATEMAPPING_CDATE,[ProgramRebateMapping].[active] AS PROGRAMREBATEMAPPING_ACTIVE,[ProgramRebateMapping].[edate] AS PROGRAMREBATEMAPPING_EDATE,[ProgramRebateMapping].[program] AS PROGRAMREBATEMAPPING_PROGRAM,[ProgramRebateMapping].[issue_type] AS PROGRAMREBATEMAPPING_ISSUE_TYPE,[ProgramRebateMapping].[use_rebate_mapping] AS PROGRAMREBATEMAPPING_USE_REBATE_MAPPING,[ProgramRebateMapping].[sdate] AS PROGRAMREBATEMAPPING_SDATE  FROM  [ProgramRebateMapping]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"ProgramRebateMapping");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bUse_rebate_mapping,global::System.Nullable<DateTime> x_dSdate)
        {
            ProgramRebateMapping _oProgramRebateMapping=ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oProgramRebateMapping.cdate=x_dCdate;
            _oProgramRebateMapping.active=x_bActive;
            _oProgramRebateMapping.edate=x_dEdate;
            _oProgramRebateMapping.program=x_sProgram;
            _oProgramRebateMapping.issue_type=x_sIssue_type;
            _oProgramRebateMapping.use_rebate_mapping=x_bUse_rebate_mapping;
            _oProgramRebateMapping.sdate=x_dSdate;
            return InsertWithOutLastID(n_oDB, _oProgramRebateMapping);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bUse_rebate_mapping,global::System.Nullable<DateTime> x_dSdate)
        {
            ProgramRebateMapping _oProgramRebateMapping=ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProgramRebateMapping.cdate=x_dCdate;
            _oProgramRebateMapping.active=x_bActive;
            _oProgramRebateMapping.edate=x_dEdate;
            _oProgramRebateMapping.program=x_sProgram;
            _oProgramRebateMapping.issue_type=x_sIssue_type;
            _oProgramRebateMapping.use_rebate_mapping=x_bUse_rebate_mapping;
            _oProgramRebateMapping.sdate=x_dSdate;
            return InsertWithOutLastID(x_oDB, _oProgramRebateMapping);
        }
        
        
        public bool Insert(ProgramRebateMapping x_oProgramRebateMapping)
        {
            return InsertWithOutLastID(n_oDB, x_oProgramRebateMapping);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is ProgramRebateMapping)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (ProgramRebateMapping)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,ProgramRebateMapping x_oProgramRebateMapping)
        {
            return InsertWithOutLastID(x_oDB, x_oProgramRebateMapping);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProgramRebateMapping x_oProgramRebateMapping)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ProgramRebateMapping]   ([cdate],[active],[edate],[program],[issue_type],[use_rebate_mapping],[sdate])  VALUES  (@cdate,@active,@edate,@program,@issue_type,@use_rebate_mapping,@sdate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oProgramRebateMapping);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProgramRebateMapping x_oProgramRebateMapping)
        {
            bool _bResult = false;
            if (!x_oProgramRebateMapping.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oProgramRebateMapping.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oProgramRebateMapping.cdate; }
                if(x_oProgramRebateMapping.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oProgramRebateMapping.active; }
                if(x_oProgramRebateMapping.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oProgramRebateMapping.edate; }
                if(x_oProgramRebateMapping.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProgramRebateMapping.program; }
                if(x_oProgramRebateMapping.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProgramRebateMapping.issue_type; }
                if(x_oProgramRebateMapping.use_rebate_mapping==null){  x_oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit).Value=x_oProgramRebateMapping.use_rebate_mapping; }
                if(x_oProgramRebateMapping.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oProgramRebateMapping.sdate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bUse_rebate_mapping,global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            ProgramRebateMapping _oProgramRebateMapping=ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProgramRebateMapping.cdate=x_dCdate;
            _oProgramRebateMapping.active=x_bActive;
            _oProgramRebateMapping.edate=x_dEdate;
            _oProgramRebateMapping.program=x_sProgram;
            _oProgramRebateMapping.issue_type=x_sIssue_type;
            _oProgramRebateMapping.use_rebate_mapping=x_bUse_rebate_mapping;
            _oProgramRebateMapping.sdate=x_dSdate;
            if(InsertWithLastID(x_oDB, _oProgramRebateMapping,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(ProgramRebateMapping x_oProgramRebateMapping)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oProgramRebateMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, ProgramRebateMapping x_oProgramRebateMapping)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oProgramRebateMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProgramRebateMapping)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (ProgramRebateMapping)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,ProgramRebateMapping x_oProgramRebateMapping, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ProgramRebateMapping]   ([cdate],[active],[edate],[program],[issue_type],[use_rebate_mapping],[sdate])  VALUES  (@cdate,@active,@edate,@program,@issue_type,@use_rebate_mapping,@sdate)"+" SELECT  @@IDENTITY AS ProgramRebateMapping_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oProgramRebateMapping,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProgramRebateMapping x_oProgramRebateMapping, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oProgramRebateMapping.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oProgramRebateMapping.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oProgramRebateMapping.cdate; }
                if(x_oProgramRebateMapping.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oProgramRebateMapping.active; }
                if(x_oProgramRebateMapping.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oProgramRebateMapping.edate; }
                if(x_oProgramRebateMapping.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProgramRebateMapping.program; }
                if(x_oProgramRebateMapping.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oProgramRebateMapping.issue_type; }
                if(x_oProgramRebateMapping.use_rebate_mapping==null){  x_oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit).Value=x_oProgramRebateMapping.use_rebate_mapping; }
                if(x_oProgramRebateMapping.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oProgramRebateMapping.sdate; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["ProgramRebateMapping_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["ProgramRebateMapping_LASTID"].ToString()) && int.TryParse(_oData["ProgramRebateMapping_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bUse_rebate_mapping,global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            ProgramRebateMapping _oProgramRebateMapping=ProgramRebateMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProgramRebateMapping.cdate=x_dCdate;
            _oProgramRebateMapping.active=x_bActive;
            _oProgramRebateMapping.edate=x_dEdate;
            _oProgramRebateMapping.program=x_sProgram;
            _oProgramRebateMapping.issue_type=x_sIssue_type;
            _oProgramRebateMapping.use_rebate_mapping=x_bUse_rebate_mapping;
            _oProgramRebateMapping.sdate=x_dSdate;
            if(InsertWithLastID_SP(x_oDB, _oProgramRebateMapping,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(ProgramRebateMapping x_oProgramRebateMapping)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oProgramRebateMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProgramRebateMapping x_oProgramRebateMapping)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oProgramRebateMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProgramRebateMapping)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (ProgramRebateMapping)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,ProgramRebateMapping x_oProgramRebateMapping, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "PROGRAMREBATEMAPPING";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oProgramRebateMapping,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ProgramRebateMapping x_oProgramRebateMapping, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProgramRebateMapping.cdate; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProgramRebateMapping.active; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProgramRebateMapping.edate; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProgramRebateMapping.program; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProgramRebateMapping.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.use_rebate_mapping==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oProgramRebateMapping.use_rebate_mapping; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oProgramRebateMapping.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oProgramRebateMapping.sdate; }
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
        
        #region INSERT_PROGRAMREBATEMAPPING Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-09-22>
        ///-- Description:	<Description,PROGRAMREBATEMAPPING, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_PROGRAMREBATEMAPPING Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_PROGRAMREBATEMAPPING', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_PROGRAMREBATEMAPPING;
        GO
        CREATE PROCEDURE INSERT_PROGRAMREBATEMAPPING
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @active bit,
        @edate datetime,
        @program nvarchar(50),
        @issue_type nvarchar(50),
        @use_rebate_mapping bit,
        @sdate datetime
        AS
        
        INSERT INTO  [ProgramRebateMapping]   ([cdate],[active],[edate],[program],[issue_type],[use_rebate_mapping],[sdate])  VALUES  (@cdate,@active,@edate,@program,@issue_type,@use_rebate_mapping,@sdate)
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
            string _sQuery = "DELETE FROM  [ProgramRebateMapping]  WHERE [ProgramRebateMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
            return ProgramRebateMappingRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [ProgramRebateMapping]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
            string _sQuery = "DELETE FROM [ProgramRebateMapping]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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


