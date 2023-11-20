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
///-- Description:	<Description,Table :[MobileOrderAddressRevision],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderAddressRevision] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderAddressRevision")]
    public class MobileOrderAddressRevisionRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderAddressRevisionRepositoryBase instance;
        public static MobileOrderAddressRevisionRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderAddressRevisionRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderAddressRevisionRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderAddressRevisionRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderAddressRevisionEntity> MobileOrderAddressRevisions;
        #endregion
        
        #region Constructor
        public MobileOrderAddressRevisionRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderAddressRevisionRepositoryBase() { 
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
        public static MobileOrderAddressRevision CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderAddressRevision(_oDB);
        }
        
        public static MobileOrderAddressRevision CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderAddressRevision(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderAddressRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
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
        
        
        public MobileOrderAddressRevisionEntity GetObj(global::System.Nullable<long> x_lMid)
        {
            return GetObj(n_oDB, x_lMid);
        }
        
        
        public static MobileOrderAddressRevisionEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderAddressRevision _MobileOrderAddressRevision = (MobileOrderAddressRevision)MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderAddressRevision.Load(x_lMid)) { return null; }
            return _MobileOrderAddressRevision;
        }
        
        
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderAddressRevisionList==null){ return null;}
            return _oMobileOrderAddressRevisionList.Count == 0 ? null : _oMobileOrderAddressRevisionList.ToArray();
        }
        
        public static List<MobileOrderAddressRevisionEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderAddressRevisionList==null){ return null;}
            return _oMobileOrderAddressRevisionList.Count == 0 ? null : _oMobileOrderAddressRevisionList.ToArray();
        }
        
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderAddressRevisionList==null){ return null;}
            return _oMobileOrderAddressRevisionList.Count == 0 ? null : _oMobileOrderAddressRevisionList.ToArray();
        }
        
        public static List<MobileOrderAddressRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderAddressRevisionEntity> _oRow = new List<MobileOrderAddressRevisionEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderAddressRevision].[d_build] AS MOBILEORDERADDRESSREVISION_D_BUILD,[MobileOrderAddressRevision].[d_street] AS MOBILEORDERADDRESSREVISION_D_STREET,[MobileOrderAddressRevision].[d_district] AS MOBILEORDERADDRESSREVISION_D_DISTRICT,[MobileOrderAddressRevision].[d_region] AS MOBILEORDERADDRESSREVISION_D_REGION,[MobileOrderAddressRevision].[d_floor] AS MOBILEORDERADDRESSREVISION_D_FLOOR,[MobileOrderAddressRevision].[d_room] AS MOBILEORDERADDRESSREVISION_D_ROOM,[MobileOrderAddressRevision].[order_id] AS MOBILEORDERADDRESSREVISION_ORDER_ID,[MobileOrderAddressRevision].[address_type] AS MOBILEORDERADDRESSREVISION_ADDRESS_TYPE,[MobileOrderAddressRevision].[d_type] AS MOBILEORDERADDRESSREVISION_D_TYPE,[MobileOrderAddressRevision].[address_id] AS MOBILEORDERADDRESSREVISION_ADDRESS_ID,[MobileOrderAddressRevision].[mid] AS MOBILEORDERADDRESSREVISION_MID,[MobileOrderAddressRevision].[d_blk] AS MOBILEORDERADDRESSREVISION_D_BLK  FROM  [MobileOrderAddressRevision]";
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
                _sQuery += " WHERE [MobileOrderAddressRevision].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderAddressRevision _oMobileOrderAddressRevision = MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_STREET"])) {_oMobileOrderAddressRevision.d_street = (string)_oData["MOBILEORDERADDRESSREVISION_D_STREET"]; }else{_oMobileOrderAddressRevision.d_street=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ADDRESS_ID"])) {_oMobileOrderAddressRevision.address_id = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESSREVISION_ADDRESS_ID"]; }else{_oMobileOrderAddressRevision.address_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_REGION"])) {_oMobileOrderAddressRevision.d_region = (string)_oData["MOBILEORDERADDRESSREVISION_D_REGION"]; }else{_oMobileOrderAddressRevision.d_region=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_FLOOR"])) {_oMobileOrderAddressRevision.d_floor = (string)_oData["MOBILEORDERADDRESSREVISION_D_FLOOR"]; }else{_oMobileOrderAddressRevision.d_floor=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_BUILD"])) {_oMobileOrderAddressRevision.d_build = (string)_oData["MOBILEORDERADDRESSREVISION_D_BUILD"]; }else{_oMobileOrderAddressRevision.d_build=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_ROOM"])) {_oMobileOrderAddressRevision.d_room = (string)_oData["MOBILEORDERADDRESSREVISION_D_ROOM"]; }else{_oMobileOrderAddressRevision.d_room=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ORDER_ID"])) {_oMobileOrderAddressRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESSREVISION_ORDER_ID"]; }else{_oMobileOrderAddressRevision.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ADDRESS_TYPE"])) {_oMobileOrderAddressRevision.address_type = (string)_oData["MOBILEORDERADDRESSREVISION_ADDRESS_TYPE"]; }else{_oMobileOrderAddressRevision.address_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_TYPE"])) {_oMobileOrderAddressRevision.d_type = (string)_oData["MOBILEORDERADDRESSREVISION_D_TYPE"]; }else{_oMobileOrderAddressRevision.d_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_DISTRICT"])) {_oMobileOrderAddressRevision.d_district = (string)_oData["MOBILEORDERADDRESSREVISION_D_DISTRICT"]; }else{_oMobileOrderAddressRevision.d_district=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_MID"])) {_oMobileOrderAddressRevision.mid = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESSREVISION_MID"]; }else{_oMobileOrderAddressRevision.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_BLK"])) {_oMobileOrderAddressRevision.d_blk = (string)_oData["MOBILEORDERADDRESSREVISION_D_BLK"]; }else{_oMobileOrderAddressRevision.d_blk=global::System.String.Empty;}
                        _oMobileOrderAddressRevision.SetDB(x_oDB);
                        _oMobileOrderAddressRevision.GetFound();
                        _oRow.Add(_oMobileOrderAddressRevision);
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
        
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderAddressRevisionList==null){ return null;}
            return _oMobileOrderAddressRevisionList.Count == 0 ? null : _oMobileOrderAddressRevisionList.ToArray();
        }
        
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderAddressRevisionList==null){ return null;}
            return _oMobileOrderAddressRevisionList.Count == 0 ? null : _oMobileOrderAddressRevisionList.ToArray();
        }
        
        public static List<MobileOrderAddressRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderAddressRevisionEntity> _oRow = new List<MobileOrderAddressRevisionEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderAddressRevision].[d_build] AS MOBILEORDERADDRESSREVISION_D_BUILD,[MobileOrderAddressRevision].[d_street] AS MOBILEORDERADDRESSREVISION_D_STREET,[MobileOrderAddressRevision].[d_district] AS MOBILEORDERADDRESSREVISION_D_DISTRICT,[MobileOrderAddressRevision].[d_region] AS MOBILEORDERADDRESSREVISION_D_REGION,[MobileOrderAddressRevision].[d_floor] AS MOBILEORDERADDRESSREVISION_D_FLOOR,[MobileOrderAddressRevision].[d_room] AS MOBILEORDERADDRESSREVISION_D_ROOM,[MobileOrderAddressRevision].[order_id] AS MOBILEORDERADDRESSREVISION_ORDER_ID,[MobileOrderAddressRevision].[address_type] AS MOBILEORDERADDRESSREVISION_ADDRESS_TYPE,[MobileOrderAddressRevision].[d_type] AS MOBILEORDERADDRESSREVISION_D_TYPE,[MobileOrderAddressRevision].[address_id] AS MOBILEORDERADDRESSREVISION_ADDRESS_ID,[MobileOrderAddressRevision].[mid] AS MOBILEORDERADDRESSREVISION_MID,[MobileOrderAddressRevision].[d_blk] AS MOBILEORDERADDRESSREVISION_D_BLK";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderAddressRevisionRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderAddressRevisionEntity _oMobileOrderAddressRevision = MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_STREET"])) {_oMobileOrderAddressRevision.d_street = (string)_oData["MOBILEORDERADDRESSREVISION_D_STREET"]; } else {_oMobileOrderAddressRevision.d_street=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ADDRESS_ID"])) {_oMobileOrderAddressRevision.address_id = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESSREVISION_ADDRESS_ID"]; } else {_oMobileOrderAddressRevision.address_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_REGION"])) {_oMobileOrderAddressRevision.d_region = (string)_oData["MOBILEORDERADDRESSREVISION_D_REGION"]; } else {_oMobileOrderAddressRevision.d_region=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_FLOOR"])) {_oMobileOrderAddressRevision.d_floor = (string)_oData["MOBILEORDERADDRESSREVISION_D_FLOOR"]; } else {_oMobileOrderAddressRevision.d_floor=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_BUILD"])) {_oMobileOrderAddressRevision.d_build = (string)_oData["MOBILEORDERADDRESSREVISION_D_BUILD"]; } else {_oMobileOrderAddressRevision.d_build=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_ROOM"])) {_oMobileOrderAddressRevision.d_room = (string)_oData["MOBILEORDERADDRESSREVISION_D_ROOM"]; } else {_oMobileOrderAddressRevision.d_room=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ORDER_ID"])) {_oMobileOrderAddressRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESSREVISION_ORDER_ID"]; } else {_oMobileOrderAddressRevision.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ADDRESS_TYPE"])) {_oMobileOrderAddressRevision.address_type = (string)_oData["MOBILEORDERADDRESSREVISION_ADDRESS_TYPE"]; } else {_oMobileOrderAddressRevision.address_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_TYPE"])) {_oMobileOrderAddressRevision.d_type = (string)_oData["MOBILEORDERADDRESSREVISION_D_TYPE"]; } else {_oMobileOrderAddressRevision.d_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_DISTRICT"])) {_oMobileOrderAddressRevision.d_district = (string)_oData["MOBILEORDERADDRESSREVISION_D_DISTRICT"]; } else {_oMobileOrderAddressRevision.d_district=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_MID"])) {_oMobileOrderAddressRevision.mid = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESSREVISION_MID"]; } else {_oMobileOrderAddressRevision.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_BLK"])) {_oMobileOrderAddressRevision.d_blk = (string)_oData["MOBILEORDERADDRESSREVISION_D_BLK"]; } else {_oMobileOrderAddressRevision.d_blk=global::System.String.Empty; }
                _oMobileOrderAddressRevision.SetDB(x_oDB);
                _oMobileOrderAddressRevision.GetFound();
                _oRow.Add(_oMobileOrderAddressRevision);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderAddressRevision.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderAddressRevision.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderAddressRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderAddressRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderAddressRevision].[d_build] AS MOBILEORDERADDRESSREVISION_D_BUILD,[MobileOrderAddressRevision].[d_street] AS MOBILEORDERADDRESSREVISION_D_STREET,[MobileOrderAddressRevision].[d_district] AS MOBILEORDERADDRESSREVISION_D_DISTRICT,[MobileOrderAddressRevision].[d_region] AS MOBILEORDERADDRESSREVISION_D_REGION,[MobileOrderAddressRevision].[d_floor] AS MOBILEORDERADDRESSREVISION_D_FLOOR,[MobileOrderAddressRevision].[d_room] AS MOBILEORDERADDRESSREVISION_D_ROOM,[MobileOrderAddressRevision].[order_id] AS MOBILEORDERADDRESSREVISION_ORDER_ID,[MobileOrderAddressRevision].[address_type] AS MOBILEORDERADDRESSREVISION_ADDRESS_TYPE,[MobileOrderAddressRevision].[d_type] AS MOBILEORDERADDRESSREVISION_D_TYPE,[MobileOrderAddressRevision].[address_id] AS MOBILEORDERADDRESSREVISION_ADDRESS_ID,[MobileOrderAddressRevision].[mid] AS MOBILEORDERADDRESSREVISION_MID,[MobileOrderAddressRevision].[d_blk] AS MOBILEORDERADDRESSREVISION_D_BLK  FROM  [MobileOrderAddressRevision]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderAddressRevision");
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
        
        public bool Insert(string x_sD_street,global::System.Nullable<long> x_lAddress_id,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            MobileOrderAddressRevision _oMobileOrderAddressRevision=MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderAddressRevision.d_street=x_sD_street;
            _oMobileOrderAddressRevision.address_id=x_lAddress_id;
            _oMobileOrderAddressRevision.d_region=x_sD_region;
            _oMobileOrderAddressRevision.d_floor=x_sD_floor;
            _oMobileOrderAddressRevision.d_build=x_sD_build;
            _oMobileOrderAddressRevision.d_room=x_sD_room;
            _oMobileOrderAddressRevision.order_id=x_iOrder_id;
            _oMobileOrderAddressRevision.address_type=x_sAddress_type;
            _oMobileOrderAddressRevision.d_type=x_sD_type;
            _oMobileOrderAddressRevision.d_district=x_sD_district;
            _oMobileOrderAddressRevision.d_blk=x_sD_blk;
            return InsertWithOutLastID(n_oDB, _oMobileOrderAddressRevision);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sD_street,global::System.Nullable<long> x_lAddress_id,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            MobileOrderAddressRevision _oMobileOrderAddressRevision=MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderAddressRevision.d_street=x_sD_street;
            _oMobileOrderAddressRevision.address_id=x_lAddress_id;
            _oMobileOrderAddressRevision.d_region=x_sD_region;
            _oMobileOrderAddressRevision.d_floor=x_sD_floor;
            _oMobileOrderAddressRevision.d_build=x_sD_build;
            _oMobileOrderAddressRevision.d_room=x_sD_room;
            _oMobileOrderAddressRevision.order_id=x_iOrder_id;
            _oMobileOrderAddressRevision.address_type=x_sAddress_type;
            _oMobileOrderAddressRevision.d_type=x_sD_type;
            _oMobileOrderAddressRevision.d_district=x_sD_district;
            _oMobileOrderAddressRevision.d_blk=x_sD_blk;
            return InsertWithOutLastID(x_oDB, _oMobileOrderAddressRevision);
        }
        
        
        public bool Insert(MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderAddressRevision);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderAddressRevision)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderAddressRevision)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderAddressRevision);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderAddressRevision]   ([d_build],[d_street],[d_district],[d_region],[d_floor],[d_room],[order_id],[address_type],[d_type],[address_id],[d_blk])  VALUES  (@d_build,@d_street,@d_district,@d_region,@d_floor,@d_room,@order_id,@address_type,@d_type,@address_id,@d_blk)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderAddressRevision);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            bool _bResult = false;
            if (!x_oMobileOrderAddressRevision.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderAddressRevision.d_build==null){  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddressRevision.d_build; }
                if(x_oMobileOrderAddressRevision.d_street==null){  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddressRevision.d_street; }
                if(x_oMobileOrderAddressRevision.d_district==null){  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddressRevision.d_district; }
                if(x_oMobileOrderAddressRevision.d_region==null){  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_region; }
                if(x_oMobileOrderAddressRevision.d_floor==null){  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_floor; }
                if(x_oMobileOrderAddressRevision.d_room==null){  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_room; }
                if(x_oMobileOrderAddressRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderAddressRevision.order_id; }
                if(x_oMobileOrderAddressRevision.address_type==null){  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.address_type; }
                if(x_oMobileOrderAddressRevision.d_type==null){  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_type; }
                if(x_oMobileOrderAddressRevision.address_id==null){  x_oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderAddressRevision.address_id; }
                if(x_oMobileOrderAddressRevision.d_blk==null){  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_blk; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sD_street,global::System.Nullable<long> x_lAddress_id,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            int _oLastID;
            MobileOrderAddressRevision _oMobileOrderAddressRevision=MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderAddressRevision.d_street=x_sD_street;
            _oMobileOrderAddressRevision.address_id=x_lAddress_id;
            _oMobileOrderAddressRevision.d_region=x_sD_region;
            _oMobileOrderAddressRevision.d_floor=x_sD_floor;
            _oMobileOrderAddressRevision.d_build=x_sD_build;
            _oMobileOrderAddressRevision.d_room=x_sD_room;
            _oMobileOrderAddressRevision.order_id=x_iOrder_id;
            _oMobileOrderAddressRevision.address_type=x_sAddress_type;
            _oMobileOrderAddressRevision.d_type=x_sD_type;
            _oMobileOrderAddressRevision.d_district=x_sD_district;
            _oMobileOrderAddressRevision.d_blk=x_sD_blk;
            if(InsertWithLastID(x_oDB, _oMobileOrderAddressRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderAddressRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderAddressRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderAddressRevision)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderAddressRevision)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderAddressRevision x_oMobileOrderAddressRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderAddressRevision]   ([d_build],[d_street],[d_district],[d_region],[d_floor],[d_room],[order_id],[address_type],[d_type],[address_id],[d_blk])  VALUES  (@d_build,@d_street,@d_district,@d_region,@d_floor,@d_room,@order_id,@address_type,@d_type,@address_id,@d_blk)"+" SELECT  @@IDENTITY AS MobileOrderAddressRevision_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderAddressRevision,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderAddressRevision x_oMobileOrderAddressRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderAddressRevision.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderAddressRevision.d_build==null){  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddressRevision.d_build; }
                if(x_oMobileOrderAddressRevision.d_street==null){  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddressRevision.d_street; }
                if(x_oMobileOrderAddressRevision.d_district==null){  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderAddressRevision.d_district; }
                if(x_oMobileOrderAddressRevision.d_region==null){  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_region; }
                if(x_oMobileOrderAddressRevision.d_floor==null){  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_floor; }
                if(x_oMobileOrderAddressRevision.d_room==null){  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_room; }
                if(x_oMobileOrderAddressRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderAddressRevision.order_id; }
                if(x_oMobileOrderAddressRevision.address_type==null){  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.address_type; }
                if(x_oMobileOrderAddressRevision.d_type==null){  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_type; }
                if(x_oMobileOrderAddressRevision.address_id==null){  x_oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderAddressRevision.address_id; }
                if(x_oMobileOrderAddressRevision.d_blk==null){  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderAddressRevision.d_blk; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderAddressRevision_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderAddressRevision_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderAddressRevision_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sD_street,global::System.Nullable<long> x_lAddress_id,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            int _oLastID;
            MobileOrderAddressRevision _oMobileOrderAddressRevision=MobileOrderAddressRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderAddressRevision.d_street=x_sD_street;
            _oMobileOrderAddressRevision.address_id=x_lAddress_id;
            _oMobileOrderAddressRevision.d_region=x_sD_region;
            _oMobileOrderAddressRevision.d_floor=x_sD_floor;
            _oMobileOrderAddressRevision.d_build=x_sD_build;
            _oMobileOrderAddressRevision.d_room=x_sD_room;
            _oMobileOrderAddressRevision.order_id=x_iOrder_id;
            _oMobileOrderAddressRevision.address_type=x_sAddress_type;
            _oMobileOrderAddressRevision.d_type=x_sD_type;
            _oMobileOrderAddressRevision.d_district=x_sD_district;
            _oMobileOrderAddressRevision.d_blk=x_sD_blk;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderAddressRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderAddressRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderAddressRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderAddressRevision)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderAddressRevision)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderAddressRevision x_oMobileOrderAddressRevision, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERADDRESSREVISION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderAddressRevision,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderAddressRevision x_oMobileOrderAddressRevision, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_build==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_build; }
                _oPar=x_oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_street==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_street; }
                _oPar=x_oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_district==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_district; }
                _oPar=x_oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_region==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_region; }
                _oPar=x_oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_floor==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_floor; }
                _oPar=x_oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_room==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_room; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.order_id; }
                _oPar=x_oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.address_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.address_type; }
                _oPar=x_oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_type; }
                _oPar=x_oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.address_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.address_id; }
                _oPar=x_oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderAddressRevision.d_blk==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderAddressRevision.d_blk; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.BigInt);
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
        
        #region INSERT_MOBILEORDERADDRESSREVISION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERADDRESSREVISION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERADDRESSREVISION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERADDRESSREVISION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERADDRESSREVISION;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERADDRESSREVISION
        	-- Add the parameters for the stored procedure here
        @RETURN_MID bigint output,
        @d_street nvarchar(250),
        @address_id bigint,
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
        
        INSERT INTO  [MobileOrderAddressRevision]   ([d_build],[d_street],[d_district],[d_region],[d_floor],[d_room],[order_id],[address_type],[d_type],[address_id],[d_blk])  VALUES  (@d_build,@d_street,@d_district,@d_region,@d_floor,@d_room,@order_id,@address_type,@d_type,@address_id,@d_blk)
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
        
        public bool Delete(global::System.Nullable<long> x_lMid)
        {
            return DeleteProc(n_oDB, x_lMid);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return DeleteProc(x_oDB, x_lMid);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lMid)
        {
            if (x_lMid==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderAddressRevision]  WHERE [MobileOrderAddressRevision].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.BigInt).Value = x_lMid;
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
            return MobileOrderAddressRevisionRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderAddressRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderAddressRevision]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
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


