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
///-- Create date: <Create Date 2010-11-05>
///-- Description:	<Description,Table :[MobileAssignList],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileAssignList] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileAssignList")]
    public class MobileAssignListRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileAssignListRepositoryBase instance;
        public static MobileAssignListRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileAssignListRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileAssignListRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileAssignListRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileAssignListEntity> MobileAssignLists;
        #endregion
        
        #region Constructor
        public MobileAssignListRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileAssignListRepositoryBase() { 
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
        public static MobileAssignList CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileAssignList(_oDB);
        }
        
        public static MobileAssignList CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileAssignList(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileAssignList]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAssignList]","["+ Configurator.MSSQLTablePrefix + "MobileAssignList]"); }
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
        
        
        
        
        public static MobileAssignListEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileAssignListEntity> _oMobileAssignListList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileAssignListList==null){ return null;}
            return _oMobileAssignListList.Count == 0 ? null : _oMobileAssignListList.ToArray();
        }
        
        
        public static MobileAssignListEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileAssignListEntity> _oMobileAssignListList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileAssignListList==null){ return null;}
            return _oMobileAssignListList.Count == 0 ? null : _oMobileAssignListList.ToArray();
        }
        
        public static List<MobileAssignListEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileAssignListEntity> _oRow = new List<MobileAssignListEntity>();
            string _sQuery = "SELECT d_date AS MOBILERETENTIONORDER_D_DATE,record_id AS MOBILERETENTIONORDER_RECORD_ID,order_id AS MOBILERETENTIONORDER_ORDER_ID,date_diff AS MOBILERETENTIONORDER_DATE_DIFF,status AS MOBILERETENTIONORDER_STATUS,hs_model AS MOBILERETENTIONORDER_HS_MODEL,sku AS MOBILERETENTIONORDER_SKU,imei_no AS MOBILERETENTIONORDER_IMEI_NO,edf_no AS MOBILERETENTIONORDER_EDF_NO,active AS MOBILERETENTIONORDER_ACTIVE FROM MobileAssignList";
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
                _sQuery += " WHERE .["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAssignList]","["+ Configurator.MSSQLTablePrefix + "MobileAssignList]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileAssignList _oMobileAssignList = MobileAssignListRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"])) {_oMobileAssignList.sku = (string)_oData["MOBILERETENTIONORDER_SKU"]; }else{_oMobileAssignList.sku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"])) {_oMobileAssignList.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"]; }else{_oMobileAssignList.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"])) {_oMobileAssignList.hs_model = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"]; }else{_oMobileAssignList.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"])) {_oMobileAssignList.edf_no = (string)_oData["MOBILERETENTIONORDER_EDF_NO"]; }else{_oMobileAssignList.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"])) {_oMobileAssignList.imei_no = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"]; }else{_oMobileAssignList.imei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"])) {_oMobileAssignList.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"]; }else{_oMobileAssignList.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"])) {_oMobileAssignList.d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"]; }else{_oMobileAssignList.d_date=null;}
                        _oMobileAssignList.SetDB(x_oDB);
                        _oMobileAssignList.GetFound();
                        _oRow.Add(_oMobileAssignList);
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
        
        
        public static MobileAssignListEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileAssignListEntity> _oMobileAssignListList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileAssignListList==null){ return null;}
            return _oMobileAssignListList.Count == 0 ? null : _oMobileAssignListList.ToArray();
        }
        
        
        public static MobileAssignListEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileAssignListEntity> _oMobileAssignListList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileAssignListList==null){ return null;}
            return _oMobileAssignListList.Count == 0 ? null : _oMobileAssignListList.ToArray();
        }
        
        public static List<MobileAssignListEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileAssignListEntity> _oRow = new List<MobileAssignListEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields = " d_date AS MOBILERETENTIONORDER_D_DATE, record_id AS MOBILERETENTIONORDER_RECORD_ID,order_id AS MOBILERETENTIONORDER_ORDER_ID,date_diff AS MOBILERETENTIONORDER_DATE_DIFF,status AS MOBILERETENTIONORDER_STATUS,hs_model AS MOBILERETENTIONORDER_HS_MODEL,sku AS MOBILERETENTIONORDER_SKU,imei_no AS MOBILERETENTIONORDER_IMEI_NO,edf_no AS MOBILERETENTIONORDER_EDF_NO,active AS MOBILERETENTIONORDER_ACTIVE ";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileAssignList]","["+ Configurator.MSSQLTablePrefix + "MobileAssignList]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileAssignListRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileAssignListEntity _oMobileAssignList = MobileAssignListRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"])) {_oMobileAssignList.sku = (string)_oData["MOBILERETENTIONORDER_SKU"]; } else {_oMobileAssignList.sku=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"])) {_oMobileAssignList.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"]; } else {_oMobileAssignList.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"])) {_oMobileAssignList.hs_model = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"]; } else {_oMobileAssignList.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"])) {_oMobileAssignList.edf_no = (string)_oData["MOBILERETENTIONORDER_EDF_NO"]; } else {_oMobileAssignList.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"])) {_oMobileAssignList.imei_no = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"]; } else {_oMobileAssignList.imei_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"])) {_oMobileAssignList.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"]; } else {_oMobileAssignList.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"])) {_oMobileAssignList.d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"]; } else {_oMobileAssignList.d_date=null; }
                _oMobileAssignList.SetDB(x_oDB);
                _oMobileAssignList.GetFound();
                _oRow.Add(_oMobileAssignList);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileAssignList.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileAssignList.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileAssignList.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileAssignList.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT d_date AS MOBILERETENTIONORDER_D_DATE, record_id AS MOBILERETENTIONORDER_RECORD_ID,order_id AS MOBILERETENTIONORDER_ORDER_ID,date_diff AS MOBILERETENTIONORDER_DATE_DIFF,status AS MOBILERETENTIONORDER_STATUS,hs_model AS MOBILERETENTIONORDER_HS_MODEL,sku AS MOBILERETENTIONORDER_SKU,imei_no AS MOBILERETENTIONORDER_IMEI_NO,edf_no AS MOBILERETENTIONORDER_EDF_NO,active AS MOBILERETENTIONORDER_ACTIVE FROM MobileAssignList " + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileAssignList]","["+ Configurator.MSSQLTablePrefix + "MobileAssignList]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileAssignList");
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
        
        public bool Insert(string x_sSku,global::System.Nullable<int> x_iOrder_id,string x_sHs_model,string x_sEdf_no,string x_sImei_no,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dD_date)
        {
            MobileAssignList _oMobileAssignList=MobileAssignListRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileAssignList.sku=x_sSku;
            _oMobileAssignList.order_id=x_iOrder_id;
            _oMobileAssignList.hs_model=x_sHs_model;
            _oMobileAssignList.edf_no=x_sEdf_no;
            _oMobileAssignList.imei_no=x_sImei_no;
            _oMobileAssignList.active=x_bActive;
            _oMobileAssignList.d_date=x_dD_date;
            return InsertWithOutLastID(n_oDB, _oMobileAssignList);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sSku,global::System.Nullable<int> x_iOrder_id,string x_sHs_model,string x_sEdf_no,string x_sImei_no,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dD_date)
        {
            MobileAssignList _oMobileAssignList=MobileAssignListRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileAssignList.sku=x_sSku;
            _oMobileAssignList.order_id=x_iOrder_id;
            _oMobileAssignList.hs_model=x_sHs_model;
            _oMobileAssignList.edf_no=x_sEdf_no;
            _oMobileAssignList.imei_no=x_sImei_no;
            _oMobileAssignList.active=x_bActive;
            _oMobileAssignList.d_date=x_dD_date;
            return InsertWithOutLastID(x_oDB, _oMobileAssignList);
        }
        
        
        public bool Insert(MobileAssignList x_oMobileAssignList)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileAssignList);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileAssignList)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileAssignList)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileAssignList x_oMobileAssignList)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileAssignList);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileAssignList x_oMobileAssignList)
        {
            return false;
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileAssignList x_oMobileAssignList)
        {
            bool _bResult = false;
            return _bResult;
        }
        
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            return -1;
        }
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return MobileAssignListRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM MobileAssignList ";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAssignList]","["+ Configurator.MSSQLTablePrefix + "MobileAssignList]"); }
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
            string _sQuery = "DELETE FROM [MobileAssignList]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAssignList]","["+ Configurator.MSSQLTablePrefix + "MobileAssignList]"); }
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


