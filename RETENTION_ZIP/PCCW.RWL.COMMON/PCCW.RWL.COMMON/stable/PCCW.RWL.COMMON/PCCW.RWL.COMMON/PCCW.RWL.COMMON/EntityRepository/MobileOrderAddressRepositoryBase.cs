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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderAddress],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderAddress] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderAddress")]
    public class MobileOrderAddressRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderAddressRepositoryBase instance;
        public static MobileOrderAddressRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderAddressRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderAddressRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderAddressRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderAddressEntity> MobileOrderAddresss;
        #endregion
        
        #region Constructor
        public MobileOrderAddressRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderAddressRepositoryBase() { 
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
        public static MobileOrderAddress CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderAddress(_oDB);
        }
        
        public static MobileOrderAddress CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderAddress(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderAddress]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
        
        
        public MobileOrderAddressEntity GetObj(global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            return GetObj(n_oDB, x_iOrder_id,x_sAddress_type);
        }
        
        
        public static MobileOrderAddressEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            if (x_oDB==null) { return null; }
            MobileOrderAddress _MobileOrderAddress = (MobileOrderAddress)MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderAddress.Load(x_iOrder_id,x_sAddress_type)) { return null; }
            return _MobileOrderAddress;
        }
        
        
        public MobileOrderAddressEntity GetObj(global::System.Nullable<long> x_lAddress_id)
        {
            return GetObj(n_oDB, x_lAddress_id);
        }
        
        
        public static MobileOrderAddressEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lAddress_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderAddress _MobileOrderAddress = (MobileOrderAddress)MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderAddress.Load(x_lAddress_id)) { return null; }
            return _MobileOrderAddress;
        }
        
        
        
        public static MobileOrderAddressEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderAddressEntity> _oMobileOrderAddressList = GetListObj(x_oDB,0, "address_id", x_oArrayItemId);
            if(_oMobileOrderAddressList==null){ return null;}
            return _oMobileOrderAddressList.Count == 0 ? null : _oMobileOrderAddressList.ToArray();
        }
        
        public static List<MobileOrderAddressEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "address_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderAddressEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderAddressEntity> _oMobileOrderAddressList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderAddressList==null){ return null;}
            return _oMobileOrderAddressList.Count == 0 ? null : _oMobileOrderAddressList.ToArray();
        }
        
        
        public static MobileOrderAddressEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderAddressEntity> _oMobileOrderAddressList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderAddressList==null){ return null;}
            return _oMobileOrderAddressList.Count == 0 ? null : _oMobileOrderAddressList.ToArray();
        }
        
        public static List<MobileOrderAddressEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderAddressEntity> _oRow = new List<MobileOrderAddressEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderAddress].[d_build] AS MOBILEORDERADDRESS_D_BUILD,[MobileOrderAddress].[d_street] AS MOBILEORDERADDRESS_D_STREET,[MobileOrderAddress].[d_district] AS MOBILEORDERADDRESS_D_DISTRICT,[MobileOrderAddress].[d_region] AS MOBILEORDERADDRESS_D_REGION,[MobileOrderAddress].[d_floor] AS MOBILEORDERADDRESS_D_FLOOR,[MobileOrderAddress].[d_room] AS MOBILEORDERADDRESS_D_ROOM,[MobileOrderAddress].[order_id] AS MOBILEORDERADDRESS_ORDER_ID,[MobileOrderAddress].[address_type] AS MOBILEORDERADDRESS_ADDRESS_TYPE,[MobileOrderAddress].[d_type] AS MOBILEORDERADDRESS_D_TYPE,[MobileOrderAddress].[address_id] AS MOBILEORDERADDRESS_ADDRESS_ID,[MobileOrderAddress].[d_blk] AS MOBILEORDERADDRESS_D_BLK  FROM  [MobileOrderAddress]";
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
                _sQuery += " WHERE [MobileOrderAddress].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderAddress _oMobileOrderAddress = MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_STREET"])) {_oMobileOrderAddress.d_street = (string)_oData["MOBILEORDERADDRESS_D_STREET"]; }else{_oMobileOrderAddress.d_street=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_ID"])) {_oMobileOrderAddress.address_id = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESS_ADDRESS_ID"]; }else{_oMobileOrderAddress.address_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_REGION"])) {_oMobileOrderAddress.d_region = (string)_oData["MOBILEORDERADDRESS_D_REGION"]; }else{_oMobileOrderAddress.d_region=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_FLOOR"])) {_oMobileOrderAddress.d_floor = (string)_oData["MOBILEORDERADDRESS_D_FLOOR"]; }else{_oMobileOrderAddress.d_floor=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BUILD"])) {_oMobileOrderAddress.d_build = (string)_oData["MOBILEORDERADDRESS_D_BUILD"]; }else{_oMobileOrderAddress.d_build=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_ROOM"])) {_oMobileOrderAddress.d_room = (string)_oData["MOBILEORDERADDRESS_D_ROOM"]; }else{_oMobileOrderAddress.d_room=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ORDER_ID"])) {_oMobileOrderAddress.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESS_ORDER_ID"]; }else{_oMobileOrderAddress.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"])) {_oMobileOrderAddress.address_type = (string)_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"]; }else{_oMobileOrderAddress.address_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_TYPE"])) {_oMobileOrderAddress.d_type = (string)_oData["MOBILEORDERADDRESS_D_TYPE"]; }else{_oMobileOrderAddress.d_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_DISTRICT"])) {_oMobileOrderAddress.d_district = (string)_oData["MOBILEORDERADDRESS_D_DISTRICT"]; }else{_oMobileOrderAddress.d_district=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BLK"])) {_oMobileOrderAddress.d_blk = (string)_oData["MOBILEORDERADDRESS_D_BLK"]; }else{_oMobileOrderAddress.d_blk=global::System.String.Empty;}
                        _oMobileOrderAddress.SetDB(x_oDB);
                        _oMobileOrderAddress.GetFound();
                        _oRow.Add(_oMobileOrderAddress);
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
        
        
        public static MobileOrderAddressEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderAddressEntity> _oMobileOrderAddressList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderAddressList==null){ return null;}
            return _oMobileOrderAddressList.Count == 0 ? null : _oMobileOrderAddressList.ToArray();
        }
        
        
        public static MobileOrderAddressEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderAddressEntity> _oMobileOrderAddressList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderAddressList==null){ return null;}
            return _oMobileOrderAddressList.Count == 0 ? null : _oMobileOrderAddressList.ToArray();
        }
        
        public static List<MobileOrderAddressEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderAddressEntity> _oRow = new List<MobileOrderAddressEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderAddress].[d_build] AS MOBILEORDERADDRESS_D_BUILD,[MobileOrderAddress].[d_street] AS MOBILEORDERADDRESS_D_STREET,[MobileOrderAddress].[d_district] AS MOBILEORDERADDRESS_D_DISTRICT,[MobileOrderAddress].[d_region] AS MOBILEORDERADDRESS_D_REGION,[MobileOrderAddress].[d_floor] AS MOBILEORDERADDRESS_D_FLOOR,[MobileOrderAddress].[d_room] AS MOBILEORDERADDRESS_D_ROOM,[MobileOrderAddress].[order_id] AS MOBILEORDERADDRESS_ORDER_ID,[MobileOrderAddress].[address_type] AS MOBILEORDERADDRESS_ADDRESS_TYPE,[MobileOrderAddress].[d_type] AS MOBILEORDERADDRESS_D_TYPE,[MobileOrderAddress].[address_id] AS MOBILEORDERADDRESS_ADDRESS_ID,[MobileOrderAddress].[d_blk] AS MOBILEORDERADDRESS_D_BLK";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderAddressRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderAddressEntity _oMobileOrderAddress = MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_STREET"])) {_oMobileOrderAddress.d_street = (string)_oData["MOBILEORDERADDRESS_D_STREET"]; } else {_oMobileOrderAddress.d_street=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_ID"])) {_oMobileOrderAddress.address_id = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESS_ADDRESS_ID"]; } else {_oMobileOrderAddress.address_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_REGION"])) {_oMobileOrderAddress.d_region = (string)_oData["MOBILEORDERADDRESS_D_REGION"]; } else {_oMobileOrderAddress.d_region=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_FLOOR"])) {_oMobileOrderAddress.d_floor = (string)_oData["MOBILEORDERADDRESS_D_FLOOR"]; } else {_oMobileOrderAddress.d_floor=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BUILD"])) {_oMobileOrderAddress.d_build = (string)_oData["MOBILEORDERADDRESS_D_BUILD"]; } else {_oMobileOrderAddress.d_build=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_ROOM"])) {_oMobileOrderAddress.d_room = (string)_oData["MOBILEORDERADDRESS_D_ROOM"]; } else {_oMobileOrderAddress.d_room=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ORDER_ID"])) {_oMobileOrderAddress.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESS_ORDER_ID"]; } else {_oMobileOrderAddress.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"])) {_oMobileOrderAddress.address_type = (string)_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"]; } else {_oMobileOrderAddress.address_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_TYPE"])) {_oMobileOrderAddress.d_type = (string)_oData["MOBILEORDERADDRESS_D_TYPE"]; } else {_oMobileOrderAddress.d_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_DISTRICT"])) {_oMobileOrderAddress.d_district = (string)_oData["MOBILEORDERADDRESS_D_DISTRICT"]; } else {_oMobileOrderAddress.d_district=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BLK"])) {_oMobileOrderAddress.d_blk = (string)_oData["MOBILEORDERADDRESS_D_BLK"]; } else {_oMobileOrderAddress.d_blk=global::System.String.Empty; }
                _oMobileOrderAddress.SetDB(x_oDB);
                _oMobileOrderAddress.GetFound();
                _oRow.Add(_oMobileOrderAddress);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderAddress.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderAddress.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderAddress.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderAddress.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderAddress].[d_build] AS MOBILEORDERADDRESS_D_BUILD,[MobileOrderAddress].[d_street] AS MOBILEORDERADDRESS_D_STREET,[MobileOrderAddress].[d_district] AS MOBILEORDERADDRESS_D_DISTRICT,[MobileOrderAddress].[d_region] AS MOBILEORDERADDRESS_D_REGION,[MobileOrderAddress].[d_floor] AS MOBILEORDERADDRESS_D_FLOOR,[MobileOrderAddress].[d_room] AS MOBILEORDERADDRESS_D_ROOM,[MobileOrderAddress].[order_id] AS MOBILEORDERADDRESS_ORDER_ID,[MobileOrderAddress].[address_type] AS MOBILEORDERADDRESS_ADDRESS_TYPE,[MobileOrderAddress].[d_type] AS MOBILEORDERADDRESS_D_TYPE,[MobileOrderAddress].[address_id] AS MOBILEORDERADDRESS_ADDRESS_ID,[MobileOrderAddress].[d_blk] AS MOBILEORDERADDRESS_D_BLK  FROM  [MobileOrderAddress]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderAddress");
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
        
        public bool Insert(string x_sD_street,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            MobileOrderAddress _oMobileOrderAddress=MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderAddress.d_street=x_sD_street;
            _oMobileOrderAddress.d_region=x_sD_region;
            _oMobileOrderAddress.d_floor=x_sD_floor;
            _oMobileOrderAddress.d_build=x_sD_build;
            _oMobileOrderAddress.d_room=x_sD_room;
            _oMobileOrderAddress.order_id=x_iOrder_id;
            _oMobileOrderAddress.address_type=x_sAddress_type;
            _oMobileOrderAddress.d_type=x_sD_type;
            _oMobileOrderAddress.d_district=x_sD_district;
            _oMobileOrderAddress.d_blk=x_sD_blk;
            return InsertWithOutLastID(n_oDB, _oMobileOrderAddress);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sD_street,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            MobileOrderAddress _oMobileOrderAddress=MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderAddress.d_street=x_sD_street;
            _oMobileOrderAddress.d_region=x_sD_region;
            _oMobileOrderAddress.d_floor=x_sD_floor;
            _oMobileOrderAddress.d_build=x_sD_build;
            _oMobileOrderAddress.d_room=x_sD_room;
            _oMobileOrderAddress.order_id=x_iOrder_id;
            _oMobileOrderAddress.address_type=x_sAddress_type;
            _oMobileOrderAddress.d_type=x_sD_type;
            _oMobileOrderAddress.d_district=x_sD_district;
            _oMobileOrderAddress.d_blk=x_sD_blk;
            return InsertWithOutLastID(x_oDB, _oMobileOrderAddress);
        }
        
        
        public bool Insert(MobileOrderAddress x_oMobileOrderAddress)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderAddress);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderAddress)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderAddress)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderAddress x_oMobileOrderAddress)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderAddress);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderAddress x_oMobileOrderAddress)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderAddress]   ([d_build],[d_street],[d_district],[d_region],[d_floor],[d_room],[order_id],[address_type],[d_type],[d_blk])  VALUES  (@d_build,@d_street,@d_district,@d_region,@d_floor,@d_room,@order_id,@address_type,@d_type,@d_blk)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderAddress);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderAddress x_oMobileOrderAddress)
        {
            bool _bResult = false;
            if (!x_oMobileOrderAddress.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderAddress.d_build==null){  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddress.d_build; }
                if(x_oMobileOrderAddress.d_street==null){  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddress.d_street; }
                if(x_oMobileOrderAddress.d_district==null){  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddress.d_district; }
                if(x_oMobileOrderAddress.d_region==null){  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_region; }
                if(x_oMobileOrderAddress.d_floor==null){  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_floor; }
                if(x_oMobileOrderAddress.d_room==null){  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_room; }
                if(x_oMobileOrderAddress.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderAddress.order_id; }
                if(x_oMobileOrderAddress.address_type==null){  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.address_type; }
                if(x_oMobileOrderAddress.d_type==null){  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_type; }
                if(x_oMobileOrderAddress.d_blk==null){  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_blk; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sD_street,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            int _oLastID;
            MobileOrderAddress _oMobileOrderAddress=MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderAddress.d_street=x_sD_street;
            _oMobileOrderAddress.d_region=x_sD_region;
            _oMobileOrderAddress.d_floor=x_sD_floor;
            _oMobileOrderAddress.d_build=x_sD_build;
            _oMobileOrderAddress.d_room=x_sD_room;
            _oMobileOrderAddress.order_id=x_iOrder_id;
            _oMobileOrderAddress.address_type=x_sAddress_type;
            _oMobileOrderAddress.d_type=x_sD_type;
            _oMobileOrderAddress.d_district=x_sD_district;
            _oMobileOrderAddress.d_blk=x_sD_blk;
            if(InsertWithLastID(x_oDB, _oMobileOrderAddress,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderAddress x_oMobileOrderAddress)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderAddress, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderAddress x_oMobileOrderAddress)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderAddress, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderAddress)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderAddress)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderAddress x_oMobileOrderAddress, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderAddress]   ([d_build],[d_street],[d_district],[d_region],[d_floor],[d_room],[order_id],[address_type],[d_type],[d_blk])  VALUES  (@d_build,@d_street,@d_district,@d_region,@d_floor,@d_room,@order_id,@address_type,@d_type,@d_blk)"+" SELECT  @@IDENTITY AS MobileOrderAddress_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderAddress,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderAddress x_oMobileOrderAddress, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderAddress.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderAddress.d_build==null){  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddress.d_build; }
                if(x_oMobileOrderAddress.d_street==null){  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddress.d_street; }
                if(x_oMobileOrderAddress.d_district==null){  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddress.d_district; }
                if(x_oMobileOrderAddress.d_region==null){  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_region; }
                if(x_oMobileOrderAddress.d_floor==null){  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_floor; }
                if(x_oMobileOrderAddress.d_room==null){  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_room; }
                if(x_oMobileOrderAddress.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderAddress.order_id; }
                if(x_oMobileOrderAddress.address_type==null){  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.address_type; }
                if(x_oMobileOrderAddress.d_type==null){  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_type; }
                if(x_oMobileOrderAddress.d_blk==null){  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddress.d_blk; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderAddress_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderAddress_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderAddress_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sD_street,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            int _oLastID;
            MobileOrderAddress _oMobileOrderAddress=MobileOrderAddressRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderAddress.d_street=x_sD_street;
            _oMobileOrderAddress.d_region=x_sD_region;
            _oMobileOrderAddress.d_floor=x_sD_floor;
            _oMobileOrderAddress.d_build=x_sD_build;
            _oMobileOrderAddress.d_room=x_sD_room;
            _oMobileOrderAddress.order_id=x_iOrder_id;
            _oMobileOrderAddress.address_type=x_sAddress_type;
            _oMobileOrderAddress.d_type=x_sD_type;
            _oMobileOrderAddress.d_district=x_sD_district;
            _oMobileOrderAddress.d_blk=x_sD_blk;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderAddress,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderAddress x_oMobileOrderAddress)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderAddress, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderAddress x_oMobileOrderAddress)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderAddress, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderAddress)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderAddress)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderAddress x_oMobileOrderAddress, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERADDRESS";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderAddress,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderAddress x_oMobileOrderAddress, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_build==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_build; }
                _oPar=x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_street==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_street; }
                _oPar=x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_district==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_district; }
                _oPar=x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_region==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_region; }
                _oPar=x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_floor==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_floor; }
                _oPar=x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_room==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_room; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.order_id; }
                _oPar=x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.address_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.address_type; }
                _oPar=x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_type; }
                _oPar=x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddress.d_blk==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddress.d_blk; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ADDRESS_ID", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ADDRESS_ID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERADDRESS Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERADDRESS, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERADDRESS Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERADDRESS', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERADDRESS;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERADDRESS
        	-- Add the parameters for the stored procedure here
        @RETURN_ADDRESS_ID bigint output,
        @d_street nvarchar(250),
        @d_region nvarchar(50),
        @d_floor nvarchar(50),
        @d_build nvarchar(250),
        @d_room nvarchar(50),
        @order_id int,
        @address_type nvarchar(50),
        @d_type nvarchar(50),
        @d_district nvarchar(250),
        @d_blk nvarchar(50)
        AS
        
        INSERT INTO  [MobileOrderAddress]   ([d_build],[d_street],[d_district],[d_region],[d_floor],[d_room],[order_id],[address_type],[d_type],[d_blk])  VALUES  (@d_build,@d_street,@d_district,@d_region,@d_floor,@d_room,@order_id,@address_type,@d_type,@d_blk)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ADDRESS_ID=@@IDENTITY
        RETURN @RETURN_ADDRESS_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ADDRESS_ID=-1
        RETURN @RETURN_ADDRESS_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            return DeleteProc(n_oDB, x_iOrder_id,x_sAddress_type);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            return DeleteProc(x_oDB, x_iOrder_id,x_sAddress_type);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            if (x_iOrder_id==null) { return false; }
            if (x_sAddress_type==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderAddress]  WHERE [MobileOrderAddress].[order_id]=@order_id AND [MobileOrderAddress].[address_type]=@address_type";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = x_iOrder_id;
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
        
        public bool Delete(global::System.Nullable<long> x_lAddress_id)
        {
            return DeleteProc(n_oDB, x_lAddress_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lAddress_id)
        {
            return DeleteProc(x_oDB, x_lAddress_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lAddress_id)
        {
            if (x_lAddress_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderAddress]  WHERE [MobileOrderAddress].[address_id]=@address_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value = x_lAddress_id;
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
            return MobileOrderAddressRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderAddress]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderAddress]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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


