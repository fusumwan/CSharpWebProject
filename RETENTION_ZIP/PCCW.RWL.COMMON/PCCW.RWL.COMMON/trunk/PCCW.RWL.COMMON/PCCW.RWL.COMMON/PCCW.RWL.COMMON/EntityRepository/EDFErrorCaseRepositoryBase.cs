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
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Table :[EDFErrorCase],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [EDFErrorCase] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"EDFErrorCase")]
    public class EDFErrorCaseRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static EDFErrorCaseRepositoryBase instance;
        public static EDFErrorCaseRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new EDFErrorCaseRepositoryBase(_oDB);
            }
            return instance;
        }
        public static EDFErrorCaseRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new EDFErrorCaseRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<EDFErrorCaseEntity> EDFErrorCases;
        #endregion
        
        #region Constructor
        public EDFErrorCaseRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~EDFErrorCaseRepositoryBase() { 
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
        public static EDFErrorCase CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new EDFErrorCase(_oDB);
        }
        
        public static EDFErrorCase CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new EDFErrorCase(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [EDFErrorCase]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
        
        
        public EDFErrorCaseEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static EDFErrorCaseEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            EDFErrorCase _EDFErrorCase = (EDFErrorCase)EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_EDFErrorCase.Load(x_iId)) { return null; }
            return _EDFErrorCase;
        }
        
        
        
        public static EDFErrorCaseEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<EDFErrorCaseEntity> _oEDFErrorCaseList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oEDFErrorCaseList.Count == 0 ? null : _oEDFErrorCaseList.ToArray();
        }
        
        public static List<EDFErrorCaseEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static EDFErrorCaseEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<EDFErrorCaseEntity> _oEDFErrorCaseList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oEDFErrorCaseList.Count == 0 ? null : _oEDFErrorCaseList.ToArray();
        }
        
        
        public static EDFErrorCaseEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<EDFErrorCaseEntity> _oEDFErrorCaseList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oEDFErrorCaseList.Count == 0 ? null : _oEDFErrorCaseList.ToArray();
        }
        
        public static List<EDFErrorCaseEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<EDFErrorCaseEntity> _oRow = new List<EDFErrorCaseEntity>();
            string _sQuery = "SELECT  "+_sTop+" [EDFErrorCase].[id] AS EDFERRORCASE_ID,[EDFErrorCase].[cdate] AS EDFERRORCASE_CDATE,[EDFErrorCase].[cid] AS EDFERRORCASE_CID,[EDFErrorCase].[mrt_no] AS EDFERRORCASE_MRT_NO,[EDFErrorCase].[status] AS EDFERRORCASE_STATUS,[EDFErrorCase].[active] AS EDFERRORCASE_ACTIVE,[EDFErrorCase].[remark] AS EDFERRORCASE_REMARK,[EDFErrorCase].[imei_status] AS EDFERRORCASE_IMEI_STATUS,[EDFErrorCase].[imei_remark] AS EDFERRORCASE_IMEI_REMARK,[EDFErrorCase].[edf_no] AS EDFERRORCASE_EDF_NO,[EDFErrorCase].[order_id] AS EDFERRORCASE_ORDER_ID,[EDFErrorCase].[error_msg] AS EDFERRORCASE_ERROR_MSG,[EDFErrorCase].[did] AS EDFERRORCASE_DID,[EDFErrorCase].[ddate] AS EDFERRORCASE_DDATE,[EDFErrorCase].[imei_no] AS EDFERRORCASE_IMEI_NO  FROM  [EDFErrorCase]";
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
                _sQuery += " WHERE [EDFErrorCase].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        EDFErrorCase _oEDFErrorCase = EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ID"])) {_oEDFErrorCase.id = (global::System.Nullable<int>)_oData["EDFERRORCASE_ID"]; }else{_oEDFErrorCase.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CDATE"])) {_oEDFErrorCase.cdate = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_CDATE"]; }else{_oEDFErrorCase.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CID"])) {_oEDFErrorCase.cid = (string)_oData["EDFERRORCASE_CID"]; }else{_oEDFErrorCase.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_MRT_NO"])) {_oEDFErrorCase.mrt_no = (string)_oData["EDFERRORCASE_MRT_NO"]; }else{_oEDFErrorCase.mrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_STATUS"])) {_oEDFErrorCase.status = (string)_oData["EDFERRORCASE_STATUS"]; }else{_oEDFErrorCase.status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ACTIVE"])) {_oEDFErrorCase.active = (global::System.Nullable<bool>)_oData["EDFERRORCASE_ACTIVE"]; }else{_oEDFErrorCase.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_REMARK"])) {_oEDFErrorCase.remark = (string)_oData["EDFERRORCASE_REMARK"]; }else{_oEDFErrorCase.remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_STATUS"])) {_oEDFErrorCase.imei_status = (string)_oData["EDFERRORCASE_IMEI_STATUS"]; }else{_oEDFErrorCase.imei_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_NO"])) {_oEDFErrorCase.imei_no = (string)_oData["EDFERRORCASE_IMEI_NO"]; }else{_oEDFErrorCase.imei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_REMARK"])) {_oEDFErrorCase.imei_remark = (string)_oData["EDFERRORCASE_IMEI_REMARK"]; }else{_oEDFErrorCase.imei_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_EDF_NO"])) {_oEDFErrorCase.edf_no = (string)_oData["EDFERRORCASE_EDF_NO"]; }else{_oEDFErrorCase.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ORDER_ID"])) {_oEDFErrorCase.order_id = (global::System.Nullable<int>)_oData["EDFERRORCASE_ORDER_ID"]; }else{_oEDFErrorCase.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DID"])) {_oEDFErrorCase.did = (string)_oData["EDFERRORCASE_DID"]; }else{_oEDFErrorCase.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DDATE"])) {_oEDFErrorCase.ddate = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_DDATE"]; }else{_oEDFErrorCase.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ERROR_MSG"])) {_oEDFErrorCase.error_msg = (string)_oData["EDFERRORCASE_ERROR_MSG"]; }else{_oEDFErrorCase.error_msg=global::System.String.Empty;}
                        _oEDFErrorCase.SetDB(x_oDB);
                        _oEDFErrorCase.GetFound();
                        _oRow.Add(_oEDFErrorCase);
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
        
        
        public static EDFErrorCaseEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<EDFErrorCaseEntity> _oEDFErrorCaseList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oEDFErrorCaseList.Count == 0 ? null : _oEDFErrorCaseList.ToArray();
        }
        
        
        public static EDFErrorCaseEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<EDFErrorCaseEntity> _oEDFErrorCaseList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oEDFErrorCaseList.Count == 0 ? null : _oEDFErrorCaseList.ToArray();
        }
        
        public static List<EDFErrorCaseEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<EDFErrorCaseEntity> _oRow = new List<EDFErrorCaseEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[EDFErrorCase].[id] AS EDFERRORCASE_ID,[EDFErrorCase].[cdate] AS EDFERRORCASE_CDATE,[EDFErrorCase].[cid] AS EDFERRORCASE_CID,[EDFErrorCase].[mrt_no] AS EDFERRORCASE_MRT_NO,[EDFErrorCase].[status] AS EDFERRORCASE_STATUS,[EDFErrorCase].[active] AS EDFERRORCASE_ACTIVE,[EDFErrorCase].[remark] AS EDFERRORCASE_REMARK,[EDFErrorCase].[imei_status] AS EDFERRORCASE_IMEI_STATUS,[EDFErrorCase].[imei_remark] AS EDFERRORCASE_IMEI_REMARK,[EDFErrorCase].[edf_no] AS EDFERRORCASE_EDF_NO,[EDFErrorCase].[order_id] AS EDFERRORCASE_ORDER_ID,[EDFErrorCase].[error_msg] AS EDFERRORCASE_ERROR_MSG,[EDFErrorCase].[did] AS EDFERRORCASE_DID,[EDFErrorCase].[ddate] AS EDFERRORCASE_DDATE,[EDFErrorCase].[imei_no] AS EDFERRORCASE_IMEI_NO";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = EDFErrorCaseRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                EDFErrorCaseEntity _oEDFErrorCase = EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ID"])) {_oEDFErrorCase.id = (global::System.Nullable<int>)_oData["EDFERRORCASE_ID"]; } else {_oEDFErrorCase.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CDATE"])) {_oEDFErrorCase.cdate = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_CDATE"]; } else {_oEDFErrorCase.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CID"])) {_oEDFErrorCase.cid = (string)_oData["EDFERRORCASE_CID"]; } else {_oEDFErrorCase.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_MRT_NO"])) {_oEDFErrorCase.mrt_no = (string)_oData["EDFERRORCASE_MRT_NO"]; } else {_oEDFErrorCase.mrt_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_STATUS"])) {_oEDFErrorCase.status = (string)_oData["EDFERRORCASE_STATUS"]; } else {_oEDFErrorCase.status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ACTIVE"])) {_oEDFErrorCase.active = (global::System.Nullable<bool>)_oData["EDFERRORCASE_ACTIVE"]; } else {_oEDFErrorCase.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_REMARK"])) {_oEDFErrorCase.remark = (string)_oData["EDFERRORCASE_REMARK"]; } else {_oEDFErrorCase.remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_STATUS"])) {_oEDFErrorCase.imei_status = (string)_oData["EDFERRORCASE_IMEI_STATUS"]; } else {_oEDFErrorCase.imei_status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_NO"])) {_oEDFErrorCase.imei_no = (string)_oData["EDFERRORCASE_IMEI_NO"]; } else {_oEDFErrorCase.imei_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_REMARK"])) {_oEDFErrorCase.imei_remark = (string)_oData["EDFERRORCASE_IMEI_REMARK"]; } else {_oEDFErrorCase.imei_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_EDF_NO"])) {_oEDFErrorCase.edf_no = (string)_oData["EDFERRORCASE_EDF_NO"]; } else {_oEDFErrorCase.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ORDER_ID"])) {_oEDFErrorCase.order_id = (global::System.Nullable<int>)_oData["EDFERRORCASE_ORDER_ID"]; } else {_oEDFErrorCase.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DID"])) {_oEDFErrorCase.did = (string)_oData["EDFERRORCASE_DID"]; } else {_oEDFErrorCase.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DDATE"])) {_oEDFErrorCase.ddate = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_DDATE"]; } else {_oEDFErrorCase.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ERROR_MSG"])) {_oEDFErrorCase.error_msg = (string)_oData["EDFERRORCASE_ERROR_MSG"]; } else {_oEDFErrorCase.error_msg=global::System.String.Empty; }
                _oEDFErrorCase.SetDB(x_oDB);
                _oEDFErrorCase.GetFound();
                _oRow.Add(_oEDFErrorCase);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( EDFErrorCase.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,EDFErrorCase.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(EDFErrorCase.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(EDFErrorCase.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [EDFErrorCase].[id] AS EDFERRORCASE_ID,[EDFErrorCase].[cdate] AS EDFERRORCASE_CDATE,[EDFErrorCase].[cid] AS EDFERRORCASE_CID,[EDFErrorCase].[mrt_no] AS EDFERRORCASE_MRT_NO,[EDFErrorCase].[status] AS EDFERRORCASE_STATUS,[EDFErrorCase].[active] AS EDFERRORCASE_ACTIVE,[EDFErrorCase].[remark] AS EDFERRORCASE_REMARK,[EDFErrorCase].[imei_status] AS EDFERRORCASE_IMEI_STATUS,[EDFErrorCase].[imei_remark] AS EDFERRORCASE_IMEI_REMARK,[EDFErrorCase].[edf_no] AS EDFERRORCASE_EDF_NO,[EDFErrorCase].[order_id] AS EDFERRORCASE_ORDER_ID,[EDFErrorCase].[error_msg] AS EDFERRORCASE_ERROR_MSG,[EDFErrorCase].[did] AS EDFERRORCASE_DID,[EDFErrorCase].[ddate] AS EDFERRORCASE_DDATE,[EDFErrorCase].[imei_no] AS EDFERRORCASE_IMEI_NO  FROM  [EDFErrorCase]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"EDFErrorCase");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sRemark,string x_sImei_status,string x_sImei_no,string x_sImei_remark,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sError_msg)
        {
            EDFErrorCase _oEDFErrorCase=EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oEDFErrorCase.cdate=x_dCdate;
            _oEDFErrorCase.cid=x_sCid;
            _oEDFErrorCase.mrt_no=x_sMrt_no;
            _oEDFErrorCase.status=x_sStatus;
            _oEDFErrorCase.active=x_bActive;
            _oEDFErrorCase.remark=x_sRemark;
            _oEDFErrorCase.imei_status=x_sImei_status;
            _oEDFErrorCase.imei_no=x_sImei_no;
            _oEDFErrorCase.imei_remark=x_sImei_remark;
            _oEDFErrorCase.edf_no=x_sEdf_no;
            _oEDFErrorCase.order_id=x_iOrder_id;
            _oEDFErrorCase.did=x_sDid;
            _oEDFErrorCase.ddate=x_dDdate;
            _oEDFErrorCase.error_msg=x_sError_msg;
            return InsertWithOutLastID(n_oDB, _oEDFErrorCase);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sRemark,string x_sImei_status,string x_sImei_no,string x_sImei_remark,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sError_msg)
        {
            EDFErrorCase _oEDFErrorCase=EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEDFErrorCase.cdate=x_dCdate;
            _oEDFErrorCase.cid=x_sCid;
            _oEDFErrorCase.mrt_no=x_sMrt_no;
            _oEDFErrorCase.status=x_sStatus;
            _oEDFErrorCase.active=x_bActive;
            _oEDFErrorCase.remark=x_sRemark;
            _oEDFErrorCase.imei_status=x_sImei_status;
            _oEDFErrorCase.imei_no=x_sImei_no;
            _oEDFErrorCase.imei_remark=x_sImei_remark;
            _oEDFErrorCase.edf_no=x_sEdf_no;
            _oEDFErrorCase.order_id=x_iOrder_id;
            _oEDFErrorCase.did=x_sDid;
            _oEDFErrorCase.ddate=x_dDdate;
            _oEDFErrorCase.error_msg=x_sError_msg;
            return InsertWithOutLastID(x_oDB, _oEDFErrorCase);
        }
        
        
        public bool Insert(EDFErrorCase x_oEDFErrorCase)
        {
            return InsertWithOutLastID(n_oDB, x_oEDFErrorCase);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is EDFErrorCase)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (EDFErrorCase)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,EDFErrorCase x_oEDFErrorCase)
        {
            return InsertWithOutLastID(x_oDB, x_oEDFErrorCase);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,EDFErrorCase x_oEDFErrorCase)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [EDFErrorCase]   ([cdate],[cid],[mrt_no],[status],[active],[remark],[imei_status],[imei_remark],[edf_no],[order_id],[error_msg],[did],[ddate],[imei_no])  VALUES  (@cdate,@cid,@mrt_no,@status,@active,@remark,@imei_status,@imei_remark,@edf_no,@order_id,@error_msg,@did,@ddate,@imei_no)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oEDFErrorCase);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,EDFErrorCase x_oEDFErrorCase)
        {
            bool _bResult = false;
            if (!x_oEDFErrorCase.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oEDFErrorCase.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oEDFErrorCase.cdate; }
                if(x_oEDFErrorCase.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.cid; }
                if(x_oEDFErrorCase.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.mrt_no; }
                if(x_oEDFErrorCase.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.status; }
                if(x_oEDFErrorCase.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oEDFErrorCase.active; }
                if(x_oEDFErrorCase.remark==null){  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value=x_oEDFErrorCase.remark; }
                if(x_oEDFErrorCase.imei_status==null){  x_oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.imei_status; }
                if(x_oEDFErrorCase.imei_remark==null){  x_oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text).Value=x_oEDFErrorCase.imei_remark; }
                if(x_oEDFErrorCase.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.edf_no; }
                if(x_oEDFErrorCase.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oEDFErrorCase.order_id; }
                if(x_oEDFErrorCase.error_msg==null){  x_oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text).Value=x_oEDFErrorCase.error_msg; }
                if(x_oEDFErrorCase.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.did; }
                if(x_oEDFErrorCase.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oEDFErrorCase.ddate; }
                if(x_oEDFErrorCase.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.imei_no; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sRemark,string x_sImei_status,string x_sImei_no,string x_sImei_remark,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sError_msg)
        {
            int _oLastID;
            EDFErrorCase _oEDFErrorCase=EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEDFErrorCase.cdate=x_dCdate;
            _oEDFErrorCase.cid=x_sCid;
            _oEDFErrorCase.mrt_no=x_sMrt_no;
            _oEDFErrorCase.status=x_sStatus;
            _oEDFErrorCase.active=x_bActive;
            _oEDFErrorCase.remark=x_sRemark;
            _oEDFErrorCase.imei_status=x_sImei_status;
            _oEDFErrorCase.imei_no=x_sImei_no;
            _oEDFErrorCase.imei_remark=x_sImei_remark;
            _oEDFErrorCase.edf_no=x_sEdf_no;
            _oEDFErrorCase.order_id=x_iOrder_id;
            _oEDFErrorCase.did=x_sDid;
            _oEDFErrorCase.ddate=x_dDdate;
            _oEDFErrorCase.error_msg=x_sError_msg;
            if(InsertWithLastID(x_oDB, _oEDFErrorCase,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(EDFErrorCase x_oEDFErrorCase)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oEDFErrorCase, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, EDFErrorCase x_oEDFErrorCase)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oEDFErrorCase, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is EDFErrorCase)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (EDFErrorCase)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,EDFErrorCase x_oEDFErrorCase, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [EDFErrorCase]   ([cdate],[cid],[mrt_no],[status],[active],[remark],[imei_status],[imei_remark],[edf_no],[order_id],[error_msg],[did],[ddate],[imei_no])  VALUES  (@cdate,@cid,@mrt_no,@status,@active,@remark,@imei_status,@imei_remark,@edf_no,@order_id,@error_msg,@did,@ddate,@imei_no)"+" SELECT  @@IDENTITY AS EDFErrorCase_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oEDFErrorCase,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,EDFErrorCase x_oEDFErrorCase, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oEDFErrorCase.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oEDFErrorCase.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oEDFErrorCase.cdate; }
                if(x_oEDFErrorCase.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.cid; }
                if(x_oEDFErrorCase.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.mrt_no; }
                if(x_oEDFErrorCase.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.status; }
                if(x_oEDFErrorCase.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oEDFErrorCase.active; }
                if(x_oEDFErrorCase.remark==null){  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text).Value=x_oEDFErrorCase.remark; }
                if(x_oEDFErrorCase.imei_status==null){  x_oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.imei_status; }
                if(x_oEDFErrorCase.imei_remark==null){  x_oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text).Value=x_oEDFErrorCase.imei_remark; }
                if(x_oEDFErrorCase.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.edf_no; }
                if(x_oEDFErrorCase.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oEDFErrorCase.order_id; }
                if(x_oEDFErrorCase.error_msg==null){  x_oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text).Value=x_oEDFErrorCase.error_msg; }
                if(x_oEDFErrorCase.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.did; }
                if(x_oEDFErrorCase.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oEDFErrorCase.ddate; }
                if(x_oEDFErrorCase.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oEDFErrorCase.imei_no; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["EDFErrorCase_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["EDFErrorCase_LASTID"].ToString()) && int.TryParse(_oData["EDFErrorCase_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sRemark,string x_sImei_status,string x_sImei_no,string x_sImei_remark,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sError_msg)
        {
            int _oLastID;
            EDFErrorCase _oEDFErrorCase=EDFErrorCaseRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEDFErrorCase.cdate=x_dCdate;
            _oEDFErrorCase.cid=x_sCid;
            _oEDFErrorCase.mrt_no=x_sMrt_no;
            _oEDFErrorCase.status=x_sStatus;
            _oEDFErrorCase.active=x_bActive;
            _oEDFErrorCase.remark=x_sRemark;
            _oEDFErrorCase.imei_status=x_sImei_status;
            _oEDFErrorCase.imei_no=x_sImei_no;
            _oEDFErrorCase.imei_remark=x_sImei_remark;
            _oEDFErrorCase.edf_no=x_sEdf_no;
            _oEDFErrorCase.order_id=x_iOrder_id;
            _oEDFErrorCase.did=x_sDid;
            _oEDFErrorCase.ddate=x_dDdate;
            _oEDFErrorCase.error_msg=x_sError_msg;
            if(InsertWithLastID_SP(x_oDB, _oEDFErrorCase,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(EDFErrorCase x_oEDFErrorCase)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oEDFErrorCase, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, EDFErrorCase x_oEDFErrorCase)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oEDFErrorCase, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is EDFErrorCase)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (EDFErrorCase)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,EDFErrorCase x_oEDFErrorCase, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "EDFERRORCASE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oEDFErrorCase,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,EDFErrorCase x_oEDFErrorCase, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oEDFErrorCase.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.cid; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.status; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.active; }
                _oPar=x_oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.remark; }
                _oPar=x_oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.imei_status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.imei_status; }
                _oPar=x_oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.imei_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.imei_remark; }
                _oPar=x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.edf_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.edf_no; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.order_id; }
                _oPar=x_oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.error_msg==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.error_msg; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.did; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oEDFErrorCase.ddate; }
                _oPar=x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oEDFErrorCase.imei_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oEDFErrorCase.imei_no; }
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
        
        #region INSERT_EDFERRORCASE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-05-31>
        ///-- Description:	<Description,EDFERRORCASE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_EDFERRORCASE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB
        GO
        IF OBJECT_ID ( 'INSERT_EDFERRORCASE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_EDFERRORCASE;
        GO
        CREATE PROCEDURE INSERT_EDFERRORCASE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @mrt_no nvarchar(50),
        @status nvarchar(50),
        @active bit,
        @remark text,
        @imei_status nvarchar(50),
        @imei_no nvarchar(50),
        @imei_remark text,
        @edf_no nvarchar(50),
        @order_id int,
        @did nvarchar(50),
        @ddate datetime,
        @error_msg text
        AS
        
        INSERT INTO  [EDFErrorCase]   ([cdate],[cid],[mrt_no],[status],[active],[remark],[imei_status],[imei_remark],[edf_no],[order_id],[error_msg],[did],[ddate],[imei_no])  VALUES  (@cdate,@cid,@mrt_no,@status,@active,@remark,@imei_status,@imei_remark,@edf_no,@order_id,@error_msg,@did,@ddate,@imei_no)
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
            string _sQuery = "DELETE FROM  [EDFErrorCase]  WHERE [EDFErrorCase].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
            return EDFErrorCaseRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [EDFErrorCase]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
            string _sQuery = "DELETE FROM [EDFErrorCase]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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


