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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[DOAProfileRecord],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [DOAProfileRecord] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"DOAProfileRecord")]
    public class DOAProfileRecordRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static DOAProfileRecordRepositoryBase instance;
        public static DOAProfileRecordRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr("MobileRetentionOrderDB");
                instance = new DOAProfileRecordRepositoryBase(_oDB);
            }
            return instance;
        }
        public static DOAProfileRecordRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new DOAProfileRecordRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<DOAProfileRecordEntity> DOAProfileRecords;
        #endregion
        
        #region Constructor
        public DOAProfileRecordRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~DOAProfileRecordRepositoryBase() { 
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
        public static DOAProfileRecord CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr("MobileRetentionOrderDB");
            return new DOAProfileRecord(_oDB);
        }
        
        public static DOAProfileRecord CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new DOAProfileRecord(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [DOAProfileRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
        
        
        public DOAProfileRecordEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static DOAProfileRecordEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            DOAProfileRecord _DOAProfileRecord = (DOAProfileRecord)DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_DOAProfileRecord.Load(x_iId)) { return null; }
            return _DOAProfileRecord;
        }
        
        
        
        public static DOAProfileRecordEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<DOAProfileRecordEntity> _oDOAProfileRecordList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oDOAProfileRecordList.Count == 0 ? null : _oDOAProfileRecordList.ToArray();
        }
        
        public static List<DOAProfileRecordEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static DOAProfileRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DOAProfileRecordEntity> _oDOAProfileRecordList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oDOAProfileRecordList.Count == 0 ? null : _oDOAProfileRecordList.ToArray();
        }
        
        
        public static DOAProfileRecordEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DOAProfileRecordEntity> _oDOAProfileRecordList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oDOAProfileRecordList.Count == 0 ? null : _oDOAProfileRecordList.ToArray();
        }
        
        public static List<DOAProfileRecordEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<DOAProfileRecordEntity> _oRow = new List<DOAProfileRecordEntity>();
            string _sQuery = "SELECT  "+_sTop+" [DOAProfileRecord].[id] AS DOAPROFILERECORD_ID,[DOAProfileRecord].[cdate] AS DOAPROFILERECORD_CDATE,[DOAProfileRecord].[cid] AS DOAPROFILERECORD_CID,[DOAProfileRecord].[did] AS DOAPROFILERECORD_DID,[DOAProfileRecord].[status] AS DOAPROFILERECORD_STATUS,[DOAProfileRecord].[active] AS DOAPROFILERECORD_ACTIVE,[DOAProfileRecord].[order_remark] AS DOAPROFILERECORD_ORDER_REMARK,[DOAProfileRecord].[edate] AS DOAPROFILERECORD_EDATE,[DOAProfileRecord].[edf_no] AS DOAPROFILERECORD_EDF_NO,[DOAProfileRecord].[used] AS DOAPROFILERECORD_USED,[DOAProfileRecord].[order_id] AS DOAPROFILERECORD_ORDER_ID,[DOAProfileRecord].[order_dn_remark] AS DOAPROFILERECORD_ORDER_DN_REMARK,[DOAProfileRecord].[ddate] AS DOAPROFILERECORD_DDATE,[DOAProfileRecord].[imei_no] AS DOAPROFILERECORD_IMEI_NO,[DOAProfileRecord].[imei_stock_remark] AS DOAPROFILERECORD_IMEI_STOCK_REMARK  FROM  [DOAProfileRecord]";
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
                _sQuery += " WHERE [DOAProfileRecord].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        DOAProfileRecord _oDOAProfileRecord = DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ID"])) {_oDOAProfileRecord.id = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ID"]; }else{_oDOAProfileRecord.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CDATE"])) {_oDOAProfileRecord.cdate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_CDATE"]; }else{_oDOAProfileRecord.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CID"])) {_oDOAProfileRecord.cid = (string)_oData["DOAPROFILERECORD_CID"]; }else{_oDOAProfileRecord.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DID"])) {_oDOAProfileRecord.did = (string)_oData["DOAPROFILERECORD_DID"]; }else{_oDOAProfileRecord.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_STATUS"])) {_oDOAProfileRecord.status = (string)_oData["DOAPROFILERECORD_STATUS"]; }else{_oDOAProfileRecord.status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ACTIVE"])) {_oDOAProfileRecord.active = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_ACTIVE"]; }else{_oDOAProfileRecord.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"])) {_oDOAProfileRecord.imei_stock_remark = (string)_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"]; }else{_oDOAProfileRecord.imei_stock_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDATE"])) {_oDOAProfileRecord.edate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_EDATE"]; }else{_oDOAProfileRecord.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDF_NO"])) {_oDOAProfileRecord.edf_no = (string)_oData["DOAPROFILERECORD_EDF_NO"]; }else{_oDOAProfileRecord.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_USED"])) {_oDOAProfileRecord.used = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_USED"]; }else{_oDOAProfileRecord.used=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_ID"])) {_oDOAProfileRecord.order_id = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ORDER_ID"]; }else{_oDOAProfileRecord.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_DN_REMARK"])) {_oDOAProfileRecord.order_dn_remark = (string)_oData["DOAPROFILERECORD_ORDER_DN_REMARK"]; }else{_oDOAProfileRecord.order_dn_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DDATE"])) {_oDOAProfileRecord.ddate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_DDATE"]; }else{_oDOAProfileRecord.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_NO"])) {_oDOAProfileRecord.imei_no = (string)_oData["DOAPROFILERECORD_IMEI_NO"]; }else{_oDOAProfileRecord.imei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_REMARK"])) {_oDOAProfileRecord.order_remark = (string)_oData["DOAPROFILERECORD_ORDER_REMARK"]; }else{_oDOAProfileRecord.order_remark=global::System.String.Empty;}
                        _oDOAProfileRecord.SetDB(x_oDB);
                        _oDOAProfileRecord.GetFound();
                        _oRow.Add(_oDOAProfileRecord);
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
        
        
        public static DOAProfileRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DOAProfileRecordEntity> _oDOAProfileRecordList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oDOAProfileRecordList.Count == 0 ? null : _oDOAProfileRecordList.ToArray();
        }
        
        
        public static DOAProfileRecordEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DOAProfileRecordEntity> _oDOAProfileRecordList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oDOAProfileRecordList.Count == 0 ? null : _oDOAProfileRecordList.ToArray();
        }
        
        public static List<DOAProfileRecordEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<DOAProfileRecordEntity> _oRow = new List<DOAProfileRecordEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[DOAProfileRecord].[id] AS DOAPROFILERECORD_ID,[DOAProfileRecord].[cdate] AS DOAPROFILERECORD_CDATE,[DOAProfileRecord].[cid] AS DOAPROFILERECORD_CID,[DOAProfileRecord].[did] AS DOAPROFILERECORD_DID,[DOAProfileRecord].[status] AS DOAPROFILERECORD_STATUS,[DOAProfileRecord].[active] AS DOAPROFILERECORD_ACTIVE,[DOAProfileRecord].[order_remark] AS DOAPROFILERECORD_ORDER_REMARK,[DOAProfileRecord].[edate] AS DOAPROFILERECORD_EDATE,[DOAProfileRecord].[edf_no] AS DOAPROFILERECORD_EDF_NO,[DOAProfileRecord].[used] AS DOAPROFILERECORD_USED,[DOAProfileRecord].[order_id] AS DOAPROFILERECORD_ORDER_ID,[DOAProfileRecord].[order_dn_remark] AS DOAPROFILERECORD_ORDER_DN_REMARK,[DOAProfileRecord].[ddate] AS DOAPROFILERECORD_DDATE,[DOAProfileRecord].[imei_no] AS DOAPROFILERECORD_IMEI_NO,[DOAProfileRecord].[imei_stock_remark] AS DOAPROFILERECORD_IMEI_STOCK_REMARK";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = DOAProfileRecordRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                DOAProfileRecordEntity _oDOAProfileRecord = DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ID"])) {_oDOAProfileRecord.id = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ID"]; } else {_oDOAProfileRecord.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CDATE"])) {_oDOAProfileRecord.cdate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_CDATE"]; } else {_oDOAProfileRecord.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CID"])) {_oDOAProfileRecord.cid = (string)_oData["DOAPROFILERECORD_CID"]; } else {_oDOAProfileRecord.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DID"])) {_oDOAProfileRecord.did = (string)_oData["DOAPROFILERECORD_DID"]; } else {_oDOAProfileRecord.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_STATUS"])) {_oDOAProfileRecord.status = (string)_oData["DOAPROFILERECORD_STATUS"]; } else {_oDOAProfileRecord.status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ACTIVE"])) {_oDOAProfileRecord.active = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_ACTIVE"]; } else {_oDOAProfileRecord.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"])) {_oDOAProfileRecord.imei_stock_remark = (string)_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"]; } else {_oDOAProfileRecord.imei_stock_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDATE"])) {_oDOAProfileRecord.edate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_EDATE"]; } else {_oDOAProfileRecord.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDF_NO"])) {_oDOAProfileRecord.edf_no = (string)_oData["DOAPROFILERECORD_EDF_NO"]; } else {_oDOAProfileRecord.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_USED"])) {_oDOAProfileRecord.used = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_USED"]; } else {_oDOAProfileRecord.used=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_ID"])) {_oDOAProfileRecord.order_id = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ORDER_ID"]; } else {_oDOAProfileRecord.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_DN_REMARK"])) {_oDOAProfileRecord.order_dn_remark = (string)_oData["DOAPROFILERECORD_ORDER_DN_REMARK"]; } else {_oDOAProfileRecord.order_dn_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DDATE"])) {_oDOAProfileRecord.ddate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_DDATE"]; } else {_oDOAProfileRecord.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_NO"])) {_oDOAProfileRecord.imei_no = (string)_oData["DOAPROFILERECORD_IMEI_NO"]; } else {_oDOAProfileRecord.imei_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_REMARK"])) {_oDOAProfileRecord.order_remark = (string)_oData["DOAPROFILERECORD_ORDER_REMARK"]; } else {_oDOAProfileRecord.order_remark=global::System.String.Empty; }
                _oDOAProfileRecord.SetDB(x_oDB);
                _oDOAProfileRecord.GetFound();
                _oRow.Add(_oDOAProfileRecord);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( DOAProfileRecord.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,DOAProfileRecord.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(DOAProfileRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(DOAProfileRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [DOAProfileRecord].[id] AS DOAPROFILERECORD_ID,[DOAProfileRecord].[cdate] AS DOAPROFILERECORD_CDATE,[DOAProfileRecord].[cid] AS DOAPROFILERECORD_CID,[DOAProfileRecord].[did] AS DOAPROFILERECORD_DID,[DOAProfileRecord].[status] AS DOAPROFILERECORD_STATUS,[DOAProfileRecord].[active] AS DOAPROFILERECORD_ACTIVE,[DOAProfileRecord].[order_remark] AS DOAPROFILERECORD_ORDER_REMARK,[DOAProfileRecord].[edate] AS DOAPROFILERECORD_EDATE,[DOAProfileRecord].[edf_no] AS DOAPROFILERECORD_EDF_NO,[DOAProfileRecord].[used] AS DOAPROFILERECORD_USED,[DOAProfileRecord].[order_id] AS DOAPROFILERECORD_ORDER_ID,[DOAProfileRecord].[order_dn_remark] AS DOAPROFILERECORD_ORDER_DN_REMARK,[DOAProfileRecord].[ddate] AS DOAPROFILERECORD_DDATE,[DOAProfileRecord].[imei_no] AS DOAPROFILERECORD_IMEI_NO,[DOAProfileRecord].[imei_stock_remark] AS DOAPROFILERECORD_IMEI_STOCK_REMARK  FROM  [DOAProfileRecord]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"DOAProfileRecord");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sImei_stock_remark,global::System.Nullable<DateTime> x_dEdate,string x_sEdf_no,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,string x_sOrder_dn_remark,global::System.Nullable<DateTime> x_dDdate,string x_sImei_no,string x_sOrder_remark)
        {
            DOAProfileRecord _oDOAProfileRecord=DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oDOAProfileRecord.cdate=x_dCdate;
            _oDOAProfileRecord.cid=x_sCid;
            _oDOAProfileRecord.did=x_sDid;
            _oDOAProfileRecord.status=x_sStatus;
            _oDOAProfileRecord.active=x_bActive;
            _oDOAProfileRecord.imei_stock_remark=x_sImei_stock_remark;
            _oDOAProfileRecord.edate=x_dEdate;
            _oDOAProfileRecord.edf_no=x_sEdf_no;
            _oDOAProfileRecord.used=x_bUsed;
            _oDOAProfileRecord.order_id=x_iOrder_id;
            _oDOAProfileRecord.order_dn_remark=x_sOrder_dn_remark;
            _oDOAProfileRecord.ddate=x_dDdate;
            _oDOAProfileRecord.imei_no=x_sImei_no;
            _oDOAProfileRecord.order_remark=x_sOrder_remark;
            return InsertWithOutLastID(n_oDB, _oDOAProfileRecord);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sImei_stock_remark,global::System.Nullable<DateTime> x_dEdate,string x_sEdf_no,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,string x_sOrder_dn_remark,global::System.Nullable<DateTime> x_dDdate,string x_sImei_no,string x_sOrder_remark)
        {
            DOAProfileRecord _oDOAProfileRecord=DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDOAProfileRecord.cdate=x_dCdate;
            _oDOAProfileRecord.cid=x_sCid;
            _oDOAProfileRecord.did=x_sDid;
            _oDOAProfileRecord.status=x_sStatus;
            _oDOAProfileRecord.active=x_bActive;
            _oDOAProfileRecord.imei_stock_remark=x_sImei_stock_remark;
            _oDOAProfileRecord.edate=x_dEdate;
            _oDOAProfileRecord.edf_no=x_sEdf_no;
            _oDOAProfileRecord.used=x_bUsed;
            _oDOAProfileRecord.order_id=x_iOrder_id;
            _oDOAProfileRecord.order_dn_remark=x_sOrder_dn_remark;
            _oDOAProfileRecord.ddate=x_dDdate;
            _oDOAProfileRecord.imei_no=x_sImei_no;
            _oDOAProfileRecord.order_remark=x_sOrder_remark;
            return InsertWithOutLastID(x_oDB, _oDOAProfileRecord);
        }
        
        
        public bool Insert(DOAProfileRecord x_oDOAProfileRecord)
        {
            return InsertWithOutLastID(n_oDB, x_oDOAProfileRecord);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is DOAProfileRecord)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (DOAProfileRecord)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,DOAProfileRecord x_oDOAProfileRecord)
        {
            return InsertWithOutLastID(x_oDB, x_oDOAProfileRecord);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,DOAProfileRecord x_oDOAProfileRecord)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [DOAProfileRecord]   ([cdate],[cid],[did],[status],[active],[order_remark],[edate],[edf_no],[used],[order_id],[order_dn_remark],[ddate],[imei_no],[imei_stock_remark])  VALUES  (@cdate,@cid,@did,@status,@active,@order_remark,@edate,@edf_no,@used,@order_id,@order_dn_remark,@ddate,@imei_no,@imei_stock_remark)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oDOAProfileRecord);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DOAProfileRecord x_oDOAProfileRecord)
        {
            bool _bResult = false;
            if (!x_oDOAProfileRecord.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oDOAProfileRecord.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oDOAProfileRecord.cdate; }
                if(x_oDOAProfileRecord.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.cid; }
                if(x_oDOAProfileRecord.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.did; }
                if(x_oDOAProfileRecord.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.status; }
                if(x_oDOAProfileRecord.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oDOAProfileRecord.active; }
                if(x_oDOAProfileRecord.order_remark==null){  x_oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text).Value=x_oDOAProfileRecord.order_remark; }
                if(x_oDOAProfileRecord.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oDOAProfileRecord.edate; }
                if(x_oDOAProfileRecord.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.edf_no; }
                if(x_oDOAProfileRecord.used==null){  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value=x_oDOAProfileRecord.used; }
                if(x_oDOAProfileRecord.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oDOAProfileRecord.order_id; }
                if(x_oDOAProfileRecord.order_dn_remark==null){  x_oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text).Value=x_oDOAProfileRecord.order_dn_remark; }
                if(x_oDOAProfileRecord.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oDOAProfileRecord.ddate; }
                if(x_oDOAProfileRecord.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.imei_no; }
                if(x_oDOAProfileRecord.imei_stock_remark==null){  x_oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text).Value=x_oDOAProfileRecord.imei_stock_remark; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sImei_stock_remark,global::System.Nullable<DateTime> x_dEdate,string x_sEdf_no,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,string x_sOrder_dn_remark,global::System.Nullable<DateTime> x_dDdate,string x_sImei_no,string x_sOrder_remark)
        {
            int _oLastID;
            DOAProfileRecord _oDOAProfileRecord=DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDOAProfileRecord.cdate=x_dCdate;
            _oDOAProfileRecord.cid=x_sCid;
            _oDOAProfileRecord.did=x_sDid;
            _oDOAProfileRecord.status=x_sStatus;
            _oDOAProfileRecord.active=x_bActive;
            _oDOAProfileRecord.imei_stock_remark=x_sImei_stock_remark;
            _oDOAProfileRecord.edate=x_dEdate;
            _oDOAProfileRecord.edf_no=x_sEdf_no;
            _oDOAProfileRecord.used=x_bUsed;
            _oDOAProfileRecord.order_id=x_iOrder_id;
            _oDOAProfileRecord.order_dn_remark=x_sOrder_dn_remark;
            _oDOAProfileRecord.ddate=x_dDdate;
            _oDOAProfileRecord.imei_no=x_sImei_no;
            _oDOAProfileRecord.order_remark=x_sOrder_remark;
            if(InsertWithLastID(x_oDB, _oDOAProfileRecord,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(DOAProfileRecord x_oDOAProfileRecord)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oDOAProfileRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, DOAProfileRecord x_oDOAProfileRecord)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oDOAProfileRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DOAProfileRecord)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (DOAProfileRecord)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,DOAProfileRecord x_oDOAProfileRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [DOAProfileRecord]   ([cdate],[cid],[did],[status],[active],[order_remark],[edate],[edf_no],[used],[order_id],[order_dn_remark],[ddate],[imei_no],[imei_stock_remark])  VALUES  (@cdate,@cid,@did,@status,@active,@order_remark,@edate,@edf_no,@used,@order_id,@order_dn_remark,@ddate,@imei_no,@imei_stock_remark)"+" SELECT  @@IDENTITY AS DOAProfileRecord_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oDOAProfileRecord,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DOAProfileRecord x_oDOAProfileRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oDOAProfileRecord.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oDOAProfileRecord.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oDOAProfileRecord.cdate; }
                if(x_oDOAProfileRecord.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.cid; }
                if(x_oDOAProfileRecord.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.did; }
                if(x_oDOAProfileRecord.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.status; }
                if(x_oDOAProfileRecord.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oDOAProfileRecord.active; }
                if(x_oDOAProfileRecord.order_remark==null){  x_oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text).Value=x_oDOAProfileRecord.order_remark; }
                if(x_oDOAProfileRecord.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oDOAProfileRecord.edate; }
                if(x_oDOAProfileRecord.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.edf_no; }
                if(x_oDOAProfileRecord.used==null){  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value=x_oDOAProfileRecord.used; }
                if(x_oDOAProfileRecord.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oDOAProfileRecord.order_id; }
                if(x_oDOAProfileRecord.order_dn_remark==null){  x_oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text).Value=x_oDOAProfileRecord.order_dn_remark; }
                if(x_oDOAProfileRecord.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oDOAProfileRecord.ddate; }
                if(x_oDOAProfileRecord.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oDOAProfileRecord.imei_no; }
                if(x_oDOAProfileRecord.imei_stock_remark==null){  x_oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text).Value=x_oDOAProfileRecord.imei_stock_remark; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["DOAProfileRecord_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["DOAProfileRecord_LASTID"].ToString()) && int.TryParse(_oData["DOAProfileRecord_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sImei_stock_remark,global::System.Nullable<DateTime> x_dEdate,string x_sEdf_no,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,string x_sOrder_dn_remark,global::System.Nullable<DateTime> x_dDdate,string x_sImei_no,string x_sOrder_remark)
        {
            int _oLastID;
            DOAProfileRecord _oDOAProfileRecord=DOAProfileRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDOAProfileRecord.cdate=x_dCdate;
            _oDOAProfileRecord.cid=x_sCid;
            _oDOAProfileRecord.did=x_sDid;
            _oDOAProfileRecord.status=x_sStatus;
            _oDOAProfileRecord.active=x_bActive;
            _oDOAProfileRecord.imei_stock_remark=x_sImei_stock_remark;
            _oDOAProfileRecord.edate=x_dEdate;
            _oDOAProfileRecord.edf_no=x_sEdf_no;
            _oDOAProfileRecord.used=x_bUsed;
            _oDOAProfileRecord.order_id=x_iOrder_id;
            _oDOAProfileRecord.order_dn_remark=x_sOrder_dn_remark;
            _oDOAProfileRecord.ddate=x_dDdate;
            _oDOAProfileRecord.imei_no=x_sImei_no;
            _oDOAProfileRecord.order_remark=x_sOrder_remark;
            if(InsertWithLastID_SP(x_oDB, _oDOAProfileRecord,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(DOAProfileRecord x_oDOAProfileRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oDOAProfileRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DOAProfileRecord x_oDOAProfileRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oDOAProfileRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DOAProfileRecord)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (DOAProfileRecord)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,DOAProfileRecord x_oDOAProfileRecord, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "DOAPROFILERECORD";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oDOAProfileRecord,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,DOAProfileRecord x_oDOAProfileRecord, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oDOAProfileRecord.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.did; }
                _oPar=x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.status; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.active; }
                _oPar=x_oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.order_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.order_remark; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oDOAProfileRecord.edate; }
                _oPar=x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.edf_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.edf_no; }
                _oPar=x_oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.used==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.used; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.order_id; }
                _oPar=x_oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.order_dn_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.order_dn_remark; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oDOAProfileRecord.ddate; }
                _oPar=x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.imei_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.imei_no; }
                _oPar=x_oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oDOAProfileRecord.imei_stock_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oDOAProfileRecord.imei_stock_remark; }
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
        
        #region INSERT_DOAPROFILERECORD Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-04-20>
        ///-- Description:	<Description,DOAPROFILERECORD, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_DOAPROFILERECORD Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB
        GO
        IF OBJECT_ID ( 'INSERT_DOAPROFILERECORD', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_DOAPROFILERECORD;
        GO
        CREATE PROCEDURE INSERT_DOAPROFILERECORD
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @did nvarchar(50),
        @status nvarchar(50),
        @active bit,
        @imei_stock_remark text,
        @edate datetime,
        @edf_no nvarchar(50),
        @used bit,
        @order_id int,
        @order_dn_remark text,
        @ddate datetime,
        @imei_no nvarchar(50),
        @order_remark text
        AS
        
        INSERT INTO  [DOAProfileRecord]   ([cdate],[cid],[did],[status],[active],[order_remark],[edate],[edf_no],[used],[order_id],[order_dn_remark],[ddate],[imei_no],[imei_stock_remark])  VALUES  (@cdate,@cid,@did,@status,@active,@order_remark,@edate,@edf_no,@used,@order_id,@order_dn_remark,@ddate,@imei_no,@imei_stock_remark)
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
            string _sQuery = "DELETE FROM  [DOAProfileRecord]  WHERE [DOAProfileRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
            return DOAProfileRecordRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [DOAProfileRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
            string _sQuery = "DELETE FROM [DOAProfileRecord]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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


