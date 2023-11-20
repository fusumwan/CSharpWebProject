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
///-- Create date: <Create Date 2011-02-02>
///-- Description:	<Description,Table :[MobileRetentionOrderAddRuleExceptionList],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrderAddRuleExceptionList] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileRetentionOrderAddRuleExceptionList")]
    public class MobileRetentionOrderAddRuleExceptionListRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileRetentionOrderAddRuleExceptionListRepositoryBase instance;
        public static MobileRetentionOrderAddRuleExceptionListRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileRetentionOrderAddRuleExceptionListRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileRetentionOrderAddRuleExceptionListRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileRetentionOrderAddRuleExceptionListRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileRetentionOrderAddRuleExceptionListEntity> MobileRetentionOrderAddRuleExceptionLists;
        #endregion
        
        #region Constructor
        public MobileRetentionOrderAddRuleExceptionListRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileRetentionOrderAddRuleExceptionListRepositoryBase() { 
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
        public static MobileRetentionOrderAddRuleExceptionList CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileRetentionOrderAddRuleExceptionList(_oDB);
        }
        
        public static MobileRetentionOrderAddRuleExceptionList CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileRetentionOrderAddRuleExceptionList(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileRetentionOrderAddRuleExceptionList]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
        
        
        public MobileRetentionOrderAddRuleExceptionListEntity GetObj(string x_sMrt_no,string x_sFilename)
        {
            return GetObj(n_oDB, x_sMrt_no,x_sFilename);
        }
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity GetObj(MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename)
        {
            if (x_oDB==null) { return null; }
            MobileRetentionOrderAddRuleExceptionList _MobileRetentionOrderAddRuleExceptionList = (MobileRetentionOrderAddRuleExceptionList)MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileRetentionOrderAddRuleExceptionList.Load(x_sMrt_no,x_sFilename)) { return null; }
            return _MobileRetentionOrderAddRuleExceptionList;
        }
        
        
        public MobileRetentionOrderAddRuleExceptionListEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileRetentionOrderAddRuleExceptionList _MobileRetentionOrderAddRuleExceptionList = (MobileRetentionOrderAddRuleExceptionList)MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileRetentionOrderAddRuleExceptionList.Load(x_iId)) { return null; }
            return _MobileRetentionOrderAddRuleExceptionList;
        }
        
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileRetentionOrderAddRuleExceptionListList==null){ return null;}
            return _oMobileRetentionOrderAddRuleExceptionListList.Count == 0 ? null : _oMobileRetentionOrderAddRuleExceptionListList.ToArray();
        }
        
        public static List<MobileRetentionOrderAddRuleExceptionListEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionOrderAddRuleExceptionListList==null){ return null;}
            return _oMobileRetentionOrderAddRuleExceptionListList.Count == 0 ? null : _oMobileRetentionOrderAddRuleExceptionListList.ToArray();
        }
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionOrderAddRuleExceptionListList==null){ return null;}
            return _oMobileRetentionOrderAddRuleExceptionListList.Count == 0 ? null : _oMobileRetentionOrderAddRuleExceptionListList.ToArray();
        }
        
        public static List<MobileRetentionOrderAddRuleExceptionListEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oRow = new List<MobileRetentionOrderAddRuleExceptionListEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileRetentionOrderAddRuleExceptionList].[id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID,[MobileRetentionOrderAddRuleExceptionList].[cdate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE,[MobileRetentionOrderAddRuleExceptionList].[cid] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID,[MobileRetentionOrderAddRuleExceptionList].[filename] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME,[MobileRetentionOrderAddRuleExceptionList].[active] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE,[MobileRetentionOrderAddRuleExceptionList].[mrt_no] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO,[MobileRetentionOrderAddRuleExceptionList].[used] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED,[MobileRetentionOrderAddRuleExceptionList].[order_id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID,[MobileRetentionOrderAddRuleExceptionList].[ddate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE,[MobileRetentionOrderAddRuleExceptionList].[did] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID  FROM  [MobileRetentionOrderAddRuleExceptionList]";
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
                _sQuery += " WHERE [MobileRetentionOrderAddRuleExceptionList].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList = MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"])) {_oMobileRetentionOrderAddRuleExceptionList.id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"]; }else{_oMobileRetentionOrderAddRuleExceptionList.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"])) {_oMobileRetentionOrderAddRuleExceptionList.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"]; }else{_oMobileRetentionOrderAddRuleExceptionList.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"])) {_oMobileRetentionOrderAddRuleExceptionList.cid = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"]; }else{_oMobileRetentionOrderAddRuleExceptionList.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"])) {_oMobileRetentionOrderAddRuleExceptionList.mrt_no = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"]; }else{_oMobileRetentionOrderAddRuleExceptionList.mrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"])) {_oMobileRetentionOrderAddRuleExceptionList.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"]; }else{_oMobileRetentionOrderAddRuleExceptionList.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"])) {_oMobileRetentionOrderAddRuleExceptionList.filename = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"]; }else{_oMobileRetentionOrderAddRuleExceptionList.filename=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"])) {_oMobileRetentionOrderAddRuleExceptionList.used = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"]; }else{_oMobileRetentionOrderAddRuleExceptionList.used=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"])) {_oMobileRetentionOrderAddRuleExceptionList.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"]; }else{_oMobileRetentionOrderAddRuleExceptionList.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"])) {_oMobileRetentionOrderAddRuleExceptionList.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"]; }else{_oMobileRetentionOrderAddRuleExceptionList.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"])) {_oMobileRetentionOrderAddRuleExceptionList.did = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"]; }else{_oMobileRetentionOrderAddRuleExceptionList.did=global::System.String.Empty;}
                        _oMobileRetentionOrderAddRuleExceptionList.SetDB(x_oDB);
                        _oMobileRetentionOrderAddRuleExceptionList.GetFound();
                        _oRow.Add(_oMobileRetentionOrderAddRuleExceptionList);
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
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionOrderAddRuleExceptionListList==null){ return null;}
            return _oMobileRetentionOrderAddRuleExceptionListList.Count == 0 ? null : _oMobileRetentionOrderAddRuleExceptionListList.ToArray();
        }
        
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionOrderAddRuleExceptionListList==null){ return null;}
            return _oMobileRetentionOrderAddRuleExceptionListList.Count == 0 ? null : _oMobileRetentionOrderAddRuleExceptionListList.ToArray();
        }
        
        public static List<MobileRetentionOrderAddRuleExceptionListEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileRetentionOrderAddRuleExceptionListEntity> _oRow = new List<MobileRetentionOrderAddRuleExceptionListEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileRetentionOrderAddRuleExceptionList].[id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID,[MobileRetentionOrderAddRuleExceptionList].[cdate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE,[MobileRetentionOrderAddRuleExceptionList].[cid] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID,[MobileRetentionOrderAddRuleExceptionList].[filename] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME,[MobileRetentionOrderAddRuleExceptionList].[active] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE,[MobileRetentionOrderAddRuleExceptionList].[mrt_no] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO,[MobileRetentionOrderAddRuleExceptionList].[used] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED,[MobileRetentionOrderAddRuleExceptionList].[order_id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID,[MobileRetentionOrderAddRuleExceptionList].[ddate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE,[MobileRetentionOrderAddRuleExceptionList].[did] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileRetentionOrderAddRuleExceptionListRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileRetentionOrderAddRuleExceptionListEntity _oMobileRetentionOrderAddRuleExceptionList = MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"])) {_oMobileRetentionOrderAddRuleExceptionList.id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"]; } else {_oMobileRetentionOrderAddRuleExceptionList.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"])) {_oMobileRetentionOrderAddRuleExceptionList.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"]; } else {_oMobileRetentionOrderAddRuleExceptionList.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"])) {_oMobileRetentionOrderAddRuleExceptionList.cid = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"]; } else {_oMobileRetentionOrderAddRuleExceptionList.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"])) {_oMobileRetentionOrderAddRuleExceptionList.mrt_no = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"]; } else {_oMobileRetentionOrderAddRuleExceptionList.mrt_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"])) {_oMobileRetentionOrderAddRuleExceptionList.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"]; } else {_oMobileRetentionOrderAddRuleExceptionList.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"])) {_oMobileRetentionOrderAddRuleExceptionList.filename = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"]; } else {_oMobileRetentionOrderAddRuleExceptionList.filename=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"])) {_oMobileRetentionOrderAddRuleExceptionList.used = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"]; } else {_oMobileRetentionOrderAddRuleExceptionList.used=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"])) {_oMobileRetentionOrderAddRuleExceptionList.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"]; } else {_oMobileRetentionOrderAddRuleExceptionList.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"])) {_oMobileRetentionOrderAddRuleExceptionList.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"]; } else {_oMobileRetentionOrderAddRuleExceptionList.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"])) {_oMobileRetentionOrderAddRuleExceptionList.did = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"]; } else {_oMobileRetentionOrderAddRuleExceptionList.did=global::System.String.Empty; }
                _oMobileRetentionOrderAddRuleExceptionList.SetDB(x_oDB);
                _oMobileRetentionOrderAddRuleExceptionList.GetFound();
                _oRow.Add(_oMobileRetentionOrderAddRuleExceptionList);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileRetentionOrderAddRuleExceptionList.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileRetentionOrderAddRuleExceptionList.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileRetentionOrderAddRuleExceptionList.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileRetentionOrderAddRuleExceptionList.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileRetentionOrderAddRuleExceptionList].[id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID,[MobileRetentionOrderAddRuleExceptionList].[cdate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE,[MobileRetentionOrderAddRuleExceptionList].[cid] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID,[MobileRetentionOrderAddRuleExceptionList].[filename] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME,[MobileRetentionOrderAddRuleExceptionList].[active] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE,[MobileRetentionOrderAddRuleExceptionList].[mrt_no] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO,[MobileRetentionOrderAddRuleExceptionList].[used] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED,[MobileRetentionOrderAddRuleExceptionList].[order_id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID,[MobileRetentionOrderAddRuleExceptionList].[ddate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE,[MobileRetentionOrderAddRuleExceptionList].[did] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID  FROM  [MobileRetentionOrderAddRuleExceptionList]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileRetentionOrderAddRuleExceptionList");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,global::System.Nullable<bool> x_bActive,string x_sFilename,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList=MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileRetentionOrderAddRuleExceptionList.cdate=x_dCdate;
            _oMobileRetentionOrderAddRuleExceptionList.cid=x_sCid;
            _oMobileRetentionOrderAddRuleExceptionList.mrt_no=x_sMrt_no;
            _oMobileRetentionOrderAddRuleExceptionList.active=x_bActive;
            _oMobileRetentionOrderAddRuleExceptionList.filename=x_sFilename;
            _oMobileRetentionOrderAddRuleExceptionList.used=x_bUsed;
            _oMobileRetentionOrderAddRuleExceptionList.order_id=x_iOrder_id;
            _oMobileRetentionOrderAddRuleExceptionList.ddate=x_dDdate;
            _oMobileRetentionOrderAddRuleExceptionList.did=x_sDid;
            return InsertWithOutLastID(n_oDB, _oMobileRetentionOrderAddRuleExceptionList);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,global::System.Nullable<bool> x_bActive,string x_sFilename,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList=MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrderAddRuleExceptionList.cdate=x_dCdate;
            _oMobileRetentionOrderAddRuleExceptionList.cid=x_sCid;
            _oMobileRetentionOrderAddRuleExceptionList.mrt_no=x_sMrt_no;
            _oMobileRetentionOrderAddRuleExceptionList.active=x_bActive;
            _oMobileRetentionOrderAddRuleExceptionList.filename=x_sFilename;
            _oMobileRetentionOrderAddRuleExceptionList.used=x_bUsed;
            _oMobileRetentionOrderAddRuleExceptionList.order_id=x_iOrder_id;
            _oMobileRetentionOrderAddRuleExceptionList.ddate=x_dDdate;
            _oMobileRetentionOrderAddRuleExceptionList.did=x_sDid;
            return InsertWithOutLastID(x_oDB, _oMobileRetentionOrderAddRuleExceptionList);
        }
        
        
        public bool Insert(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileRetentionOrderAddRuleExceptionList);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileRetentionOrderAddRuleExceptionList)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileRetentionOrderAddRuleExceptionList)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileRetentionOrderAddRuleExceptionList);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionOrderAddRuleExceptionList]   ([cdate],[cid],[filename],[active],[mrt_no],[used],[order_id],[ddate],[did])  VALUES  (@cdate,@cid,@filename,@active,@mrt_no,@used,@order_id,@ddate,@did)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrderAddRuleExceptionList);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            bool _bResult = false;
            if (!x_oMobileRetentionOrderAddRuleExceptionList.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionOrderAddRuleExceptionList.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderAddRuleExceptionList.cdate; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderAddRuleExceptionList.cid; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.filename==null){  x_oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrderAddRuleExceptionList.filename; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrderAddRuleExceptionList.active; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderAddRuleExceptionList.mrt_no; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.used==null){  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrderAddRuleExceptionList.used; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrderAddRuleExceptionList.order_id; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderAddRuleExceptionList.ddate; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderAddRuleExceptionList.did; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,global::System.Nullable<bool> x_bActive,string x_sFilename,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            int _oLastID;
            MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList=MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrderAddRuleExceptionList.cdate=x_dCdate;
            _oMobileRetentionOrderAddRuleExceptionList.cid=x_sCid;
            _oMobileRetentionOrderAddRuleExceptionList.mrt_no=x_sMrt_no;
            _oMobileRetentionOrderAddRuleExceptionList.active=x_bActive;
            _oMobileRetentionOrderAddRuleExceptionList.filename=x_sFilename;
            _oMobileRetentionOrderAddRuleExceptionList.used=x_bUsed;
            _oMobileRetentionOrderAddRuleExceptionList.order_id=x_iOrder_id;
            _oMobileRetentionOrderAddRuleExceptionList.ddate=x_dDdate;
            _oMobileRetentionOrderAddRuleExceptionList.did=x_sDid;
            if(InsertWithLastID(x_oDB, _oMobileRetentionOrderAddRuleExceptionList,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileRetentionOrderAddRuleExceptionList, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileRetentionOrderAddRuleExceptionList, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionOrderAddRuleExceptionList)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileRetentionOrderAddRuleExceptionList)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionOrderAddRuleExceptionList]   ([cdate],[cid],[filename],[active],[mrt_no],[used],[order_id],[ddate],[did])  VALUES  (@cdate,@cid,@filename,@active,@mrt_no,@used,@order_id,@ddate,@did)"+" SELECT  @@IDENTITY AS MobileRetentionOrderAddRuleExceptionList_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrderAddRuleExceptionList,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileRetentionOrderAddRuleExceptionList.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionOrderAddRuleExceptionList.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderAddRuleExceptionList.cdate; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderAddRuleExceptionList.cid; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.filename==null){  x_oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrderAddRuleExceptionList.filename; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrderAddRuleExceptionList.active; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderAddRuleExceptionList.mrt_no; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.used==null){  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrderAddRuleExceptionList.used; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrderAddRuleExceptionList.order_id; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderAddRuleExceptionList.ddate; }
                if(x_oMobileRetentionOrderAddRuleExceptionList.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderAddRuleExceptionList.did; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileRetentionOrderAddRuleExceptionList_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileRetentionOrderAddRuleExceptionList_LASTID"].ToString()) && int.TryParse(_oData["MobileRetentionOrderAddRuleExceptionList_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,global::System.Nullable<bool> x_bActive,string x_sFilename,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            int _oLastID;
            MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList=MobileRetentionOrderAddRuleExceptionListRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrderAddRuleExceptionList.cdate=x_dCdate;
            _oMobileRetentionOrderAddRuleExceptionList.cid=x_sCid;
            _oMobileRetentionOrderAddRuleExceptionList.mrt_no=x_sMrt_no;
            _oMobileRetentionOrderAddRuleExceptionList.active=x_bActive;
            _oMobileRetentionOrderAddRuleExceptionList.filename=x_sFilename;
            _oMobileRetentionOrderAddRuleExceptionList.used=x_bUsed;
            _oMobileRetentionOrderAddRuleExceptionList.order_id=x_iOrder_id;
            _oMobileRetentionOrderAddRuleExceptionList.ddate=x_dDdate;
            _oMobileRetentionOrderAddRuleExceptionList.did=x_sDid;
            if(InsertWithLastID_SP(x_oDB, _oMobileRetentionOrderAddRuleExceptionList,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileRetentionOrderAddRuleExceptionList, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileRetentionOrderAddRuleExceptionList, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionOrderAddRuleExceptionList)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileRetentionOrderAddRuleExceptionList)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILERETENTIONORDERADDRULEEXCEPTIONLIST";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrderAddRuleExceptionList,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.cid; }
                _oPar=x_oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.filename==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.filename; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.active; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.used==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.used; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.order_id; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.ddate; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderAddRuleExceptionList.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderAddRuleExceptionList.did; }
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
        
        #region INSERT_MOBILERETENTIONORDERADDRULEEXCEPTIONLIST Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-02-02>
        ///-- Description:	<Description,MOBILERETENTIONORDERADDRULEEXCEPTIONLIST, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILERETENTIONORDERADDRULEEXCEPTIONLIST Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILERETENTIONORDERADDRULEEXCEPTIONLIST', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILERETENTIONORDERADDRULEEXCEPTIONLIST;
        GO
        CREATE PROCEDURE INSERT_MOBILERETENTIONORDERADDRULEEXCEPTIONLIST
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @mrt_no nvarchar(50),
        @active bit,
        @filename nvarchar(250),
        @used bit,
        @order_id int,
        @ddate datetime,
        @did nvarchar(50)
        AS
        
        INSERT INTO  [MobileRetentionOrderAddRuleExceptionList]   ([cdate],[cid],[filename],[active],[mrt_no],[used],[order_id],[ddate],[did])  VALUES  (@cdate,@cid,@filename,@active,@mrt_no,@used,@order_id,@ddate,@did)
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
        
        public bool Delete(string x_sMrt_no,string x_sFilename)
        {
            return DeleteProc(n_oDB, x_sMrt_no,x_sFilename);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename)
        {
            return DeleteProc(x_oDB, x_sMrt_no,x_sFilename);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, string x_sMrt_no,string x_sFilename)
        {
            if (x_sMrt_no==null) { return false; }
            if (x_sFilename==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionOrderAddRuleExceptionList]  WHERE [MobileRetentionOrderAddRuleExceptionList].[mrt_no]=@mrt_no AND [MobileRetentionOrderAddRuleExceptionList].[filename]=@filename";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = x_sMrt_no;
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
            string _sQuery = "DELETE FROM  [MobileRetentionOrderAddRuleExceptionList]  WHERE [MobileRetentionOrderAddRuleExceptionList].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
            return MobileRetentionOrderAddRuleExceptionListRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionOrderAddRuleExceptionList]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
            string _sQuery = "DELETE FROM [MobileRetentionOrderAddRuleExceptionList]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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


