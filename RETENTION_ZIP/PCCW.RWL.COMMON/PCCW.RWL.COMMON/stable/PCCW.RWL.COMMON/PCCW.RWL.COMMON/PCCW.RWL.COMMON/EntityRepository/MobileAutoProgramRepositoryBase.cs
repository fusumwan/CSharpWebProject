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
///-- Create date: <Create Date 2010-06-11>
///-- Description:	<Description,Table :[MobileAutoProgram],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileAutoProgram] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileAutoProgram")]
    public class MobileAutoProgramRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileAutoProgramRepositoryBase instance;
        public static MobileAutoProgramRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileAutoProgramRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileAutoProgramRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileAutoProgramRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileAutoProgramEntity> MobileAutoPrograms;
        #endregion
        
        #region Constructor
        public MobileAutoProgramRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileAutoProgramRepositoryBase() { 
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
        public static MobileAutoProgram CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileAutoProgram(_oDB);
        }
        
        public static MobileAutoProgram CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileAutoProgram(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileAutoProgram]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
        
        
        public MobileAutoProgramEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileAutoProgramEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileAutoProgram _MobileAutoProgram = (MobileAutoProgram)MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileAutoProgram.Load(x_iId)) { return null; }
            return _MobileAutoProgram;
        }
        
        
        
        public static MobileAutoProgramEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileAutoProgramEntity> _oMobileAutoProgramList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oMobileAutoProgramList.Count == 0 ? null : _oMobileAutoProgramList.ToArray();
        }
        
        public static List<MobileAutoProgramEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileAutoProgramEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileAutoProgramEntity> _oMobileAutoProgramList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oMobileAutoProgramList.Count == 0 ? null : _oMobileAutoProgramList.ToArray();
        }
        
        
        public static MobileAutoProgramEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileAutoProgramEntity> _oMobileAutoProgramList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oMobileAutoProgramList.Count == 0 ? null : _oMobileAutoProgramList.ToArray();
        }
        
        public static List<MobileAutoProgramEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileAutoProgramEntity> _oRow = new List<MobileAutoProgramEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileAutoProgram].[rdate] AS MOBILEAUTOPROGRAM_RDATE,[MobileAutoProgram].[auto_name] AS MOBILEAUTOPROGRAM_AUTO_NAME,[MobileAutoProgram].[active] AS MOBILEAUTOPROGRAM_ACTIVE,[MobileAutoProgram].[guid] AS MOBILEAUTOPROGRAM_GUID,[MobileAutoProgram].[id] AS MOBILEAUTOPROGRAM_ID  FROM  [MobileAutoProgram]";
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
                _sQuery += " WHERE [MobileAutoProgram].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileAutoProgram _oMobileAutoProgram = MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_RDATE"])) {_oMobileAutoProgram.rdate = (global::System.Nullable<DateTime>)_oData["MOBILEAUTOPROGRAM_RDATE"]; }else{_oMobileAutoProgram.rdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_AUTO_NAME"])) {_oMobileAutoProgram.auto_name = (string)_oData["MOBILEAUTOPROGRAM_AUTO_NAME"]; }else{_oMobileAutoProgram.auto_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ID"])) {_oMobileAutoProgram.id = (global::System.Nullable<int>)_oData["MOBILEAUTOPROGRAM_ID"]; }else{_oMobileAutoProgram.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_GUID"])) {_oMobileAutoProgram.guid = (global::System.Nullable<Guid>)_oData["MOBILEAUTOPROGRAM_GUID"]; }else{_oMobileAutoProgram.guid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ACTIVE"])) {_oMobileAutoProgram.active = (global::System.Nullable<bool>)_oData["MOBILEAUTOPROGRAM_ACTIVE"]; }else{_oMobileAutoProgram.active=null;}
                        _oMobileAutoProgram.SetDB(x_oDB);
                        _oMobileAutoProgram.GetFound();
                        _oRow.Add(_oMobileAutoProgram);
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
        
        
        public static MobileAutoProgramEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileAutoProgramEntity> _oMobileAutoProgramList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileAutoProgramList.Count == 0 ? null : _oMobileAutoProgramList.ToArray();
        }
        
        
        public static MobileAutoProgramEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileAutoProgramEntity> _oMobileAutoProgramList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileAutoProgramList.Count == 0 ? null : _oMobileAutoProgramList.ToArray();
        }
        
        public static List<MobileAutoProgramEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileAutoProgramEntity> _oRow = new List<MobileAutoProgramEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileAutoProgram].[rdate] AS MOBILEAUTOPROGRAM_RDATE,[MobileAutoProgram].[auto_name] AS MOBILEAUTOPROGRAM_AUTO_NAME,[MobileAutoProgram].[active] AS MOBILEAUTOPROGRAM_ACTIVE,[MobileAutoProgram].[guid] AS MOBILEAUTOPROGRAM_GUID,[MobileAutoProgram].[id] AS MOBILEAUTOPROGRAM_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileAutoProgramRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileAutoProgramEntity _oMobileAutoProgram = MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_RDATE"])) {_oMobileAutoProgram.rdate = (global::System.Nullable<DateTime>)_oData["MOBILEAUTOPROGRAM_RDATE"]; } else {_oMobileAutoProgram.rdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_AUTO_NAME"])) {_oMobileAutoProgram.auto_name = (string)_oData["MOBILEAUTOPROGRAM_AUTO_NAME"]; } else {_oMobileAutoProgram.auto_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ID"])) {_oMobileAutoProgram.id = (global::System.Nullable<int>)_oData["MOBILEAUTOPROGRAM_ID"]; } else {_oMobileAutoProgram.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_GUID"])) {_oMobileAutoProgram.guid = (global::System.Nullable<Guid>)_oData["MOBILEAUTOPROGRAM_GUID"]; } else {_oMobileAutoProgram.guid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ACTIVE"])) {_oMobileAutoProgram.active = (global::System.Nullable<bool>)_oData["MOBILEAUTOPROGRAM_ACTIVE"]; } else {_oMobileAutoProgram.active=null; }
                _oMobileAutoProgram.SetDB(x_oDB);
                _oMobileAutoProgram.GetFound();
                _oRow.Add(_oMobileAutoProgram);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileAutoProgram.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileAutoProgram.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileAutoProgram.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileAutoProgram.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileAutoProgram].[rdate] AS MOBILEAUTOPROGRAM_RDATE,[MobileAutoProgram].[auto_name] AS MOBILEAUTOPROGRAM_AUTO_NAME,[MobileAutoProgram].[active] AS MOBILEAUTOPROGRAM_ACTIVE,[MobileAutoProgram].[guid] AS MOBILEAUTOPROGRAM_GUID,[MobileAutoProgram].[id] AS MOBILEAUTOPROGRAM_ID  FROM  [MobileAutoProgram]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileAutoProgram");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dRdate,string x_sAuto_name,global::System.Nullable<Guid> x_gGuid,global::System.Nullable<bool> x_bActive)
        {
            MobileAutoProgram _oMobileAutoProgram=MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileAutoProgram.rdate=x_dRdate;
            _oMobileAutoProgram.auto_name=x_sAuto_name;
            _oMobileAutoProgram.guid=x_gGuid;
            _oMobileAutoProgram.active=x_bActive;
            return InsertWithOutLastID(n_oDB, _oMobileAutoProgram);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dRdate,string x_sAuto_name,global::System.Nullable<Guid> x_gGuid,global::System.Nullable<bool> x_bActive)
        {
            MobileAutoProgram _oMobileAutoProgram=MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileAutoProgram.rdate=x_dRdate;
            _oMobileAutoProgram.auto_name=x_sAuto_name;
            _oMobileAutoProgram.guid=x_gGuid;
            _oMobileAutoProgram.active=x_bActive;
            return InsertWithOutLastID(x_oDB, _oMobileAutoProgram);
        }
        
        
        public bool Insert(MobileAutoProgram x_oMobileAutoProgram)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileAutoProgram);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileAutoProgram)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileAutoProgram)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileAutoProgram x_oMobileAutoProgram)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileAutoProgram);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileAutoProgram x_oMobileAutoProgram)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileAutoProgram]   ([rdate],[auto_name],[active],[guid])  VALUES  (@rdate,@auto_name,@active,@guid)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileAutoProgram);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileAutoProgram x_oMobileAutoProgram)
        {
            bool _bResult = false;
            if (!x_oMobileAutoProgram.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileAutoProgram.rdate==null){  x_oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileAutoProgram.rdate; }
                if(x_oMobileAutoProgram.auto_name==null){  x_oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileAutoProgram.auto_name; }
                if(x_oMobileAutoProgram.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileAutoProgram.active; }
                if(x_oMobileAutoProgram.guid==null){  x_oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier).Value=x_oMobileAutoProgram.guid; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dRdate,string x_sAuto_name,global::System.Nullable<Guid> x_gGuid,global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            MobileAutoProgram _oMobileAutoProgram=MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileAutoProgram.rdate=x_dRdate;
            _oMobileAutoProgram.auto_name=x_sAuto_name;
            _oMobileAutoProgram.guid=x_gGuid;
            _oMobileAutoProgram.active=x_bActive;
            if(InsertWithLastID(x_oDB, _oMobileAutoProgram,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileAutoProgram x_oMobileAutoProgram)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileAutoProgram, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileAutoProgram x_oMobileAutoProgram)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileAutoProgram, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileAutoProgram)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileAutoProgram)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileAutoProgram x_oMobileAutoProgram, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileAutoProgram]   ([rdate],[auto_name],[active],[guid])  VALUES  (@rdate,@auto_name,@active,@guid)"+" SELECT  @@IDENTITY AS MobileAutoProgram_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileAutoProgram,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileAutoProgram x_oMobileAutoProgram, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileAutoProgram.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileAutoProgram.rdate==null){  x_oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileAutoProgram.rdate; }
                if(x_oMobileAutoProgram.auto_name==null){  x_oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileAutoProgram.auto_name; }
                if(x_oMobileAutoProgram.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileAutoProgram.active; }
                if(x_oMobileAutoProgram.guid==null){  x_oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier).Value=x_oMobileAutoProgram.guid; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileAutoProgram_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileAutoProgram_LASTID"].ToString()) && int.TryParse(_oData["MobileAutoProgram_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dRdate,string x_sAuto_name,global::System.Nullable<Guid> x_gGuid,global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            MobileAutoProgram _oMobileAutoProgram=MobileAutoProgramRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileAutoProgram.rdate=x_dRdate;
            _oMobileAutoProgram.auto_name=x_sAuto_name;
            _oMobileAutoProgram.guid=x_gGuid;
            _oMobileAutoProgram.active=x_bActive;
            if(InsertWithLastID_SP(x_oDB, _oMobileAutoProgram,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileAutoProgram x_oMobileAutoProgram)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileAutoProgram, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileAutoProgram x_oMobileAutoProgram)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileAutoProgram, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileAutoProgram)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileAutoProgram)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileAutoProgram x_oMobileAutoProgram, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEAUTOPROGRAM";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileAutoProgram,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileAutoProgram x_oMobileAutoProgram, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileAutoProgram.rdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileAutoProgram.rdate; }
                _oPar=x_oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileAutoProgram.auto_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileAutoProgram.auto_name; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileAutoProgram.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileAutoProgram.active; }
                _oPar=x_oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileAutoProgram.guid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileAutoProgram.guid; }
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
        
        #region INSERT_MOBILEAUTOPROGRAM Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-06-11>
        ///-- Description:	<Description,MOBILEAUTOPROGRAM, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEAUTOPROGRAM Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEAUTOPROGRAM', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEAUTOPROGRAM;
        GO
        CREATE PROCEDURE INSERT_MOBILEAUTOPROGRAM
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @rdate datetime,
        @auto_name nvarchar(250),
        @guid uniqueidentifier,
        @active bit
        AS
        
        INSERT INTO  [MobileAutoProgram]   ([rdate],[auto_name],[active],[guid])  VALUES  (@rdate,@auto_name,@active,@guid)
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
            string _sQuery = "DELETE FROM  [MobileAutoProgram]  WHERE [MobileAutoProgram].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
            return MobileAutoProgramRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileAutoProgram]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
            string _sQuery = "DELETE FROM [MobileAutoProgram]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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


