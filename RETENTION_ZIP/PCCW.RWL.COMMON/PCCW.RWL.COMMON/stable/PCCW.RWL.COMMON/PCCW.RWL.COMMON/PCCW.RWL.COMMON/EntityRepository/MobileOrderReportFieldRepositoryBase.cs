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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportField],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportField] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportField")]
    public class MobileOrderReportFieldRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportFieldRepositoryBase instance;
        public static MobileOrderReportFieldRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportFieldRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportFieldRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportFieldRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportFieldEntity> MobileOrderReportFields;
        #endregion
        
        #region Constructor
        public MobileOrderReportFieldRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportFieldRepositoryBase() { 
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
        public static MobileOrderReportField CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportField(_oDB);
        }
        
        public static MobileOrderReportField CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportField(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportField]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
        
        
        public MobileOrderReportFieldEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileOrderReportFieldEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportField _MobileOrderReportField = (MobileOrderReportField)MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportField.Load(x_iId)) { return null; }
            return _MobileOrderReportField;
        }
        
        
        
        public static MobileOrderReportFieldEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportFieldEntity> _oMobileOrderReportFieldList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileOrderReportFieldList==null){ return null;}
            return _oMobileOrderReportFieldList.Count == 0 ? null : _oMobileOrderReportFieldList.ToArray();
        }
        
        public static List<MobileOrderReportFieldEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportFieldEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportFieldEntity> _oMobileOrderReportFieldList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportFieldList==null){ return null;}
            return _oMobileOrderReportFieldList.Count == 0 ? null : _oMobileOrderReportFieldList.ToArray();
        }
        
        
        public static MobileOrderReportFieldEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportFieldEntity> _oMobileOrderReportFieldList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportFieldList==null){ return null;}
            return _oMobileOrderReportFieldList.Count == 0 ? null : _oMobileOrderReportFieldList.ToArray();
        }
        
        public static List<MobileOrderReportFieldEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportFieldEntity> _oRow = new List<MobileOrderReportFieldEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportField].[id] AS MOBILEORDERREPORTFIELD_ID,[MobileOrderReportField].[cdate] AS MOBILEORDERREPORTFIELD_CDATE,[MobileOrderReportField].[cid] AS MOBILEORDERREPORTFIELD_CID,[MobileOrderReportField].[field_title] AS MOBILEORDERREPORTFIELD_FIELD_TITLE,[MobileOrderReportField].[active] AS MOBILEORDERREPORTFIELD_ACTIVE,[MobileOrderReportField].[report_id] AS MOBILEORDERREPORTFIELD_REPORT_ID,[MobileOrderReportField].[field_content_order] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER,[MobileOrderReportField].[field_content] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT,[MobileOrderReportField].[field_content_name] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME,[MobileOrderReportField].[field_order] AS MOBILEORDERREPORTFIELD_FIELD_ORDER  FROM  [MobileOrderReportField]";
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
                _sQuery += " WHERE [MobileOrderReportField].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportField _oMobileOrderReportField = MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ID"])) {_oMobileOrderReportField.id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_ID"]; }else{_oMobileOrderReportField.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CDATE"])) {_oMobileOrderReportField.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTFIELD_CDATE"]; }else{_oMobileOrderReportField.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CID"])) {_oMobileOrderReportField.cid = (string)_oData["MOBILEORDERREPORTFIELD_CID"]; }else{_oMobileOrderReportField.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"])) {_oMobileOrderReportField.field_title = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"]; }else{_oMobileOrderReportField.field_title=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ACTIVE"])) {_oMobileOrderReportField.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTFIELD_ACTIVE"]; }else{_oMobileOrderReportField.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_REPORT_ID"])) {_oMobileOrderReportField.report_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_REPORT_ID"]; }else{_oMobileOrderReportField.report_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"])) {_oMobileOrderReportField.field_content_order = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"]; }else{_oMobileOrderReportField.field_content_order=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"])) {_oMobileOrderReportField.field_content = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"]; }else{_oMobileOrderReportField.field_content=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"])) {_oMobileOrderReportField.field_content_name = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"]; }else{_oMobileOrderReportField.field_content_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"])) {_oMobileOrderReportField.field_order = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"]; }else{_oMobileOrderReportField.field_order=null;}
                        _oMobileOrderReportField.SetDB(x_oDB);
                        _oMobileOrderReportField.GetFound();
                        _oRow.Add(_oMobileOrderReportField);
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
        
        
        public static MobileOrderReportFieldEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportFieldEntity> _oMobileOrderReportFieldList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportFieldList==null){ return null;}
            return _oMobileOrderReportFieldList.Count == 0 ? null : _oMobileOrderReportFieldList.ToArray();
        }
        
        
        public static MobileOrderReportFieldEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportFieldEntity> _oMobileOrderReportFieldList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportFieldList==null){ return null;}
            return _oMobileOrderReportFieldList.Count == 0 ? null : _oMobileOrderReportFieldList.ToArray();
        }
        
        public static List<MobileOrderReportFieldEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportFieldEntity> _oRow = new List<MobileOrderReportFieldEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportField].[id] AS MOBILEORDERREPORTFIELD_ID,[MobileOrderReportField].[cdate] AS MOBILEORDERREPORTFIELD_CDATE,[MobileOrderReportField].[cid] AS MOBILEORDERREPORTFIELD_CID,[MobileOrderReportField].[field_title] AS MOBILEORDERREPORTFIELD_FIELD_TITLE,[MobileOrderReportField].[active] AS MOBILEORDERREPORTFIELD_ACTIVE,[MobileOrderReportField].[report_id] AS MOBILEORDERREPORTFIELD_REPORT_ID,[MobileOrderReportField].[field_content_order] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER,[MobileOrderReportField].[field_content] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT,[MobileOrderReportField].[field_content_name] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME,[MobileOrderReportField].[field_order] AS MOBILEORDERREPORTFIELD_FIELD_ORDER";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportFieldRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportFieldEntity _oMobileOrderReportField = MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ID"])) {_oMobileOrderReportField.id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_ID"]; } else {_oMobileOrderReportField.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CDATE"])) {_oMobileOrderReportField.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTFIELD_CDATE"]; } else {_oMobileOrderReportField.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CID"])) {_oMobileOrderReportField.cid = (string)_oData["MOBILEORDERREPORTFIELD_CID"]; } else {_oMobileOrderReportField.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"])) {_oMobileOrderReportField.field_title = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"]; } else {_oMobileOrderReportField.field_title=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ACTIVE"])) {_oMobileOrderReportField.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTFIELD_ACTIVE"]; } else {_oMobileOrderReportField.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_REPORT_ID"])) {_oMobileOrderReportField.report_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_REPORT_ID"]; } else {_oMobileOrderReportField.report_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"])) {_oMobileOrderReportField.field_content_order = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"]; } else {_oMobileOrderReportField.field_content_order=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"])) {_oMobileOrderReportField.field_content = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"]; } else {_oMobileOrderReportField.field_content=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"])) {_oMobileOrderReportField.field_content_name = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"]; } else {_oMobileOrderReportField.field_content_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"])) {_oMobileOrderReportField.field_order = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"]; } else {_oMobileOrderReportField.field_order=null; }
                _oMobileOrderReportField.SetDB(x_oDB);
                _oMobileOrderReportField.GetFound();
                _oRow.Add(_oMobileOrderReportField);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportField.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportField.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportField.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportField.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportField].[id] AS MOBILEORDERREPORTFIELD_ID,[MobileOrderReportField].[cdate] AS MOBILEORDERREPORTFIELD_CDATE,[MobileOrderReportField].[cid] AS MOBILEORDERREPORTFIELD_CID,[MobileOrderReportField].[field_title] AS MOBILEORDERREPORTFIELD_FIELD_TITLE,[MobileOrderReportField].[active] AS MOBILEORDERREPORTFIELD_ACTIVE,[MobileOrderReportField].[report_id] AS MOBILEORDERREPORTFIELD_REPORT_ID,[MobileOrderReportField].[field_content_order] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER,[MobileOrderReportField].[field_content] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT,[MobileOrderReportField].[field_content_name] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME,[MobileOrderReportField].[field_order] AS MOBILEORDERREPORTFIELD_FIELD_ORDER  FROM  [MobileOrderReportField]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportField");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sField_title,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iReport_id,global::System.Nullable<int> x_iField_content_order,string x_sField_content,string x_sField_content_name,global::System.Nullable<int> x_iField_order)
        {
            MobileOrderReportField _oMobileOrderReportField=MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportField.cdate=x_dCdate;
            _oMobileOrderReportField.cid=x_sCid;
            _oMobileOrderReportField.field_title=x_sField_title;
            _oMobileOrderReportField.active=x_bActive;
            _oMobileOrderReportField.report_id=x_iReport_id;
            _oMobileOrderReportField.field_content_order=x_iField_content_order;
            _oMobileOrderReportField.field_content=x_sField_content;
            _oMobileOrderReportField.field_content_name=x_sField_content_name;
            _oMobileOrderReportField.field_order=x_iField_order;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportField);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sField_title,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iReport_id,global::System.Nullable<int> x_iField_content_order,string x_sField_content,string x_sField_content_name,global::System.Nullable<int> x_iField_order)
        {
            MobileOrderReportField _oMobileOrderReportField=MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportField.cdate=x_dCdate;
            _oMobileOrderReportField.cid=x_sCid;
            _oMobileOrderReportField.field_title=x_sField_title;
            _oMobileOrderReportField.active=x_bActive;
            _oMobileOrderReportField.report_id=x_iReport_id;
            _oMobileOrderReportField.field_content_order=x_iField_content_order;
            _oMobileOrderReportField.field_content=x_sField_content;
            _oMobileOrderReportField.field_content_name=x_sField_content_name;
            _oMobileOrderReportField.field_order=x_iField_order;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportField);
        }
        
        
        public bool Insert(MobileOrderReportField x_oMobileOrderReportField)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportField);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportField)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportField)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportField x_oMobileOrderReportField)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportField);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportField x_oMobileOrderReportField)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportField]   ([cdate],[cid],[field_title],[active],[report_id],[field_content_order],[field_content],[field_content_name],[field_order])  VALUES  (@cdate,@cid,@field_title,@active,@report_id,@field_content_order,@field_content,@field_content_name,@field_order)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportField);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportField x_oMobileOrderReportField)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportField.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportField.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportField.cdate; }
                if(x_oMobileOrderReportField.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value=x_oMobileOrderReportField.cid; }
                if(x_oMobileOrderReportField.field_title==null){  x_oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileOrderReportField.field_title; }
                if(x_oMobileOrderReportField.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportField.active; }
                if(x_oMobileOrderReportField.report_id==null){  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportField.report_id; }
                if(x_oMobileOrderReportField.field_content_order==null){  x_oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportField.field_content_order; }
                if(x_oMobileOrderReportField.field_content==null){  x_oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823).Value=x_oMobileOrderReportField.field_content; }
                if(x_oMobileOrderReportField.field_content_name==null){  x_oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100).Value=x_oMobileOrderReportField.field_content_name; }
                if(x_oMobileOrderReportField.field_order==null){  x_oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportField.field_order; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sField_title,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iReport_id,global::System.Nullable<int> x_iField_content_order,string x_sField_content,string x_sField_content_name,global::System.Nullable<int> x_iField_order)
        {
            int _oLastID;
            MobileOrderReportField _oMobileOrderReportField=MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportField.cdate=x_dCdate;
            _oMobileOrderReportField.cid=x_sCid;
            _oMobileOrderReportField.field_title=x_sField_title;
            _oMobileOrderReportField.active=x_bActive;
            _oMobileOrderReportField.report_id=x_iReport_id;
            _oMobileOrderReportField.field_content_order=x_iField_content_order;
            _oMobileOrderReportField.field_content=x_sField_content;
            _oMobileOrderReportField.field_content_name=x_sField_content_name;
            _oMobileOrderReportField.field_order=x_iField_order;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportField,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportField x_oMobileOrderReportField)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportField, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportField x_oMobileOrderReportField)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportField, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportField)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportField)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportField x_oMobileOrderReportField, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportField]   ([cdate],[cid],[field_title],[active],[report_id],[field_content_order],[field_content],[field_content_name],[field_order])  VALUES  (@cdate,@cid,@field_title,@active,@report_id,@field_content_order,@field_content,@field_content_name,@field_order)"+" SELECT  @@IDENTITY AS MobileOrderReportField_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportField,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportField x_oMobileOrderReportField, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportField.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportField.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportField.cdate; }
                if(x_oMobileOrderReportField.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value=x_oMobileOrderReportField.cid; }
                if(x_oMobileOrderReportField.field_title==null){  x_oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileOrderReportField.field_title; }
                if(x_oMobileOrderReportField.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportField.active; }
                if(x_oMobileOrderReportField.report_id==null){  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportField.report_id; }
                if(x_oMobileOrderReportField.field_content_order==null){  x_oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportField.field_content_order; }
                if(x_oMobileOrderReportField.field_content==null){  x_oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823).Value=x_oMobileOrderReportField.field_content; }
                if(x_oMobileOrderReportField.field_content_name==null){  x_oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100).Value=x_oMobileOrderReportField.field_content_name; }
                if(x_oMobileOrderReportField.field_order==null){  x_oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportField.field_order; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportField_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportField_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportField_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sField_title,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iReport_id,global::System.Nullable<int> x_iField_content_order,string x_sField_content,string x_sField_content_name,global::System.Nullable<int> x_iField_order)
        {
            int _oLastID;
            MobileOrderReportField _oMobileOrderReportField=MobileOrderReportFieldRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportField.cdate=x_dCdate;
            _oMobileOrderReportField.cid=x_sCid;
            _oMobileOrderReportField.field_title=x_sField_title;
            _oMobileOrderReportField.active=x_bActive;
            _oMobileOrderReportField.report_id=x_iReport_id;
            _oMobileOrderReportField.field_content_order=x_iField_content_order;
            _oMobileOrderReportField.field_content=x_sField_content;
            _oMobileOrderReportField.field_content_name=x_sField_content_name;
            _oMobileOrderReportField.field_order=x_iField_order;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportField,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportField x_oMobileOrderReportField)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportField, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportField x_oMobileOrderReportField)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportField, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportField)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportField)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportField x_oMobileOrderReportField, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTFIELD";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportField,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportField x_oMobileOrderReportField, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportField.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.cid; }
                _oPar=x_oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.field_title==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.field_title; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.active; }
                _oPar=x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.report_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.report_id; }
                _oPar=x_oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.field_content_order==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.field_content_order; }
                _oPar=x_oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.field_content==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.field_content; }
                _oPar=x_oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.field_content_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.field_content_name; }
                _oPar=x_oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportField.field_order==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportField.field_order; }
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
        
        #region INSERT_MOBILEORDERREPORTFIELD Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,MOBILEORDERREPORTFIELD, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTFIELD Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTFIELD', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTFIELD;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTFIELD
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nchar(10),
        @field_title nvarchar(100),
        @active bit,
        @report_id int,
        @field_content_order int,
        @field_content ntext,
        @field_content_name nchar(100),
        @field_order int
        AS
        
        INSERT INTO  [MobileOrderReportField]   ([cdate],[cid],[field_title],[active],[report_id],[field_content_order],[field_content],[field_content_name],[field_order])  VALUES  (@cdate,@cid,@field_title,@active,@report_id,@field_content_order,@field_content,@field_content_name,@field_order)
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
            string _sQuery = "DELETE FROM  [MobileOrderReportField]  WHERE [MobileOrderReportField].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
            return MobileOrderReportFieldRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportField]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportField]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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


