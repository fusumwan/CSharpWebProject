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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryTime],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [DeliveryTime] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"DeliveryTime")]
    public class DeliveryTimeRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static DeliveryTimeRepositoryBase instance;
        public static DeliveryTimeRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new DeliveryTimeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static DeliveryTimeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new DeliveryTimeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<DeliveryTimeEntity> DeliveryTimes;
        #endregion
        
        #region Constructor
        public DeliveryTimeRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~DeliveryTimeRepositoryBase() { 
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
        public static DeliveryTime CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new DeliveryTime(_oDB);
        }
        
        public static DeliveryTime CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new DeliveryTime(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [DeliveryTime]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
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
        
        
        public DeliveryTimeEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static DeliveryTimeEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            DeliveryTime _DeliveryTime = (DeliveryTime)DeliveryTimeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_DeliveryTime.Load(x_iId)) { return null; }
            return _DeliveryTime;
        }
        
        
        
        public static DeliveryTimeEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<DeliveryTimeEntity> _oDeliveryTimeList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oDeliveryTimeList==null){ return null;}
            return _oDeliveryTimeList.Count == 0 ? null : _oDeliveryTimeList.ToArray();
        }
        
        public static List<DeliveryTimeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static DeliveryTimeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DeliveryTimeEntity> _oDeliveryTimeList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oDeliveryTimeList==null){ return null;}
            return _oDeliveryTimeList.Count == 0 ? null : _oDeliveryTimeList.ToArray();
        }
        
        
        public static DeliveryTimeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DeliveryTimeEntity> _oDeliveryTimeList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oDeliveryTimeList==null){ return null;}
            return _oDeliveryTimeList.Count == 0 ? null : _oDeliveryTimeList.ToArray();
        }
        
        public static List<DeliveryTimeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<DeliveryTimeEntity> _oRow = new List<DeliveryTimeEntity>();
            string _sQuery = "SELECT  "+_sTop+" [DeliveryTime].[active] AS DELIVERYTIME_ACTIVE,[DeliveryTime].[cdate] AS DELIVERYTIME_CDATE,[DeliveryTime].[cid] AS DELIVERYTIME_CID,[DeliveryTime].[location] AS DELIVERYTIME_LOCATION,[DeliveryTime].[id] AS DELIVERYTIME_ID,[DeliveryTime].[period] AS DELIVERYTIME_PERIOD  FROM  [DeliveryTime]";
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
                _sQuery += " WHERE [DeliveryTime].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        DeliveryTime _oDeliveryTime = DeliveryTimeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_ID"])) {_oDeliveryTime.id = (global::System.Nullable<int>)_oData["DELIVERYTIME_ID"]; }else{_oDeliveryTime.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_CDATE"])) {_oDeliveryTime.cdate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIME_CDATE"]; }else{_oDeliveryTime.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_CID"])) {_oDeliveryTime.cid = (string)_oData["DELIVERYTIME_CID"]; }else{_oDeliveryTime.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_LOCATION"])) {_oDeliveryTime.location = (string)_oData["DELIVERYTIME_LOCATION"]; }else{_oDeliveryTime.location=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_ACTIVE"])) {_oDeliveryTime.active = (global::System.Nullable<bool>)_oData["DELIVERYTIME_ACTIVE"]; }else{_oDeliveryTime.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_PERIOD"])) {_oDeliveryTime.period = (string)_oData["DELIVERYTIME_PERIOD"]; }else{_oDeliveryTime.period=global::System.String.Empty;}
                        _oDeliveryTime.SetDB(x_oDB);
                        _oDeliveryTime.GetFound();
                        _oRow.Add(_oDeliveryTime);
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
        
        
        public static DeliveryTimeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DeliveryTimeEntity> _oDeliveryTimeList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oDeliveryTimeList==null){ return null;}
            return _oDeliveryTimeList.Count == 0 ? null : _oDeliveryTimeList.ToArray();
        }
        
        
        public static DeliveryTimeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DeliveryTimeEntity> _oDeliveryTimeList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oDeliveryTimeList==null){ return null;}
            return _oDeliveryTimeList.Count == 0 ? null : _oDeliveryTimeList.ToArray();
        }
        
        public static List<DeliveryTimeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<DeliveryTimeEntity> _oRow = new List<DeliveryTimeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[DeliveryTime].[active] AS DELIVERYTIME_ACTIVE,[DeliveryTime].[cdate] AS DELIVERYTIME_CDATE,[DeliveryTime].[cid] AS DELIVERYTIME_CID,[DeliveryTime].[location] AS DELIVERYTIME_LOCATION,[DeliveryTime].[id] AS DELIVERYTIME_ID,[DeliveryTime].[period] AS DELIVERYTIME_PERIOD";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = DeliveryTimeRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                DeliveryTimeEntity _oDeliveryTime = DeliveryTimeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_ID"])) {_oDeliveryTime.id = (global::System.Nullable<int>)_oData["DELIVERYTIME_ID"]; } else {_oDeliveryTime.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_CDATE"])) {_oDeliveryTime.cdate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIME_CDATE"]; } else {_oDeliveryTime.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_CID"])) {_oDeliveryTime.cid = (string)_oData["DELIVERYTIME_CID"]; } else {_oDeliveryTime.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_LOCATION"])) {_oDeliveryTime.location = (string)_oData["DELIVERYTIME_LOCATION"]; } else {_oDeliveryTime.location=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_ACTIVE"])) {_oDeliveryTime.active = (global::System.Nullable<bool>)_oData["DELIVERYTIME_ACTIVE"]; } else {_oDeliveryTime.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_PERIOD"])) {_oDeliveryTime.period = (string)_oData["DELIVERYTIME_PERIOD"]; } else {_oDeliveryTime.period=global::System.String.Empty; }
                _oDeliveryTime.SetDB(x_oDB);
                _oDeliveryTime.GetFound();
                _oRow.Add(_oDeliveryTime);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( DeliveryTime.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,DeliveryTime.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(DeliveryTime.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(DeliveryTime.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [DeliveryTime].[active] AS DELIVERYTIME_ACTIVE,[DeliveryTime].[cdate] AS DELIVERYTIME_CDATE,[DeliveryTime].[cid] AS DELIVERYTIME_CID,[DeliveryTime].[location] AS DELIVERYTIME_LOCATION,[DeliveryTime].[id] AS DELIVERYTIME_ID,[DeliveryTime].[period] AS DELIVERYTIME_PERIOD  FROM  [DeliveryTime]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"DeliveryTime");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,global::System.Nullable<bool> x_bActive,string x_sPeriod)
        {
            DeliveryTime _oDeliveryTime=DeliveryTimeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oDeliveryTime.cdate=x_dCdate;
            _oDeliveryTime.cid=x_sCid;
            _oDeliveryTime.location=x_sLocation;
            _oDeliveryTime.active=x_bActive;
            _oDeliveryTime.period=x_sPeriod;
            return InsertWithOutLastID(n_oDB, _oDeliveryTime);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,global::System.Nullable<bool> x_bActive,string x_sPeriod)
        {
            DeliveryTime _oDeliveryTime=DeliveryTimeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryTime.cdate=x_dCdate;
            _oDeliveryTime.cid=x_sCid;
            _oDeliveryTime.location=x_sLocation;
            _oDeliveryTime.active=x_bActive;
            _oDeliveryTime.period=x_sPeriod;
            return InsertWithOutLastID(x_oDB, _oDeliveryTime);
        }
        
        
        public bool Insert(DeliveryTime x_oDeliveryTime)
        {
            return InsertWithOutLastID(n_oDB, x_oDeliveryTime);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is DeliveryTime)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (DeliveryTime)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,DeliveryTime x_oDeliveryTime)
        {
            return InsertWithOutLastID(x_oDB, x_oDeliveryTime);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,DeliveryTime x_oDeliveryTime)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [DeliveryTime]   ([active],[cdate],[cid],[location],[period])  VALUES  (@active,@cdate,@cid,@location,@period)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oDeliveryTime);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DeliveryTime x_oDeliveryTime)
        {
            bool _bResult = false;
            if (!x_oDeliveryTime.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oDeliveryTime.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oDeliveryTime.active; }
                if(x_oDeliveryTime.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oDeliveryTime.cdate; }
                if(x_oDeliveryTime.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDeliveryTime.cid; }
                if(x_oDeliveryTime.location==null){  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value=x_oDeliveryTime.location; }
                if(x_oDeliveryTime.period==null){  x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar,5).Value=x_oDeliveryTime.period; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,global::System.Nullable<bool> x_bActive,string x_sPeriod)
        {
            int _oLastID;
            DeliveryTime _oDeliveryTime=DeliveryTimeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryTime.cdate=x_dCdate;
            _oDeliveryTime.cid=x_sCid;
            _oDeliveryTime.location=x_sLocation;
            _oDeliveryTime.active=x_bActive;
            _oDeliveryTime.period=x_sPeriod;
            if(InsertWithLastID(x_oDB, _oDeliveryTime,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(DeliveryTime x_oDeliveryTime)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oDeliveryTime, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, DeliveryTime x_oDeliveryTime)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oDeliveryTime, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DeliveryTime)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (DeliveryTime)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,DeliveryTime x_oDeliveryTime, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [DeliveryTime]   ([active],[cdate],[cid],[location],[period])  VALUES  (@active,@cdate,@cid,@location,@period)"+" SELECT  @@IDENTITY AS DeliveryTime_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oDeliveryTime,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DeliveryTime x_oDeliveryTime, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oDeliveryTime.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oDeliveryTime.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oDeliveryTime.active; }
                if(x_oDeliveryTime.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oDeliveryTime.cdate; }
                if(x_oDeliveryTime.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDeliveryTime.cid; }
                if(x_oDeliveryTime.location==null){  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value=x_oDeliveryTime.location; }
                if(x_oDeliveryTime.period==null){  x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar,5).Value=x_oDeliveryTime.period; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["DeliveryTime_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["DeliveryTime_LASTID"].ToString()) && int.TryParse(_oData["DeliveryTime_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,global::System.Nullable<bool> x_bActive,string x_sPeriod)
        {
            int _oLastID;
            DeliveryTime _oDeliveryTime=DeliveryTimeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryTime.cdate=x_dCdate;
            _oDeliveryTime.cid=x_sCid;
            _oDeliveryTime.location=x_sLocation;
            _oDeliveryTime.active=x_bActive;
            _oDeliveryTime.period=x_sPeriod;
            if(InsertWithLastID_SP(x_oDB, _oDeliveryTime,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(DeliveryTime x_oDeliveryTime)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oDeliveryTime, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DeliveryTime x_oDeliveryTime)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oDeliveryTime, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DeliveryTime)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (DeliveryTime)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,DeliveryTime x_oDeliveryTime, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "DELIVERYTIME";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oDeliveryTime,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DeliveryTime x_oDeliveryTime, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryTime.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryTime.active; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryTime.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oDeliveryTime.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryTime.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryTime.cid; }
                _oPar=x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryTime.location==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryTime.location; }
                _oPar=x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar,5);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryTime.period==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryTime.period; }
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
        
        #region INSERT_DELIVERYTIME Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-10-31>
        ///-- Description:	<Description,DELIVERYTIME, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_DELIVERYTIME Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_DELIVERYTIME', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_DELIVERYTIME;
        GO
        CREATE PROCEDURE INSERT_DELIVERYTIME
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @location nvarchar(100),
        @active bit,
        @period nvarchar(5)
        AS
        
        INSERT INTO  [DeliveryTime]   ([active],[cdate],[cid],[location],[period])  VALUES  (@active,@cdate,@cid,@location,@period)
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
            string _sQuery = "DELETE FROM  [DeliveryTime]  WHERE [DeliveryTime].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
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
            return DeliveryTimeRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [DeliveryTime]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
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
            string _sQuery = "DELETE FROM [DeliveryTime]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
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


