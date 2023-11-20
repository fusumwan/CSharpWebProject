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
///-- Create date: <Create Date 2010-06-09>
///-- Description:	<Description,Table :[MobileManualAssignedHistory],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileManualAssignedHistory] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileManualAssignedHistory")]
    public class MobileManualAssignedHistoryRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileManualAssignedHistoryRepositoryBase instance;
        public static MobileManualAssignedHistoryRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileManualAssignedHistoryRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileManualAssignedHistoryRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileManualAssignedHistoryRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileManualAssignedHistoryEntity> MobileManualAssignedHistorys;
        #endregion
        
        #region Constructor
        public MobileManualAssignedHistoryRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileManualAssignedHistoryRepositoryBase() { 
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
        public static MobileManualAssignedHistory CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileManualAssignedHistory(_oDB);
        }
        
        public static MobileManualAssignedHistory CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileManualAssignedHistory(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileManualAssignedHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
        
        
        public MobileManualAssignedHistoryEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileManualAssignedHistoryEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileManualAssignedHistory _MobileManualAssignedHistory = (MobileManualAssignedHistory)MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileManualAssignedHistory.Load(x_iId)) { return null; }
            return _MobileManualAssignedHistory;
        }
        
        
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistoryList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oMobileManualAssignedHistoryList.Count == 0 ? null : _oMobileManualAssignedHistoryList.ToArray();
        }
        
        public static List<MobileManualAssignedHistoryEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistoryList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oMobileManualAssignedHistoryList.Count == 0 ? null : _oMobileManualAssignedHistoryList.ToArray();
        }
        
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistoryList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oMobileManualAssignedHistoryList.Count == 0 ? null : _oMobileManualAssignedHistoryList.ToArray();
        }
        
        public static List<MobileManualAssignedHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileManualAssignedHistoryEntity> _oRow = new List<MobileManualAssignedHistoryEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileManualAssignedHistory].[sku] AS MOBILEMANUALASSIGNEDHISTORY_SKU,[MobileManualAssignedHistory].[order_id] AS MOBILEMANUALASSIGNEDHISTORY_ORDER_ID,[MobileManualAssignedHistory].[cdate] AS MOBILEMANUALASSIGNEDHISTORY_CDATE,[MobileManualAssignedHistory].[cid] AS MOBILEMANUALASSIGNEDHISTORY_CID,[MobileManualAssignedHistory].[imei_no] AS MOBILEMANUALASSIGNEDHISTORY_IMEI_NO,[MobileManualAssignedHistory].[id] AS MOBILEMANUALASSIGNEDHISTORY_ID  FROM  [MobileManualAssignedHistory]";
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
                _sQuery += " WHERE [MobileManualAssignedHistory].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileManualAssignedHistory _oMobileManualAssignedHistory = MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"])) {_oMobileManualAssignedHistory.sku = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"]; }else{_oMobileManualAssignedHistory.sku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"])) {_oMobileManualAssignedHistory.order_id = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"]; }else{_oMobileManualAssignedHistory.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"])) {_oMobileManualAssignedHistory.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"]; }else{_oMobileManualAssignedHistory.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CID"])) {_oMobileManualAssignedHistory.cid = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_CID"]; }else{_oMobileManualAssignedHistory.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"])) {_oMobileManualAssignedHistory.imei_no = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"]; }else{_oMobileManualAssignedHistory.imei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ID"])) {_oMobileManualAssignedHistory.id = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ID"]; }else{_oMobileManualAssignedHistory.id=null;}
                        _oMobileManualAssignedHistory.SetDB(x_oDB);
                        _oMobileManualAssignedHistory.GetFound();
                        _oRow.Add(_oMobileManualAssignedHistory);
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
        
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistoryList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileManualAssignedHistoryList.Count == 0 ? null : _oMobileManualAssignedHistoryList.ToArray();
        }
        
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistoryList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileManualAssignedHistoryList.Count == 0 ? null : _oMobileManualAssignedHistoryList.ToArray();
        }
        
        public static List<MobileManualAssignedHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileManualAssignedHistoryEntity> _oRow = new List<MobileManualAssignedHistoryEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileManualAssignedHistory].[sku] AS MOBILEMANUALASSIGNEDHISTORY_SKU,[MobileManualAssignedHistory].[order_id] AS MOBILEMANUALASSIGNEDHISTORY_ORDER_ID,[MobileManualAssignedHistory].[cdate] AS MOBILEMANUALASSIGNEDHISTORY_CDATE,[MobileManualAssignedHistory].[cid] AS MOBILEMANUALASSIGNEDHISTORY_CID,[MobileManualAssignedHistory].[imei_no] AS MOBILEMANUALASSIGNEDHISTORY_IMEI_NO,[MobileManualAssignedHistory].[id] AS MOBILEMANUALASSIGNEDHISTORY_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileManualAssignedHistoryRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileManualAssignedHistoryEntity _oMobileManualAssignedHistory = MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"])) {_oMobileManualAssignedHistory.sku = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"]; } else {_oMobileManualAssignedHistory.sku=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"])) {_oMobileManualAssignedHistory.order_id = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"]; } else {_oMobileManualAssignedHistory.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"])) {_oMobileManualAssignedHistory.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"]; } else {_oMobileManualAssignedHistory.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CID"])) {_oMobileManualAssignedHistory.cid = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_CID"]; } else {_oMobileManualAssignedHistory.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"])) {_oMobileManualAssignedHistory.imei_no = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"]; } else {_oMobileManualAssignedHistory.imei_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ID"])) {_oMobileManualAssignedHistory.id = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ID"]; } else {_oMobileManualAssignedHistory.id=null; }
                _oMobileManualAssignedHistory.SetDB(x_oDB);
                _oMobileManualAssignedHistory.GetFound();
                _oRow.Add(_oMobileManualAssignedHistory);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileManualAssignedHistory.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileManualAssignedHistory.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileManualAssignedHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileManualAssignedHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileManualAssignedHistory].[sku] AS MOBILEMANUALASSIGNEDHISTORY_SKU,[MobileManualAssignedHistory].[order_id] AS MOBILEMANUALASSIGNEDHISTORY_ORDER_ID,[MobileManualAssignedHistory].[cdate] AS MOBILEMANUALASSIGNEDHISTORY_CDATE,[MobileManualAssignedHistory].[cid] AS MOBILEMANUALASSIGNEDHISTORY_CID,[MobileManualAssignedHistory].[imei_no] AS MOBILEMANUALASSIGNEDHISTORY_IMEI_NO,[MobileManualAssignedHistory].[id] AS MOBILEMANUALASSIGNEDHISTORY_ID  FROM  [MobileManualAssignedHistory]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileManualAssignedHistory");
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
        
        public bool Insert(string x_sSku,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sImei_no)
        {
            MobileManualAssignedHistory _oMobileManualAssignedHistory=MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileManualAssignedHistory.sku=x_sSku;
            _oMobileManualAssignedHistory.order_id=x_iOrder_id;
            _oMobileManualAssignedHistory.cdate=x_dCdate;
            _oMobileManualAssignedHistory.cid=x_sCid;
            _oMobileManualAssignedHistory.imei_no=x_sImei_no;
            return InsertWithOutLastID(n_oDB, _oMobileManualAssignedHistory);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sSku,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sImei_no)
        {
            MobileManualAssignedHistory _oMobileManualAssignedHistory=MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileManualAssignedHistory.sku=x_sSku;
            _oMobileManualAssignedHistory.order_id=x_iOrder_id;
            _oMobileManualAssignedHistory.cdate=x_dCdate;
            _oMobileManualAssignedHistory.cid=x_sCid;
            _oMobileManualAssignedHistory.imei_no=x_sImei_no;
            return InsertWithOutLastID(x_oDB, _oMobileManualAssignedHistory);
        }
        
        
        public bool Insert(MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileManualAssignedHistory);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileManualAssignedHistory)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileManualAssignedHistory)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileManualAssignedHistory);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileManualAssignedHistory]   ([sku],[order_id],[cdate],[cid],[imei_no])  VALUES  (@sku,@order_id,@cdate,@cid,@imei_no)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileManualAssignedHistory);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            bool _bResult = false;
            if (!x_oMobileManualAssignedHistory.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileManualAssignedHistory.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileManualAssignedHistory.sku; }
                if(x_oMobileManualAssignedHistory.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileManualAssignedHistory.order_id; }
                if(x_oMobileManualAssignedHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileManualAssignedHistory.cdate; }
                if(x_oMobileManualAssignedHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileManualAssignedHistory.cid; }
                if(x_oMobileManualAssignedHistory.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileManualAssignedHistory.imei_no; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sSku,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sImei_no)
        {
            int _oLastID;
            MobileManualAssignedHistory _oMobileManualAssignedHistory=MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileManualAssignedHistory.sku=x_sSku;
            _oMobileManualAssignedHistory.order_id=x_iOrder_id;
            _oMobileManualAssignedHistory.cdate=x_dCdate;
            _oMobileManualAssignedHistory.cid=x_sCid;
            _oMobileManualAssignedHistory.imei_no=x_sImei_no;
            if(InsertWithLastID(x_oDB, _oMobileManualAssignedHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileManualAssignedHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileManualAssignedHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileManualAssignedHistory)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileManualAssignedHistory)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileManualAssignedHistory x_oMobileManualAssignedHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileManualAssignedHistory]   ([sku],[order_id],[cdate],[cid],[imei_no])  VALUES  (@sku,@order_id,@cdate,@cid,@imei_no)"+" SELECT  @@IDENTITY AS MobileManualAssignedHistory_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileManualAssignedHistory,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileManualAssignedHistory x_oMobileManualAssignedHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileManualAssignedHistory.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileManualAssignedHistory.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileManualAssignedHistory.sku; }
                if(x_oMobileManualAssignedHistory.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileManualAssignedHistory.order_id; }
                if(x_oMobileManualAssignedHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileManualAssignedHistory.cdate; }
                if(x_oMobileManualAssignedHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileManualAssignedHistory.cid; }
                if(x_oMobileManualAssignedHistory.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileManualAssignedHistory.imei_no; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileManualAssignedHistory_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileManualAssignedHistory_LASTID"].ToString()) && int.TryParse(_oData["MobileManualAssignedHistory_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sSku,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sImei_no)
        {
            int _oLastID;
            MobileManualAssignedHistory _oMobileManualAssignedHistory=MobileManualAssignedHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileManualAssignedHistory.sku=x_sSku;
            _oMobileManualAssignedHistory.order_id=x_iOrder_id;
            _oMobileManualAssignedHistory.cdate=x_dCdate;
            _oMobileManualAssignedHistory.cid=x_sCid;
            _oMobileManualAssignedHistory.imei_no=x_sImei_no;
            if(InsertWithLastID_SP(x_oDB, _oMobileManualAssignedHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileManualAssignedHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileManualAssignedHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileManualAssignedHistory)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileManualAssignedHistory)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileManualAssignedHistory x_oMobileManualAssignedHistory, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEMANUALASSIGNEDHISTORY";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileManualAssignedHistory,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileManualAssignedHistory x_oMobileManualAssignedHistory, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileManualAssignedHistory.sku==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileManualAssignedHistory.sku; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileManualAssignedHistory.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileManualAssignedHistory.order_id; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileManualAssignedHistory.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileManualAssignedHistory.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileManualAssignedHistory.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileManualAssignedHistory.cid; }
                _oPar=x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileManualAssignedHistory.imei_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileManualAssignedHistory.imei_no; }
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
        
        #region INSERT_MOBILEMANUALASSIGNEDHISTORY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-06-09>
        ///-- Description:	<Description,MOBILEMANUALASSIGNEDHISTORY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEMANUALASSIGNEDHISTORY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEMANUALASSIGNEDHISTORY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEMANUALASSIGNEDHISTORY;
        GO
        CREATE PROCEDURE INSERT_MOBILEMANUALASSIGNEDHISTORY
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @sku nvarchar(100),
        @order_id int,
        @cdate datetime,
        @cid nvarchar(50),
        @imei_no nvarchar(250)
        AS
        
        INSERT INTO  [MobileManualAssignedHistory]   ([sku],[order_id],[cdate],[cid],[imei_no])  VALUES  (@sku,@order_id,@cdate,@cid,@imei_no)
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
            string _sQuery = "DELETE FROM  [MobileManualAssignedHistory]  WHERE [MobileManualAssignedHistory].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
            return MobileManualAssignedHistoryRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileManualAssignedHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
            string _sQuery = "DELETE FROM [MobileManualAssignedHistory]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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


