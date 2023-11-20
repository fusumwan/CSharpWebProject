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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryLocation],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [DeliveryLocation] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"DeliveryLocation")]
    public class DeliveryLocationRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static DeliveryLocationRepositoryBase instance;
        public static DeliveryLocationRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new DeliveryLocationRepositoryBase(_oDB);
            }
            return instance;
        }
        public static DeliveryLocationRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new DeliveryLocationRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<DeliveryLocationEntity> DeliveryLocations;
        #endregion
        
        #region Constructor
        public DeliveryLocationRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~DeliveryLocationRepositoryBase() { 
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
        public static DeliveryLocation CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new DeliveryLocation(_oDB);
        }
        
        public static DeliveryLocation CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new DeliveryLocation(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [DeliveryLocation]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
        
        
        public DeliveryLocationEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static DeliveryLocationEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            DeliveryLocation _DeliveryLocation = (DeliveryLocation)DeliveryLocationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_DeliveryLocation.Load(x_iId)) { return null; }
            return _DeliveryLocation;
        }
        
        
        
        public static DeliveryLocationEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<DeliveryLocationEntity> _oDeliveryLocationList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oDeliveryLocationList==null){ return null;}
            return _oDeliveryLocationList.Count == 0 ? null : _oDeliveryLocationList.ToArray();
        }
        
        public static List<DeliveryLocationEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static DeliveryLocationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DeliveryLocationEntity> _oDeliveryLocationList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oDeliveryLocationList==null){ return null;}
            return _oDeliveryLocationList.Count == 0 ? null : _oDeliveryLocationList.ToArray();
        }
        
        
        public static DeliveryLocationEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DeliveryLocationEntity> _oDeliveryLocationList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oDeliveryLocationList==null){ return null;}
            return _oDeliveryLocationList.Count == 0 ? null : _oDeliveryLocationList.ToArray();
        }
        
        public static List<DeliveryLocationEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<DeliveryLocationEntity> _oRow = new List<DeliveryLocationEntity>();
            string _sQuery = "SELECT  "+_sTop+" [DeliveryLocation].[active] AS DELIVERYLOCATION_ACTIVE,[DeliveryLocation].[cdate] AS DELIVERYLOCATION_CDATE,[DeliveryLocation].[cid] AS DELIVERYLOCATION_CID,[DeliveryLocation].[location] AS DELIVERYLOCATION_LOCATION,[DeliveryLocation].[fee] AS DELIVERYLOCATION_FEE,[DeliveryLocation].[area] AS DELIVERYLOCATION_AREA,[DeliveryLocation].[id] AS DELIVERYLOCATION_ID  FROM  [DeliveryLocation]";
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
                _sQuery += " WHERE [DeliveryLocation].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        DeliveryLocation _oDeliveryLocation = DeliveryLocationRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ID"])) {_oDeliveryLocation.id = (global::System.Nullable<int>)_oData["DELIVERYLOCATION_ID"]; }else{_oDeliveryLocation.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CDATE"])) {_oDeliveryLocation.cdate = (global::System.Nullable<DateTime>)_oData["DELIVERYLOCATION_CDATE"]; }else{_oDeliveryLocation.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CID"])) {_oDeliveryLocation.cid = (string)_oData["DELIVERYLOCATION_CID"]; }else{_oDeliveryLocation.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_LOCATION"])) {_oDeliveryLocation.location = (string)_oData["DELIVERYLOCATION_LOCATION"]; }else{_oDeliveryLocation.location=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_FEE"])) {_oDeliveryLocation.fee = (string)_oData["DELIVERYLOCATION_FEE"]; }else{_oDeliveryLocation.fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_AREA"])) {_oDeliveryLocation.area = (string)_oData["DELIVERYLOCATION_AREA"]; }else{_oDeliveryLocation.area=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ACTIVE"])) {_oDeliveryLocation.active = (global::System.Nullable<bool>)_oData["DELIVERYLOCATION_ACTIVE"]; }else{_oDeliveryLocation.active=null;}
                        _oDeliveryLocation.SetDB(x_oDB);
                        _oDeliveryLocation.GetFound();
                        _oRow.Add(_oDeliveryLocation);
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
        
        
        public static DeliveryLocationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DeliveryLocationEntity> _oDeliveryLocationList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oDeliveryLocationList==null){ return null;}
            return _oDeliveryLocationList.Count == 0 ? null : _oDeliveryLocationList.ToArray();
        }
        
        
        public static DeliveryLocationEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DeliveryLocationEntity> _oDeliveryLocationList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oDeliveryLocationList==null){ return null;}
            return _oDeliveryLocationList.Count == 0 ? null : _oDeliveryLocationList.ToArray();
        }
        
        public static List<DeliveryLocationEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<DeliveryLocationEntity> _oRow = new List<DeliveryLocationEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[DeliveryLocation].[active] AS DELIVERYLOCATION_ACTIVE,[DeliveryLocation].[cdate] AS DELIVERYLOCATION_CDATE,[DeliveryLocation].[cid] AS DELIVERYLOCATION_CID,[DeliveryLocation].[location] AS DELIVERYLOCATION_LOCATION,[DeliveryLocation].[fee] AS DELIVERYLOCATION_FEE,[DeliveryLocation].[area] AS DELIVERYLOCATION_AREA,[DeliveryLocation].[id] AS DELIVERYLOCATION_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = DeliveryLocationRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                DeliveryLocationEntity _oDeliveryLocation = DeliveryLocationRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ID"])) {_oDeliveryLocation.id = (global::System.Nullable<int>)_oData["DELIVERYLOCATION_ID"]; } else {_oDeliveryLocation.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CDATE"])) {_oDeliveryLocation.cdate = (global::System.Nullable<DateTime>)_oData["DELIVERYLOCATION_CDATE"]; } else {_oDeliveryLocation.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CID"])) {_oDeliveryLocation.cid = (string)_oData["DELIVERYLOCATION_CID"]; } else {_oDeliveryLocation.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_LOCATION"])) {_oDeliveryLocation.location = (string)_oData["DELIVERYLOCATION_LOCATION"]; } else {_oDeliveryLocation.location=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_FEE"])) {_oDeliveryLocation.fee = (string)_oData["DELIVERYLOCATION_FEE"]; } else {_oDeliveryLocation.fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_AREA"])) {_oDeliveryLocation.area = (string)_oData["DELIVERYLOCATION_AREA"]; } else {_oDeliveryLocation.area=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ACTIVE"])) {_oDeliveryLocation.active = (global::System.Nullable<bool>)_oData["DELIVERYLOCATION_ACTIVE"]; } else {_oDeliveryLocation.active=null; }
                _oDeliveryLocation.SetDB(x_oDB);
                _oDeliveryLocation.GetFound();
                _oRow.Add(_oDeliveryLocation);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( DeliveryLocation.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,DeliveryLocation.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(DeliveryLocation.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(DeliveryLocation.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [DeliveryLocation].[active] AS DELIVERYLOCATION_ACTIVE,[DeliveryLocation].[cdate] AS DELIVERYLOCATION_CDATE,[DeliveryLocation].[cid] AS DELIVERYLOCATION_CID,[DeliveryLocation].[location] AS DELIVERYLOCATION_LOCATION,[DeliveryLocation].[fee] AS DELIVERYLOCATION_FEE,[DeliveryLocation].[area] AS DELIVERYLOCATION_AREA,[DeliveryLocation].[id] AS DELIVERYLOCATION_ID  FROM  [DeliveryLocation]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"DeliveryLocation");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,string x_sFee,string x_sArea,global::System.Nullable<bool> x_bActive)
        {
            DeliveryLocation _oDeliveryLocation=DeliveryLocationRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oDeliveryLocation.cdate=x_dCdate;
            _oDeliveryLocation.cid=x_sCid;
            _oDeliveryLocation.location=x_sLocation;
            _oDeliveryLocation.fee=x_sFee;
            _oDeliveryLocation.area=x_sArea;
            _oDeliveryLocation.active=x_bActive;
            return InsertWithOutLastID(n_oDB, _oDeliveryLocation);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,string x_sFee,string x_sArea,global::System.Nullable<bool> x_bActive)
        {
            DeliveryLocation _oDeliveryLocation=DeliveryLocationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryLocation.cdate=x_dCdate;
            _oDeliveryLocation.cid=x_sCid;
            _oDeliveryLocation.location=x_sLocation;
            _oDeliveryLocation.fee=x_sFee;
            _oDeliveryLocation.area=x_sArea;
            _oDeliveryLocation.active=x_bActive;
            return InsertWithOutLastID(x_oDB, _oDeliveryLocation);
        }
        
        
        public bool Insert(DeliveryLocation x_oDeliveryLocation)
        {
            return InsertWithOutLastID(n_oDB, x_oDeliveryLocation);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is DeliveryLocation)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (DeliveryLocation)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,DeliveryLocation x_oDeliveryLocation)
        {
            return InsertWithOutLastID(x_oDB, x_oDeliveryLocation);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,DeliveryLocation x_oDeliveryLocation)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [DeliveryLocation]   ([active],[cdate],[cid],[location],[fee],[area])  VALUES  (@active,@cdate,@cid,@location,@fee,@area)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oDeliveryLocation);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DeliveryLocation x_oDeliveryLocation)
        {
            bool _bResult = false;
            if (!x_oDeliveryLocation.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oDeliveryLocation.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oDeliveryLocation.active; }
                if(x_oDeliveryLocation.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oDeliveryLocation.cdate; }
                if(x_oDeliveryLocation.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDeliveryLocation.cid; }
                if(x_oDeliveryLocation.location==null){  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value=x_oDeliveryLocation.location; }
                if(x_oDeliveryLocation.fee==null){  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDeliveryLocation.fee; }
                if(x_oDeliveryLocation.area==null){  x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100).Value=x_oDeliveryLocation.area; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,string x_sFee,string x_sArea,global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            DeliveryLocation _oDeliveryLocation=DeliveryLocationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryLocation.cdate=x_dCdate;
            _oDeliveryLocation.cid=x_sCid;
            _oDeliveryLocation.location=x_sLocation;
            _oDeliveryLocation.fee=x_sFee;
            _oDeliveryLocation.area=x_sArea;
            _oDeliveryLocation.active=x_bActive;
            if(InsertWithLastID(x_oDB, _oDeliveryLocation,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(DeliveryLocation x_oDeliveryLocation)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oDeliveryLocation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, DeliveryLocation x_oDeliveryLocation)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oDeliveryLocation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DeliveryLocation)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (DeliveryLocation)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,DeliveryLocation x_oDeliveryLocation, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [DeliveryLocation]   ([active],[cdate],[cid],[location],[fee],[area])  VALUES  (@active,@cdate,@cid,@location,@fee,@area)"+" SELECT  @@IDENTITY AS DeliveryLocation_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oDeliveryLocation,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DeliveryLocation x_oDeliveryLocation, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oDeliveryLocation.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oDeliveryLocation.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oDeliveryLocation.active; }
                if(x_oDeliveryLocation.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oDeliveryLocation.cdate; }
                if(x_oDeliveryLocation.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDeliveryLocation.cid; }
                if(x_oDeliveryLocation.location==null){  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value=x_oDeliveryLocation.location; }
                if(x_oDeliveryLocation.fee==null){  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDeliveryLocation.fee; }
                if(x_oDeliveryLocation.area==null){  x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100).Value=x_oDeliveryLocation.area; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["DeliveryLocation_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["DeliveryLocation_LASTID"].ToString()) && int.TryParse(_oData["DeliveryLocation_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,string x_sFee,string x_sArea,global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            DeliveryLocation _oDeliveryLocation=DeliveryLocationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryLocation.cdate=x_dCdate;
            _oDeliveryLocation.cid=x_sCid;
            _oDeliveryLocation.location=x_sLocation;
            _oDeliveryLocation.fee=x_sFee;
            _oDeliveryLocation.area=x_sArea;
            _oDeliveryLocation.active=x_bActive;
            if(InsertWithLastID_SP(x_oDB, _oDeliveryLocation,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(DeliveryLocation x_oDeliveryLocation)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oDeliveryLocation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DeliveryLocation x_oDeliveryLocation)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oDeliveryLocation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DeliveryLocation)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (DeliveryLocation)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,DeliveryLocation x_oDeliveryLocation, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "DELIVERYLOCATION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oDeliveryLocation,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DeliveryLocation x_oDeliveryLocation, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryLocation.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryLocation.active; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryLocation.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oDeliveryLocation.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryLocation.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryLocation.cid; }
                _oPar=x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryLocation.location==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryLocation.location; }
                _oPar=x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryLocation.fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryLocation.fee; }
                _oPar=x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDeliveryLocation.area==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDeliveryLocation.area; }
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
        
        #region INSERT_DELIVERYLOCATION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-10-31>
        ///-- Description:	<Description,DELIVERYLOCATION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_DELIVERYLOCATION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_DELIVERYLOCATION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_DELIVERYLOCATION;
        GO
        CREATE PROCEDURE INSERT_DELIVERYLOCATION
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @location nvarchar(100),
        @fee nvarchar(50),
        @area nvarchar(100),
        @active bit
        AS
        
        INSERT INTO  [DeliveryLocation]   ([active],[cdate],[cid],[location],[fee],[area])  VALUES  (@active,@cdate,@cid,@location,@fee,@area)
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
            string _sQuery = "DELETE FROM  [DeliveryLocation]  WHERE [DeliveryLocation].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
            return DeliveryLocationRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [DeliveryLocation]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
            string _sQuery = "DELETE FROM [DeliveryLocation]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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


